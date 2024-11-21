using CsvHelper;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace SpamFilterApp
{
    public partial class MainForm : XtraForm
    {
        private NaiveBayesClassifier _classifier;
        private List<ClassificationResult> _classificationHistory; // Lưu lịch sử phân loại

        public MainForm()
        {
            InitializeComponent();
            _classifier = new NaiveBayesClassifier();
            _classificationHistory = new List<ClassificationResult>();

            // Tải dữ liệu từ file CSV
            string filePath = @"C:\CongNghe.Net\NaiveBayes\Dataset\email_dataset.csv"; // Thay đổi đường dẫn đến file của bạn
            LoadData(filePath);

            panelControl.Controls.Add(chartControl);
        }

        private void LoadData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Đọc các bản ghi từ file CSV
                var records = csv.GetRecords<EmailData>().ToList();

                foreach (var record in records)
                {
                    // Nhãn spam được xác định bởi label (spam là "Spam", không spam là "Not Spam")
                    bool isSpam = record.label.Trim().ToLower() == "spam";

                    // Huấn luyện bộ phân loại với thông tin email
                    _classifier.Train(new Email
                    {
                        Content = record.content.Trim(),
                        IsSpam = isSpam
                    });
                }
            }
        }

        private void UpdateChart(Dictionary<string, double> spamWordProbabilities, Dictionary<string, double> notSpamWordProbabilities)
        {
            // Xóa các series hiện có
            chartControl.Series.Clear();

            // Tạo series cho xác suất spam
            Series spamSeries = new Series("Xác suất Spam", ViewType.Pie);
            foreach (var kvp in spamWordProbabilities)
            {
                var word = kvp.Key;
                var probability = kvp.Value; // Chuyển đổi thành phần trăm
                SeriesPoint point = new SeriesPoint(word, probability);
                spamSeries.Points.Add(point);
            }

            // Tạo series cho xác suất không spam
            Series notSpamSeries = new Series("Xác suất Không Spam", ViewType.Pie);
            foreach (var kvp in notSpamWordProbabilities)
            {
                var word = kvp.Key;
                var probability = kvp.Value; // Chuyển đổi thành phần trăm
                SeriesPoint point = new SeriesPoint(word, probability);
                notSpamSeries.Points.Add(point);
            }

            // Thêm series vào biểu đồ
            chartControl.Series.Add(spamSeries);
            chartControl.Series.Add(notSpamSeries);

            // Tùy chỉnh hiển thị nếu cần
            foreach (Series series in chartControl.Series)
            {
                PieSeriesView view = (PieSeriesView)series.View;
                view.Titles.Add(new SeriesTitle() { Text = series.Name });

                // Hiển thị từ thay vì tỷ lệ phần trăm trong chú thích
                series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series.Label.TextPattern = "{A}: {V:F2}"; // Hiển thị tên từ thay vì giá trị
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            // Lấy GridView từ GridControl
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            // Kiểm tra nếu dòng đang được xử lý là dữ liệu (không phải header)
            if (e.RowHandle >= 0)
            {
                // Lấy giá trị của cột "Kết quả" cho dòng hiện tại
                string result = view.GetRowCellValue(e.RowHandle, view.Columns["Result"]).ToString();

                // Kiểm tra kết quả và thay đổi màu nền
                if (result == "Spam")
                {
                    // Màu đỏ cho kết quả là "Spam"
                    e.Appearance.BackColor = System.Drawing.Color.Red;
                    e.Appearance.ForeColor = System.Drawing.Color.White; // Đổi màu chữ nếu cần
                }
                else
                {
                    // Màu đỏ cho kết quả là "Spam"
                    e.Appearance.BackColor = System.Drawing.Color.Green;
                    e.Appearance.ForeColor = System.Drawing.Color.White; // Đổi màu chữ nếu cần
                }
            }
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            string emailContent = memoEmailContent.Text;

            if (string.IsNullOrEmpty(emailContent))
            {
                XtraMessageBox.Show("Vui lòng nhập nội dung email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Phân loại email và lấy kết quả cùng với xác suất
            var (result, spamProbability, notSpamProbability, spamWordProbabilities, notSpamWordProbabilities) = _classifier.ClassifyWithWordProbabilities(emailContent);

            // Lưu vào lịch sử phân loại
            _classificationHistory.Add(new ClassificationResult
            {
                Content = emailContent,
                Result = result,
                SpamProbability = spamProbability,
                NotSpamProbability = notSpamProbability
            });

            string message = $"Kết quả: {result} \nXác suất Spam: {spamProbability}% \nXác suất không Spam: {notSpamProbability}%";
            MessageBoxIcon icon = result == "Spam" ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
            XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);

            lblResult.Text = message;

            // Cập nhật danh sách email vào GridControl
            UpdateEmailList();

            // Cập nhật biểu đồ
            UpdateChart(spamWordProbabilities, notSpamWordProbabilities);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDuongDan.Text = openFileDialog.FileName; // Hiển thị đường dẫn
                    memoEmailContent.Text = File.ReadAllText(openFileDialog.FileName); // Hiển thị nội dung tệp
                }
            }
        }

        private void UpdateEmailList()
        {
            var bindingList = new BindingList<ClassificationResult>(
                _classificationHistory.Select((x, index) => new ClassificationResult
                {
                    Index = index + 1, // Đếm từ 1
                    Content = x.Content,
                    Result = x.Result,
                    SpamProbability = x.SpamProbability,
                    NotSpamProbability = x.NotSpamProbability
                }).ToList());

            gridControlEmails.DataSource = bindingList; // Cập nhật DataSource
        }

        private void btnReportSpam_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có email nào được chọn trong GridControl hay không
            var selectedEmail = (ClassificationResult)gridViewEmail.GetFocusedRow();

            if (selectedEmail == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một email để báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            var dialogResult = XtraMessageBox.Show($"Bạn có chắc chắn muốn báo cáo email này là spam?\nNội dung: {selectedEmail.Content}",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Thêm email vào dataset
                AddEmailToDataset(selectedEmail);
            }
        }

        private void AddEmailToDataset(ClassificationResult email)
        {
            var spamDatasetPath = @"C:\CongNghe.Net\NaiveBayes\Dataset\email_dataset.csv"; // Đường dẫn đến file CSV chứa email spam

            try
            {
                // Sử dụng StreamWriter để ghi thêm dữ liệu vào file CSV mà không xóa dữ liệu cũ
                using (var writer = new StreamWriter(spamDatasetPath, true)) // 'true' để ghi thêm vào file
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    // Ghi thêm email vào file CSV
                    csv.WriteRecord(new EmailData { label = "Spam", content = email.Content });
                    writer.WriteLine(); // Ghi xuống dòng mới sau mỗi bản ghi
                }

                XtraMessageBox.Show("Email đã được thêm vào danh sách spam.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại dữ liệu sau khi thêm mới
                _classifier.Train(new Email { Content = email.Content, IsSpam = true });
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi ghi vào file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewEmail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Kiểm tra xem có email nào được chọn trong GridControl hay không
            var selectedEmail = (ClassificationResult)gridViewEmail.GetFocusedRow();
            // Kiểm tra nếu email đã được phân loại là Not Spam
            if (selectedEmail.Result == "Not Spam")
            {
                btnReportSpam.Enabled = true; // Ẩn nút báo cáo
            }
            else
            {
                btnReportSpam.Enabled = false; // Hiện nút report
            }
        }

        private void gridViewEmail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // Lấy thông tin từ hàng được chọn
            var selectedEmail = (ClassificationResult)gridViewEmail.GetFocusedRow();

            if (selectedEmail != null)
            {
                // Hiển thị thông số lên DevExpress Chart
                UpdateChartOnRowSelection(selectedEmail);
            }
        }

        private void UpdateChartOnRowSelection(ClassificationResult selectedEmail)
        {
            // Giả sử bạn đã tính toán xác suất cho nội dung email được chọn
            var (result, spamProbability, notSpamProbability, spamWordProbabilities, notSpamWordProbabilities) =
                _classifier.ClassifyWithWordProbabilities(selectedEmail.Content);

            // Cập nhật lblResult với kết quả phân loại
            lblResult.Text = $"Kết quả: {result}\nXác suất Spam: {spamProbability:P2}\nXác suất Not Spam: {notSpamProbability:P2}";

            // Cập nhật chart
            UpdateChart(spamWordProbabilities, notSpamWordProbabilities);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            memoEmailContent.Clear();
        }
    }
}

