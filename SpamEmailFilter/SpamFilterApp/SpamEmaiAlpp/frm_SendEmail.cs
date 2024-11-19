using DevExpress.XtraEditors;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpamEmaiAlpp
{
    public partial class frm_SendEmail : Form
    {
        private UC_Sent ucSent;
        public frm_SendEmail(UC_Sent ucSent)
        {
            InitializeComponent();
            this.ucSent = ucSent;
        }

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTo.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập người nhận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string recipient = txtTo.Text.Replace("Đến: ", "").Trim();
            string subject = txtSubject.Text;
            string body = txtContent.Text;

            try
            {
                var gmailService = GmailServiceHelper.GetGmailService();
                GmailServiceHelper.SendEmail(gmailService, recipient, subject, body);
                XtraMessageBox.Show("Email đã được gửi thành công!");

                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Có lỗi xảy ra khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTo_Enter(object sender, EventArgs e)
        {
            txtTo.Text = "Đến: ";
            txtTo.SelectionStart = 5;
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            if (txtTo.Text.Length < 5 || !txtTo.Text.StartsWith("Đến: "))
            {
                txtTo.Text = "Đến: ";
                txtTo.SelectionStart = 5;
            }
        }
    }
}
