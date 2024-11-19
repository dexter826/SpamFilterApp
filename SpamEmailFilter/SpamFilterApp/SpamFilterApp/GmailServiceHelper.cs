using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SpamFilterApp
{
    public static class GmailServiceHelper
    {
        private static readonly string[] Scopes = { GmailService.Scope.GmailReadonly };
        private static readonly string ApplicationName = "SpamFilterApp";

        public static GmailService GetGmailService()
        {
            UserCredential credential;
            string credPath = "C:\\CongNghe.Net\\NaiveBayes\\SpamEmailFilter\\SpamFilterApp\\credentials.json"; // Đường dẫn đến tệp credentials.json

            using (var stream = new FileStream(credPath, FileMode.Open, FileAccess.Read))
            {
                string tokenPath = "token.json";
                var clientSecrets = GoogleClientSecrets.FromStream(stream);
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets.Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(tokenPath, true)).Result;
            }

            // Tạo Gmail service
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }

        public static List<Message> GetEmails(GmailService service, string query, int maxResults = 10)
        {
            var request = service.Users.Messages.List("me");
            request.Q = query; 
            request.MaxResults = maxResults;

            var response = request.Execute();
            return response.Messages?.ToList() ?? new List<Message>();
        }

        public static string GetEmailContent(GmailService service, string messageId)
        {
            var email = service.Users.Messages.Get("me", messageId).Execute();

            if (email?.Payload?.Parts == null) return string.Empty;

            // Giải mã nội dung base64 của email
            var part = email.Payload.Parts.FirstOrDefault(p => !string.IsNullOrEmpty(p.Body.Data));
            if (part == null) return string.Empty;

            string encodedBody = part.Body.Data.Replace('-', '+').Replace('_', '/');
            byte[] data = Convert.FromBase64String(encodedBody);
            return Encoding.UTF8.GetString(data);
        }

    }
}
