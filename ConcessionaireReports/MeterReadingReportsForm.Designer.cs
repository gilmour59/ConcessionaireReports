namespace ConcessionaireReports
{
    partial class MeterReadingReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReadingSlipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMeterReadingReports = new ConcessionaireReports.DataSetMeterReadingReports();
            this.tabControlMeterReadingReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxReadingSlipBook = new System.Windows.Forms.ComboBox();
            this.comboBoxReadingSlipZone = new System.Windows.Forms.ComboBox();
            this.comboBoxReadingSlipBillingMonth = new System.Windows.Forms.ComboBox();
            this.reportViewerReadingSlip = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonReadingSlipSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerReadBillSOA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonChangedMeterPreviousReadSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerChangedMeterPreviousReadYear = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerChangedMeterPreviousReadMonth = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewerMeterReaderAccomplishment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonSummaryPulledOutMetersSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerSummaryPulledOutMetersYear = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSummaryPulledOutMetersMonth = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewerAccountsSuddenIncDecConsumption = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAccountsSuddenIncDecConsumptionSearch = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewerAccountsMinimumConsumption = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonSummaryReceivedMetersSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerSummaryReceivedMetersTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSummaryReceivedMetersFrom = new System.Windows.Forms.DateTimePicker();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewerUnreadMeters = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonSummaryDisposedMetersSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerSummaryDisposedMetersTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSummaryDisposedMetersFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAccountsSuddenIncDecConsumptionBook = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountsSuddenIncDecConsumptionZone = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownAccountsSuddenIncDecConsumptionChange = new System.Windows.Forms.NumericUpDown();
            this.AccountsSuddenIncDecConsumptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReadingSlipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMeterReadingReports)).BeginInit();
            this.tabControlMeterReadingReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccountsSuddenIncDecConsumptionChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsSuddenIncDecConsumptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadingSlipBindingSource
            // 
            this.ReadingSlipBindingSource.DataMember = "ReadingSlip";
            this.ReadingSlipBindingSource.DataSource = this.DataSetMeterReadingReports;
            // 
            // DataSetMeterReadingReports
            // 
            this.DataSetMeterReadingReports.DataSetName = "DataSetMeterReadingReports";
            this.DataSetMeterReadingReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControlMeterReadingReports
            // 
            this.tabControlMeterReadingReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMeterReadingReports.Controls.Add(this.tabPage1);
            this.tabControlMeterReadingReports.Controls.Add(this.tabPage2);
            this.tabControlMeterReadingReports.Controls.Add(this.tabPage3);
            this.tabControlMeterReadingReports.Controls.Add(this.tabPage4);
            this.tabControlMeterReadingReports.Controls.Add(this.tabPage5);
            this.tabControlMeterReadingReports.Controls.Add(this.tabPage6);
            this.tabControlMeterReadingReports.ItemSize = new System.Drawing.Size(60, 180);
            this.tabControlMeterReadingReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlMeterReadingReports.Multiline = true;
            this.tabControlMeterReadingReports.Name = "tabControlMeterReadingReports";
            this.tabControlMeterReadingReports.SelectedIndex = 0;
            this.tabControlMeterReadingReports.Size = new System.Drawing.Size(1180, 563);
            this.tabControlMeterReadingReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMeterReadingReports.TabIndex = 2;
            this.tabControlMeterReadingReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMeterReadingReports_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxReadingSlipBook);
            this.tabPage1.Controls.Add(this.comboBoxReadingSlipZone);
            this.tabPage1.Controls.Add(this.comboBoxReadingSlipBillingMonth);
            this.tabPage1.Controls.Add(this.reportViewerReadingSlip);
            this.tabPage1.Controls.Add(this.buttonReadingSlipSearch);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reading Slip";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxReadingSlipBook
            // 
            this.comboBoxReadingSlipBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadingSlipBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadingSlipBook.FormattingEnabled = true;
            this.comboBoxReadingSlipBook.Location = new System.Drawing.Point(540, 25);
            this.comboBoxReadingSlipBook.Name = "comboBoxReadingSlipBook";
            this.comboBoxReadingSlipBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxReadingSlipBook.TabIndex = 37;
            // 
            // comboBoxReadingSlipZone
            // 
            this.comboBoxReadingSlipZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadingSlipZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadingSlipZone.FormattingEnabled = true;
            this.comboBoxReadingSlipZone.Location = new System.Drawing.Point(378, 25);
            this.comboBoxReadingSlipZone.Name = "comboBoxReadingSlipZone";
            this.comboBoxReadingSlipZone.Size = new System.Drawing.Size(56, 24);
            this.comboBoxReadingSlipZone.TabIndex = 36;
            this.comboBoxReadingSlipZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxReadingSlipZone_SelectedIndexChanged);
            // 
            // comboBoxReadingSlipBillingMonth
            // 
            this.comboBoxReadingSlipBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadingSlipBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadingSlipBillingMonth.FormattingEnabled = true;
            this.comboBoxReadingSlipBillingMonth.Location = new System.Drawing.Point(116, 25);
            this.comboBoxReadingSlipBillingMonth.Name = "comboBoxReadingSlipBillingMonth";
            this.comboBoxReadingSlipBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxReadingSlipBillingMonth.TabIndex = 35;
            // 
            // reportViewerReadingSlip
            // 
            reportDataSource5.Name = "DataSetMeterReadingReports";
            reportDataSource5.Value = this.ReadingSlipBindingSource;
            this.reportViewerReadingSlip.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerReadingSlip.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportReadingSlip.rdlc";
            this.reportViewerReadingSlip.Location = new System.Drawing.Point(27, 67);
            this.reportViewerReadingSlip.Name = "reportViewerReadingSlip";
            this.reportViewerReadingSlip.ServerReport.BearerToken = null;
            this.reportViewerReadingSlip.Size = new System.Drawing.Size(938, 469);
            this.reportViewerReadingSlip.TabIndex = 34;
            // 
            // buttonReadingSlipSearch
            // 
            this.buttonReadingSlipSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadingSlipSearch.Location = new System.Drawing.Point(674, 17);
            this.buttonReadingSlipSearch.Name = "buttonReadingSlipSearch";
            this.buttonReadingSlipSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonReadingSlipSearch.TabIndex = 21;
            this.buttonReadingSlipSearch.Text = "Search";
            this.buttonReadingSlipSearch.UseVisualStyleBackColor = true;
            this.buttonReadingSlipSearch.Click += new System.EventHandler(this.buttonReadingSlipSearch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(491, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Zone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Billing Month:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewerReadBillSOA);
            this.tabPage2.Controls.Add(this.buttonChangedMeterPreviousReadSearch);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimePickerChangedMeterPreviousReadYear);
            this.tabPage2.Controls.Add(this.dateTimePickerChangedMeterPreviousReadMonth);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read & Bill SOA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerReadBillSOA
            // 
            this.reportViewerReadBillSOA.Location = new System.Drawing.Point(29, 67);
            this.reportViewerReadBillSOA.Name = "reportViewerReadBillSOA";
            this.reportViewerReadBillSOA.ServerReport.BearerToken = null;
            this.reportViewerReadBillSOA.Size = new System.Drawing.Size(938, 469);
            this.reportViewerReadBillSOA.TabIndex = 34;
            // 
            // buttonChangedMeterPreviousReadSearch
            // 
            this.buttonChangedMeterPreviousReadSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangedMeterPreviousReadSearch.Location = new System.Drawing.Point(638, 23);
            this.buttonChangedMeterPreviousReadSearch.Name = "buttonChangedMeterPreviousReadSearch";
            this.buttonChangedMeterPreviousReadSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonChangedMeterPreviousReadSearch.TabIndex = 26;
            this.buttonChangedMeterPreviousReadSearch.Text = "Search";
            this.buttonChangedMeterPreviousReadSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Month:";
            // 
            // dateTimePickerChangedMeterPreviousReadYear
            // 
            this.dateTimePickerChangedMeterPreviousReadYear.CustomFormat = "yyyy";
            this.dateTimePickerChangedMeterPreviousReadYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerChangedMeterPreviousReadYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChangedMeterPreviousReadYear.Location = new System.Drawing.Point(419, 31);
            this.dateTimePickerChangedMeterPreviousReadYear.Name = "dateTimePickerChangedMeterPreviousReadYear";
            this.dateTimePickerChangedMeterPreviousReadYear.ShowUpDown = true;
            this.dateTimePickerChangedMeterPreviousReadYear.Size = new System.Drawing.Size(82, 24);
            this.dateTimePickerChangedMeterPreviousReadYear.TabIndex = 22;
            // 
            // dateTimePickerChangedMeterPreviousReadMonth
            // 
            this.dateTimePickerChangedMeterPreviousReadMonth.CustomFormat = "MMMM";
            this.dateTimePickerChangedMeterPreviousReadMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerChangedMeterPreviousReadMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChangedMeterPreviousReadMonth.Location = new System.Drawing.Point(160, 31);
            this.dateTimePickerChangedMeterPreviousReadMonth.Name = "dateTimePickerChangedMeterPreviousReadMonth";
            this.dateTimePickerChangedMeterPreviousReadMonth.ShowUpDown = true;
            this.dateTimePickerChangedMeterPreviousReadMonth.Size = new System.Drawing.Size(111, 24);
            this.dateTimePickerChangedMeterPreviousReadMonth.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewerMeterReaderAccomplishment);
            this.tabPage3.Controls.Add(this.buttonSummaryPulledOutMetersSearch);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.dateTimePickerSummaryPulledOutMetersYear);
            this.tabPage3.Controls.Add(this.dateTimePickerSummaryPulledOutMetersMonth);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Meter Reader Accomplishment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewerMeterReaderAccomplishment
            // 
            this.reportViewerMeterReaderAccomplishment.Location = new System.Drawing.Point(28, 67);
            this.reportViewerMeterReaderAccomplishment.Name = "reportViewerMeterReaderAccomplishment";
            this.reportViewerMeterReaderAccomplishment.ServerReport.BearerToken = null;
            this.reportViewerMeterReaderAccomplishment.Size = new System.Drawing.Size(938, 469);
            this.reportViewerMeterReaderAccomplishment.TabIndex = 34;
            // 
            // buttonSummaryPulledOutMetersSearch
            // 
            this.buttonSummaryPulledOutMetersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummaryPulledOutMetersSearch.Location = new System.Drawing.Point(637, 23);
            this.buttonSummaryPulledOutMetersSearch.Name = "buttonSummaryPulledOutMetersSearch";
            this.buttonSummaryPulledOutMetersSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonSummaryPulledOutMetersSearch.TabIndex = 32;
            this.buttonSummaryPulledOutMetersSearch.Text = "Search";
            this.buttonSummaryPulledOutMetersSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Month:";
            // 
            // dateTimePickerSummaryPulledOutMetersYear
            // 
            this.dateTimePickerSummaryPulledOutMetersYear.CustomFormat = "yyyy";
            this.dateTimePickerSummaryPulledOutMetersYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSummaryPulledOutMetersYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSummaryPulledOutMetersYear.Location = new System.Drawing.Point(418, 31);
            this.dateTimePickerSummaryPulledOutMetersYear.Name = "dateTimePickerSummaryPulledOutMetersYear";
            this.dateTimePickerSummaryPulledOutMetersYear.ShowUpDown = true;
            this.dateTimePickerSummaryPulledOutMetersYear.Size = new System.Drawing.Size(82, 24);
            this.dateTimePickerSummaryPulledOutMetersYear.TabIndex = 28;
            // 
            // dateTimePickerSummaryPulledOutMetersMonth
            // 
            this.dateTimePickerSummaryPulledOutMetersMonth.CustomFormat = "MMMM";
            this.dateTimePickerSummaryPulledOutMetersMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSummaryPulledOutMetersMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSummaryPulledOutMetersMonth.Location = new System.Drawing.Point(159, 31);
            this.dateTimePickerSummaryPulledOutMetersMonth.Name = "dateTimePickerSummaryPulledOutMetersMonth";
            this.dateTimePickerSummaryPulledOutMetersMonth.ShowUpDown = true;
            this.dateTimePickerSummaryPulledOutMetersMonth.Size = new System.Drawing.Size(111, 24);
            this.dateTimePickerSummaryPulledOutMetersMonth.TabIndex = 29;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numericUpDownAccountsSuddenIncDecConsumptionChange);
            this.tabPage4.Controls.Add(this.comboBoxAccountsSuddenIncDecConsumptionBook);
            this.tabPage4.Controls.Add(this.comboBoxAccountsSuddenIncDecConsumptionZone);
            this.tabPage4.Controls.Add(this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.reportViewerAccountsSuddenIncDecConsumption);
            this.tabPage4.Controls.Add(this.buttonAccountsSuddenIncDecConsumptionSearch);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(992, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "List of Accounts with Sudden Increase/Decrease in Consumption";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewerAccountsSuddenIncDecConsumption
            // 
            reportDataSource4.Name = "DataSetMeterReadingReports";
            reportDataSource4.Value = this.AccountsSuddenIncDecConsumptionBindingSource;
            this.reportViewerAccountsSuddenIncDecConsumption.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerAccountsSuddenIncDecConsumption.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportAccountsSuddenIncDecConsumption.rdlc";
            this.reportViewerAccountsSuddenIncDecConsumption.Location = new System.Drawing.Point(27, 67);
            this.reportViewerAccountsSuddenIncDecConsumption.Name = "reportViewerAccountsSuddenIncDecConsumption";
            this.reportViewerAccountsSuddenIncDecConsumption.ServerReport.BearerToken = null;
            this.reportViewerAccountsSuddenIncDecConsumption.Size = new System.Drawing.Size(938, 469);
            this.reportViewerAccountsSuddenIncDecConsumption.TabIndex = 34;
            // 
            // buttonAccountsSuddenIncDecConsumptionSearch
            // 
            this.buttonAccountsSuddenIncDecConsumptionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountsSuddenIncDecConsumptionSearch.Location = new System.Drawing.Point(827, 20);
            this.buttonAccountsSuddenIncDecConsumptionSearch.Name = "buttonAccountsSuddenIncDecConsumptionSearch";
            this.buttonAccountsSuddenIncDecConsumptionSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountsSuddenIncDecConsumptionSearch.TabIndex = 25;
            this.buttonAccountsSuddenIncDecConsumptionSearch.Text = "Search";
            this.buttonAccountsSuddenIncDecConsumptionSearch.UseVisualStyleBackColor = true;
            this.buttonAccountsSuddenIncDecConsumptionSearch.Click += new System.EventHandler(this.buttonAccountsSuddenIncDecConsumptionSearch_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewerAccountsMinimumConsumption);
            this.tabPage5.Controls.Add(this.buttonSummaryReceivedMetersSearch);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.dateTimePickerSummaryReceivedMetersTo);
            this.tabPage5.Controls.Add(this.dateTimePickerSummaryReceivedMetersFrom);
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(992, 555);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "List of Accounts with Minimum Consumption";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewerAccountsMinimumConsumption
            // 
            this.reportViewerAccountsMinimumConsumption.Location = new System.Drawing.Point(26, 63);
            this.reportViewerAccountsMinimumConsumption.Name = "reportViewerAccountsMinimumConsumption";
            this.reportViewerAccountsMinimumConsumption.ServerReport.BearerToken = null;
            this.reportViewerAccountsMinimumConsumption.Size = new System.Drawing.Size(938, 469);
            this.reportViewerAccountsMinimumConsumption.TabIndex = 34;
            // 
            // buttonSummaryReceivedMetersSearch
            // 
            this.buttonSummaryReceivedMetersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummaryReceivedMetersSearch.Location = new System.Drawing.Point(614, 19);
            this.buttonSummaryReceivedMetersSearch.Name = "buttonSummaryReceivedMetersSearch";
            this.buttonSummaryReceivedMetersSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonSummaryReceivedMetersSearch.TabIndex = 16;
            this.buttonSummaryReceivedMetersSearch.Text = "Search";
            this.buttonSummaryReceivedMetersSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(342, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "From:";
            // 
            // dateTimePickerSummaryReceivedMetersTo
            // 
            this.dateTimePickerSummaryReceivedMetersTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerSummaryReceivedMetersTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSummaryReceivedMetersTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSummaryReceivedMetersTo.Location = new System.Drawing.Point(374, 27);
            this.dateTimePickerSummaryReceivedMetersTo.Name = "dateTimePickerSummaryReceivedMetersTo";
            this.dateTimePickerSummaryReceivedMetersTo.Size = new System.Drawing.Size(125, 24);
            this.dateTimePickerSummaryReceivedMetersTo.TabIndex = 0;
            // 
            // dateTimePickerSummaryReceivedMetersFrom
            // 
            this.dateTimePickerSummaryReceivedMetersFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerSummaryReceivedMetersFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSummaryReceivedMetersFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSummaryReceivedMetersFrom.Location = new System.Drawing.Point(136, 27);
            this.dateTimePickerSummaryReceivedMetersFrom.Name = "dateTimePickerSummaryReceivedMetersFrom";
            this.dateTimePickerSummaryReceivedMetersFrom.Size = new System.Drawing.Size(118, 24);
            this.dateTimePickerSummaryReceivedMetersFrom.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewerUnreadMeters);
            this.tabPage6.Controls.Add(this.buttonSummaryDisposedMetersSearch);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.dateTimePickerSummaryDisposedMetersTo);
            this.tabPage6.Controls.Add(this.dateTimePickerSummaryDisposedMetersFrom);
            this.tabPage6.Location = new System.Drawing.Point(184, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(992, 555);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "List of Unread Meters";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewerUnreadMeters
            // 
            reportDataSource6.Name = "DataSetMeterReadingReports";
            reportDataSource6.Value = this.ReadingSlipBindingSource;
            this.reportViewerUnreadMeters.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerUnreadMeters.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ReportReadingSlip.rdlc";
            this.reportViewerUnreadMeters.Location = new System.Drawing.Point(23, 63);
            this.reportViewerUnreadMeters.Name = "reportViewerUnreadMeters";
            this.reportViewerUnreadMeters.ServerReport.BearerToken = null;
            this.reportViewerUnreadMeters.Size = new System.Drawing.Size(938, 469);
            this.reportViewerUnreadMeters.TabIndex = 35;
            // 
            // buttonSummaryDisposedMetersSearch
            // 
            this.buttonSummaryDisposedMetersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummaryDisposedMetersSearch.Location = new System.Drawing.Point(616, 19);
            this.buttonSummaryDisposedMetersSearch.Name = "buttonSummaryDisposedMetersSearch";
            this.buttonSummaryDisposedMetersSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonSummaryDisposedMetersSearch.TabIndex = 32;
            this.buttonSummaryDisposedMetersSearch.Text = "Search";
            this.buttonSummaryDisposedMetersSearch.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "To:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "From:";
            // 
            // dateTimePickerSummaryDisposedMetersTo
            // 
            this.dateTimePickerSummaryDisposedMetersTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerSummaryDisposedMetersTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSummaryDisposedMetersTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSummaryDisposedMetersTo.Location = new System.Drawing.Point(376, 27);
            this.dateTimePickerSummaryDisposedMetersTo.Name = "dateTimePickerSummaryDisposedMetersTo";
            this.dateTimePickerSummaryDisposedMetersTo.Size = new System.Drawing.Size(125, 24);
            this.dateTimePickerSummaryDisposedMetersTo.TabIndex = 28;
            // 
            // dateTimePickerSummaryDisposedMetersFrom
            // 
            this.dateTimePickerSummaryDisposedMetersFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerSummaryDisposedMetersFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSummaryDisposedMetersFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSummaryDisposedMetersFrom.Location = new System.Drawing.Point(138, 27);
            this.dateTimePickerSummaryDisposedMetersFrom.Name = "dateTimePickerSummaryDisposedMetersFrom";
            this.dateTimePickerSummaryDisposedMetersFrom.Size = new System.Drawing.Size(118, 24);
            this.dateTimePickerSummaryDisposedMetersFrom.TabIndex = 29;
            // 
            // comboBoxAccountsSuddenIncDecConsumptionBook
            // 
            this.comboBoxAccountsSuddenIncDecConsumptionBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsSuddenIncDecConsumptionBook.FormattingEnabled = true;
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Location = new System.Drawing.Point(540, 28);
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Name = "comboBoxAccountsSuddenIncDecConsumptionBook";
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxAccountsSuddenIncDecConsumptionBook.TabIndex = 43;
            // 
            // comboBoxAccountsSuddenIncDecConsumptionZone
            // 
            this.comboBoxAccountsSuddenIncDecConsumptionZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsSuddenIncDecConsumptionZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsSuddenIncDecConsumptionZone.FormattingEnabled = true;
            this.comboBoxAccountsSuddenIncDecConsumptionZone.Location = new System.Drawing.Point(378, 28);
            this.comboBoxAccountsSuddenIncDecConsumptionZone.Name = "comboBoxAccountsSuddenIncDecConsumptionZone";
            this.comboBoxAccountsSuddenIncDecConsumptionZone.Size = new System.Drawing.Size(56, 24);
            this.comboBoxAccountsSuddenIncDecConsumptionZone.TabIndex = 42;
            this.comboBoxAccountsSuddenIncDecConsumptionZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccountsSuddenIncDecConsumptionZone_SelectedIndexChanged);
            // 
            // comboBoxAccountsSuddenIncDecConsumptionBillingMonth
            // 
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.FormattingEnabled = true;
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Location = new System.Drawing.Point(116, 28);
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Name = "comboBoxAccountsSuddenIncDecConsumptionBillingMonth";
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Book:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(330, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Zone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Billing Month:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(649, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "% Change: ";
            // 
            // numericUpDownAccountsSuddenIncDecConsumptionChange
            // 
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.Location = new System.Drawing.Point(731, 31);
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.Name = "numericUpDownAccountsSuddenIncDecConsumptionChange";
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.TabIndex = 44;
            // 
            // AccountsSuddenIncDecConsumptionBindingSource
            // 
            this.AccountsSuddenIncDecConsumptionBindingSource.DataMember = "AccountsSuddenIncDecConsumption";
            this.AccountsSuddenIncDecConsumptionBindingSource.DataSource = this.DataSetMeterReadingReports;
            // 
            // MeterReadingReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 587);
            this.Controls.Add(this.tabControlMeterReadingReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MeterReadingReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meter Reading Reports";
            this.Load += new System.EventHandler(this.MeterReadingReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReadingSlipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMeterReadingReports)).EndInit();
            this.tabControlMeterReadingReports.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccountsSuddenIncDecConsumptionChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsSuddenIncDecConsumptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMeterReadingReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonReadingSlipSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonChangedMeterPreviousReadSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerChangedMeterPreviousReadYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerChangedMeterPreviousReadMonth;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonSummaryPulledOutMetersSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryPulledOutMetersYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryPulledOutMetersMonth;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAccountsSuddenIncDecConsumptionSearch;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonSummaryReceivedMetersSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryReceivedMetersTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryReceivedMetersFrom;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button buttonSummaryDisposedMetersSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryDisposedMetersTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerSummaryDisposedMetersFrom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReadingSlip;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReadBillSOA;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMeterReaderAccomplishment;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountsSuddenIncDecConsumption;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccountsMinimumConsumption;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerUnreadMeters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxReadingSlipBook;
        private System.Windows.Forms.ComboBox comboBoxReadingSlipZone;
        private System.Windows.Forms.ComboBox comboBoxReadingSlipBillingMonth;
        private System.Windows.Forms.BindingSource ReadingSlipBindingSource;
        private DataSetMeterReadingReports DataSetMeterReadingReports;
        private System.Windows.Forms.ComboBox comboBoxAccountsSuddenIncDecConsumptionBook;
        private System.Windows.Forms.ComboBox comboBoxAccountsSuddenIncDecConsumptionZone;
        private System.Windows.Forms.ComboBox comboBoxAccountsSuddenIncDecConsumptionBillingMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownAccountsSuddenIncDecConsumptionChange;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource AccountsSuddenIncDecConsumptionBindingSource;
    }
}