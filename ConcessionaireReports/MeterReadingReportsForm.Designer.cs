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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReadingSlipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMeterReadingReports = new ConcessionaireReports.DataSetMeterReadingReports();
            this.MeterReaderAccomplishmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountsSuddenIncDecConsumptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountsMinimumConsumptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnreadMetersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonMeterReaderAccomplishmentSearch = new System.Windows.Forms.Button();
            this.comboBoxMeterReaderAccomplishmentBillingMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewerMeterReaderAccomplishment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDownAccountsSuddenIncDecConsumptionChange = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAccountsSuddenIncDecConsumptionBook = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountsSuddenIncDecConsumptionZone = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.reportViewerAccountsSuddenIncDecConsumption = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAccountsSuddenIncDecConsumptionSearch = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBoxAccountsMinimumConsumptionBook = new System.Windows.Forms.ComboBox();
            this.reportViewerAccountsMinimumConsumption = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxAccountsMinimumConsumptionZone = new System.Windows.Forms.ComboBox();
            this.buttonAccountsMinimumConsumptionSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountsMinimumConsumptionBillingMonth = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.comboBoxUnreadMetersBook = new System.Windows.Forms.ComboBox();
            this.comboBoxUnreadMetersZone = new System.Windows.Forms.ComboBox();
            this.buttonUnreadMetersSearch = new System.Windows.Forms.Button();
            this.comboBoxUnreadMetersBillingMonth = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.reportViewerUnreadMeters = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ReadingSlipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMeterReadingReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeterReaderAccomplishmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsSuddenIncDecConsumptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsMinimumConsumptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnreadMetersBindingSource)).BeginInit();
            this.tabControlMeterReadingReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccountsSuddenIncDecConsumptionChange)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
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
            // MeterReaderAccomplishmentBindingSource
            // 
            this.MeterReaderAccomplishmentBindingSource.DataMember = "MeterReaderAccomplishment";
            this.MeterReaderAccomplishmentBindingSource.DataSource = this.DataSetMeterReadingReports;
            // 
            // AccountsSuddenIncDecConsumptionBindingSource
            // 
            this.AccountsSuddenIncDecConsumptionBindingSource.DataMember = "AccountsSuddenIncDecConsumption";
            this.AccountsSuddenIncDecConsumptionBindingSource.DataSource = this.DataSetMeterReadingReports;
            // 
            // AccountsMinimumConsumptionBindingSource
            // 
            this.AccountsMinimumConsumptionBindingSource.DataMember = "AccountsMinimumConsumption";
            this.AccountsMinimumConsumptionBindingSource.DataSource = this.DataSetMeterReadingReports;
            // 
            // UnreadMetersBindingSource
            // 
            this.UnreadMetersBindingSource.DataMember = "UnreadMeters";
            this.UnreadMetersBindingSource.DataSource = this.DataSetMeterReadingReports;
            // 
            // tabControlMeterReadingReports
            // 
            this.tabControlMeterReadingReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMeterReadingReports.Controls.Add(this.tabPage1);
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
            this.comboBoxReadingSlipBook.Location = new System.Drawing.Point(539, 13);
            this.comboBoxReadingSlipBook.Name = "comboBoxReadingSlipBook";
            this.comboBoxReadingSlipBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxReadingSlipBook.TabIndex = 37;
            // 
            // comboBoxReadingSlipZone
            // 
            this.comboBoxReadingSlipZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadingSlipZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadingSlipZone.FormattingEnabled = true;
            this.comboBoxReadingSlipZone.Location = new System.Drawing.Point(377, 13);
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
            this.comboBoxReadingSlipBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxReadingSlipBillingMonth.Name = "comboBoxReadingSlipBillingMonth";
            this.comboBoxReadingSlipBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxReadingSlipBillingMonth.TabIndex = 35;
            // 
            // reportViewerReadingSlip
            // 
            reportDataSource7.Name = "DataSetMeterReadingReports";
            reportDataSource7.Value = this.ReadingSlipBindingSource;
            this.reportViewerReadingSlip.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewerReadingSlip.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.MeterReadingReports.ReportReadingSlip.rdlc";
            this.reportViewerReadingSlip.Location = new System.Drawing.Point(26, 49);
            this.reportViewerReadingSlip.Name = "reportViewerReadingSlip";
            this.reportViewerReadingSlip.ServerReport.BearerToken = null;
            this.reportViewerReadingSlip.Size = new System.Drawing.Size(944, 481);
            this.reportViewerReadingSlip.TabIndex = 34;
            // 
            // buttonReadingSlipSearch
            // 
            this.buttonReadingSlipSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadingSlipSearch.Location = new System.Drawing.Point(673, 5);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonMeterReaderAccomplishmentSearch);
            this.tabPage3.Controls.Add(this.comboBoxMeterReaderAccomplishmentBillingMonth);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.reportViewerMeterReaderAccomplishment);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Meter Reader Accomplishment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonMeterReaderAccomplishmentSearch
            // 
            this.buttonMeterReaderAccomplishmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeterReaderAccomplishmentSearch.Location = new System.Drawing.Point(348, 5);
            this.buttonMeterReaderAccomplishmentSearch.Name = "buttonMeterReaderAccomplishmentSearch";
            this.buttonMeterReaderAccomplishmentSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonMeterReaderAccomplishmentSearch.TabIndex = 50;
            this.buttonMeterReaderAccomplishmentSearch.Text = "Search";
            this.buttonMeterReaderAccomplishmentSearch.UseVisualStyleBackColor = true;
            this.buttonMeterReaderAccomplishmentSearch.Click += new System.EventHandler(this.buttonMeterReaderAccomplishmentSearch_Click);
            // 
            // comboBoxMeterReaderAccomplishmentBillingMonth
            // 
            this.comboBoxMeterReaderAccomplishmentBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeterReaderAccomplishmentBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMeterReaderAccomplishmentBillingMonth.FormattingEnabled = true;
            this.comboBoxMeterReaderAccomplishmentBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxMeterReaderAccomplishmentBillingMonth.Name = "comboBoxMeterReaderAccomplishmentBillingMonth";
            this.comboBoxMeterReaderAccomplishmentBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxMeterReaderAccomplishmentBillingMonth.TabIndex = 49;
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
            // reportViewerMeterReaderAccomplishment
            // 
            reportDataSource8.Name = "DataSetMeterReadingReports";
            reportDataSource8.Value = this.MeterReaderAccomplishmentBindingSource;
            this.reportViewerMeterReaderAccomplishment.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewerMeterReaderAccomplishment.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.MeterReadingReports.ReportMeterReaderAccomplishment.rd" +
    "lc";
            this.reportViewerMeterReaderAccomplishment.Location = new System.Drawing.Point(26, 49);
            this.reportViewerMeterReaderAccomplishment.Name = "reportViewerMeterReaderAccomplishment";
            this.reportViewerMeterReaderAccomplishment.ServerReport.BearerToken = null;
            this.reportViewerMeterReaderAccomplishment.Size = new System.Drawing.Size(944, 481);
            this.reportViewerMeterReaderAccomplishment.TabIndex = 34;
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
            // numericUpDownAccountsSuddenIncDecConsumptionChange
            // 
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.Location = new System.Drawing.Point(730, 16);
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.Name = "numericUpDownAccountsSuddenIncDecConsumptionChange";
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownAccountsSuddenIncDecConsumptionChange.TabIndex = 44;
            // 
            // comboBoxAccountsSuddenIncDecConsumptionBook
            // 
            this.comboBoxAccountsSuddenIncDecConsumptionBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsSuddenIncDecConsumptionBook.FormattingEnabled = true;
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Location = new System.Drawing.Point(539, 13);
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Name = "comboBoxAccountsSuddenIncDecConsumptionBook";
            this.comboBoxAccountsSuddenIncDecConsumptionBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxAccountsSuddenIncDecConsumptionBook.TabIndex = 43;
            // 
            // comboBoxAccountsSuddenIncDecConsumptionZone
            // 
            this.comboBoxAccountsSuddenIncDecConsumptionZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsSuddenIncDecConsumptionZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsSuddenIncDecConsumptionZone.FormattingEnabled = true;
            this.comboBoxAccountsSuddenIncDecConsumptionZone.Location = new System.Drawing.Point(377, 13);
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
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Name = "comboBoxAccountsSuddenIncDecConsumptionBillingMonth";
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxAccountsSuddenIncDecConsumptionBillingMonth.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(648, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "% Change: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Book:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(329, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Zone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Billing Month:";
            // 
            // reportViewerAccountsSuddenIncDecConsumption
            // 
            reportDataSource6.Name = "DataSetMeterReadingReports";
            reportDataSource6.Value = this.AccountsSuddenIncDecConsumptionBindingSource;
            this.reportViewerAccountsSuddenIncDecConsumption.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerAccountsSuddenIncDecConsumption.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.MeterReadingReports.ReportAccountsSuddenIncDecConsumpt" +
    "ion.rdlc";
            this.reportViewerAccountsSuddenIncDecConsumption.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAccountsSuddenIncDecConsumption.Name = "reportViewerAccountsSuddenIncDecConsumption";
            this.reportViewerAccountsSuddenIncDecConsumption.ServerReport.BearerToken = null;
            this.reportViewerAccountsSuddenIncDecConsumption.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAccountsSuddenIncDecConsumption.TabIndex = 34;
            // 
            // buttonAccountsSuddenIncDecConsumptionSearch
            // 
            this.buttonAccountsSuddenIncDecConsumptionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountsSuddenIncDecConsumptionSearch.Location = new System.Drawing.Point(826, 5);
            this.buttonAccountsSuddenIncDecConsumptionSearch.Name = "buttonAccountsSuddenIncDecConsumptionSearch";
            this.buttonAccountsSuddenIncDecConsumptionSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountsSuddenIncDecConsumptionSearch.TabIndex = 25;
            this.buttonAccountsSuddenIncDecConsumptionSearch.Text = "Search";
            this.buttonAccountsSuddenIncDecConsumptionSearch.UseVisualStyleBackColor = true;
            this.buttonAccountsSuddenIncDecConsumptionSearch.Click += new System.EventHandler(this.buttonAccountsSuddenIncDecConsumptionSearch_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBoxAccountsMinimumConsumptionBook);
            this.tabPage5.Controls.Add(this.reportViewerAccountsMinimumConsumption);
            this.tabPage5.Controls.Add(this.comboBoxAccountsMinimumConsumptionZone);
            this.tabPage5.Controls.Add(this.buttonAccountsMinimumConsumptionSearch);
            this.tabPage5.Controls.Add(this.comboBoxAccountsMinimumConsumptionBillingMonth);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(992, 555);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "List of Accounts with Minimum Consumption";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccountsMinimumConsumptionBook
            // 
            this.comboBoxAccountsMinimumConsumptionBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsMinimumConsumptionBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsMinimumConsumptionBook.FormattingEnabled = true;
            this.comboBoxAccountsMinimumConsumptionBook.Location = new System.Drawing.Point(539, 13);
            this.comboBoxAccountsMinimumConsumptionBook.Name = "comboBoxAccountsMinimumConsumptionBook";
            this.comboBoxAccountsMinimumConsumptionBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxAccountsMinimumConsumptionBook.TabIndex = 49;
            // 
            // reportViewerAccountsMinimumConsumption
            // 
            reportDataSource9.Name = "DataSetMeterReadingReports";
            reportDataSource9.Value = this.AccountsMinimumConsumptionBindingSource;
            this.reportViewerAccountsMinimumConsumption.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewerAccountsMinimumConsumption.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.MeterReadingReports.ReportAccountsMinimumConsumption.r" +
    "dlc";
            this.reportViewerAccountsMinimumConsumption.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAccountsMinimumConsumption.Name = "reportViewerAccountsMinimumConsumption";
            this.reportViewerAccountsMinimumConsumption.ServerReport.BearerToken = null;
            this.reportViewerAccountsMinimumConsumption.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAccountsMinimumConsumption.TabIndex = 34;
            // 
            // comboBoxAccountsMinimumConsumptionZone
            // 
            this.comboBoxAccountsMinimumConsumptionZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsMinimumConsumptionZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsMinimumConsumptionZone.FormattingEnabled = true;
            this.comboBoxAccountsMinimumConsumptionZone.Location = new System.Drawing.Point(377, 13);
            this.comboBoxAccountsMinimumConsumptionZone.Name = "comboBoxAccountsMinimumConsumptionZone";
            this.comboBoxAccountsMinimumConsumptionZone.Size = new System.Drawing.Size(56, 24);
            this.comboBoxAccountsMinimumConsumptionZone.TabIndex = 48;
            this.comboBoxAccountsMinimumConsumptionZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccountsMinimumConsumptionZone_SelectedIndexChanged);
            // 
            // buttonAccountsMinimumConsumptionSearch
            // 
            this.buttonAccountsMinimumConsumptionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountsMinimumConsumptionSearch.Location = new System.Drawing.Point(650, 5);
            this.buttonAccountsMinimumConsumptionSearch.Name = "buttonAccountsMinimumConsumptionSearch";
            this.buttonAccountsMinimumConsumptionSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountsMinimumConsumptionSearch.TabIndex = 16;
            this.buttonAccountsMinimumConsumptionSearch.Text = "Search";
            this.buttonAccountsMinimumConsumptionSearch.UseVisualStyleBackColor = true;
            this.buttonAccountsMinimumConsumptionSearch.Click += new System.EventHandler(this.buttonAccountsMinimumConsumptionSearch_Click);
            // 
            // comboBoxAccountsMinimumConsumptionBillingMonth
            // 
            this.comboBoxAccountsMinimumConsumptionBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountsMinimumConsumptionBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountsMinimumConsumptionBillingMonth.FormattingEnabled = true;
            this.comboBoxAccountsMinimumConsumptionBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxAccountsMinimumConsumptionBillingMonth.Name = "comboBoxAccountsMinimumConsumptionBillingMonth";
            this.comboBoxAccountsMinimumConsumptionBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxAccountsMinimumConsumptionBillingMonth.TabIndex = 47;
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
            this.tabPage6.Controls.Add(this.comboBoxUnreadMetersBook);
            this.tabPage6.Controls.Add(this.comboBoxUnreadMetersZone);
            this.tabPage6.Controls.Add(this.buttonUnreadMetersSearch);
            this.tabPage6.Controls.Add(this.comboBoxUnreadMetersBillingMonth);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.reportViewerUnreadMeters);
            this.tabPage6.Location = new System.Drawing.Point(184, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(992, 555);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "List of Unread Meters";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // comboBoxUnreadMetersBook
            // 
            this.comboBoxUnreadMetersBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnreadMetersBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnreadMetersBook.FormattingEnabled = true;
            this.comboBoxUnreadMetersBook.Location = new System.Drawing.Point(539, 13);
            this.comboBoxUnreadMetersBook.Name = "comboBoxUnreadMetersBook";
            this.comboBoxUnreadMetersBook.Size = new System.Drawing.Size(56, 24);
            this.comboBoxUnreadMetersBook.TabIndex = 56;
            // 
            // comboBoxUnreadMetersZone
            // 
            this.comboBoxUnreadMetersZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnreadMetersZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnreadMetersZone.FormattingEnabled = true;
            this.comboBoxUnreadMetersZone.Location = new System.Drawing.Point(377, 13);
            this.comboBoxUnreadMetersZone.Name = "comboBoxUnreadMetersZone";
            this.comboBoxUnreadMetersZone.Size = new System.Drawing.Size(56, 24);
            this.comboBoxUnreadMetersZone.TabIndex = 55;
            this.comboBoxUnreadMetersZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnreadMetersZone_SelectedIndexChanged);
            // 
            // buttonUnreadMetersSearch
            // 
            this.buttonUnreadMetersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnreadMetersSearch.Location = new System.Drawing.Point(650, 5);
            this.buttonUnreadMetersSearch.Name = "buttonUnreadMetersSearch";
            this.buttonUnreadMetersSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonUnreadMetersSearch.TabIndex = 50;
            this.buttonUnreadMetersSearch.Text = "Search";
            this.buttonUnreadMetersSearch.UseVisualStyleBackColor = true;
            this.buttonUnreadMetersSearch.Click += new System.EventHandler(this.buttonUnreadMetersSearch_Click);
            // 
            // comboBoxUnreadMetersBillingMonth
            // 
            this.comboBoxUnreadMetersBillingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnreadMetersBillingMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnreadMetersBillingMonth.FormattingEnabled = true;
            this.comboBoxUnreadMetersBillingMonth.Location = new System.Drawing.Point(115, 13);
            this.comboBoxUnreadMetersBillingMonth.Name = "comboBoxUnreadMetersBillingMonth";
            this.comboBoxUnreadMetersBillingMonth.Size = new System.Drawing.Size(167, 24);
            this.comboBoxUnreadMetersBillingMonth.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Billing Month:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(490, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Book:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(329, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 52;
            this.label17.Text = "Zone:";
            // 
            // reportViewerUnreadMeters
            // 
            reportDataSource10.Name = "DataSetMeterReadingReports";
            reportDataSource10.Value = this.UnreadMetersBindingSource;
            this.reportViewerUnreadMeters.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewerUnreadMeters.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.MeterReadingReports.ReportUnreadMeters.rdlc";
            this.reportViewerUnreadMeters.Location = new System.Drawing.Point(26, 49);
            this.reportViewerUnreadMeters.Name = "reportViewerUnreadMeters";
            this.reportViewerUnreadMeters.ServerReport.BearerToken = null;
            this.reportViewerUnreadMeters.Size = new System.Drawing.Size(944, 481);
            this.reportViewerUnreadMeters.TabIndex = 35;
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
            ((System.ComponentModel.ISupportInitialize)(this.MeterReaderAccomplishmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsSuddenIncDecConsumptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsMinimumConsumptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnreadMetersBindingSource)).EndInit();
            this.tabControlMeterReadingReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccountsSuddenIncDecConsumptionChange)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMeterReadingReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonReadingSlipSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAccountsSuddenIncDecConsumptionSearch;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonAccountsMinimumConsumptionSearch;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReadingSlip;
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
        private System.Windows.Forms.ComboBox comboBoxAccountsMinimumConsumptionBook;
        private System.Windows.Forms.ComboBox comboBoxAccountsMinimumConsumptionZone;
        private System.Windows.Forms.ComboBox comboBoxAccountsMinimumConsumptionBillingMonth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource AccountsMinimumConsumptionBindingSource;
        private System.Windows.Forms.ComboBox comboBoxUnreadMetersBook;
        private System.Windows.Forms.ComboBox comboBoxUnreadMetersZone;
        private System.Windows.Forms.Button buttonUnreadMetersSearch;
        private System.Windows.Forms.ComboBox comboBoxUnreadMetersBillingMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource UnreadMetersBindingSource;
        private System.Windows.Forms.Button buttonMeterReaderAccomplishmentSearch;
        private System.Windows.Forms.ComboBox comboBoxMeterReaderAccomplishmentBillingMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource MeterReaderAccomplishmentBindingSource;
    }
}