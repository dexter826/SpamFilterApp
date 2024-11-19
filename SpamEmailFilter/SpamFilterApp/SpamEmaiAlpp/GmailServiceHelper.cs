using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;

namespace SpamEmaiAlpp
{
    public static class GmailServiceHelper
    {
        private static readonly string[] Scopes = {
        GmailService.Scope.GmailSend, // Quyền gửi email
        GmailService.Scope.GmailReadonly // Quyền đọc email
        };

        private static readonly string ApplicationName = "SpamEmailAlpp";

        public static GmailService GetGmailService()
        {
            UserCredential credential;
            string credPath = @"C:\CongNghe.Net\NaiveBayes\SpamEmailFilter\SpamFilterApp\credentials.json";

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
            return new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public static List<Message> GetEmails(GmailService service, string query, int maxResults = 10)
        {
            var request = service.Users.Messages.List("me");
            request.Q = query;
            request.MaxResults = maxResults;

            var response = request.Execute();
            return response.Messages?.ToList() ?? new List<Message>();
        }

        public static Email GetEmailDetails(GmailService service, string messageId)
        {
            var email = service.Users.Messages.Get("me", messageId).Execute();
            var headers = email.Payload.Headers;

            string sender = headers.FirstOrDefault(h => h.Name == "From")?.Value;
            string recipient = headers.FirstOrDefault(h => h.Name == "To")?.Value;
            string subject = headers.FirstOrDefault(h => h.Name == "Subject")?.Value;
            string date = headers.FirstOrDefault(h => h.Name == "Date")?.Value;

            DateTime emailDateTime;
            if (!DateTime.TryParse(date, out emailDateTime))
            {
                emailDateTime = DateTime.MinValue;
            }

            // Lấy nội dung email
            string emailContent = GetEmailContent(email);

            return new Email
            {
                Sender = sender,
                Recipient = recipient,
                Subject = subject,
                DateTime = emailDateTime,
                Content = emailContent
            };
        }

        public static string GetEmailContent(Message email)
        {
            if (email?.Payload?.Parts == null)
                return email?.Payload?.Body?.Data;

            var part = email.Payload.Parts.FirstOrDefault(p => !string.IsNullOrEmpty(p.Body?.Data));
            if (part == null) return string.Empty;

            string encodedBody = part.Body.Data.Replace('-', '+').Replace('_', '/');
            byte[] data = Convert.FromBase64String(encodedBody);
            return Encoding.UTF8.GetString(data);
        }

        public static void SendEmail(GmailService service, string to, string subject, string body)
        {
            var emailMessage = new AE.Net.Mail.MailMessage
            {
                Subject = subject,
                Body = body,
                From = new MailAddress("leductrung0907@gmail.com")
            };
            emailMessage.To.Add(new MailAddress(to));
            emailMessage.ReplyTo.Add(emailMessage.From);

            var msgString = new StringWriter();
            emailMessage.Save(msgString);

            var msg = new Message
            {
                Raw = Base64UrlEncode(msgString.ToString())
            };

            service.Users.Messages.Send(msg, "me").Execute();
        }

        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
    }
}
