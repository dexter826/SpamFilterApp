using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Google.Apis.Gmail.v1.Data;
using Guna.UI2.WinForms;

namespace SpamEmaiAlpp
{
    public partial class frm_Gmail : XtraForm
    {
        private UC_Inbox ucInbox;
        private UC_Spam ucSpam;
        private UC_Delete ucDelete;
        private UC_Sent ucSent;

        private List<Email> inboxEmails = new List<Email>();
        private List<Email> spamEmails = new List<Email>();
        private List<Email> deleteEmails = new List<Email>();
        private List<Email> sentEmails = new List<Email>();

        private NaiveBayesClassifier classifier = new NaiveBayesClassifier();

        //private bool isCheckEmailClicked = false;    // Thêm cờ để kiểm tra click
        private bool isTimerCompleted = false; // Thêm cờ để kiểm tra trạng thái của timer

        public frm_Gmail()
        {
            InitializeComponent();
            ucInbox = new UC_Inbox(ckb_AllEmail);
            ucInbox.EmailSelectionChanged += UC_Inbox_EmailSelectionChanged; // Đăng ký sự kiện
            panelContent.Controls.Add(ucInbox);
            ucInbox.Dock = DockStyle.Fill;

            ucSpam = new UC_Spam();
            ucDelete = new UC_Delete();
            ucSent = new UC_Sent();

            SetActiveButton(btn_Inbox); // Đặt nút Inbox là nút đang chọn

            // Tải dữ liệu từ file CSV
            string filePath = @"C:\CongNghe.Net\NaiveBayes\Dataset\email_dataset.csv"; // Thay đổi đường dẫn đến file của bạn
            LoadData(filePath);

            // Gọi phương thức kiểm tra email khi form được khởi tạo
            CheckEmails();
        }

        /// <summary>
        /// Load dữ liệu email lên form
        /// </summary>
        /// 
        private void CheckEmails()
        {
            var service = GmailServiceHelper.GetGmailService();
            var messages = GmailServiceHelper.GetEmails(service, "in:inbox is:unread");

            foreach (var message in messages)
            {
                // Kiểm tra nếu email đã tồn tại trong danh sách inbox hoặc spam
                bool isEmailExist = inboxEmails.Any(i => i.Id == message.Id) || spamEmails.Any(i => i.Id == message.Id);
                if (isEmailExist)
                {
                    continue; // Nếu đã tồn tại, bỏ qua email này
                }

                // Sử dụng GetEmailDetails để lấy thông tin đầy đủ của email
                var email = GmailServiceHelper.GetEmailDetails(service, message.Id);
                email.Id = message.Id;

                // Phân loại email
                var (result, spamProbability, notSpamProbability) = classifier.ClassifyWithWordProbabilities(email.Content + email.Subject);

                // Thêm vào danh sách email tương ứng
                if (result == "Spam")
                {
                    email.IsSpam = true;
                    spamEmails.Add(email); // Thêm vào danh sách spam
                    ucSpam.AddEmailToSpam(spamEmails); // Hiển thị vào danh sách spam
                }
                else
                {
                    email.IsSpam = false;
                    inboxEmails.Add(email); // Thêm vào danh sách inbox
                    ucInbox.AddEmailToInbox(inboxEmails); // Hiển thị vào danh sách inbox
                }
            }

            lbl_CountInbox.Text = inboxEmails.Count.ToString();
            lbl_CountSpam.Text = spamEmails.Count.ToString();

            // Lấy danh sách email đã gửi
            var sentMessages = GmailServiceHelper.GetEmails(service, "in:sent"); // Lấy email trong thư mục đã gửi
            var sentEmails = new List<Email>();

            if (sentMessages == null || !sentMessages.Any())
            {
                XtraMessageBox.Show("Không tìm thấy email nào trong thư mục đã gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var sentMessage in sentMessages)
            {
                // Kiểm tra nếu email đã tồn tại trong danh sách đã gửi
                bool isEmailExist = sentEmails.Any(i => i.Id == sentMessage.Id);
                if (isEmailExist)
                {
                    continue; // Nếu đã tồn tại, bỏ qua email này
                }

                // Sử dụng GetEmailDetails để lấy thông tin đầy đủ của email
                var sentEmail = GmailServiceHelper.GetEmailDetails(service, sentMessage.Id);
                sentEmail.Id = sentMessage.Id;

                sentEmails.Add(sentEmail); // Thêm vào danh sách đã gửi
            }
            ucSent.AddEmailToSent(sentEmails);

            // Chuyển về UC_Inbox sau khi kiểm tra email
            btn_Inbox_Click(null, null); // Gọi lại btn_Inbox_Click để cập nhật giao diện
        }

        /// <summary>
        /// Load dữ liệu từ email_dataset để lọc email
        /// </summary>
        /// <param name="filePath"></param>
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
                    classifier.Train(new Email
                    {
                        Content = record.content.Trim(),
                        IsSpam = isSpam
                    });
                }
            }
        }

        /// <summary>
        /// Các button chính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Guna2Button previousButton;
        private void SetActiveButton(Guna2Button activeButton)
        {
            if (previousButton != null)
            {
                previousButton.FillColor = Color.Transparent;
            }
            activeButton.FillColor = Color.DarkGray; // Màu khi được chọn

            // Cập nhật previousButton là nút hiện tại
            previousButton = activeButton;
        }

        private void btn_Inbox_Click(object sender, EventArgs e)
        {
            ucInbox.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucInbox);


            ucInbox.AddEmailToInbox(inboxEmails);

            SetActiveButton(btn_Inbox);

            UpdateControlVisibility();
        }

        private void btn_SpamForm_Click(object sender, EventArgs e)
        {
            ucSpam.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucSpam);

            ucSpam.AddEmailToSpam(spamEmails);

            SetActiveButton(btn_SpamForm);
            UpdateControlVisibility();
        }

        private void btn_EmailDeleted_Click(object sender, EventArgs e)
        {
            ucDelete.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucDelete);

            ucDelete.AddEmailToDelete(deleteEmails);

            SetActiveButton(btn_EmailDeleted);
            UpdateControlVisibility();
        }

        private void btn_SentEmail_Click(object sender, EventArgs e)
        {
            ucSent.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucSent);

            ucSent.AddEmailToSent(sentEmails);

            SetActiveButton(btn_SentEmail);
            UpdateControlVisibility();
        }

        private void btb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hiệu ứng load Refresh và gọi CheckEmail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_Loading.Width += 5;
            if (panel_Loading.Width >= 1027)
            {
                timer1.Stop();
                panel_Loading.Visible = false;
                isTimerCompleted = true; // Đặt cờ thành true khi timer hoàn thành

                // Gọi phương thức CheckEmails sau khi timer hoàn thành
                CheckEmails();
            }
        }

        private void btn_CheckEmails_Click(object sender, EventArgs e)
        {
            panel_Loading.Visible = true;
            timer1.Enabled = true;
            panel_Loading.Width = 0;
            isTimerCompleted = false; // Đặt cờ là false trước khi bắt đầu

            // Chạy timer để hiển thị loading
            timer1.Start();
        }

        private void btn_CreateNewEmail_Click(object sender, EventArgs e)
        {
            var sendEmailForm = new frm_SendEmail(ucSent);
            sendEmailForm.ShowDialog();
        }

        /// <summary>
        /// Report + Delete email trong inbox
        /// </summary>
        /// <param name="emails"></param>
        private void AddEmailsToDataset(List<EmailData> emails)
        {
            string filePath = @"C:\CongNghe.Net\NaiveBayes\Dataset\email_dataset.csv";

            using (var writer = new StreamWriter(filePath, append: true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                foreach (var email in emails)
                {
                    csv.NextRecord();
                    csv.WriteRecord(new EmailData
                    {
                        label = "Spam",
                        content = email.content,
                    });
                }
            }

            // Tùy chọn: Đào tạo lại bộ phân loại với dataset đã cập nhật
            LoadData(filePath);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var selectedEmails = new List<Email>();

            // Duyệt qua các hàng trong DataGridView để tìm email đã được chọn
            foreach (DataGridViewRow row in ucInbox.dgv_InboxEmailList.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;

                if (checkBox != null && checkBox.Value != null && (bool)checkBox.Value)
                {
                    Email email = row.Tag as Email; // Lấy email từ Tag

                    if (email != null)
                    {
                        selectedEmails.Add(email); // Thêm email vào danh sách đã chọn mà không thay đổi
                    }
                }
            }

            // Thêm email đã chọn vào dataset
            if (selectedEmails.Any())
            {
                // Lấy chỉ phần content từ DataGridView
                var contentEmails = selectedEmails.Select(email => new EmailData
                {
                    label = "Spam",
                    content = email.Content // chỉ lấy phần content của email + .subjecb,.sender(nếu cần)
                }).ToList();

                AddEmailsToDataset(contentEmails); // Ghi vào dataset

                XtraMessageBox.Show($"{selectedEmails.Count} email đã được báo cáo là SPAM");

                spamEmails.AddRange(selectedEmails); // Thêm email đầy đủ vào spamEmails

                // Làm mới hiển thị sau khi báo cáo
                inboxEmails.RemoveAll(email => selectedEmails.Contains(email));
                ucInbox.AddEmailToInbox(inboxEmails);
                lbl_CountInbox.Text = inboxEmails.Count.ToString();
                lbl_CountSpam.Text = spamEmails.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var selectedEmails = new List<Email>();

            // Loop through rows in the DataGridView to find checked emails
            foreach (DataGridViewRow row in ucInbox.dgv_InboxEmailList.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;

                if (checkBox != null && checkBox.Value != null && (bool)checkBox.Value)
                {
                    Email email = row.Tag as Email; // Lấy email từ Tag

                    if (email != null)
                    {
                        selectedEmails.Add(email);
                    }
                }
            }

            // Check if any emails are selected
            if (selectedEmails.Any())
            {
                // Hiển thị hộp thoại xác nhận
                var result = XtraMessageBox.Show(
                    $"Are you sure you want to delete {selectedEmails.Count} selected emails?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Kiểm tra nếu người dùng chọn "Yes" để tiếp tục xóa
                if (result == DialogResult.Yes)
                {
                    // Add selected emails to UC_Delete
                    ucDelete.AddEmailToDelete(selectedEmails);
                    XtraMessageBox.Show($"{selectedEmails.Count} emails have been deleted.");

                    inboxEmails.RemoveAll(email => selectedEmails.Contains(email));
                    deleteEmails.AddRange(selectedEmails);
                    ucInbox.AddEmailToInbox(inboxEmails);
                    lbl_CountInbox.Text = inboxEmails.Count.ToString();
                }
            }
            else
            {
                return;
            }
        }

        private void ckb_AllEmail_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ckb_AllEmail.Checked;

            // Lặp qua tất cả các dòng trong DataGridView và cập nhật trạng thái checkbox
            foreach (DataGridViewRow row in ucInbox.dgv_InboxEmailList.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                if (checkBox != null)
                {
                    checkBox.Value = isChecked; // Đặt giá trị checkbox theo trạng thái của ckb_AllEmail
                }
            }

            // Kiểm tra lại hiển thị của các nút
            UpdateButtonVisibility();
        }

        private void UpdateControlVisibility()
        {
            // Kiểm tra xem UC_Inbox có đang hiển thị không
            bool isInboxVisible = panelContent.Controls.Contains(ucInbox);

            // Cập nhật trạng thái hiển thị cho ckb_AllEmail và các nút
            ckb_AllEmail.Visible = isInboxVisible;
        }

        private void UpdateButtonVisibility()
        {
            // Kiểm tra nếu ckb_AllEmail được chọn hoặc có ít nhất một dòng được chọn
            bool anyEmailSelected = ckb_AllEmail.Checked ||
                ucInbox.dgv_InboxEmailList.Rows.Cast<DataGridViewRow>().Any(row =>
                {
                    DataGridViewCheckBoxCell checkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                    return checkBox != null && checkBox.Value != null && (bool)checkBox.Value;
                });

            // Hiển thị hoặc ẩn các nút dựa trên kết quả kiểm tra
            btnReport.Visible = anyEmailSelected;
            btn_Delete.Visible = anyEmailSelected;
        }

        private void UC_Inbox_EmailSelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }

        /// <summary>
        /// Chỉnh focus icon txt_search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.IconLeft = Properties.Resources.search_2;
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            txt_Search.IconLeft = Properties.Resources.search;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_Search.Text.ToLower();

            ///Inbox
            var filteredInboxEmails = inboxEmails
                .Where(email => email.Content.ToLower().Contains(searchText)
                                || email.Sender.ToLower().Contains(searchText)
                                || email.Subject.ToLower().Contains(searchText))
                .ToList();
            ucInbox.AddEmailToInbox(filteredInboxEmails);

            ///Spam
            var filteredSpamEmails = spamEmails
                .Where(email => email.Content.ToLower().Contains(searchText)
                                || email.Sender.ToLower().Contains(searchText)
                                || email.Subject.ToLower().Contains(searchText))
                .ToList();
            ucSpam.AddEmailToSpam(filteredSpamEmails);

            ///Delete
            var filteredDeleteEmails = deleteEmails
                .Where(email => email.Content.ToLower().Contains(searchText)
                                || email.Sender.ToLower().Contains(searchText)
                                || email.Subject.ToLower().Contains(searchText))
                .ToList();

            ucDelete.AddEmailToDelete(filteredDeleteEmails);


            ///Sent
            var filteredSentEmails = sentEmails
                .Where(email => email.Content.ToLower().Contains(searchText)
                                || email.Sender.ToLower().Contains(searchText)
                                || email.Subject.ToLower().Contains(searchText))
                .ToList();

            ucSent.AddEmailToSent(filteredSentEmails);
        }
    }
}
