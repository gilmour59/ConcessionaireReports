namespace ConcessionaireReports
{
    partial class ARMaintenanceReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARMaintenanceReportsForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControlARMaintenanceReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerPromissoryNoteFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPromissoryNoteTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPromissoryNoteSearch = new System.Windows.Forms.Button();
            this.pictureBoxLoadingPromissoryNote = new System.Windows.Forms.PictureBox();
            this.reportViewerPromissoryNote = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxLoadingOverduePromiNote = new System.Windows.Forms.PictureBox();
            this.dateTimePickerOverduePromiNoteAsOf = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewerOverduePromiNote = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonOverduePromiNoteSearch = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.pictureBoxLoadingDebCredMemo = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDebCredMemoFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebCredMemoTo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonDebCredMemoSearch = new System.Windows.Forms.Button();
            this.reportViewerDebCredMemo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PromissoryNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetARMaintenanceReports = new ConcessionaireReports.DataSetARMaintenanceReports();
            this.OverduePNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlARMaintenanceReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingPromissoryNote)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingOverduePromiNote)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingDebCredMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromissoryNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetARMaintenanceReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverduePNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlARMaintenanceReports
            // 
            this.tabControlARMaintenanceReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlARMaintenanceReports.Controls.Add(this.tabPage1);
            this.tabControlARMaintenanceReports.Controls.Add(this.tabPage2);
            this.tabControlARMaintenanceReports.Controls.Add(this.tabPage7);
            this.tabControlARMaintenanceReports.ItemSize = new System.Drawing.Size(70, 150);
            this.tabControlARMaintenanceReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlARMaintenanceReports.Multiline = true;
            this.tabControlARMaintenanceReports.Name = "tabControlARMaintenanceReports";
            this.tabControlARMaintenanceReports.SelectedIndex = 0;
            this.tabControlARMaintenanceReports.Size = new System.Drawing.Size(1152, 563);
            this.tabControlARMaintenanceReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlARMaintenanceReports.TabIndex = 2;
            this.tabControlARMaintenanceReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlARMaintenanceReports_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerPromissoryNoteFrom);
            this.tabPage1.Controls.Add(this.dateTimePickerPromissoryNoteTo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonPromissoryNoteSearch);
            this.tabPage1.Controls.Add(this.pictureBoxLoadingPromissoryNote);
            this.tabPage1.Controls.Add(this.reportViewerPromissoryNote);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary of Promissory Notes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerPromissoryNoteFrom
            // 
            this.dateTimePickerPromissoryNoteFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerPromissoryNoteFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPromissoryNoteFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPromissoryNoteFrom.Location = new System.Drawing.Point(71, 16);
            this.dateTimePickerPromissoryNoteFrom.Name = "dateTimePickerPromissoryNoteFrom";
            this.dateTimePickerPromissoryNoteFrom.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerPromissoryNoteFrom.TabIndex = 73;
            // 
            // dateTimePickerPromissoryNoteTo
            // 
            this.dateTimePickerPromissoryNoteTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerPromissoryNoteTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPromissoryNoteTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPromissoryNoteTo.Location = new System.Drawing.Point(290, 16);
            this.dateTimePickerPromissoryNoteTo.Name = "dateTimePickerPromissoryNoteTo";
            this.dateTimePickerPromissoryNoteTo.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerPromissoryNoteTo.TabIndex = 74;
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
            // buttonPromissoryNoteSearch
            // 
            this.buttonPromissoryNoteSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromissoryNoteSearch.Location = new System.Drawing.Point(534, 8);
            this.buttonPromissoryNoteSearch.Name = "buttonPromissoryNoteSearch";
            this.buttonPromissoryNoteSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonPromissoryNoteSearch.TabIndex = 70;
            this.buttonPromissoryNoteSearch.Text = "Search";
            this.buttonPromissoryNoteSearch.UseVisualStyleBackColor = true;
            this.buttonPromissoryNoteSearch.Click += new System.EventHandler(this.buttonPromissoryNoteSearch_Click);
            // 
            // pictureBoxLoadingPromissoryNote
            // 
            this.pictureBoxLoadingPromissoryNote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingPromissoryNote.Image")));
            this.pictureBoxLoadingPromissoryNote.Location = new System.Drawing.Point(26, 49);
            this.pictureBoxLoadingPromissoryNote.Name = "pictureBoxLoadingPromissoryNote";
            this.pictureBoxLoadingPromissoryNote.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingPromissoryNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingPromissoryNote.TabIndex = 69;
            this.pictureBoxLoadingPromissoryNote.TabStop = false;
            this.pictureBoxLoadingPromissoryNote.Visible = false;
            // 
            // reportViewerPromissoryNote
            // 
            reportDataSource1.Name = "DataSetARMaintenanceReports";
            reportDataSource1.Value = this.PromissoryNotesBindingSource;
            this.reportViewerPromissoryNote.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPromissoryNote.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ARMaintenanceReports.ReportPromissoryNotes.rdlc";
            this.reportViewerPromissoryNote.Location = new System.Drawing.Point(26, 49);
            this.reportViewerPromissoryNote.Name = "reportViewerPromissoryNote";
            this.reportViewerPromissoryNote.ServerReport.BearerToken = null;
            this.reportViewerPromissoryNote.Size = new System.Drawing.Size(944, 481);
            this.reportViewerPromissoryNote.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBoxLoadingOverduePromiNote);
            this.tabPage2.Controls.Add(this.dateTimePickerOverduePromiNoteAsOf);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.reportViewerOverduePromiNote);
            this.tabPage2.Controls.Add(this.buttonOverduePromiNoteSearch);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Summary of Overdue Promissory Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLoadingOverduePromiNote
            // 
            this.pictureBoxLoadingOverduePromiNote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingOverduePromiNote.Image")));
            this.pictureBoxLoadingOverduePromiNote.Location = new System.Drawing.Point(26, 49);
            this.pictureBoxLoadingOverduePromiNote.Name = "pictureBoxLoadingOverduePromiNote";
            this.pictureBoxLoadingOverduePromiNote.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingOverduePromiNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingOverduePromiNote.TabIndex = 71;
            this.pictureBoxLoadingOverduePromiNote.TabStop = false;
            this.pictureBoxLoadingOverduePromiNote.Visible = false;
            // 
            // dateTimePickerOverduePromiNoteAsOf
            // 
            this.dateTimePickerOverduePromiNoteAsOf.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerOverduePromiNoteAsOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOverduePromiNoteAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOverduePromiNoteAsOf.Location = new System.Drawing.Point(80, 13);
            this.dateTimePickerOverduePromiNoteAsOf.Name = "dateTimePickerOverduePromiNoteAsOf";
            this.dateTimePickerOverduePromiNoteAsOf.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerOverduePromiNoteAsOf.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "As Of:";
            // 
            // reportViewerOverduePromiNote
            // 
            reportDataSource2.Name = "DataSetARMaintenanceReports";
            reportDataSource2.Value = this.OverduePNBindingSource;
            this.reportViewerOverduePromiNote.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerOverduePromiNote.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ARMaintenanceReports.ReportOverduePN.rdlc";
            this.reportViewerOverduePromiNote.Location = new System.Drawing.Point(26, 49);
            this.reportViewerOverduePromiNote.Name = "reportViewerOverduePromiNote";
            this.reportViewerOverduePromiNote.ServerReport.BearerToken = null;
            this.reportViewerOverduePromiNote.Size = new System.Drawing.Size(944, 481);
            this.reportViewerOverduePromiNote.TabIndex = 10;
            // 
            // buttonOverduePromiNoteSearch
            // 
            this.buttonOverduePromiNoteSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverduePromiNoteSearch.Location = new System.Drawing.Point(292, 5);
            this.buttonOverduePromiNoteSearch.Name = "buttonOverduePromiNoteSearch";
            this.buttonOverduePromiNoteSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonOverduePromiNoteSearch.TabIndex = 9;
            this.buttonOverduePromiNoteSearch.Text = "Search";
            this.buttonOverduePromiNoteSearch.UseVisualStyleBackColor = true;
            this.buttonOverduePromiNoteSearch.Click += new System.EventHandler(this.buttonOverduePromiNoteSearch_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pictureBoxLoadingDebCredMemo);
            this.tabPage7.Controls.Add(this.dateTimePickerDebCredMemoFrom);
            this.tabPage7.Controls.Add(this.dateTimePickerDebCredMemoTo);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Controls.Add(this.buttonDebCredMemoSearch);
            this.tabPage7.Controls.Add(this.reportViewerDebCredMemo);
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(994, 555);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Summary of Debit/Credit Memorandum";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLoadingDebCredMemo
            // 
            this.pictureBoxLoadingDebCredMemo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingDebCredMemo.Image")));
            this.pictureBoxLoadingDebCredMemo.Location = new System.Drawing.Point(26, 49);
            this.pictureBoxLoadingDebCredMemo.Name = "pictureBoxLoadingDebCredMemo";
            this.pictureBoxLoadingDebCredMemo.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingDebCredMemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingDebCredMemo.TabIndex = 70;
            this.pictureBoxLoadingDebCredMemo.TabStop = false;
            this.pictureBoxLoadingDebCredMemo.Visible = false;
            // 
            // dateTimePickerDebCredMemoFrom
            // 
            this.dateTimePickerDebCredMemoFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDebCredMemoFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebCredMemoFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDebCredMemoFrom.Location = new System.Drawing.Point(71, 16);
            this.dateTimePickerDebCredMemoFrom.Name = "dateTimePickerDebCredMemoFrom";
            this.dateTimePickerDebCredMemoFrom.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerDebCredMemoFrom.TabIndex = 43;
            // 
            // dateTimePickerDebCredMemoTo
            // 
            this.dateTimePickerDebCredMemoTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDebCredMemoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebCredMemoTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDebCredMemoTo.Location = new System.Drawing.Point(290, 16);
            this.dateTimePickerDebCredMemoTo.Name = "dateTimePickerDebCredMemoTo";
            this.dateTimePickerDebCredMemoTo.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerDebCredMemoTo.TabIndex = 43;
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
            // buttonDebCredMemoSearch
            // 
            this.buttonDebCredMemoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebCredMemoSearch.Location = new System.Drawing.Point(534, 8);
            this.buttonDebCredMemoSearch.Name = "buttonDebCredMemoSearch";
            this.buttonDebCredMemoSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonDebCredMemoSearch.TabIndex = 37;
            this.buttonDebCredMemoSearch.Text = "Search";
            this.buttonDebCredMemoSearch.UseVisualStyleBackColor = true;
            // 
            // reportViewerDebCredMemo
            // 
            reportDataSource3.Name = "DataSetReceivablesReports";
            reportDataSource3.Value = null;
            this.reportViewerDebCredMemo.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerDebCredMemo.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReceivablesReports.ReportOtherReceivables.rdlc";
            this.reportViewerDebCredMemo.Location = new System.Drawing.Point(26, 49);
            this.reportViewerDebCredMemo.Name = "reportViewerDebCredMemo";
            this.reportViewerDebCredMemo.ServerReport.BearerToken = null;
            this.reportViewerDebCredMemo.Size = new System.Drawing.Size(944, 481);
            this.reportViewerDebCredMemo.TabIndex = 7;
            // 
            // PromissoryNotesBindingSource
            // 
            this.PromissoryNotesBindingSource.DataMember = "PromissoryNotes";
            this.PromissoryNotesBindingSource.DataSource = this.DataSetARMaintenanceReports;
            // 
            // DataSetARMaintenanceReports
            // 
            this.DataSetARMaintenanceReports.DataSetName = "DataSetARMaintenanceReports";
            this.DataSetARMaintenanceReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OverduePNBindingSource
            // 
            this.OverduePNBindingSource.DataMember = "OverduePN";
            this.OverduePNBindingSource.DataSource = this.DataSetARMaintenanceReports;
            // 
            // ARMaintenanceReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 587);
            this.Controls.Add(this.tabControlARMaintenanceReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ARMaintenanceReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AR Maintenance Reports";
            this.Load += new System.EventHandler(this.ARMaintenanceReportsForm_Load);
            this.tabControlARMaintenanceReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingPromissoryNote)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingOverduePromiNote)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingDebCredMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromissoryNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetARMaintenanceReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverduePNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlARMaintenanceReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBoxLoadingPromissoryNote;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPromissoryNote;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOverduePromiNoteAsOf;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOverduePromiNote;
        private System.Windows.Forms.Button buttonOverduePromiNoteSearch;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox pictureBoxLoadingDebCredMemo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebCredMemoTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonDebCredMemoSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDebCredMemo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebCredMemoFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerPromissoryNoteFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerPromissoryNoteTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPromissoryNoteSearch;
        private System.Windows.Forms.PictureBox pictureBoxLoadingOverduePromiNote;
        private System.Windows.Forms.BindingSource PromissoryNotesBindingSource;
        private DataSetARMaintenanceReports DataSetARMaintenanceReports;
        private System.Windows.Forms.BindingSource OverduePNBindingSource;
    }
}