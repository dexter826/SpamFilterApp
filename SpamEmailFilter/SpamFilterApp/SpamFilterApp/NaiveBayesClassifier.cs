using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamFilterApp
{
    public class NaiveBayesClassifier
    {
        private List<Email> _emails; // Danh sách email đã được huấn luyện
        private Dictionary<string, int> _spamCount; // Đếm số từ trong email spam
        private Dictionary<string, int> _hamCount; // Đếm số từ trong email không spam
        private int _totalSpam; // Tổng số email spam
        private int _totalHam; // Tổng số email không spam
        private int _totalSpamWords; // Tổng số từ trong tập dữ liệu spam
        private int _totalHamWords; // Tổng số từ trong tập dữ liệu không spam

        public NaiveBayesClassifier()
        {
            _emails = new List<Email>();
            _spamCount = new Dictionary<string, int>();
            _hamCount = new Dictionary<string, int>();
            _totalSpam = 0;
            _totalHam = 0;
            _totalSpamWords = 0;
            _totalHamWords = 0;
        }

        public void Train(Email email)
        {
            _emails.Add(email);
            if (email.IsSpam)
            {
                _totalSpam++;
                AddToCount(_spamCount, email.Content);
                _totalSpamWords += email.Content.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
            else
            {
                _totalHam++;
                AddToCount(_hamCount, email.Content);
                _totalHamWords += email.Content.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }

        private void AddToCount(Dictionary<string, int> countDict, string content)
        {
            var words = content.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (countDict.ContainsKey(word))
                    countDict[word]++;
                else
                    countDict[word] = 1;
            }
        }

        public (string result, double spamProbability, double notSpamProbability, Dictionary<string, double> spamWordProbabilities, Dictionary<string, double> notSpamWordProbabilities) ClassifyWithWordProbabilities(string content)
        {
            // Loại bỏ ký tự xuống dòng và khoảng trắng thừa
            content = string.Join(" ", content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)).Trim();
            content = System.Text.RegularExpressions.Regex.Replace(content, @"\s+", " "); // Loại bỏ khoảng trắng thừa

            var words = content.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var spamWordProbabilities = new Dictionary<string, double>();
            var notSpamWordProbabilities = new Dictionary<string, double>();

            //xác suất tiên nghiệm
            double priorSpamProbability = _totalSpam > 0 ? (double)_totalSpam / (_totalSpam + _totalHam) : 0.0;
            double priorNotSpamProbability = _totalHam > 0 ? (double)_totalHam / (_totalSpam + _totalHam) : 0.0;


            //sử dụng log để tránh tràn số
            double logSpamProbability = Math.Log(priorSpamProbability);
            double logNotSpamProbability = Math.Log(priorNotSpamProbability);

            foreach (var word in words)
            {
                var spamWordProbability = GetWordProbability(word, _spamCount, _totalSpamWords);
                var notSpamWordProbability = GetWordProbability(word, _hamCount, _totalHamWords);

                logSpamProbability += Math.Log(spamWordProbability);
                logNotSpamProbability += Math.Log(notSpamWordProbability);

                spamWordProbabilities[word] = spamWordProbability;
                notSpamWordProbabilities[word] = notSpamWordProbability;
            }

            string result = logSpamProbability > logNotSpamProbability ? "Spam" : "Not Spam";

            return (result, Math.Exp(logSpamProbability), Math.Exp(logNotSpamProbability), spamWordProbabilities, notSpamWordProbabilities);
        }

        public double GetWordProbability(string word, Dictionary<string, int> wordCounts, int total)
        {
            // Tính toán xác suất của từ dựa trên số lần xuất hiện và tổng số từ
            if (wordCounts.TryGetValue(word, out int count))
            {
                return (double)(count + 1) / (total + wordCounts.Count); // Sử dụng Laplace smoothing
            }

            // Trả về giá trị rất nhỏ cho từ không tồn tại trong dữ liệu huấn luyện
            return 1.0 / (total + wordCounts.Count); // Xử lý trường hợp từ không xuất hiện trong dữ liệu huấn luyện
        }
    }
}
