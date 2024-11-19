namespace SpamEmaiAlpp
{
    partial class frm_Gmail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Gmail));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_SentEmail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_EmailDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_CountSpam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btb_Exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_CreateNewEmail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SpamForm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_CountInbox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Inbox = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ckb_AllEmail = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnReport = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_Loading = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btn_CheckEmails = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.btn_SentEmail);
            this.guna2Panel1.Controls.Add(this.btn_EmailDeleted);
            this.guna2Panel1.Controls.Add(this.lbl_CountSpam);
            this.guna2Panel1.Controls.Add(this.btb_Exit);
            this.guna2Panel1.Controls.Add(this.btn_CreateNewEmail);
            this.guna2Panel1.Controls.Add(this.btn_SpamForm);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.lbl_CountInbox);
            this.guna2Panel1.Controls.Add(this.btn_Inbox);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(256, 652);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_SentEmail
            // 
            this.btn_SentEmail.BackColor = System.Drawing.Color.Transparent;
            this.btn_SentEmail.BorderRadius = 20;
            this.btn_SentEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SentEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SentEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SentEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SentEmail.FillColor = System.Drawing.Color.Transparent;
            this.btn_SentEmail.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SentEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SentEmail.ForeColor = System.Drawing.Color.White;
            this.btn_SentEmail.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_SentEmail.Image = global::SpamEmaiAlpp.Properties.Resources.send_2;
            this.btn_SentEmail.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btn_SentEmail.Location = new System.Drawing.Point(-20, 413);
            this.btn_SentEmail.Name = "btn_SentEmail";
            this.btn_SentEmail.Size = new System.Drawing.Size(237, 65);
            this.btn_SentEmail.TabIndex = 6;
            this.btn_SentEmail.Text = "Đã gửi";
            this.btn_SentEmail.TextOffset = new System.Drawing.Point(-9, 0);
            this.btn_SentEmail.UseTransparentBackground = true;
            this.btn_SentEmail.Click += new System.EventHandler(this.btn_SentEmail_Click);
            // 
            // btn_EmailDeleted
            // 
            this.btn_EmailDeleted.BackColor = System.Drawing.Color.Transparent;
            this.btn_EmailDeleted.BorderRadius = 20;
            this.btn_EmailDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_EmailDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_EmailDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_EmailDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_EmailDeleted.FillColor = System.Drawing.Color.Transparent;
            this.btn_EmailDeleted.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EmailDeleted.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EmailDeleted.ForeColor = System.Drawing.Color.White;
            this.btn_EmailDeleted.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_EmailDeleted.Image = global::SpamEmaiAlpp.Properties.Resources.garbage;
            this.btn_EmailDeleted.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btn_EmailDeleted.Location = new System.Drawing.Point(-20, 342);
            this.btn_EmailDeleted.Name = "btn_EmailDeleted";
            this.btn_EmailDeleted.Size = new System.Drawing.Size(237, 65);
            this.btn_EmailDeleted.TabIndex = 5;
            this.btn_EmailDeleted.Text = "Thùng rác";
            this.btn_EmailDeleted.TextOffset = new System.Drawing.Point(-4, 0);
            this.btn_EmailDeleted.UseTransparentBackground = true;
            this.btn_EmailDeleted.Click += new System.EventHandler(this.btn_EmailDeleted_Click);
            // 
            // lbl_CountSpam
            // 
            this.lbl_CountSpam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CountSpam.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountSpam.ForeColor = System.Drawing.Color.White;
            this.lbl_CountSpam.Location = new System.Drawing.Point(223, 298);
            this.lbl_CountSpam.Name = "lbl_CountSpam";
            this.lbl_CountSpam.Size = new System.Drawing.Size(11, 21);
            this.lbl_CountSpam.TabIndex = 4;
            this.lbl_CountSpam.Text = "z";
            // 
            // btb_Exit
            // 
            this.btb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btb_Exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btb_Exit.HoverState.ImageSize = new System.Drawing.Size(50, 55);
            this.btb_Exit.Image = global::SpamEmaiAlpp.Properties.Resources.exit;
            this.btb_Exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btb_Exit.ImageRotate = 0F;
            this.btb_Exit.ImageSize = new System.Drawing.Size(45, 50);
            this.btb_Exit.Location = new System.Drawing.Point(12, 591);
            this.btb_Exit.Name = "btb_Exit";
            this.btb_Exit.PressedState.ImageSize = new System.Drawing.Size(45, 50);
            this.btb_Exit.Size = new System.Drawing.Size(54, 49);
            this.btb_Exit.TabIndex = 7;
            this.tooltip.SetToolTip(this.btb_Exit, "Thoát");
            this.btb_Exit.UseTransparentBackground = true;
            this.btb_Exit.Click += new System.EventHandler(this.btb_Exit_Click);
            // 
            // btn_CreateNewEmail
            // 
            this.btn_CreateNewEmail.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateNewEmail.BorderRadius = 20;
            this.btn_CreateNewEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CreateNewEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CreateNewEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CreateNewEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CreateNewEmail.FillColor = System.Drawing.Color.White;
            this.btn_CreateNewEmail.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_CreateNewEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateNewEmail.ForeColor = System.Drawing.Color.DimGray;
            this.btn_CreateNewEmail.Image = global::SpamEmaiAlpp.Properties.Resources.edit1;
            this.btn_CreateNewEmail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CreateNewEmail.ImageOffset = new System.Drawing.Point(8, 0);
            this.btn_CreateNewEmail.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_CreateNewEmail.Location = new System.Drawing.Point(50, 94);
            this.btn_CreateNewEmail.Name = "btn_CreateNewEmail";
            this.btn_CreateNewEmail.Size = new System.Drawing.Size(156, 70);
            this.btn_CreateNewEmail.TabIndex = 0;
            this.btn_CreateNewEmail.Text = "Soạn thư";
            this.btn_CreateNewEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_CreateNewEmail.TextOffset = new System.Drawing.Point(-8, 0);
            this.btn_CreateNewEmail.UseTransparentBackground = true;
            this.btn_CreateNewEmail.Click += new System.EventHandler(this.btn_CreateNewEmail_Click);
            // 
            // btn_SpamForm
            // 
            this.btn_SpamForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_SpamForm.BorderRadius = 20;
            this.btn_SpamForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SpamForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SpamForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SpamForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SpamForm.FillColor = System.Drawing.Color.Transparent;
            this.btn_SpamForm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SpamForm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SpamForm.ForeColor = System.Drawing.Color.White;
            this.btn_SpamForm.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_SpamForm.Image = global::SpamEmaiAlpp.Properties.Resources.spam;
            this.btn_SpamForm.ImageOffset = new System.Drawing.Point(-9, 0);
            this.btn_SpamForm.Location = new System.Drawing.Point(-20, 276);
            this.btn_SpamForm.Name = "btn_SpamForm";
            this.btn_SpamForm.Size = new System.Drawing.Size(237, 65);
            this.btn_SpamForm.TabIndex = 3;
            this.btn_SpamForm.Text = "Thư rác";
            this.btn_SpamForm.TextOffset = new System.Drawing.Point(-8, 0);
            this.btn_SpamForm.UseTransparentBackground = true;
            this.btn_SpamForm.Click += new System.EventHandler(this.btn_SpamForm_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(212, 63);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbl_CountInbox
            // 
            this.lbl_CountInbox.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CountInbox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountInbox.ForeColor = System.Drawing.Color.White;
            this.lbl_CountInbox.Location = new System.Drawing.Point(223, 232);
            this.lbl_CountInbox.Name = "lbl_CountInbox";
            this.lbl_CountInbox.Size = new System.Drawing.Size(11, 21);
            this.lbl_CountInbox.TabIndex = 2;
            this.lbl_CountInbox.Text = "z";
            // 
            // btn_Inbox
            // 
            this.btn_Inbox.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inbox.BorderRadius = 20;
            this.btn_Inbox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Inbox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Inbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Inbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Inbox.FillColor = System.Drawing.Color.Transparent;
            this.btn_Inbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Inbox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inbox.ForeColor = System.Drawing.Color.White;
            this.btn_Inbox.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_Inbox.Image = global::SpamEmaiAlpp.Properties.Resources.all_inbox;
            this.btn_Inbox.Location = new System.Drawing.Point(-20, 210);
            this.btn_Inbox.Name = "btn_Inbox";
            this.btn_Inbox.Size = new System.Drawing.Size(237, 65);
            this.btn_Inbox.TabIndex = 1;
            this.btn_Inbox.Text = "Hộp thư đến";
            this.btn_Inbox.UseTransparentBackground = true;
            this.btn_Inbox.Click += new System.EventHandler(this.btn_Inbox_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.BorderRadius = 20;
            this.panelContent.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.panelContent.BorderThickness = 1;
            this.panelContent.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContent.Location = new System.Drawing.Point(275, 118);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1060, 513);
            this.panelContent.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.Controls.Add(this.ckb_AllEmail);
            this.guna2Panel2.Controls.Add(this.btn_Delete);
            this.guna2Panel2.Controls.Add(this.btnReport);
            this.guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Location = new System.Drawing.Point(263, 82);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1084, 558);
            this.guna2Panel2.TabIndex = 3;
            // 
            // ckb_AllEmail
            // 
            this.ckb_AllEmail.AutoSize = true;
            this.ckb_AllEmail.BackColor = System.Drawing.Color.White;
            this.ckb_AllEmail.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.ckb_AllEmail.CheckedState.BorderRadius = 3;
            this.ckb_AllEmail.CheckedState.BorderThickness = 1;
            this.ckb_AllEmail.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ckb_AllEmail.CheckMarkColor = System.Drawing.Color.DimGray;
            this.ckb_AllEmail.Font = new System.Drawing.Font("Roboto", 9F);
            this.ckb_AllEmail.ForeColor = System.Drawing.Color.White;
            this.ckb_AllEmail.Location = new System.Drawing.Point(30, 12);
            this.ckb_AllEmail.Name = "ckb_AllEmail";
            this.ckb_AllEmail.Size = new System.Drawing.Size(15, 14);
            this.ckb_AllEmail.TabIndex = 0;
            this.ckb_AllEmail.UncheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.ckb_AllEmail.UncheckedState.BorderRadius = 3;
            this.ckb_AllEmail.UncheckedState.BorderThickness = 2;
            this.ckb_AllEmail.UncheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ckb_AllEmail.UseVisualStyleBackColor = false;
            this.ckb_AllEmail.Visible = false;
            this.ckb_AllEmail.CheckedChanged += new System.EventHandler(this.ckb_AllEmail_CheckedChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Delete.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_Delete.Image = global::SpamEmaiAlpp.Properties.Resources.delete1;
            this.btn_Delete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Delete.ImageRotate = 0F;
            this.btn_Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Delete.Location = new System.Drawing.Point(125, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.btn_Delete.Size = new System.Drawing.Size(38, 30);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.UseTransparentBackground = true;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnReport.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnReport.Image = global::SpamEmaiAlpp.Properties.Resources.release1;
            this.btnReport.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnReport.ImageRotate = 0F;
            this.btnReport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReport.Location = new System.Drawing.Point(73, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.btnReport.Size = new System.Drawing.Size(38, 30);
            this.btnReport.TabIndex = 1;
            this.btnReport.UseTransparentBackground = true;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.panel_Loading);
            this.guna2Panel3.Location = new System.Drawing.Point(293, 77);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1027, 5);
            this.guna2Panel3.TabIndex = 7;
            // 
            // panel_Loading
            // 
            this.panel_Loading.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Loading.Location = new System.Drawing.Point(0, 0);
            this.panel_Loading.Name = "panel_Loading";
            this.panel_Loading.Size = new System.Drawing.Size(160, 17);
            this.panel_Loading.TabIndex = 0;
            this.panel_Loading.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tooltip
            // 
            this.tooltip.AllowLinksHandling = true;
            this.tooltip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // btn_CheckEmails
            // 
            this.btn_CheckEmails.BackColor = System.Drawing.Color.Transparent;
            this.btn_CheckEmails.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_CheckEmails.HoverState.Image = global::SpamEmaiAlpp.Properties.Resources.icons8_update_left_rotation;
            this.btn_CheckEmails.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_CheckEmails.Image = global::SpamEmaiAlpp.Properties.Resources.icons8_update_left_rotation;
            this.btn_CheckEmails.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_CheckEmails.ImageRotate = 0F;
            this.btn_CheckEmails.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_CheckEmails.Location = new System.Drawing.Point(1303, 32);
            this.btn_CheckEmails.Name = "btn_CheckEmails";
            this.btn_CheckEmails.PressedState.Image = global::SpamEmaiAlpp.Properties.Resources.icons8_update_left_rotation;
            this.btn_CheckEmails.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_CheckEmails.Size = new System.Drawing.Size(47, 39);
            this.btn_CheckEmails.TabIndex = 2;
            this.tooltip.SetToolTip(this.btn_CheckEmails, "Làm mới");
            this.btn_CheckEmails.UseTransparentBackground = true;
            this.btn_CheckEmails.Click += new System.EventHandler(this.btn_CheckEmails_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderRadius = 20;
            this.txt_Search.BorderThickness = 0;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FillColor = System.Drawing.Color.Gray;
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.FocusedState.FillColor = System.Drawing.Color.Silver;
            this.txt_Search.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.IconLeft = global::SpamEmaiAlpp.Properties.Resources.search;
            this.txt_Search.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_Search.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_Search.Location = new System.Drawing.Point(263, 13);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.txt_Search.PlaceholderText = "Tìm kiếm trong thư";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(588, 55);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            // 
            // frm_Gmail
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1362, 652);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.btn_CheckEmails);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::SpamEmaiAlpp.Properties.Resources.gmail_new_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Gmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spam Filter Email App";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Inbox;
        private Guna.UI2.WinForms.Guna2Button btn_SpamForm;
        private Guna.UI2.WinForms.Guna2Button btn_CreateNewEmail;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2ImageButton btb_Exit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ImageButton btnReport;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_CountInbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_CountSpam;
        private Guna.UI2.WinForms.Guna2Button btn_EmailDeleted;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Delete;
        private Guna.UI2.WinForms.Guna2CheckBox ckb_AllEmail;
        private Guna.UI2.WinForms.Guna2ImageButton btn_CheckEmails;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel panel_Loading;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip;
        public Guna.UI2.WinForms.Guna2Button btn_SentEmail;
    }
}

