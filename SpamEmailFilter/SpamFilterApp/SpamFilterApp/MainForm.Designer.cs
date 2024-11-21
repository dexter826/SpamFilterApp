namespace SpamFilterApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnClassify = new DevExpress.XtraEditors.SimpleButton();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.memoEmailContent = new DevExpress.XtraEditors.MemoEdit();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlEmails = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReportSpam = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoEmailContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClassify
            // 
            this.btnClassify.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassify.Appearance.Options.UseFont = true;
            this.btnClassify.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClassify.ImageOptions.SvgImage")));
            this.btnClassify.Location = new System.Drawing.Point(226, 506);
            this.btnClassify.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(309, 44);
            this.btnClassify.TabIndex = 5;
            this.btnClassify.Text = "Kiểm tra";
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // lblResult
            // 
            this.lblResult.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Appearance.Options.UseFont = true;
            this.lblResult.Location = new System.Drawing.Point(6, 453);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 22);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Kết quả";
            // 
            // memoEmailContent
            // 
            this.memoEmailContent.Location = new System.Drawing.Point(16, 112);
            this.memoEmailContent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.memoEmailContent.Name = "memoEmailContent";
            this.memoEmailContent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEmailContent.Properties.Appearance.Options.UseFont = true;
            this.memoEmailContent.Size = new System.Drawing.Size(739, 385);
            this.memoEmailContent.TabIndex = 4;
            // 
            // chartControl
            // 
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Location = new System.Drawing.Point(6, 5);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.Size = new System.Drawing.Size(924, 415);
            this.chartControl.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.labelControl3);
            this.panelControl.Controls.Add(this.chartControl);
            this.panelControl.Controls.Add(this.lblResult);
            this.panelControl.Location = new System.Drawing.Point(763, 53);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(935, 525);
            this.panelControl.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(411, 426);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Biểu đồ xác suất ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(343, 22);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nhập nội dung email hoặc chọn dường dẫn";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 556);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 22);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Lịch sử kiểm tra";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(590, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(531, 36);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "ỨNG DỤNG KIỂM TRA EMAIL SPAM";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Enabled = false;
            this.txtDuongDan.Location = new System.Drawing.Point(16, 81);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.Properties.Appearance.Options.UseFont = true;
            this.txtDuongDan.Size = new System.Drawing.Size(629, 24);
            this.txtDuongDan.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.ImageOptions.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(653, 73);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(102, 32);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gridControlEmails
            // 
            this.gridControlEmails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControlEmails.Location = new System.Drawing.Point(5, 5);
            this.gridControlEmails.MainView = this.gridViewEmail;
            this.gridControlEmails.Name = "gridControlEmails";
            this.gridControlEmails.Size = new System.Drawing.Size(1667, 208);
            this.gridControlEmails.TabIndex = 9;
            this.gridControlEmails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmail});
            // 
            // gridViewEmail
            // 
            this.gridViewEmail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewEmail.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewEmail.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewEmail.Appearance.Row.Options.UseFont = true;
            this.gridViewEmail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewEmail.GridControl = this.gridControlEmails;
            this.gridViewEmail.Name = "gridViewEmail";
            this.gridViewEmail.OptionsBehavior.Editable = false;
            this.gridViewEmail.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewEmail.OptionsCustomization.AllowGroup = false;
            this.gridViewEmail.OptionsView.ShowGroupPanel = false;
            this.gridViewEmail.OptionsView.ShowIndicator = false;
            this.gridViewEmail.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewEmail_RowClick);
            this.gridViewEmail.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridViewEmail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewEmail_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "Index";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 70;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nội dung";
            this.gridColumn2.FieldName = "Content";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1083;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Kết quả";
            this.gridColumn3.FieldName = "Result";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 109;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Xác suất Spam";
            this.gridColumn4.FieldName = "SpamProbability";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 190;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Xác suất Không Spam";
            this.gridColumn5.FieldName = "NotSpamProbability";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 213;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlEmails);
            this.panelControl1.Location = new System.Drawing.Point(16, 584);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1677, 218);
            this.panelControl1.TabIndex = 10;
            // 
            // btnReportSpam
            // 
            this.btnReportSpam.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnReportSpam.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSpam.Appearance.Options.UseBackColor = true;
            this.btnReportSpam.Appearance.Options.UseFont = true;
            this.btnReportSpam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReportSpam.ImageOptions.Image")));
            this.btnReportSpam.Location = new System.Drawing.Point(646, 531);
            this.btnReportSpam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReportSpam.Name = "btnReportSpam";
            this.btnReportSpam.Size = new System.Drawing.Size(109, 41);
            this.btnReportSpam.TabIndex = 12;
            this.btnReportSpam.Text = "Report";
            this.btnReportSpam.Click += new System.EventHandler(this.btnReportSpam_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Appearance.Options.UseFont = true;
            this.btn_Clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.ImageOptions.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(16, 504);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnClassify;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 814);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnReportSpam);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.memoEmailContent);
            this.Controls.Add(this.btnClassify);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spam Email Filter";
            ((System.ComponentModel.ISupportInitialize)(this.memoEmailContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClassify;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.MemoEdit memoEmailContent;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraGrid.GridControl gridControlEmails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmail;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnReportSpam;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
    }
}

