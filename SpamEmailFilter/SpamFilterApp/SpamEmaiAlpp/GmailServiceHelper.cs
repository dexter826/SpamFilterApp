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
        /// <summary>
        /// Phạm vi truy cập của ứng dụng.
        /// </summary>
        private static readonly string[] Scopes = {
            GmailService.Scope.GmailSend, // Quyền gửi email
            GmailService.Scope.GmailReadonly // Quyền đọc email
        };

        private static readonly string ApplicationName = "SpamEmailAlpp";

        /// <summary>
        /// Khởi tạo và trả về một đối tượng GmailService sử dụng OAuth2 credentials.
        /// </summary>
        /// <returns>GmailService</returns>        
        public static GmailService GetGmailService()
        {
            UserCredential credential;
            // Sử dụng đường dẫn tương đối thay vì đường dẫn tuyệt đối
            string credPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credentials.json");

            if (!File.Exists(credPath))
            {
                throw new FileNotFoundException("credentials.json không tồn tại. Vui lòng tạo file theo mẫu credentials.json.example");
            }

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

        /// <summary>
        /// Lấy danh sách các email dựa trên truy vấn.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="query"></param>
        /// <param name="maxResults"></param>
        /// <returns></returns>
        public static List<Message> GetEmails(GmailService service, string query, int maxResults = 10)
        {
            var request = service.Users.Messages.List("me");
            request.Q = query;
            request.MaxResults = maxResults;

            var response = request.Execute();
            return response.Messages?.ToList() ?? new List<Message>();
        }

        /// <summary>
        /// Lấy thông tin chi tiết về một email cụ thể.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="messageId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Trích xuất và giải mã nội dung của một email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gửi email.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="from">Optional email address to use as sender. If not provided, uses the authenticated user's email.</param>
        public static void SendEmail(GmailService service, string to, string subject, string body, string from = null)
        {
            var emailMessage = new AE.Net.Mail.MailMessage
            {
                Subject = subject,
                Body = body,
                From = new MailAddress(from ?? service.Users.GetProfile("me").Execute().EmailAddress)
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

        /// <summary>
        /// Mã hóa chuỗi thành chuỗi Base64 URL.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
