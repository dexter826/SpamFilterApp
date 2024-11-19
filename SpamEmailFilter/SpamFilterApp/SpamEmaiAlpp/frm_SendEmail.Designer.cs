namespace SpamEmaiAlpp
{
    partial class frm_SendEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SendEmail));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubject = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SendEmail = new Guna.UI2.WinForms.Guna2Button();
            this.txtContent = new DevExpress.XtraEditors.MemoEdit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.btn_Close);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(790, 53);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(63, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Thư mới";
            // 
            // btn_Close
            // 
            this.btn_Close.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Close.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Close.Image = global::SpamEmaiAlpp.Properties.Resources.close_24;
            this.btn_Close.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Close.ImageRotate = 0F;
            this.btn_Close.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_Close.Location = new System.Drawing.Point(750, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_Close.Size = new System.Drawing.Size(32, 29);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTo.BorderRadius = 2;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultText = "";
            this.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTo.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtTo.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTo.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTo.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtTo.Location = new System.Drawing.Point(16, 53);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTo.PlaceholderText = "Người nhận";
            this.txtTo.SelectedText = "";
            this.txtTo.Size = new System.Drawing.Size(755, 53);
            this.txtTo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTo.TabIndex = 1;
            this.txtTo.TextOffset = new System.Drawing.Point(-5, 0);
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            this.txtTo.Enter += new System.EventHandler(this.txtTo_Enter);
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.BorderRadius = 2;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.DefaultText = "";
            this.txtSubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubject.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtSubject.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtSubject.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSubject.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtSubject.Location = new System.Drawing.Point(16, 110);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSubject.PlaceholderText = "Tiêu đề";
            this.txtSubject.SelectedText = "";
            this.txtSubject.Size = new System.Drawing.Size(755, 53);
            this.txtSubject.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSubject.TabIndex = 2;
            this.txtSubject.TextOffset = new System.Drawing.Point(-5, 0);
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.BackColor = System.Drawing.Color.Transparent;
            this.btn_SendEmail.BorderRadius = 20;
            this.btn_SendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SendEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.btn_SendEmail.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendEmail.ForeColor = System.Drawing.Color.White;
            this.btn_SendEmail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(97)))), ((int)(((byte)(195)))));
            this.btn_SendEmail.Location = new System.Drawing.Point(627, 565);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.ShadowDecoration.BorderRadius = 20;
            this.btn_SendEmail.ShadowDecoration.Depth = 10;
            this.btn_SendEmail.ShadowDecoration.Enabled = true;
            this.btn_SendEmail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.btn_SendEmail.Size = new System.Drawing.Size(141, 45);
            this.btn_SendEmail.TabIndex = 4;
            this.btn_SendEmail.Text = "Gửi";
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(14, 181);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Name = "txtContent";
            this.txtContent.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContent.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.txtContent.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Properties.Appearance.Options.UseBackColor = true;
            this.txtContent.Properties.Appearance.Options.UseFont = true;
            this.txtContent.Properties.Appearance.Options.UseForeColor = true;
            this.txtContent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtContent.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.Size = new System.Drawing.Size(763, 373);
            this.txtContent.TabIndex = 3;
            // 
            // frm_SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(790, 622);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btn_SendEmail);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.txtTo);
            this.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SendEmail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SendEmail";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Close;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private Guna.UI2.WinForms.Guna2TextBox txtSubject;
        private Guna.UI2.WinForms.Guna2Button btn_SendEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DevExpress.XtraEditors.MemoEdit txtContent;
    }
}