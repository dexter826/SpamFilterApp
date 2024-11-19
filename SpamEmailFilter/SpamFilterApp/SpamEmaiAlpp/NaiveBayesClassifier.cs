using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamEmaiAlpp
{
    // Lớp NaiveBayesClassifier sử dụng thuật toán Naive Bayes để phân loại email thành spam hoặc không spam
    public class NaiveBayesClassifier
    {
        private readonly List<Email> _emails; // Danh sách email đã được huấn luyện
        private readonly Dictionary<string, int> _spamCount; // Đếm số từ trong email spam
        private readonly Dictionary<string, int> _hamCount; // Đếm số từ trong email không spam
        private int _totalSpam; // Tổng số email spam
        private int _totalHam; // Tổng số email không spam
        private int _totalSpamWords; // Tổng số từ trong tập dữ liệu spam
        private int _totalHamWords; // Tổng số từ trong tập dữ liệu không spam

        //Phương thức khởi tạo của lớp NaiveBayesClassifier
        public NaiveBayesClassifier()
        {
            _emails = new List<Email>(); // Khởi tạo danh sách email
            _spamCount = new Dictionary<string, int>(); // Khởi tạo từ điển đếm từ trong email spam
            _hamCount = new Dictionary<string, int>(); // Khởi tạo từ điển đếm từ trong email không spam
            _totalSpam = 0; // Ban đầu số email spam là 0
            _totalHam = 0; // Ban đầu số email không spam là 0
            _totalSpamWords = 0; // Ban đầu tổng số từ trong email spam là 0
            _totalHamWords = 0; // Ban đầu tổng số từ trong email không spam là 0
        }

        // Phương thức huấn luyện mô hình với một email
        public void Train(Email email)
        {
            _emails.Add(email); // Thêm email vào danh sách email đã huấn luyện
            if (email.IsSpam) // Kiểm tra nếu email là spam
            {
                _totalSpam++; // Tăng số lượng email spam lên 1
                AddToCount(_spamCount, email.Content); // Cập nhật từ điển đếm từ trong email spam
                // Đếm số từ trong email spam và cộng vào tổng số từ trong tất cả email spam
                _totalSpamWords += email.Content.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
            else
            {
                _totalHam++; // Tăng số lượng email không spam lên 1
                AddToCount(_hamCount, email.Content); // Cập nhật từ điển đếm từ trong email không spam
                // Đếm số từ trong email không spam và cộng vào tổng số từ trong tất cả email không spam
                _totalHamWords += email.Content.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }

        // Phương thức hỗ trợ để thêm từ vào từ điển đếm từ
        private static void AddToCount(Dictionary<string, int> countDict, string content)
        {
            // Tách từ trong nội dung email (bỏ qua khoảng trắng và dấu câu) và chuyển về chữ thường
            var words = content.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (countDict.ContainsKey(word)) // Nếu từ đã tồn tại trong từ điển
                    countDict[word]++; // Tăng số lần xuất hiện của từ đó lên 1
                else
                    countDict[word] = 1; // Nếu từ chưa tồn tại, đặt số lần xuất hiện của từ đó là 1
            }
        }

        // Phương thức phân loại email với xác suất từ khóa (trả về kết quả, xác suất spam và xác suất không spam)
        public (string result, double spamProbability, double notSpamProbabilit) ClassifyWithWordProbabilities(string content)
        {
            // Loại bỏ ký tự xuống dòng và khoảng trắng thừa
            content = string.Join(" ", content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)).Trim();
            content = System.Text.RegularExpressions.Regex.Replace(content, @"\s+", " "); // Loại bỏ khoảng trắng thừa

            // Tách từ trong nội dung email và chuyển về chữ thường
            var words = content.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Xác suất tiên nghiệm (prior probability) của email là spam hoặc không spam
            double priorSpamProbability = _totalSpam > 0 ? (double)_totalSpam / (_totalSpam + _totalHam) : 0.0;
            double priorNotSpamProbability = _totalHam > 0 ? (double)_totalHam / (_totalSpam + _totalHam) : 0.0;


            // Tính log của xác suất tiên nghiệm để tránh tràn số
            double logSpamProbability = Math.Log(priorSpamProbability);
            double logNotSpamProbability = Math.Log(priorNotSpamProbability);

            // Duyệt từng từ trong email để tính xác suất
            foreach (var word in words)
            {
                var spamWordProbability = GetWordProbability(word, _spamCount, _totalSpamWords);
                var notSpamWordProbability = GetWordProbability(word, _hamCount, _totalHamWords);

                // Cộng log xác suất của từ vào xác suất tổng của email là spam hoặc không spam
                logSpamProbability += Math.Log(spamWordProbability);
                logNotSpamProbability += Math.Log(notSpamWordProbability);
            }

            string result = logSpamProbability > logNotSpamProbability ? "Spam" : "Not Spam";

            return (result, Math.Exp(logSpamProbability), Math.Exp(logNotSpamProbability));
        }

        // Phương thức tính xác suất của một từ dựa trên số lần xuất hiện và tổng số từ
        public static double GetWordProbability(string word, Dictionary<string, int> wordCounts, int total)
        {
            // Tính toán xác suất của từ dựa trên số lần xuất hiện và tổng số từ
            if (wordCounts.TryGetValue(word, out int count))
            {
                // Tính xác suất của từ với Laplace smoothing
                return (double)(count + 1) / (total + wordCounts.Count);
            }

            // Trả về giá trị rất nhỏ cho từ không tồn tại trong dữ liệu huấn luyện
            return 1.0 / (total + wordCounts.Count); // Xử lý trường hợp từ không xuất hiện trong dữ liệu huấn luyện
        }
    }
}
