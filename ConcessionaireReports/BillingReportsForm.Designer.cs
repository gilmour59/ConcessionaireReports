namespace ConcessionaireReports
{
    partial class BillingReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BillComputationRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBillingReports = new ConcessionaireReports.DataSetBillingReports();
            this.BillingSummaryPerBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillingSummaryPerMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PenaltyBillingReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlBillingReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxBillComputationRegBook = new System.Windows.Forms.ComboBox();
            this.comboBoxBillComputationRegZone = new System.Windows.Forms.ComboBox();
            this.comboBoxBillComputationRegBillingMonth = new System.Windows.Forms.ComboBox();
            this.reportViewerBillComputationReg = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonBillComputationRegSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerBillSummaryBook = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxBillSummaryBookBook = new System.Windows.Forms.ComboBox();
            this.comboBoxBillSummaryBookZone = new System.Windows.Forms.ComboBox();
            this.comboBoxBillSummaryBookBillingMonth = new System.Windows.Forms.ComboBox();
            this.buttonBillSummaryBookSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonBillSummaryMonthSearch = new System.Windows.Forms.Button();
            this.comboBoxBillSummaryMonthBillingMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewerBillSummaryMonth = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonBillPreviousMonthSearch = new System.Windows.Forms.Button();
            this.comboBoxBillPreviousMonthBillingMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reportViewerBillPreviousMonth = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBoxPenaltyBillingReportBook = new System.Windows.Forms.ComboBox();
            this.reportViewerPenaltyBillingReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxPenaltyBillingReportZone = new System.Windows.Forms.ComboBox();
            this.buttonPenaltyBillingReportSearch = new System.Windows.Forms.Button();
            this.comboBoxPenaltyBillingReportBillingMonth = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonPenaltySummaryMonthSearch = new System.Windows.Forms.Button();
            this.comboBoxPenaltySummaryMonthBillingMonth = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reportViewerPenaltySummaryMonth = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonBillingSummaryMaterialsSearch = new System.Windows.Forms.Button();
            this.comboBoxBillingSummaryMaterialsBillingMonth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.reportViewerBillingSummaryMaterials = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.reportViewerBillingAdjustmentSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonBillingAdjustmentSummarySearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerBillingAdjustmentSummaryYear = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBillingAdjustmentSummaryMonth = new System.Windows.Forms.DateTimePicker();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.buttonDailyBillingSummarySearch = new System.Windows.Forms.Button();
            this.comboBoxDailyBillingSummaryBillingMonth = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.reportViewerDailyBillingSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BillingSummaryMaterialsFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BillComputationRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBillingReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingSummaryPerBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingSummaryPerMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenaltyBillingReportBindingSource)).BeginInit();
            this.tabControlBillingReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillingSummaryMaterialsFeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BillComputationRegisterBindingSource
            // 
            this.BillComputationRegisterBindingSource.DataMember = "BillComputationRegister";
            this.BillComputationRegisterBindingSource.DataSource = this.DataSetBillingReports;
            // 
            // DataSetBillingReports
            // 
            this.DataSetBillingReports.DataSetName = "DataSetBillingReports";
            this.DataSetBillingReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillingSummaryPerBookBindingSource
            // 
            this.BillingSummaryPerBookBindingSource.DataMember = "BillingSummaryPerBook";
            this.BillingSummaryPerBookBindingSource.DataSource = this.DataSetBillingReports;
            // 
            // BillingSummaryPerMonthBindingSource
            // 
            this.BillingSummaryPerMonthBindingSource.DataMember = "BillingSummaryPerMonth";
            this.BillingSummaryPerMonthBindingSource.DataSource = this.DataSetBillingReports;
            // 
            // PenaltyBillingReportBindingSource
            // 
            this.PenaltyBillingReportBindingSource.DataMember = "PenaltyBillingReport";
            this.PenaltyBillingReportBindingSource.DataSource = this.DataSetBillingReports;
            // 
            // tabControlBillingReports
            // 
            this.tabControlBillingReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlBillingReports.Controls.Add(this.tabPage1);
            this.tabControlBillingReports.Controls.Add(this.tabPage2);
            this.tabControlBillingReports.Controls.Add(this.tabPage3);
            this.tabControlBillingReports.Controls.Add(this.tabPage4);
            this.tabControlBillingReports.Controls.Add(this.tabPage5);
            this.tabControlBillingReports.Controls.Add(this.tabPage6);
            this.tabControlBillingReports.Controls.Add(this.tabPage7);
            this.tabControlBillingReports.Controls.Add(this.tabPage8);
            this.tabControlBillingReports.Controls.Add(this.tabPage9);
            this.tabControlBillingReports.Controls.Add(this.tabPage10);
            this.tabControlBillingReports.ItemSize = new System.Drawing.Size(55, 185);
            this.tabControlBillingReports.Location = new System.Drawing.Point(16, 12);
            this.tabControlBillingReports.Multiline = true;
            this.tabControlBillingReports.Name = "tabControlBillingReports";
            this.tabControlBillingReports.SelectedIndex = 0;
            this.tabControlBillingReports.Size = new System.Drawing.Size(1180, 563);
            this.tabControlBillingReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlBillingReports.TabIndex = 3;
            this.tabControlBillingReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlConcessionaireReports_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxBillComputationRegBook);
            this.tabPage1.Controls.Add(this.comboBoxBillComputationRegZone);
            this.tabPage1.Controls.Add(this.comboBoxBillComputationRegBillingMonth);
            this.tabPage1.Controls.Add(this.reportViewerBillComputationReg);
            this.tabPage1.Controls.Add(this.buttonBillComputationRegSearch);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(189, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bill Computation Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxBillComputationRegBook
            // 
            this.comboBoxBillComputationRegBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillComputationRegBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillComputationRegBook.FormattingEnabled = true;
            this.comboBoxBillComputationRegBook.Location = new System.Drawing.Point(539, 13);
            this.comboBoxBillComputationRegBook.Name = "comboBoxBillComputationRegBook";
            this.comboBoxBillComputationRegBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxBillComputationRegBook.TabIndex = 37;
            // 
            // comboBoxBillComputationRegZone
            // 
            this.comboBoxBillComputationRegZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillComputationRegZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillComputationRegZone.FormattingEnabled = true;
            this.comboBoxBillComputationRegZone.Location = new System.Drawing.Point(377, 13);
            this.comboBoxBillComputationRegZone.Name = "comboBoxBillComputationRegZone";
            this.comboBoxBillComputationRegZone.Size = new System.Drawing.Size(56, 24);
            this.comboBoxBillComputationRegZone.TabIndex = 36;
            this.comboBoxBillComputationRegZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillComputationRegZone_SelectedIndexChanged);
            // 
            // comboBoxBillComputationRegBillingMonth
            // 
            this.comboBoxBillComputationRegBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillComputationRegBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillComputationRegBillingMonth.FormattingEnabled = true;
            this.comboBoxBillComputationRegBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxBillComputationRegBillingMonth.Name = "comboBoxBillComputationRegBillingMonth";
            this.comboBoxBillComputationRegBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxBillComputationRegBillingMonth.TabIndex = 35;
            // 
            // reportViewerBillComputationReg
            // 
            reportDataSource1.Name = "DataSetBillingReports";
            reportDataSource1.Value = this.BillComputationRegisterBindingSource;
            this.reportViewerBillComputationReg.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBillComputationReg.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportBillComputationRegister.rdlc";
            this.reportViewerBillComputationReg.Location = new System.Drawing.Point(26, 49);
            this.reportViewerBillComputationReg.Name = "reportViewerBillComputationReg";
            this.reportViewerBillComputationReg.ServerReport.BearerToken = null;
            this.reportViewerBillComputationReg.Size = new System.Drawing.Size(944, 481);
            this.reportViewerBillComputationReg.TabIndex = 34;
            // 
            // buttonBillComputationRegSearch
            // 
            this.buttonBillComputationRegSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillComputationRegSearch.Location = new System.Drawing.Point(673, 5);
            this.buttonBillComputationRegSearch.Name = "buttonBillComputationRegSearch";
            this.buttonBillComputationRegSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonBillComputationRegSearch.TabIndex = 21;
            this.buttonBillComputationRegSearch.Text = "Search";
            this.buttonBillComputationRegSearch.UseVisualStyleBackColor = true;
            this.buttonBillComputationRegSearch.Click += new System.EventHandler(this.buttonBillComputationRegSearch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(490, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Zone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Billing Month:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewerBillSummaryBook);
            this.tabPage2.Controls.Add(this.comboBoxBillSummaryBookBook);
            this.tabPage2.Controls.Add(this.comboBoxBillSummaryBookZone);
            this.tabPage2.Controls.Add(this.comboBoxBillSummaryBookBillingMonth);
            this.tabPage2.Controls.Add(this.buttonBillSummaryBookSearch);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(189, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(987, 555);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Billing Summary Per Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerBillSummaryBook
            // 
            reportDataSource2.Name = "DataSetBillingReports";
            reportDataSource2.Value = this.BillingSummaryPerBookBindingSource;
            this.reportViewerBillSummaryBook.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerBillSummaryBook.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportBillingSummaryBook.rdlc";
            this.reportViewerBillSummaryBook.Location = new System.Drawing.Point(26, 49);
            this.reportViewerBillSummaryBook.Name = "reportViewerBillSummaryBook";
            this.reportViewerBillSummaryBook.ServerReport.BearerToken = null;
            this.reportViewerBillSummaryBook.Size = new System.Drawing.Size(944, 481);
            this.reportViewerBillSummaryBook.TabIndex = 46;
            // 
            // comboBoxBillSummaryBookBook
            // 
            this.comboBoxBillSummaryBookBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillSummaryBookBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillSummaryBookBook.FormattingEnabled = true;
            this.comboBoxBillSummaryBookBook.Location = new System.Drawing.Point(539, 13);
            this.comboBoxBillSummaryBookBook.Name = "comboBoxBillSummaryBookBook";
            this.comboBoxBillSummaryBookBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxBillSummaryBookBook.TabIndex = 45;
            // 
            // comboBoxBillSummaryBookZone
            // 
            this.comboBoxBillSummaryBookZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillSummaryBookZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillSummaryBookZone.FormattingEnabled = true;
            this.comboBoxBillSummaryBookZone.Location = new System.Drawing.Point(377, 13);
            this.comboBoxBillSummaryBookZone.Name = "comboBoxBillSummaryBookZone";
            this.comboBoxBillSummaryBookZone.Size = new System.Drawing.Size(56, 24);
            this.comboBoxBillSummaryBookZone.TabIndex = 44;
            this.comboBoxBillSummaryBookZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillSummaryBookZone_SelectedIndexChanged);
            // 
            // comboBoxBillSummaryBookBillingMonth
            // 
            this.comboBoxBillSummaryBookBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillSummaryBookBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillSummaryBookBillingMonth.FormattingEnabled = true;
            this.comboBoxBillSummaryBookBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxBillSummaryBookBillingMonth.Name = "comboBoxBillSummaryBookBillingMonth";
            this.comboBoxBillSummaryBookBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxBillSummaryBookBillingMonth.TabIndex = 43;
            // 
            // buttonBillSummaryBookSearch
            // 
            this.buttonBillSummaryBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillSummaryBookSearch.Location = new System.Drawing.Point(673, 5);
            this.buttonBillSummaryBookSearch.Name = "buttonBillSummaryBookSearch";
            this.buttonBillSummaryBookSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonBillSummaryBookSearch.TabIndex = 41;
            this.buttonBillSummaryBookSearch.Text = "Search";
            this.buttonBillSummaryBookSearch.UseVisualStyleBackColor = true;
            this.buttonBillSummaryBookSearch.Click += new System.EventHandler(this.buttonBillSummaryBookSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Book:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Zone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Billing Month:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonBillSummaryMonthSearch);
            this.tabPage3.Controls.Add(this.comboBoxBillSummaryMonthBillingMonth);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.reportViewerBillSummaryMonth);
            this.tabPage3.Location = new System.Drawing.Point(189, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(987, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Billing Summary Per Month";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonBillSummaryMonthSearch
            // 
            this.buttonBillSummaryMonthSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillSummaryMonthSearch.Location = new System.Drawing.Point(348, 5);
            this.buttonBillSummaryMonthSearch.Name = "buttonBillSummaryMonthSearch";
            this.buttonBillSummaryMonthSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonBillSummaryMonthSearch.TabIndex = 50;
            this.buttonBillSummaryMonthSearch.Text = "Search";
            this.buttonBillSummaryMonthSearch.UseVisualStyleBackColor = true;
            this.buttonBillSummaryMonthSearch.Click += new System.EventHandler(this.buttonBillSummaryMonthSearch_Click);
            // 
            // comboBoxBillSummaryMonthBillingMonth
            // 
            this.comboBoxBillSummaryMonthBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillSummaryMonthBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillSummaryMonthBillingMonth.FormattingEnabled = true;
            this.comboBoxBillSummaryMonthBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxBillSummaryMonthBillingMonth.Name = "comboBoxBillSummaryMonthBillingMonth";
            this.comboBoxBillSummaryMonthBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxBillSummaryMonthBillingMonth.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Billing Month:";
            // 
            // reportViewerBillSummaryMonth
            // 
            reportDataSource3.Name = "DataSetBillingReports";
            reportDataSource3.Value = this.BillingSummaryPerMonthBindingSource;
            this.reportViewerBillSummaryMonth.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerBillSummaryMonth.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportBillingSummaryMonth.rdlc";
            this.reportViewerBillSummaryMonth.Location = new System.Drawing.Point(26, 49);
            this.reportViewerBillSummaryMonth.Name = "reportViewerBillSummaryMonth";
            this.reportViewerBillSummaryMonth.ServerReport.BearerToken = null;
            this.reportViewerBillSummaryMonth.Size = new System.Drawing.Size(944, 481);
            this.reportViewerBillSummaryMonth.TabIndex = 34;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonBillPreviousMonthSearch);
            this.tabPage4.Controls.Add(this.comboBoxBillPreviousMonthBillingMonth);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.reportViewerBillPreviousMonth);
            this.tabPage4.Location = new System.Drawing.Point(189, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(987, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Billing from Previous Months";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonBillPreviousMonthSearch
            // 
            this.buttonBillPreviousMonthSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillPreviousMonthSearch.Location = new System.Drawing.Point(348, 5);
            this.buttonBillPreviousMonthSearch.Name = "buttonBillPreviousMonthSearch";
            this.buttonBillPreviousMonthSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonBillPreviousMonthSearch.TabIndex = 53;
            this.buttonBillPreviousMonthSearch.Text = "Search";
            this.buttonBillPreviousMonthSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxBillPreviousMonthBillingMonth
            // 
            this.comboBoxBillPreviousMonthBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillPreviousMonthBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillPreviousMonthBillingMonth.FormattingEnabled = true;
            this.comboBoxBillPreviousMonthBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxBillPreviousMonthBillingMonth.Name = "comboBoxBillPreviousMonthBillingMonth";
            this.comboBoxBillPreviousMonthBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxBillPreviousMonthBillingMonth.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Billing Month:";
            // 
            // reportViewerBillPreviousMonth
            // 
            reportDataSource4.Name = "DataSetMeterReadingReports";
            reportDataSource4.Value = null;
            this.reportViewerBillPreviousMonth.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerBillPreviousMonth.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportAccountsSuddenIncDecConsumption.rdlc";
            this.reportViewerBillPreviousMonth.Location = new System.Drawing.Point(26, 49);
            this.reportViewerBillPreviousMonth.Name = "reportViewerBillPreviousMonth";
            this.reportViewerBillPreviousMonth.ServerReport.BearerToken = null;
            this.reportViewerBillPreviousMonth.Size = new System.Drawing.Size(944, 481);
            this.reportViewerBillPreviousMonth.TabIndex = 34;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBoxPenaltyBillingReportBook);
            this.tabPage5.Controls.Add(this.reportViewerPenaltyBillingReport);
            this.tabPage5.Controls.Add(this.comboBoxPenaltyBillingReportZone);
            this.tabPage5.Controls.Add(this.buttonPenaltyBillingReportSearch);
            this.tabPage5.Controls.Add(this.comboBoxPenaltyBillingReportBillingMonth);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(189, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(987, 555);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Penalty Billing Report";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBoxPenaltyBillingReportBook
            // 
            this.comboBoxPenaltyBillingReportBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPenaltyBillingReportBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPenaltyBillingReportBook.FormattingEnabled = true;
            this.comboBoxPenaltyBillingReportBook.Location = new System.Drawing.Point(539, 13);
            this.comboBoxPenaltyBillingReportBook.Name = "comboBoxPenaltyBillingReportBook";
            this.comboBoxPenaltyBillingReportBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxPenaltyBillingReportBook.TabIndex = 49;
            // 
            // reportViewerPenaltyBillingReport
            // 
            reportDataSource5.Name = "DataSetBillingReports";
            reportDataSource5.Value = this.PenaltyBillingReportBindingSource;
            this.reportViewerPenaltyBillingReport.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerPenaltyBillingReport.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportPenaltyBillingReport.rdlc";
            this.reportViewerPenaltyBillingReport.Location = new System.Drawing.Point(26, 49);
            this.reportViewerPenaltyBillingReport.Name = "reportViewerPenaltyBillingReport";
            this.reportViewerPenaltyBillingReport.ServerReport.BearerToken = null;
            this.reportViewerPenaltyBillingReport.Size = new System.Drawing.Size(944, 481);
            this.reportViewerPenaltyBillingReport.TabIndex = 34;
            // 
            // comboBoxPenaltyBillingReportZone
            // 
            this.comboBoxPenaltyBillingReportZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPenaltyBillingReportZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPenaltyBillingReportZone.FormattingEnabled = true;
            this.comboBoxPenaltyBillingReportZone.Location = new System.Drawing.Point(377, 13);
            this.comboBoxPenaltyBillingReportZone.Name = "comboBoxPenaltyBillingReportZone";
            this.comboBoxPenaltyBillingReportZone.Size = new System.Drawing.Size(56, 24);
            this.comboBoxPenaltyBillingReportZone.TabIndex = 48;
            this.comboBoxPenaltyBillingReportZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxPenaltyBillingReportZone_SelectedIndexChanged);
            // 
            // buttonPenaltyBillingReportSearch
            // 
            this.buttonPenaltyBillingReportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPenaltyBillingReportSearch.Location = new System.Drawing.Point(650, 5);
            this.buttonPenaltyBillingReportSearch.Name = "buttonPenaltyBillingReportSearch";
            this.buttonPenaltyBillingReportSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonPenaltyBillingReportSearch.TabIndex = 16;
            this.buttonPenaltyBillingReportSearch.Text = "Search";
            this.buttonPenaltyBillingReportSearch.UseVisualStyleBackColor = true;
            this.buttonPenaltyBillingReportSearch.Click += new System.EventHandler(this.buttonPenaltyBillingReportSearch_Click);
            // 
            // comboBoxPenaltyBillingReportBillingMonth
            // 
            this.comboBoxPenaltyBillingReportBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPenaltyBillingReportBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPenaltyBillingReportBillingMonth.FormattingEnabled = true;
            this.comboBoxPenaltyBillingReportBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxPenaltyBillingReportBillingMonth.Name = "comboBoxPenaltyBillingReportBillingMonth";
            this.comboBoxPenaltyBillingReportBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxPenaltyBillingReportBillingMonth.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 46;
            this.label16.Text = "Billing Month:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Book:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(329, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Zone:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonPenaltySummaryMonthSearch);
            this.tabPage6.Controls.Add(this.comboBoxPenaltySummaryMonthBillingMonth);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.reportViewerPenaltySummaryMonth);
            this.tabPage6.Location = new System.Drawing.Point(189, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(987, 555);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Penalty Summary Per Month";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonPenaltySummaryMonthSearch
            // 
            this.buttonPenaltySummaryMonthSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPenaltySummaryMonthSearch.Location = new System.Drawing.Point(348, 5);
            this.buttonPenaltySummaryMonthSearch.Name = "buttonPenaltySummaryMonthSearch";
            this.buttonPenaltySummaryMonthSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonPenaltySummaryMonthSearch.TabIndex = 53;
            this.buttonPenaltySummaryMonthSearch.Text = "Search";
            this.buttonPenaltySummaryMonthSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxPenaltySummaryMonthBillingMonth
            // 
            this.comboBoxPenaltySummaryMonthBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPenaltySummaryMonthBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPenaltySummaryMonthBillingMonth.FormattingEnabled = true;
            this.comboBoxPenaltySummaryMonthBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxPenaltySummaryMonthBillingMonth.Name = "comboBoxPenaltySummaryMonthBillingMonth";
            this.comboBoxPenaltySummaryMonthBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxPenaltySummaryMonthBillingMonth.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Billing Month:";
            // 
            // reportViewerPenaltySummaryMonth
            // 
            reportDataSource6.Name = "DataSetMeterReadingReports";
            reportDataSource6.Value = null;
            this.reportViewerPenaltySummaryMonth.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerPenaltySummaryMonth.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportUnreadMeters.rdlc";
            this.reportViewerPenaltySummaryMonth.Location = new System.Drawing.Point(26, 49);
            this.reportViewerPenaltySummaryMonth.Name = "reportViewerPenaltySummaryMonth";
            this.reportViewerPenaltySummaryMonth.ServerReport.BearerToken = null;
            this.reportViewerPenaltySummaryMonth.Size = new System.Drawing.Size(944, 481);
            this.reportViewerPenaltySummaryMonth.TabIndex = 35;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonBillingSummaryMaterialsSearch);
            this.tabPage7.Controls.Add(this.comboBoxBillingSummaryMaterialsBillingMonth);
            this.tabPage7.Controls.Add(this.label11);
            this.tabPage7.Controls.Add(this.reportViewerBillingSummaryMaterials);
            this.tabPage7.Location = new System.Drawing.Point(189, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(987, 555);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Billing Summary of  Materials and Other Fees";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonBillingSummaryMaterialsSearch
            // 
            this.buttonBillingSummaryMaterialsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillingSummaryMaterialsSearch.Location = new System.Drawing.Point(348, 5);
            this.buttonBillingSummaryMaterialsSearch.Name = "buttonBillingSummaryMaterialsSearch";
            this.buttonBillingSummaryMaterialsSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonBillingSummaryMaterialsSearch.TabIndex = 57;
            this.buttonBillingSummaryMaterialsSearch.Text = "Search";
            this.buttonBillingSummaryMaterialsSearch.UseVisualStyleBackColor = true;
            this.buttonBillingSummaryMaterialsSearch.Click += new System.EventHandler(this.buttonBillingSummaryMaterialsSearch_Click);
            // 
            // comboBoxBillingSummaryMaterialsBillingMonth
            // 
            this.comboBoxBillingSummaryMaterialsBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillingSummaryMaterialsBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBillingSummaryMaterialsBillingMonth.FormattingEnabled = true;
            this.comboBoxBillingSummaryMaterialsBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxBillingSummaryMaterialsBillingMonth.Name = "comboBoxBillingSummaryMaterialsBillingMonth";
            this.comboBoxBillingSummaryMaterialsBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxBillingSummaryMaterialsBillingMonth.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "Billing Month:";
            // 
            // reportViewerBillingSummaryMaterials
            // 
            reportDataSource7.Name = "DataSetBillingReports";
            reportDataSource7.Value = this.BillingSummaryMaterialsFeesBindingSource;
            this.reportViewerBillingSummaryMaterials.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewerBillingSummaryMaterials.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportBillingSummaryMaterialsOtherFees.rdlc";
            this.reportViewerBillingSummaryMaterials.Location = new System.Drawing.Point(26, 49);
            this.reportViewerBillingSummaryMaterials.Name = "reportViewerBillingSummaryMaterials";
            this.reportViewerBillingSummaryMaterials.ServerReport.BearerToken = null;
            this.reportViewerBillingSummaryMaterials.Size = new System.Drawing.Size(944, 481);
            this.reportViewerBillingSummaryMaterials.TabIndex = 54;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.reportViewerBillingAdjustmentSummary);
            this.tabPage8.Controls.Add(this.buttonBillingAdjustmentSummarySearch);
            this.tabPage8.Controls.Add(this.label13);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.dateTimePickerBillingAdjustmentSummaryYear);
            this.tabPage8.Controls.Add(this.dateTimePickerBillingAdjustmentSummaryMonth);
            this.tabPage8.Location = new System.Drawing.Point(189, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(987, 555);
            this.tabPage8.TabIndex = 8;
            this.tabPage8.Text = "Billing Adjustment Summary";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // reportViewerBillingAdjustmentSummary
            // 
            reportDataSource8.Name = "DataSetMeterReports";
            reportDataSource8.Value = null;
            this.reportViewerBillingAdjustmentSummary.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewerBillingAdjustmentSummary.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportChangedMeterPreviousRead.rdlc";
            this.reportViewerBillingAdjustmentSummary.Location = new System.Drawing.Point(26, 49);
            this.reportViewerBillingAdjustmentSummary.Name = "reportViewerBillingAdjustmentSummary";
            this.reportViewerBillingAdjustmentSummary.ServerReport.BearerToken = null;
            this.reportViewerBillingAdjustmentSummary.Size = new System.Drawing.Size(944, 481);
            this.reportViewerBillingAdjustmentSummary.TabIndex = 33;
            // 
            // buttonBillingAdjustmentSummarySearch
            // 
            this.buttonBillingAdjustmentSummarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillingAdjustmentSummarySearch.Location = new System.Drawing.Point(556, 5);
            this.buttonBillingAdjustmentSummarySearch.Name = "buttonBillingAdjustmentSummarySearch";
            this.buttonBillingAdjustmentSummarySearch.Size = new System.Drawing.Size(74, 38);
            this.buttonBillingAdjustmentSummarySearch.TabIndex = 32;
            this.buttonBillingAdjustmentSummarySearch.Text = "Search";
            this.buttonBillingAdjustmentSummarySearch.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(294, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Year:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Month:";
            // 
            // dateTimePickerBillingAdjustmentSummaryYear
            // 
            this.dateTimePickerBillingAdjustmentSummaryYear.CustomFormat = "yyyy";
            this.dateTimePickerBillingAdjustmentSummaryYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBillingAdjustmentSummaryYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBillingAdjustmentSummaryYear.Location = new System.Drawing.Point(337, 13);
            this.dateTimePickerBillingAdjustmentSummaryYear.Name = "dateTimePickerBillingAdjustmentSummaryYear";
            this.dateTimePickerBillingAdjustmentSummaryYear.ShowUpDown = true;
            this.dateTimePickerBillingAdjustmentSummaryYear.Size = new System.Drawing.Size(82, 24);
            this.dateTimePickerBillingAdjustmentSummaryYear.TabIndex = 28;
            // 
            // dateTimePickerBillingAdjustmentSummaryMonth
            // 
            this.dateTimePickerBillingAdjustmentSummaryMonth.CustomFormat = "MMMM";
            this.dateTimePickerBillingAdjustmentSummaryMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBillingAdjustmentSummaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBillingAdjustmentSummaryMonth.Location = new System.Drawing.Point(78, 13);
            this.dateTimePickerBillingAdjustmentSummaryMonth.Name = "dateTimePickerBillingAdjustmentSummaryMonth";
            this.dateTimePickerBillingAdjustmentSummaryMonth.ShowUpDown = true;
            this.dateTimePickerBillingAdjustmentSummaryMonth.Size = new System.Drawing.Size(111, 24);
            this.dateTimePickerBillingAdjustmentSummaryMonth.TabIndex = 29;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(189, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(987, 555);
            this.tabPage9.TabIndex = 9;
            this.tabPage9.Text = "List of Accounts with Large Consumptions Per Class";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.buttonDailyBillingSummarySearch);
            this.tabPage10.Controls.Add(this.comboBoxDailyBillingSummaryBillingMonth);
            this.tabPage10.Controls.Add(this.label15);
            this.tabPage10.Controls.Add(this.reportViewerDailyBillingSummary);
            this.tabPage10.Location = new System.Drawing.Point(189, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(987, 555);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "Daily Billing Summary";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // buttonDailyBillingSummarySearch
            // 
            this.buttonDailyBillingSummarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDailyBillingSummarySearch.Location = new System.Drawing.Point(348, 5);
            this.buttonDailyBillingSummarySearch.Name = "buttonDailyBillingSummarySearch";
            this.buttonDailyBillingSummarySearch.Size = new System.Drawing.Size(74, 38);
            this.buttonDailyBillingSummarySearch.TabIndex = 61;
            this.buttonDailyBillingSummarySearch.Text = "Search";
            this.buttonDailyBillingSummarySearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxDailyBillingSummaryBillingMonth
            // 
            this.comboBoxDailyBillingSummaryBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDailyBillingSummaryBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDailyBillingSummaryBillingMonth.FormattingEnabled = true;
            this.comboBoxDailyBillingSummaryBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxDailyBillingSummaryBillingMonth.Name = "comboBoxDailyBillingSummaryBillingMonth";
            this.comboBoxDailyBillingSummaryBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxDailyBillingSummaryBillingMonth.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 59;
            this.label15.Text = "Billing Month:";
            // 
            // reportViewerDailyBillingSummary
            // 
            reportDataSource9.Name = "DataSetMeterReadingReports";
            reportDataSource9.Value = null;
            this.reportViewerDailyBillingSummary.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewerDailyBillingSummary.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportUnreadMeters.rdlc";
            this.reportViewerDailyBillingSummary.Location = new System.Drawing.Point(26, 49);
            this.reportViewerDailyBillingSummary.Name = "reportViewerDailyBillingSummary";
            this.reportViewerDailyBillingSummary.ServerReport.BearerToken = null;
            this.reportViewerDailyBillingSummary.Size = new System.Drawing.Size(944, 481);
            this.reportViewerDailyBillingSummary.TabIndex = 58;
            // 
            // BillingSummaryMaterialsFeesBindingSource
            // 
            this.BillingSummaryMaterialsFeesBindingSource.DataMember = "BillingSummaryMaterialsFees";
            this.BillingSummaryMaterialsFeesBindingSource.DataSource = this.DataSetBillingReports;
            // 
            // BillingReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 587);
            this.Controls.Add(this.tabControlBillingReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BillingReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Billing Reports";
            this.Load += new System.EventHandler(this.BillingReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillComputationRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBillingReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingSummaryPerBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingSummaryPerMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenaltyBillingReportBindingSource)).EndInit();
            this.tabControlBillingReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillingSummaryMaterialsFeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBillingReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxBillComputationRegBook;
        private System.Windows.Forms.ComboBox comboBoxBillComputationRegZone;
        private System.Windows.Forms.ComboBox comboBoxBillComputationRegBillingMonth;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBillComputationReg;
        private System.Windows.Forms.Button buttonBillComputationRegSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonBillSummaryMonthSearch;
        private System.Windows.Forms.ComboBox comboBoxBillSummaryMonthBillingMonth;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBillSummaryMonth;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBillPreviousMonth;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBoxPenaltyBillingReportBook;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPenaltyBillingReport;
        private System.Windows.Forms.ComboBox comboBoxPenaltyBillingReportZone;
        private System.Windows.Forms.Button buttonPenaltyBillingReportSearch;
        private System.Windows.Forms.ComboBox comboBoxPenaltyBillingReportBillingMonth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPenaltySummaryMonth;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.ComboBox comboBoxBillSummaryBookBook;
        private System.Windows.Forms.ComboBox comboBoxBillSummaryBookZone;
        private System.Windows.Forms.ComboBox comboBoxBillSummaryBookBillingMonth;
        private System.Windows.Forms.Button buttonBillSummaryBookSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBillPreviousMonthSearch;
        private System.Windows.Forms.ComboBox comboBoxBillPreviousMonthBillingMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPenaltySummaryMonthSearch;
        private System.Windows.Forms.ComboBox comboBoxPenaltySummaryMonthBillingMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBillingSummaryMaterialsSearch;
        private System.Windows.Forms.ComboBox comboBoxBillingSummaryMaterialsBillingMonth;
        private System.Windows.Forms.Label label11;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBillingSummaryMaterials;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBillingAdjustmentSummary;
        private System.Windows.Forms.Button buttonBillingAdjustmentSummarySearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillingAdjustmentSummaryYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillingAdjustmentSummaryMonth;
        private System.Windows.Forms.Button buttonDailyBillingSummarySearch;
        private System.Windows.Forms.ComboBox comboBoxDailyBillingSummaryBillingMonth;
        private System.Windows.Forms.Label label15;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDailyBillingSummary;
        private System.Windows.Forms.BindingSource BillComputationRegisterBindingSource;
        private DataSetBillingReports DataSetBillingReports;
        private System.Windows.Forms.BindingSource BillingSummaryPerBookBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBillSummaryBook;
        private System.Windows.Forms.BindingSource BillingSummaryPerMonthBindingSource;
        private System.Windows.Forms.BindingSource PenaltyBillingReportBindingSource;
        private System.Windows.Forms.BindingSource BillingSummaryMaterialsFeesBindingSource;
    }
}