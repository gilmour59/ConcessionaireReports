namespace ConcessionaireReports
{
    partial class ConcessionaireReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AccountPerBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountPerBookReport = new ConcessionaireReports.AccountPerBookReport();
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
            this.buttonAccountPerBarangaySearch = new System.Windows.Forms.Button();
            this.comboBoxAccountPerBarangayBarangay = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerBarangayTown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAccountPerClassificationSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountPerClassificationClassification = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerClassificationZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonSummaryAccountsClassificationSearch = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonNewConnectionSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerNewConnectionTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNewConnectionFrom = new System.Windows.Forms.DateTimePicker();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonAccountByStatusSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountByStatusZone = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerAccountByStatusAsOf = new System.Windows.Forms.DateTimePicker();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonSeniorCitizenSearch = new System.Windows.Forms.Button();
            this.comboBoxSeniorCitizenBook = new System.Windows.Forms.ComboBox();
            this.comboBoxSeniorCitizenZone = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.comboBoxAccountPerMeterSizeMeterStatus = new System.Windows.Forms.ComboBox();
            this.buttonAccountPerMeterSizeSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountPerMeterSizeMeterSize = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerMeterSizeZone = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.reportViewerAccountPerBarangay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AccountPerBarangayReport = new ConcessionaireReports.AccountPerBarangayReport();
            this.AccountPerBarangayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBookReport)).BeginInit();
            this.tabControlConcessionaireReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBarangayReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBarangayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountPerBookBindingSource
            // 
            this.AccountPerBookBindingSource.DataMember = "AccountPerBook";
            this.AccountPerBookBindingSource.DataSource = this.AccountPerBookReport;
            // 
            // AccountPerBookReport
            // 
            this.AccountPerBookReport.DataSetName = "AccountPerBookReport";
            this.AccountPerBookReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage8);
            this.tabControlConcessionaireReports.ItemSize = new System.Drawing.Size(55, 150);
            this.tabControlConcessionaireReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlConcessionaireReports.Multiline = true;
            this.tabControlConcessionaireReports.Name = "tabControlConcessionaireReports";
            this.tabControlConcessionaireReports.SelectedIndex = 0;
            this.tabControlConcessionaireReports.Size = new System.Drawing.Size(982, 489);
            this.tabControlConcessionaireReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlConcessionaireReports.TabIndex = 0;
            this.tabControlConcessionaireReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlConcessionaireReports_DrawItem);
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
            this.tabPage1.Size = new System.Drawing.Size(824, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account List Per Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewerAccountPerBook
            // 
            reportDataSource1.Name = "AccountPerBookReport";
            reportDataSource1.Value = this.AccountPerBookBindingSource;
            this.reportViewerAccountPerBook.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAccountPerBook.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.AccountPerBookRDLC.rdlc";
            this.reportViewerAccountPerBook.Location = new System.Drawing.Point(20, 60);
            this.reportViewerAccountPerBook.Name = "reportViewerAccountPerBook";
            this.reportViewerAccountPerBook.ServerReport.BearerToken = null;
            this.reportViewerAccountPerBook.Size = new System.Drawing.Size(782, 402);
            this.reportViewerAccountPerBook.TabIndex = 3;
            // 
            // buttonAccountPerBookSearch
            // 
            this.buttonAccountPerBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountPerBookSearch.Location = new System.Drawing.Point(624, 10);
            this.buttonAccountPerBookSearch.Name = "buttonAccountPerBookSearch";
            this.buttonAccountPerBookSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerBookSearch.TabIndex = 2;
            this.buttonAccountPerBookSearch.Text = "Search";
            this.buttonAccountPerBookSearch.UseVisualStyleBackColor = true;
            this.buttonAccountPerBookSearch.Click += new System.EventHandler(this.buttonAccountPerBookSearch_Click);
            // 
            // comboBoxAccountPerBookMeterStatus
            // 
            this.comboBoxAccountPerBookMeterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBookMeterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBookMeterStatus.FormattingEnabled = true;
            this.comboBoxAccountPerBookMeterStatus.Location = new System.Drawing.Point(488, 20);
            this.comboBoxAccountPerBookMeterStatus.Name = "comboBoxAccountPerBookMeterStatus";
            this.comboBoxAccountPerBookMeterStatus.Size = new System.Drawing.Size(96, 24);
            this.comboBoxAccountPerBookMeterStatus.TabIndex = 1;
            // 
            // comboBoxAccountPerBookBook
            // 
            this.comboBoxAccountPerBookBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBookBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBookBook.FormattingEnabled = true;
            this.comboBoxAccountPerBookBook.Location = new System.Drawing.Point(296, 20);
            this.comboBoxAccountPerBookBook.Name = "comboBoxAccountPerBookBook";
            this.comboBoxAccountPerBookBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxAccountPerBookBook.TabIndex = 1;
            // 
            // comboBoxAccountPerBookZone
            // 
            this.comboBoxAccountPerBookZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBookZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBookZone.FormattingEnabled = true;
            this.comboBoxAccountPerBookZone.Location = new System.Drawing.Point(150, 20);
            this.comboBoxAccountPerBookZone.Name = "comboBoxAccountPerBookZone";
            this.comboBoxAccountPerBookZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAccountPerBookZone.TabIndex = 1;
            this.comboBoxAccountPerBookZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccountPerBookZone_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meter Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 23);
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
            this.tabPage2.Size = new System.Drawing.Size(824, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account List Per Barangay";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAccountPerBarangaySearch
            // 
            this.buttonAccountPerBarangaySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountPerBarangaySearch.Location = new System.Drawing.Point(608, 10);
            this.buttonAccountPerBarangaySearch.Name = "buttonAccountPerBarangaySearch";
            this.buttonAccountPerBarangaySearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerBarangaySearch.TabIndex = 9;
            this.buttonAccountPerBarangaySearch.Text = "Search";
            this.buttonAccountPerBarangaySearch.UseVisualStyleBackColor = true;
            this.buttonAccountPerBarangaySearch.Click += new System.EventHandler(this.buttonAccountPerBarangaySearch_Click);
            // 
            // comboBoxAccountPerBarangayBarangay
            // 
            this.comboBoxAccountPerBarangayBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBarangayBarangay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBarangayBarangay.FormattingEnabled = true;
            this.comboBoxAccountPerBarangayBarangay.Location = new System.Drawing.Point(424, 20);
            this.comboBoxAccountPerBarangayBarangay.Name = "comboBoxAccountPerBarangayBarangay";
            this.comboBoxAccountPerBarangayBarangay.Size = new System.Drawing.Size(125, 24);
            this.comboBoxAccountPerBarangayBarangay.TabIndex = 7;
            // 
            // comboBoxAccountPerBarangayTown
            // 
            this.comboBoxAccountPerBarangayTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountPerBarangayTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerBarangayTown.FormattingEnabled = true;
            this.comboBoxAccountPerBarangayTown.Location = new System.Drawing.Point(168, 20);
            this.comboBoxAccountPerBarangayTown.Name = "comboBoxAccountPerBarangayTown";
            this.comboBoxAccountPerBarangayTown.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAccountPerBarangayTown.TabIndex = 8;
            this.comboBoxAccountPerBarangayTown.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccountPerBarangayTown_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Barangay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Town:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAccountPerClassificationSearch);
            this.tabPage3.Controls.Add(this.comboBoxAccountPerClassificationClassification);
            this.tabPage3.Controls.Add(this.comboBoxAccountPerClassificationZone);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(824, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Account List Per Classification";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAccountPerClassificationSearch
            // 
            this.buttonAccountPerClassificationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountPerClassificationSearch.Location = new System.Drawing.Point(568, 16);
            this.buttonAccountPerClassificationSearch.Name = "buttonAccountPerClassificationSearch";
            this.buttonAccountPerClassificationSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerClassificationSearch.TabIndex = 14;
            this.buttonAccountPerClassificationSearch.Text = "Search";
            this.buttonAccountPerClassificationSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountPerClassificationClassification
            // 
            this.comboBoxAccountPerClassificationClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerClassificationClassification.FormattingEnabled = true;
            this.comboBoxAccountPerClassificationClassification.Location = new System.Drawing.Point(384, 26);
            this.comboBoxAccountPerClassificationClassification.Name = "comboBoxAccountPerClassificationClassification";
            this.comboBoxAccountPerClassificationClassification.Size = new System.Drawing.Size(125, 24);
            this.comboBoxAccountPerClassificationClassification.TabIndex = 12;
            // 
            // comboBoxAccountPerClassificationZone
            // 
            this.comboBoxAccountPerClassificationZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerClassificationZone.FormattingEnabled = true;
            this.comboBoxAccountPerClassificationZone.Location = new System.Drawing.Point(192, 26);
            this.comboBoxAccountPerClassificationZone.Name = "comboBoxAccountPerClassificationZone";
            this.comboBoxAccountPerClassificationZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAccountPerClassificationZone.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Classification:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zone:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonSummaryAccountsClassificationSearch);
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(824, 481);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Summary of Accounts Per Classification";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonSummaryAccountsClassificationSearch
            // 
            this.buttonSummaryAccountsClassificationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummaryAccountsClassificationSearch.Location = new System.Drawing.Point(400, 24);
            this.buttonSummaryAccountsClassificationSearch.Name = "buttonSummaryAccountsClassificationSearch";
            this.buttonSummaryAccountsClassificationSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonSummaryAccountsClassificationSearch.TabIndex = 15;
            this.buttonSummaryAccountsClassificationSearch.Text = "Search";
            this.buttonSummaryAccountsClassificationSearch.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonNewConnectionSearch);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.dateTimePickerNewConnectionTo);
            this.tabPage5.Controls.Add(this.dateTimePickerNewConnectionFrom);
            this.tabPage5.Location = new System.Drawing.Point(154, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(824, 481);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "New Connection Summary";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonNewConnectionSearch
            // 
            this.buttonNewConnectionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewConnectionSearch.Location = new System.Drawing.Point(648, 24);
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
            this.label9.Location = new System.Drawing.Point(376, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "From:";
            // 
            // dateTimePickerNewConnectionTo
            // 
            this.dateTimePickerNewConnectionTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewConnectionTo.Location = new System.Drawing.Point(408, 32);
            this.dateTimePickerNewConnectionTo.Name = "dateTimePickerNewConnectionTo";
            this.dateTimePickerNewConnectionTo.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerNewConnectionTo.TabIndex = 0;
            // 
            // dateTimePickerNewConnectionFrom
            // 
            this.dateTimePickerNewConnectionFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewConnectionFrom.Location = new System.Drawing.Point(136, 32);
            this.dateTimePickerNewConnectionFrom.Name = "dateTimePickerNewConnectionFrom";
            this.dateTimePickerNewConnectionFrom.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerNewConnectionFrom.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonAccountByStatusSearch);
            this.tabPage6.Controls.Add(this.comboBoxAccountByStatusZone);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.dateTimePickerAccountByStatusAsOf);
            this.tabPage6.Location = new System.Drawing.Point(154, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(824, 481);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Account List By Status";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonAccountByStatusSearch
            // 
            this.buttonAccountByStatusSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountByStatusSearch.Location = new System.Drawing.Point(584, 16);
            this.buttonAccountByStatusSearch.Name = "buttonAccountByStatusSearch";
            this.buttonAccountByStatusSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountByStatusSearch.TabIndex = 16;
            this.buttonAccountByStatusSearch.Text = "Search";
            this.buttonAccountByStatusSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountByStatusZone
            // 
            this.comboBoxAccountByStatusZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountByStatusZone.FormattingEnabled = true;
            this.comboBoxAccountByStatusZone.Location = new System.Drawing.Point(200, 24);
            this.comboBoxAccountByStatusZone.Name = "comboBoxAccountByStatusZone";
            this.comboBoxAccountByStatusZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAccountByStatusZone.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(152, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Zone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "As of:";
            // 
            // dateTimePickerAccountByStatusAsOf
            // 
            this.dateTimePickerAccountByStatusAsOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAccountByStatusAsOf.Location = new System.Drawing.Point(336, 24);
            this.dateTimePickerAccountByStatusAsOf.Name = "dateTimePickerAccountByStatusAsOf";
            this.dateTimePickerAccountByStatusAsOf.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerAccountByStatusAsOf.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonSeniorCitizenSearch);
            this.tabPage7.Controls.Add(this.comboBoxSeniorCitizenBook);
            this.tabPage7.Controls.Add(this.comboBoxSeniorCitizenZone);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(824, 481);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Senior Citizen Accounts";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonSeniorCitizenSearch
            // 
            this.buttonSeniorCitizenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeniorCitizenSearch.Location = new System.Drawing.Point(528, 16);
            this.buttonSeniorCitizenSearch.Name = "buttonSeniorCitizenSearch";
            this.buttonSeniorCitizenSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonSeniorCitizenSearch.TabIndex = 6;
            this.buttonSeniorCitizenSearch.Text = "Search";
            this.buttonSeniorCitizenSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxSeniorCitizenBook
            // 
            this.comboBoxSeniorCitizenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeniorCitizenBook.FormattingEnabled = true;
            this.comboBoxSeniorCitizenBook.Location = new System.Drawing.Point(408, 21);
            this.comboBoxSeniorCitizenBook.Name = "comboBoxSeniorCitizenBook";
            this.comboBoxSeniorCitizenBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxSeniorCitizenBook.TabIndex = 4;
            // 
            // comboBoxSeniorCitizenZone
            // 
            this.comboBoxSeniorCitizenZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeniorCitizenZone.FormattingEnabled = true;
            this.comboBoxSeniorCitizenZone.Location = new System.Drawing.Point(262, 21);
            this.comboBoxSeniorCitizenZone.Name = "comboBoxSeniorCitizenZone";
            this.comboBoxSeniorCitizenZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxSeniorCitizenZone.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(362, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Book:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(216, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Zone:";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.comboBoxAccountPerMeterSizeMeterStatus);
            this.tabPage8.Controls.Add(this.buttonAccountPerMeterSizeSearch);
            this.tabPage8.Controls.Add(this.comboBoxAccountPerMeterSizeMeterSize);
            this.tabPage8.Controls.Add(this.comboBoxAccountPerMeterSizeZone);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Location = new System.Drawing.Point(154, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(824, 481);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Account List Per Meter Size";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountPerMeterSizeMeterStatus
            // 
            this.comboBoxAccountPerMeterSizeMeterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerMeterSizeMeterStatus.FormattingEnabled = true;
            this.comboBoxAccountPerMeterSizeMeterStatus.Location = new System.Drawing.Point(496, 24);
            this.comboBoxAccountPerMeterSizeMeterStatus.Name = "comboBoxAccountPerMeterSizeMeterStatus";
            this.comboBoxAccountPerMeterSizeMeterStatus.Size = new System.Drawing.Size(96, 24);
            this.comboBoxAccountPerMeterSizeMeterStatus.TabIndex = 10;
            // 
            // buttonAccountPerMeterSizeSearch
            // 
            this.buttonAccountPerMeterSizeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountPerMeterSizeSearch.Location = new System.Drawing.Point(632, 16);
            this.buttonAccountPerMeterSizeSearch.Name = "buttonAccountPerMeterSizeSearch";
            this.buttonAccountPerMeterSizeSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerMeterSizeSearch.TabIndex = 9;
            this.buttonAccountPerMeterSizeSearch.Text = "Search";
            this.buttonAccountPerMeterSizeSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountPerMeterSizeMeterSize
            // 
            this.comboBoxAccountPerMeterSizeMeterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerMeterSizeMeterSize.FormattingEnabled = true;
            this.comboBoxAccountPerMeterSizeMeterSize.Location = new System.Drawing.Point(312, 26);
            this.comboBoxAccountPerMeterSizeMeterSize.Name = "comboBoxAccountPerMeterSizeMeterSize";
            this.comboBoxAccountPerMeterSizeMeterSize.Size = new System.Drawing.Size(64, 24);
            this.comboBoxAccountPerMeterSizeMeterSize.TabIndex = 7;
            // 
            // comboBoxAccountPerMeterSizeZone
            // 
            this.comboBoxAccountPerMeterSizeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountPerMeterSizeZone.FormattingEnabled = true;
            this.comboBoxAccountPerMeterSizeZone.Location = new System.Drawing.Point(152, 26);
            this.comboBoxAccountPerMeterSizeZone.Name = "comboBoxAccountPerMeterSizeZone";
            this.comboBoxAccountPerMeterSizeZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAccountPerMeterSizeZone.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(408, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Meter Status:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(234, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Meter Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(106, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Zone:";
            // 
            // reportViewerAccountPerBarangay
            // 
            reportDataSource2.Name = "AccountPerBarangayReport";
            reportDataSource2.Value = this.AccountPerBarangayBindingSource;
            this.reportViewerAccountPerBarangay.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerAccountPerBarangay.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.AccountPerBarangayRDLC.rdlc";
            this.reportViewerAccountPerBarangay.Location = new System.Drawing.Point(21, 63);
            this.reportViewerAccountPerBarangay.Name = "reportViewerAccountPerBarangay";
            this.reportViewerAccountPerBarangay.ServerReport.BearerToken = null;
            this.reportViewerAccountPerBarangay.Size = new System.Drawing.Size(783, 399);
            this.reportViewerAccountPerBarangay.TabIndex = 10;
            // 
            // AccountPerBarangayReport
            // 
            this.AccountPerBarangayReport.DataSetName = "AccountPerBarangayReport";
            this.AccountPerBarangayReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccountPerBarangayBindingSource
            // 
            this.AccountPerBarangayBindingSource.DataMember = "AccountPerBarangay";
            this.AccountPerBarangayBindingSource.DataSource = this.AccountPerBarangayReport;
            // 
            // ConcessionaireReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 513);
            this.Controls.Add(this.tabControlConcessionaireReports);
            this.MaximizeBox = false;
            this.Name = "ConcessionaireReportsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConcessionaireReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBookReport)).EndInit();
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
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBarangayReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPerBarangayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConcessionaireReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button buttonAccountPerBookSearch;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBookMeterStatus;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBookBook;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBookZone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccountPerBarangaySearch;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBarangayBarangay;
        private System.Windows.Forms.ComboBox comboBoxAccountPerBarangayTown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAccountPerClassificationSearch;
        private System.Windows.Forms.ComboBox comboBoxAccountPerClassificationClassification;
        private System.Windows.Forms.ComboBox comboBoxAccountPerClassificationZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSummaryAccountsClassificationSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewConnectionTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewConnectionFrom;
        private System.Windows.Forms.Button buttonNewConnectionSearch;
        private System.Windows.Forms.Button buttonAccountByStatusSearch;
        private System.Windows.Forms.ComboBox comboBoxAccountByStatusZone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccountByStatusAsOf;
        private System.Windows.Forms.Button buttonSeniorCitizenSearch;
        private System.Windows.Forms.ComboBox comboBoxSeniorCitizenBook;
        private System.Windows.Forms.ComboBox comboBoxSeniorCitizenZone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxAccountPerMeterSizeMeterStatus;
        private System.Windows.Forms.Button buttonAccountPerMeterSizeSearch;
        private System.Windows.Forms.ComboBox comboBoxAccountPerMeterSizeMeterSize;
        private System.Windows.Forms.ComboBox comboBoxAccountPerMeterSizeZone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource AccountPerBookBindingSource;
        private AccountPerBookReport AccountPerBookReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountPerBook;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountPerBarangay;
        private System.Windows.Forms.BindingSource AccountPerBarangayBindingSource;
        private AccountPerBarangayReport AccountPerBarangayReport;
    }
}

