using System.Collections.Generic;
using System.Windows.Forms;

namespace SpamEmaiAlpp
{
    public partial class UC_Spam : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Spam()
        {
            InitializeComponent();
        }

        public void AddEmailToSpam(List<Email> inboxEmails)
        {
            dgv_SpamEmailList.Rows.Clear(); // Xóa các dòng hiện tại
            foreach (var email in inboxEmails)
            {
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

                int rowIndex = dgv_SpamEmailList.Rows.Add(false, email.Sender, email.Subject, email.Content, formattedDateTime);
                dgv_SpamEmailList.Rows[rowIndex].Tag = email; // Gán email vào Tag của dòng
            }
        }

        private void dgv_SpamEmailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được chọn hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy email từ Tag của dòng
                var selectedEmail = dgv_SpamEmailList.Rows[e.RowIndex].Tag as Email;

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
