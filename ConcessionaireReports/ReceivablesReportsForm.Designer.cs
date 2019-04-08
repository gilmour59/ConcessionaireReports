namespace ConcessionaireReports
{
    partial class ReceivablesReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControlConcessionaireReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewerAccountPerBook = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAccountPerBookSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountPerBookMeterStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerBookBook = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerBookZone = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerAccountPerBarangay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAccountPerBarangaySearch = new System.Windows.Forms.Button();
            this.comboBoxAccountPerBarangayBarangay = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerBarangayTown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewerAccountPerClassification = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAccountPerClassificationSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountPerClassificationClassification = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerClassificationZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewerSummaryAccountsPerClass = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewerNewConnectionSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonNewConnectionSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerNewConnectionTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNewConnectionFrom = new System.Windows.Forms.DateTimePicker();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewerAccountByStatus = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAccountByStatusSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountByStatusZone = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerAccountByStatusAsOf = new System.Windows.Forms.DateTimePicker();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.reportViewerSeniorCitizenAccounts = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonSeniorCitizenSearch = new System.Windows.Forms.Button();
            this.comboBoxSeniorCitizenBook = new System.Windows.Forms.ComboBox();
            this.comboBoxSeniorCitizenZone = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControlConcessionaireReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConcessionaireReports
            // 
            this.tabControlConcessionaireReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage1);
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage2);
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage3);
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage4);
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage5);
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage6);
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage7);
            this.tabControlConcessionaireReports.ItemSize = new System.Drawing.Size(70, 150);
            this.tabControlConcessionaireReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlConcessionaireReports.Multiline = true;
            this.tabControlConcessionaireReports.Name = "tabControlConcessionaireReports";
            this.tabControlConcessionaireReports.SelectedIndex = 0;
            this.tabControlConcessionaireReports.Size = new System.Drawing.Size(1152, 563);
            this.tabControlConcessionaireReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlConcessionaireReports.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewerAccountPerBook);
            this.tabPage1.Controls.Add(this.buttonAccountPerBookSearch);
            this.tabPage1.Controls.Add(this.comboBoxAccountPerBookMeterStatus);
            this.tabPage1.Controls.Add(this.comboBoxAccountPerBookBook);
            this.tabPage1.Controls.Add(this.comboBoxAccountPerBookZone);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accounts Receivable Aging Per Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewerAccountPerBook
            // 
            reportDataSource1.Name = "DataSetConcessionaireReports";
            reportDataSource1.Value = null;
            this.reportViewerAccountPerBook.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAccountPerBook.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountPerBook.rdlc";
            this.reportViewerAccountPerBook.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAccountPerBook.Name = "reportViewerAccountPerBook";
            this.reportViewerAccountPerBook.ServerReport.BearerToken = null;
            this.reportViewerAccountPerBook.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAccountPerBook.TabIndex = 3;
            // 
            // buttonAccountPerBookSearch
            // 
            this.buttonAccountPerBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountPerBookSearch.Location = new System.Drawing.Point(543, 5);
            this.buttonAccountPerBookSearch.Name = "buttonAccountPerBookSearch";
            this.buttonAccountPerBookSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerBookSearch.TabIndex = 2;
            this.buttonAccountPerBookSearch.Text = "Search";
            this.buttonAccountPerBookSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountPerBookMeterStatus
            // 
            this.comboBoxAccountPerBookMeterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBookMeterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBookMeterStatus.FormattingEnabled = true;
            this.comboBoxAccountPerBookMeterStatus.Location = new System.Drawing.Point(407, 15);
            this.comboBoxAccountPerBookMeterStatus.Name = "comboBoxAccountPerBookMeterStatus";
            this.comboBoxAccountPerBookMeterStatus.Size = new System.Drawing.Size(96, 24);
            this.comboBoxAccountPerBookMeterStatus.TabIndex = 1;
            // 
            // comboBoxAccountPerBookBook
            // 
            this.comboBoxAccountPerBookBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBookBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBookBook.FormattingEnabled = true;
            this.comboBoxAccountPerBookBook.Location = new System.Drawing.Point(215, 15);
            this.comboBoxAccountPerBookBook.Name = "comboBoxAccountPerBookBook";
            this.comboBoxAccountPerBookBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxAccountPerBookBook.TabIndex = 1;
            // 
            // comboBoxAccountPerBookZone
            // 
            this.comboBoxAccountPerBookZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBookZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBookZone.FormattingEnabled = true;
            this.comboBoxAccountPerBookZone.Location = new System.Drawing.Point(69, 15);
            this.comboBoxAccountPerBookZone.Name = "comboBoxAccountPerBookZone";
            this.comboBoxAccountPerBookZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAccountPerBookZone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meter Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewerAccountPerBarangay);
            this.tabPage2.Controls.Add(this.buttonAccountPerBarangaySearch);
            this.tabPage2.Controls.Add(this.comboBoxAccountPerBarangayBarangay);
            this.tabPage2.Controls.Add(this.comboBoxAccountPerBarangayTown);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accounts Receivable Aging Summary Per Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerAccountPerBarangay
            // 
            reportDataSource2.Name = "DataSetConcessionaireReports";
            reportDataSource2.Value = null;
            this.reportViewerAccountPerBarangay.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerAccountPerBarangay.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountPerBarangay.rdlc";
            this.reportViewerAccountPerBarangay.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAccountPerBarangay.Name = "reportViewerAccountPerBarangay";
            this.reportViewerAccountPerBarangay.ServerReport.BearerToken = null;
            this.reportViewerAccountPerBarangay.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAccountPerBarangay.TabIndex = 10;
            // 
            // buttonAccountPerBarangaySearch
            // 
            this.buttonAccountPerBarangaySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountPerBarangaySearch.Location = new System.Drawing.Point(514, 5);
            this.buttonAccountPerBarangaySearch.Name = "buttonAccountPerBarangaySearch";
            this.buttonAccountPerBarangaySearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerBarangaySearch.TabIndex = 9;
            this.buttonAccountPerBarangaySearch.Text = "Search";
            this.buttonAccountPerBarangaySearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountPerBarangayBarangay
            // 
            this.comboBoxAccountPerBarangayBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBarangayBarangay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBarangayBarangay.FormattingEnabled = true;
            this.comboBoxAccountPerBarangayBarangay.Location = new System.Drawing.Point(330, 15);
            this.comboBoxAccountPerBarangayBarangay.Name = "comboBoxAccountPerBarangayBarangay";
            this.comboBoxAccountPerBarangayBarangay.Size = new System.Drawing.Size(125, 24);
            this.comboBoxAccountPerBarangayBarangay.TabIndex = 7;
            // 
            // comboBoxAccountPerBarangayTown
            // 
            this.comboBoxAccountPerBarangayTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBarangayTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBarangayTown.FormattingEnabled = true;
            this.comboBoxAccountPerBarangayTown.Location = new System.Drawing.Point(74, 15);
            this.comboBoxAccountPerBarangayTown.Name = "comboBoxAccountPerBarangayTown";
            this.comboBoxAccountPerBarangayTown.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAccountPerBarangayTown.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Barangay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Town:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewerAccountPerClassification);
            this.tabPage3.Controls.Add(this.buttonAccountPerClassificationSearch);
            this.tabPage3.Controls.Add(this.comboBoxAccountPerClassificationClassification);
            this.tabPage3.Controls.Add(this.comboBoxAccountPerClassificationZone);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(994, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detailed List of Receivables Per Account";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewerAccountPerClassification
            // 
            reportDataSource3.Name = "DataSetConcessionaireReports";
            reportDataSource3.Value = null;
            this.reportViewerAccountPerClassification.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerAccountPerClassification.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountPerClassification.r" +
    "dlc";
            this.reportViewerAccountPerClassification.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAccountPerClassification.Name = "reportViewerAccountPerClassification";
            this.reportViewerAccountPerClassification.ServerReport.BearerToken = null;
            this.reportViewerAccountPerClassification.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAccountPerClassification.TabIndex = 15;
            // 
            // buttonAccountPerClassificationSearch
            // 
            this.buttonAccountPerClassificationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountPerClassificationSearch.Location = new System.Drawing.Point(447, 5);
            this.buttonAccountPerClassificationSearch.Name = "buttonAccountPerClassificationSearch";
            this.buttonAccountPerClassificationSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerClassificationSearch.TabIndex = 14;
            this.buttonAccountPerClassificationSearch.Text = "Search";
            this.buttonAccountPerClassificationSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountPerClassificationClassification
            // 
            this.comboBoxAccountPerClassificationClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerClassificationClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerClassificationClassification.FormattingEnabled = true;
            this.comboBoxAccountPerClassificationClassification.Location = new System.Drawing.Point(263, 15);
            this.comboBoxAccountPerClassificationClassification.Name = "comboBoxAccountPerClassificationClassification";
            this.comboBoxAccountPerClassificationClassification.Size = new System.Drawing.Size(125, 24);
            this.comboBoxAccountPerClassificationClassification.TabIndex = 12;
            // 
            // comboBoxAccountPerClassificationZone
            // 
            this.comboBoxAccountPerClassificationZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerClassificationZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerClassificationZone.FormattingEnabled = true;
            this.comboBoxAccountPerClassificationZone.Location = new System.Drawing.Point(71, 15);
            this.comboBoxAccountPerClassificationZone.Name = "comboBoxAccountPerClassificationZone";
            this.comboBoxAccountPerClassificationZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAccountPerClassificationZone.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Classification:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zone:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewerSummaryAccountsPerClass);
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(994, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Summary of Receivables Per Account";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewerSummaryAccountsPerClass
            // 
            reportDataSource4.Name = "DataSetConcessionaireReports";
            reportDataSource4.Value = null;
            this.reportViewerSummaryAccountsPerClass.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerSummaryAccountsPerClass.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportSummaryAccountsPerClass.rd" +
    "lc";
            this.reportViewerSummaryAccountsPerClass.Location = new System.Drawing.Point(23, 24);
            this.reportViewerSummaryAccountsPerClass.Name = "reportViewerSummaryAccountsPerClass";
            this.reportViewerSummaryAccountsPerClass.ServerReport.BearerToken = null;
            this.reportViewerSummaryAccountsPerClass.Size = new System.Drawing.Size(952, 511);
            this.reportViewerSummaryAccountsPerClass.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewerNewConnectionSummary);
            this.tabPage5.Controls.Add(this.buttonNewConnectionSearch);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.dateTimePickerNewConnectionTo);
            this.tabPage5.Controls.Add(this.dateTimePickerNewConnectionFrom);
            this.tabPage5.Location = new System.Drawing.Point(154, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(994, 555);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Demand Letter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewerNewConnectionSummary
            // 
            reportDataSource5.Name = "DataSetConcessionaireReports";
            reportDataSource5.Value = null;
            this.reportViewerNewConnectionSummary.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerNewConnectionSummary.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportNewConnectionSummary.rdlc";
            this.reportViewerNewConnectionSummary.Location = new System.Drawing.Point(26, 49);
            this.reportViewerNewConnectionSummary.Name = "reportViewerNewConnectionSummary";
            this.reportViewerNewConnectionSummary.ServerReport.BearerToken = null;
            this.reportViewerNewConnectionSummary.Size = new System.Drawing.Size(944, 481);
            this.reportViewerNewConnectionSummary.TabIndex = 0;
            // 
            // buttonNewConnectionSearch
            // 
            this.buttonNewConnectionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewConnectionSearch.Location = new System.Drawing.Point(549, 5);
            this.buttonNewConnectionSearch.Name = "buttonNewConnectionSearch";
            this.buttonNewConnectionSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonNewConnectionSearch.TabIndex = 16;
            this.buttonNewConnectionSearch.Text = "Search";
            this.buttonNewConnectionSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "From:";
            // 
            // dateTimePickerNewConnectionTo
            // 
            this.dateTimePickerNewConnectionTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerNewConnectionTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewConnectionTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNewConnectionTo.Location = new System.Drawing.Point(309, 13);
            this.dateTimePickerNewConnectionTo.Name = "dateTimePickerNewConnectionTo";
            this.dateTimePickerNewConnectionTo.Size = new System.Drawing.Size(125, 24);
            this.dateTimePickerNewConnectionTo.TabIndex = 0;
            // 
            // dateTimePickerNewConnectionFrom
            // 
            this.dateTimePickerNewConnectionFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerNewConnectionFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewConnectionFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNewConnectionFrom.Location = new System.Drawing.Point(71, 13);
            this.dateTimePickerNewConnectionFrom.Name = "dateTimePickerNewConnectionFrom";
            this.dateTimePickerNewConnectionFrom.Size = new System.Drawing.Size(118, 24);
            this.dateTimePickerNewConnectionFrom.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewerAccountByStatus);
            this.tabPage6.Controls.Add(this.buttonAccountByStatusSearch);
            this.tabPage6.Controls.Add(this.comboBoxAccountByStatusZone);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.dateTimePickerAccountByStatusAsOf);
            this.tabPage6.Location = new System.Drawing.Point(154, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(994, 555);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Top Delinquent Accounts";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewerAccountByStatus
            // 
            reportDataSource6.Name = "DataSetConcessionaireReports";
            reportDataSource6.Value = null;
            this.reportViewerAccountByStatus.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerAccountByStatus.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountByStatus.rdlc";
            this.reportViewerAccountByStatus.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAccountByStatus.Name = "reportViewerAccountByStatus";
            this.reportViewerAccountByStatus.ServerReport.BearerToken = null;
            this.reportViewerAccountByStatus.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAccountByStatus.TabIndex = 17;
            // 
            // buttonAccountByStatusSearch
            // 
            this.buttonAccountByStatusSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountByStatusSearch.Location = new System.Drawing.Point(455, 5);
            this.buttonAccountByStatusSearch.Name = "buttonAccountByStatusSearch";
            this.buttonAccountByStatusSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountByStatusSearch.TabIndex = 16;
            this.buttonAccountByStatusSearch.Text = "Search";
            this.buttonAccountByStatusSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountByStatusZone
            // 
            this.comboBoxAccountByStatusZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountByStatusZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountByStatusZone.FormattingEnabled = true;
            this.comboBoxAccountByStatusZone.Location = new System.Drawing.Point(71, 13);
            this.comboBoxAccountByStatusZone.Name = "comboBoxAccountByStatusZone";
            this.comboBoxAccountByStatusZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAccountByStatusZone.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Zone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "As of:";
            // 
            // dateTimePickerAccountByStatusAsOf
            // 
            this.dateTimePickerAccountByStatusAsOf.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerAccountByStatusAsOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAccountByStatusAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAccountByStatusAsOf.Location = new System.Drawing.Point(234, 13);
            this.dateTimePickerAccountByStatusAsOf.Name = "dateTimePickerAccountByStatusAsOf";
            this.dateTimePickerAccountByStatusAsOf.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerAccountByStatusAsOf.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.reportViewerSeniorCitizenAccounts);
            this.tabPage7.Controls.Add(this.buttonSeniorCitizenSearch);
            this.tabPage7.Controls.Add(this.comboBoxSeniorCitizenBook);
            this.tabPage7.Controls.Add(this.comboBoxSeniorCitizenZone);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(994, 555);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Summary of Other Receivables";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // reportViewerSeniorCitizenAccounts
            // 
            reportDataSource7.Name = "DataSetConcessionaireReports";
            reportDataSource7.Value = null;
            this.reportViewerSeniorCitizenAccounts.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewerSeniorCitizenAccounts.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportSeniorCitizenAccounts.rdlc" +
    "";
            this.reportViewerSeniorCitizenAccounts.Location = new System.Drawing.Point(26, 49);
            this.reportViewerSeniorCitizenAccounts.Name = "reportViewerSeniorCitizenAccounts";
            this.reportViewerSeniorCitizenAccounts.ServerReport.BearerToken = null;
            this.reportViewerSeniorCitizenAccounts.Size = new System.Drawing.Size(944, 481);
            this.reportViewerSeniorCitizenAccounts.TabIndex = 7;
            // 
            // buttonSeniorCitizenSearch
            // 
            this.buttonSeniorCitizenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeniorCitizenSearch.Location = new System.Drawing.Point(338, 5);
            this.buttonSeniorCitizenSearch.Name = "buttonSeniorCitizenSearch";
            this.buttonSeniorCitizenSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonSeniorCitizenSearch.TabIndex = 6;
            this.buttonSeniorCitizenSearch.Text = "Search";
            this.buttonSeniorCitizenSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxSeniorCitizenBook
            // 
            this.comboBoxSeniorCitizenBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeniorCitizenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeniorCitizenBook.FormattingEnabled = true;
            this.comboBoxSeniorCitizenBook.Location = new System.Drawing.Point(215, 13);
            this.comboBoxSeniorCitizenBook.Name = "comboBoxSeniorCitizenBook";
            this.comboBoxSeniorCitizenBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxSeniorCitizenBook.TabIndex = 4;
            // 
            // comboBoxSeniorCitizenZone
            // 
            this.comboBoxSeniorCitizenZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeniorCitizenZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeniorCitizenZone.FormattingEnabled = true;
            this.comboBoxSeniorCitizenZone.Location = new System.Drawing.Point(69, 13);
            this.comboBoxSeniorCitizenZone.Name = "comboBoxSeniorCitizenZone";
            this.comboBoxSeniorCitizenZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxSeniorCitizenZone.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(169, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Book:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Zone:";
            // 
            // ReceivablesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 587);
            this.Controls.Add(this.tabControlConcessionaireReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceivablesReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receivables Reports";
            this.tabControlConcessionaireReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConcessionaireReports;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountPerBook;
        private System.Windows.Forms.Button buttonAccountPerBookSearch;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBookMeterStatus;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBookBook;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBookZone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountPerBarangay;
        private System.Windows.Forms.Button buttonAccountPerBarangaySearch;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBarangayBarangay;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBarangayTown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountPerClassification;
        private System.Windows.Forms.Button buttonAccountPerClassificationSearch;
        private System.Windows.Forms.ComboBox comboBoxAccountPerClassificationClassification;
        private System.Windows.Forms.ComboBox comboBoxAccountPerClassificationZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSummaryAccountsPerClass;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNewConnectionSummary;
        private System.Windows.Forms.Button buttonNewConnectionSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewConnectionTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewConnectionFrom;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountByStatus;
        private System.Windows.Forms.Button buttonAccountByStatusSearch;
        private System.Windows.Forms.ComboBox comboBoxAccountByStatusZone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccountByStatusAsOf;
        private System.Windows.Forms.TabPage tabPage7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSeniorCitizenAccounts;
        private System.Windows.Forms.Button buttonSeniorCitizenSearch;
        private System.Windows.Forms.ComboBox comboBoxSeniorCitizenBook;
        private System.Windows.Forms.ComboBox comboBoxSeniorCitizenZone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}