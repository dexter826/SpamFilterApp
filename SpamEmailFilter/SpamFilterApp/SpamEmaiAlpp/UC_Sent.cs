using DevExpress.XtraEditors;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpamEmaiAlpp
{
    public partial class UC_Sent : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Sent()
        {
            InitializeComponent();
        }

        public void AddEmailToSent(List<Email> sentEmails)
        {

            foreach (var email in sentEmails)
            {
                // Kiểm tra email có phải là null không
                if (email == null) continue; // Bỏ qua nếu email là null

                string formattedDateTime;
                // Kiểm tra nếu email được gửi hôm nay
                if (email.DateTime.Date == System.DateTime.Today)
                {
                    formattedDateTime = email.DateTime.ToString("HH:mm"); // Hiển thị theo dạng giờ:phút
                }
                else
                {
                    formattedDateTime = email.DateTime.ToString("dd MMM"); // Hiển thị theo dạng ngày tháng
                }

                int rowIndex = dgv_SentEmailList.Rows.Add(false, email.Recipient, email.Subject, email.Content, formattedDateTime);
                dgv_SentEmailList.Rows[rowIndex].Tag = email; // Gán email vào Tag của dòng
            }
        }

        private void dgv_SentEmailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được chọn hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy email từ Tag của dòng
                var selectedEmail = dgv_SentEmailList.Rows[e.RowIndex].Tag as Email;

                if (selectedEmail != null)
                {
                    string formattedDateTime = selectedEmail.DateTime.ToString("HH:mm  ddd dd/MM/yyyy");


                    frm_DetailEmail detailsForm = new frm_DetailEmail(
                        selectedEmail.Sender,
                        selectedEmail.Subject,
                        formattedDateTime,
                        selectedEmail.Content
                    );

                    detailsForm.ShowDialog(); // Hiển thị form như một dialog
                }
            }
        }
    }
}
