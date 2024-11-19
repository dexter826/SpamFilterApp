namespace SpamEmaiAlpp
{
    partial class UC_Spam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_SpamEmailList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SpamEmailList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SpamEmailList
            // 
            this.dgv_SpamEmailList.AllowUserToAddRows = false;
            this.dgv_SpamEmailList.AllowUserToDeleteRows = false;
            this.dgv_SpamEmailList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_SpamEmailList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SpamEmailList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SpamEmailList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SpamEmailList.ColumnHeadersHeight = 55;
            this.dgv_SpamEmailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Sender,
            this.Subject,
            this.Content,
            this.DateTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SpamEmailList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SpamEmailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SpamEmailList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_SpamEmailList.Location = new System.Drawing.Point(0, 0);
            this.dgv_SpamEmailList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_SpamEmailList.Name = "dgv_SpamEmailList";
            this.dgv_SpamEmailList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SpamEmailList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SpamEmailList.RowHeadersVisible = false;
            this.dgv_SpamEmailList.RowHeadersWidth = 51;
            this.dgv_SpamEmailList.RowTemplate.Height = 50;
            this.dgv_SpamEmailList.Size = new System.Drawing.Size(1130, 836);
            this.dgv_SpamEmailList.TabIndex = 1;
            this.dgv_SpamEmailList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgv_SpamEmailList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SpamEmailList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_SpamEmailList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_SpamEmailList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgv_SpamEmailList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_SpamEmailList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_SpamEmailList.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_SpamEmailList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgv_SpamEmailList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_SpamEmailList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_SpamEmailList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_SpamEmailList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_SpamEmailList.ThemeStyle.HeaderStyle.Height = 55;
            this.dgv_SpamEmailList.ThemeStyle.ReadOnly = false;
            this.dgv_SpamEmailList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SpamEmailList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SpamEmailList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_SpamEmailList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_SpamEmailList.ThemeStyle.RowsStyle.Height = 50;
            this.dgv_SpamEmailList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgv_SpamEmailList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_SpamEmailList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SpamEmailList_CellDoubleClick);
            // 
            // Check
            // 
            this.Check.DataPropertyName = "Check";
            this.Check.FillWeight = 34.65483F;
            this.Check.HeaderText = "";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            // 
            // Sender
            // 
            this.Sender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sender.DataPropertyName = "Sender";
            this.Sender.FillWeight = 15.22843F;
            this.Sender.HeaderText = "Người gửi";
            this.Sender.MinimumWidth = 6;
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            this.Sender.Width = 280;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.FillWeight = 97.073F;
            this.Subject.HeaderText = "Tiêu đề";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.FillWeight = 297.1322F;
            this.Content.HeaderText = "Nội dung";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.FillWeight = 55.91152F;
            this.DateTime.HeaderText = "Ngày gửi";
            this.DateTime.MinimumWidth = 6;
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // UC_Spam
            // 
            this.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_SpamEmailList);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UC_Spam";
            this.Size = new System.Drawing.Size(1130, 836);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SpamEmailList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2DataGridView dgv_SpamEmailList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
    }
}
