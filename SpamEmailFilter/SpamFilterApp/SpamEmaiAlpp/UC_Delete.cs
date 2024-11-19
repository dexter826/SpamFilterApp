using System.Collections.Generic;
using System.Windows.Forms;

namespace SpamEmaiAlpp
{
    public partial class UC_Delete : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Delete()
        {
            InitializeComponent();
        }

        public void AddEmailToDelete(List<Email> deletedEmails)
        {
            dgv_DeleteEmailList.Rows.Clear(); // Xóa các dòng hiện tại
            foreach (var email in deletedEmails)
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

                int rowIndex = dgv_DeleteEmailList.Rows.Add(false, email.Sender, email.Subject, email.Content, formattedDateTime);
                dgv_DeleteEmailList.Rows[rowIndex].Tag = email; // Gán email vào Tag của dòng
            }
        }

        private void dgv_DeleteEmailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được chọn hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy email từ Tag của dòng
                var selectedEmail = dgv_DeleteEmailList.Rows[e.RowIndex].Tag as Email;

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
