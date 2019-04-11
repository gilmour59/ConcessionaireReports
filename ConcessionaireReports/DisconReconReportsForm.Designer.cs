namespace ConcessionaireReports
{
    partial class DisconReconReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisconReconReportsForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControlDisconReconReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerReconnectFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReconnectTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReconnectSearch = new System.Windows.Forms.Button();
            this.pictureBoxLoadingReconnect = new System.Windows.Forms.PictureBox();
            this.reportViewerReconnect = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.pictureBoxLoadingDisconnect = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDisconnectFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDisconnectTo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonDisconnectSearch = new System.Windows.Forms.Button();
            this.reportViewerDisconnect = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControlDisconReconReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingReconnect)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingDisconnect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDisconReconReports
            // 
            this.tabControlDisconReconReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlDisconReconReports.Controls.Add(this.tabPage1);
            this.tabControlDisconReconReports.Controls.Add(this.tabPage7);
            this.tabControlDisconReconReports.ItemSize = new System.Drawing.Size(70, 150);
            this.tabControlDisconReconReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlDisconReconReports.Multiline = true;
            this.tabControlDisconReconReports.Name = "tabControlDisconReconReports";
            this.tabControlDisconReconReports.SelectedIndex = 0;
            this.tabControlDisconReconReports.Size = new System.Drawing.Size(1152, 563);
            this.tabControlDisconReconReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlDisconReconReports.TabIndex = 3;
            this.tabControlDisconReconReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlDisconReconReports_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerReconnectFrom);
            this.tabPage1.Controls.Add(this.dateTimePickerReconnectTo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonReconnectSearch);
            this.tabPage1.Controls.Add(this.pictureBoxLoadingReconnect);
            this.tabPage1.Controls.Add(this.reportViewerReconnect);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reconnection Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReconnectFrom
            // 
            this.dateTimePickerReconnectFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerReconnectFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReconnectFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReconnectFrom.Location = new System.Drawing.Point(71, 16);
            this.dateTimePickerReconnectFrom.Name = "dateTimePickerReconnectFrom";
            this.dateTimePickerReconnectFrom.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerReconnectFrom.TabIndex = 73;
            // 
            // dateTimePickerReconnectTo
            // 
            this.dateTimePickerReconnectTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerReconnectTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReconnectTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReconnectTo.Location = new System.Drawing.Point(290, 16);
            this.dateTimePickerReconnectTo.Name = "dateTimePickerReconnectTo";
            this.dateTimePickerReconnectTo.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerReconnectTo.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "From:";
            // 
            // buttonReconnectSearch
            // 
            this.buttonReconnectSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReconnectSearch.Location = new System.Drawing.Point(534, 8);
            this.buttonReconnectSearch.Name = "buttonReconnectSearch";
            this.buttonReconnectSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonReconnectSearch.TabIndex = 70;
            this.buttonReconnectSearch.Text = "Search";
            this.buttonReconnectSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLoadingReconnect
            // 
            this.pictureBoxLoadingReconnect.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingReconnect.Image")));
            this.pictureBoxLoadingReconnect.Location = new System.Drawing.Point(26, 49);
            this.pictureBoxLoadingReconnect.Name = "pictureBoxLoadingReconnect";
            this.pictureBoxLoadingReconnect.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingReconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingReconnect.TabIndex = 69;
            this.pictureBoxLoadingReconnect.TabStop = false;
            this.pictureBoxLoadingReconnect.Visible = false;
            // 
            // reportViewerReconnect
            // 
            reportDataSource1.Name = "DataSetReceivablesReports";
            reportDataSource1.Value = null;
            this.reportViewerReconnect.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerReconnect.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReceivablesReports.ReportAccountsReceivableAgingPerAcc" +
    "ount.rdlc";
            this.reportViewerReconnect.Location = new System.Drawing.Point(26, 49);
            this.reportViewerReconnect.Name = "reportViewerReconnect";
            this.reportViewerReconnect.ServerReport.BearerToken = null;
            this.reportViewerReconnect.Size = new System.Drawing.Size(944, 481);
            this.reportViewerReconnect.TabIndex = 3;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pictureBoxLoadingDisconnect);
            this.tabPage7.Controls.Add(this.dateTimePickerDisconnectFrom);
            this.tabPage7.Controls.Add(this.dateTimePickerDisconnectTo);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Controls.Add(this.buttonDisconnectSearch);
            this.tabPage7.Controls.Add(this.reportViewerDisconnect);
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(994, 555);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Disconnection Summary";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLoadingDisconnect
            // 
            this.pictureBoxLoadingDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingDisconnect.Image")));
            this.pictureBoxLoadingDisconnect.Location = new System.Drawing.Point(26, 49);
            this.pictureBoxLoadingDisconnect.Name = "pictureBoxLoadingDisconnect";
            this.pictureBoxLoadingDisconnect.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingDisconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingDisconnect.TabIndex = 70;
            this.pictureBoxLoadingDisconnect.TabStop = false;
            this.pictureBoxLoadingDisconnect.Visible = false;
            // 
            // dateTimePickerDisconnectFrom
            // 
            this.dateTimePickerDisconnectFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDisconnectFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDisconnectFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDisconnectFrom.Location = new System.Drawing.Point(71, 16);
            this.dateTimePickerDisconnectFrom.Name = "dateTimePickerDisconnectFrom";
            this.dateTimePickerDisconnectFrom.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerDisconnectFrom.TabIndex = 43;
            // 
            // dateTimePickerDisconnectTo
            // 
            this.dateTimePickerDisconnectTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDisconnectTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDisconnectTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDisconnectTo.Location = new System.Drawing.Point(290, 16);
            this.dateTimePickerDisconnectTo.Name = "dateTimePickerDisconnectTo";
            this.dateTimePickerDisconnectTo.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerDisconnectTo.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(256, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "To:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "From:";
            // 
            // buttonDisconnectSearch
            // 
            this.buttonDisconnectSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnectSearch.Location = new System.Drawing.Point(534, 8);
            this.buttonDisconnectSearch.Name = "buttonDisconnectSearch";
            this.buttonDisconnectSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonDisconnectSearch.TabIndex = 37;
            this.buttonDisconnectSearch.Text = "Search";
            this.buttonDisconnectSearch.UseVisualStyleBackColor = true;
            // 
            // reportViewerDisconnect
            // 
            reportDataSource2.Name = "DataSetReceivablesReports";
            reportDataSource2.Value = null;
            this.reportViewerDisconnect.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerDisconnect.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReceivablesReports.ReportOtherReceivables.rdlc";
            this.reportViewerDisconnect.Location = new System.Drawing.Point(26, 49);
            this.reportViewerDisconnect.Name = "reportViewerDisconnect";
            this.reportViewerDisconnect.ServerReport.BearerToken = null;
            this.reportViewerDisconnect.Size = new System.Drawing.Size(944, 481);
            this.reportViewerDisconnect.TabIndex = 7;
            // 
            // DisconReconReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 587);
            this.Controls.Add(this.tabControlDisconReconReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DisconReconReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disconnection Reconnection Reports";
            this.Load += new System.EventHandler(this.DisconReconReportsForm_Load);
            this.tabControlDisconReconReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingReconnect)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingDisconnect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDisconReconReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReconnectFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerReconnectTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReconnectSearch;
        private System.Windows.Forms.PictureBox pictureBoxLoadingReconnect;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReconnect;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox pictureBoxLoadingDisconnect;
        private System.Windows.Forms.DateTimePicker dateTimePickerDisconnectFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDisconnectTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonDisconnectSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDisconnect;
    }
}