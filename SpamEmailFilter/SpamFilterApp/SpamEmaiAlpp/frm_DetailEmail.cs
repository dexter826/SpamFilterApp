using DevExpress.XtraEditors;
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
    public partial class frm_DetailEmail : Form
    {
        public frm_DetailEmail(string sender, string subject, string formattedDateTime, string content)
        {
            InitializeComponent();
            lblSender.Text = sender;
            lblSubject.Text = subject;
            lblDateTime.Text = formattedDateTime;
            lblContent.Text = content;
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

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}