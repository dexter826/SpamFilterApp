using DevExpress.XtraEditors;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpamEmaiAlpp
{
    public partial class UC_Inbox : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler EmailSelectionChanged;
        public Guna2CheckBox CkbAllEmail { get; set; }

        public UC_Inbox(Guna2CheckBox ckbAllEmail)
        {
            InitializeComponent();
            CkbAllEmail = ckbAllEmail;
        }

        public void AddEmailToInbox(List<Email> inboxEmails)
        {
            dgv_InboxEmailList.Rows.Clear(); // Xóa các dòng hiện tại
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

                int rowIndex = dgv_InboxEmailList.Rows.Add(false, email.Sender, email.Subject, email.Content, formattedDateTime);
                dgv_InboxEmailList.Rows[rowIndex].Tag = email; // Gán email vào Tag của dòng
            }
        }


        private void dgv_InboxEmailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_InboxEmailList.Columns["Check"].Index && e.RowIndex >= 0)
            {
                // Lấy checkbox và cập nhật giá trị
                DataGridViewCheckBoxCell checkBox = dgv_InboxEmailList.Rows[e.RowIndex].Cells["Check"] as DataGridViewCheckBoxCell;
                if (checkBox != null)
                {
                    checkBox.Value = !(checkBox.Value != null && (bool)checkBox.Value);
                }

                // Gọi sự kiện
                EmailSelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void dgv_InboxEmailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được chọn hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy email từ Tag của dòng
                var selectedEmail = dgv_InboxEmailList.Rows[e.RowIndex].Tag as Email;

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
