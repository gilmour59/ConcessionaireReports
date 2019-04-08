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
            this.tabControlReceivablesReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerAgingAccountCutOff = new System.Windows.Forms.DateTimePicker();
            this.reportViewerAgingAccount = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAgingAccountSearch = new System.Windows.Forms.Button();
            this.comboBoxAgingAccountStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxAgingAccountBook = new System.Windows.Forms.ComboBox();
            this.comboBoxAgingAccountZone = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePickerAgingBookCutOff = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewerAgingBook = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAgingBookSearch = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePickerDetailedListCutOff = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDetailedListBook = new System.Windows.Forms.ComboBox();
            this.comboBoxDetailedListZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reportViewerDetailedList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonDetailedListSearch = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePickerReceivablesAccountCutOff = new System.Windows.Forms.DateTimePicker();
            this.comboBoxReceivablesAccountBook = new System.Windows.Forms.ComboBox();
            this.comboBoxReceivablesAccountZone = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.reportViewerReceivablesAccount = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonReceivablesAccountSearch = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dateTimePickerDemandLetterCutOff = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDemandLetterBook = new System.Windows.Forms.ComboBox();
            this.comboBoxDemandLetterZone = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonDemandLetterSearch = new System.Windows.Forms.Button();
            this.reportViewerDemandLetter = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.numericUpDownDelinquentLimit = new System.Windows.Forms.NumericUpDown();
            this.reportViewerDelinquent = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonDelinquentSearch = new System.Windows.Forms.Button();
            this.comboBoxDelinquentStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerDelinquentCutOff = new System.Windows.Forms.DateTimePicker();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dateTimePickerOtherReceivablesCutOff = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOtherReceivablesBook = new System.Windows.Forms.ComboBox();
            this.comboBoxOtherReceivablesZone = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonOtherReceivablesSearch = new System.Windows.Forms.Button();
            this.reportViewerOtherReceivables = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControlReceivablesReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelinquentLimit)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReceivablesReports
            // 
            this.tabControlReceivablesReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlReceivablesReports.Controls.Add(this.tabPage1);
            this.tabControlReceivablesReports.Controls.Add(this.tabPage2);
            this.tabControlReceivablesReports.Controls.Add(this.tabPage3);
            this.tabControlReceivablesReports.Controls.Add(this.tabPage4);
            this.tabControlReceivablesReports.Controls.Add(this.tabPage5);
            this.tabControlReceivablesReports.Controls.Add(this.tabPage6);
            this.tabControlReceivablesReports.Controls.Add(this.tabPage7);
            this.tabControlReceivablesReports.ItemSize = new System.Drawing.Size(70, 150);
            this.tabControlReceivablesReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlReceivablesReports.Multiline = true;
            this.tabControlReceivablesReports.Name = "tabControlReceivablesReports";
            this.tabControlReceivablesReports.SelectedIndex = 0;
            this.tabControlReceivablesReports.Size = new System.Drawing.Size(1152, 563);
            this.tabControlReceivablesReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlReceivablesReports.TabIndex = 1;
            this.tabControlReceivablesReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlConcessionaireReports_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerAgingAccountCutOff);
            this.tabPage1.Controls.Add(this.reportViewerAgingAccount);
            this.tabPage1.Controls.Add(this.buttonAgingAccountSearch);
            this.tabPage1.Controls.Add(this.comboBoxAgingAccountStatus);
            this.tabPage1.Controls.Add(this.comboBoxAgingAccountBook);
            this.tabPage1.Controls.Add(this.comboBoxAgingAccountZone);
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
            // dateTimePickerAgingAccountCutOff
            // 
            this.dateTimePickerAgingAccountCutOff.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerAgingAccountCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAgingAccountCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAgingAccountCutOff.Location = new System.Drawing.Point(406, 15);
            this.dateTimePickerAgingAccountCutOff.Name = "dateTimePickerAgingAccountCutOff";
            this.dateTimePickerAgingAccountCutOff.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerAgingAccountCutOff.TabIndex = 4;
            // 
            // reportViewerAgingAccount
            // 
            reportDataSource1.Name = "DataSetConcessionaireReports";
            reportDataSource1.Value = null;
            this.reportViewerAgingAccount.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAgingAccount.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountPerBook.rdlc";
            this.reportViewerAgingAccount.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAgingAccount.Name = "reportViewerAgingAccount";
            this.reportViewerAgingAccount.ServerReport.BearerToken = null;
            this.reportViewerAgingAccount.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAgingAccount.TabIndex = 3;
            // 
            // buttonAgingAccountSearch
            // 
            this.buttonAgingAccountSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgingAccountSearch.Location = new System.Drawing.Point(707, 5);
            this.buttonAgingAccountSearch.Name = "buttonAgingAccountSearch";
            this.buttonAgingAccountSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAgingAccountSearch.TabIndex = 2;
            this.buttonAgingAccountSearch.Text = "Search";
            this.buttonAgingAccountSearch.UseVisualStyleBackColor = true;
            this.buttonAgingAccountSearch.Click += new System.EventHandler(this.buttonAgingAccountSearch_Click);
            // 
            // comboBoxAgingAccountStatus
            // 
            this.comboBoxAgingAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgingAccountStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAgingAccountStatus.FormattingEnabled = true;
            this.comboBoxAgingAccountStatus.Location = new System.Drawing.Point(571, 15);
            this.comboBoxAgingAccountStatus.Name = "comboBoxAgingAccountStatus";
            this.comboBoxAgingAccountStatus.Size = new System.Drawing.Size(96, 24);
            this.comboBoxAgingAccountStatus.TabIndex = 1;
            // 
            // comboBoxAgingAccountBook
            // 
            this.comboBoxAgingAccountBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgingAccountBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAgingAccountBook.FormattingEnabled = true;
            this.comboBoxAgingAccountBook.Location = new System.Drawing.Point(215, 15);
            this.comboBoxAgingAccountBook.Name = "comboBoxAgingAccountBook";
            this.comboBoxAgingAccountBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxAgingAccountBook.TabIndex = 1;
            // 
            // comboBoxAgingAccountZone
            // 
            this.comboBoxAgingAccountZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgingAccountZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAgingAccountZone.FormattingEnabled = true;
            this.comboBoxAgingAccountZone.Location = new System.Drawing.Point(69, 15);
            this.comboBoxAgingAccountZone.Name = "comboBoxAgingAccountZone";
            this.comboBoxAgingAccountZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxAgingAccountZone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cut-Off Date:";
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
            this.tabPage2.Controls.Add(this.dateTimePickerAgingBookCutOff);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.reportViewerAgingBook);
            this.tabPage2.Controls.Add(this.buttonAgingBookSearch);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accounts Receivable Aging Summary Per Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAgingBookCutOff
            // 
            this.dateTimePickerAgingBookCutOff.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerAgingBookCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAgingBookCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAgingBookCutOff.Location = new System.Drawing.Point(111, 13);
            this.dateTimePickerAgingBookCutOff.Name = "dateTimePickerAgingBookCutOff";
            this.dateTimePickerAgingBookCutOff.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerAgingBookCutOff.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cut-Off Date:";
            // 
            // reportViewerAgingBook
            // 
            reportDataSource2.Name = "DataSetConcessionaireReports";
            reportDataSource2.Value = null;
            this.reportViewerAgingBook.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerAgingBook.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountPerBarangay.rdlc";
            this.reportViewerAgingBook.Location = new System.Drawing.Point(26, 49);
            this.reportViewerAgingBook.Name = "reportViewerAgingBook";
            this.reportViewerAgingBook.ServerReport.BearerToken = null;
            this.reportViewerAgingBook.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAgingBook.TabIndex = 10;
            // 
            // buttonAgingBookSearch
            // 
            this.buttonAgingBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgingBookSearch.Location = new System.Drawing.Point(292, 5);
            this.buttonAgingBookSearch.Name = "buttonAgingBookSearch";
            this.buttonAgingBookSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAgingBookSearch.TabIndex = 9;
            this.buttonAgingBookSearch.Text = "Search";
            this.buttonAgingBookSearch.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePickerDetailedListCutOff);
            this.tabPage3.Controls.Add(this.comboBoxDetailedListBook);
            this.tabPage3.Controls.Add(this.comboBoxDetailedListZone);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.reportViewerDetailedList);
            this.tabPage3.Controls.Add(this.buttonDetailedListSearch);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(994, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detailed List of Receivables Per Account";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDetailedListCutOff
            // 
            this.dateTimePickerDetailedListCutOff.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDetailedListCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDetailedListCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDetailedListCutOff.Location = new System.Drawing.Point(406, 13);
            this.dateTimePickerDetailedListCutOff.Name = "dateTimePickerDetailedListCutOff";
            this.dateTimePickerDetailedListCutOff.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerDetailedListCutOff.TabIndex = 21;
            // 
            // comboBoxDetailedListBook
            // 
            this.comboBoxDetailedListBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDetailedListBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDetailedListBook.FormattingEnabled = true;
            this.comboBoxDetailedListBook.Location = new System.Drawing.Point(215, 13);
            this.comboBoxDetailedListBook.Name = "comboBoxDetailedListBook";
            this.comboBoxDetailedListBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxDetailedListBook.TabIndex = 19;
            // 
            // comboBoxDetailedListZone
            // 
            this.comboBoxDetailedListZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDetailedListZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDetailedListZone.FormattingEnabled = true;
            this.comboBoxDetailedListZone.Location = new System.Drawing.Point(69, 13);
            this.comboBoxDetailedListZone.Name = "comboBoxDetailedListZone";
            this.comboBoxDetailedListZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxDetailedListZone.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cut-Off Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Book:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Zone:";
            // 
            // reportViewerDetailedList
            // 
            reportDataSource3.Name = "DataSetConcessionaireReports";
            reportDataSource3.Value = null;
            this.reportViewerDetailedList.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerDetailedList.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountPerClassification.r" +
    "dlc";
            this.reportViewerDetailedList.Location = new System.Drawing.Point(26, 49);
            this.reportViewerDetailedList.Name = "reportViewerDetailedList";
            this.reportViewerDetailedList.ServerReport.BearerToken = null;
            this.reportViewerDetailedList.Size = new System.Drawing.Size(944, 481);
            this.reportViewerDetailedList.TabIndex = 15;
            // 
            // buttonDetailedListSearch
            // 
            this.buttonDetailedListSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetailedListSearch.Location = new System.Drawing.Point(581, 5);
            this.buttonDetailedListSearch.Name = "buttonDetailedListSearch";
            this.buttonDetailedListSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonDetailedListSearch.TabIndex = 14;
            this.buttonDetailedListSearch.Text = "Search";
            this.buttonDetailedListSearch.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dateTimePickerReceivablesAccountCutOff);
            this.tabPage4.Controls.Add(this.comboBoxReceivablesAccountBook);
            this.tabPage4.Controls.Add(this.comboBoxReceivablesAccountZone);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.reportViewerReceivablesAccount);
            this.tabPage4.Controls.Add(this.buttonReceivablesAccountSearch);
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(994, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Summary of Receivables Per Account";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReceivablesAccountCutOff
            // 
            this.dateTimePickerReceivablesAccountCutOff.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerReceivablesAccountCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReceivablesAccountCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReceivablesAccountCutOff.Location = new System.Drawing.Point(407, 13);
            this.dateTimePickerReceivablesAccountCutOff.Name = "dateTimePickerReceivablesAccountCutOff";
            this.dateTimePickerReceivablesAccountCutOff.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerReceivablesAccountCutOff.TabIndex = 29;
            // 
            // comboBoxReceivablesAccountBook
            // 
            this.comboBoxReceivablesAccountBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReceivablesAccountBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReceivablesAccountBook.FormattingEnabled = true;
            this.comboBoxReceivablesAccountBook.Location = new System.Drawing.Point(216, 13);
            this.comboBoxReceivablesAccountBook.Name = "comboBoxReceivablesAccountBook";
            this.comboBoxReceivablesAccountBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxReceivablesAccountBook.TabIndex = 27;
            // 
            // comboBoxReceivablesAccountZone
            // 
            this.comboBoxReceivablesAccountZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReceivablesAccountZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReceivablesAccountZone.FormattingEnabled = true;
            this.comboBoxReceivablesAccountZone.Location = new System.Drawing.Point(70, 13);
            this.comboBoxReceivablesAccountZone.Name = "comboBoxReceivablesAccountZone";
            this.comboBoxReceivablesAccountZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxReceivablesAccountZone.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cut-Off Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(170, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Book:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Zone:";
            // 
            // reportViewerReceivablesAccount
            // 
            reportDataSource4.Name = "DataSetConcessionaireReports";
            reportDataSource4.Value = null;
            this.reportViewerReceivablesAccount.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerReceivablesAccount.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountPerClassification.r" +
    "dlc";
            this.reportViewerReceivablesAccount.Location = new System.Drawing.Point(27, 49);
            this.reportViewerReceivablesAccount.Name = "reportViewerReceivablesAccount";
            this.reportViewerReceivablesAccount.ServerReport.BearerToken = null;
            this.reportViewerReceivablesAccount.Size = new System.Drawing.Size(944, 481);
            this.reportViewerReceivablesAccount.TabIndex = 23;
            // 
            // buttonReceivablesAccountSearch
            // 
            this.buttonReceivablesAccountSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceivablesAccountSearch.Location = new System.Drawing.Point(582, 5);
            this.buttonReceivablesAccountSearch.Name = "buttonReceivablesAccountSearch";
            this.buttonReceivablesAccountSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonReceivablesAccountSearch.TabIndex = 22;
            this.buttonReceivablesAccountSearch.Text = "Search";
            this.buttonReceivablesAccountSearch.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dateTimePickerDemandLetterCutOff);
            this.tabPage5.Controls.Add(this.comboBoxDemandLetterBook);
            this.tabPage5.Controls.Add(this.comboBoxDemandLetterZone);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.buttonDemandLetterSearch);
            this.tabPage5.Controls.Add(this.reportViewerDemandLetter);
            this.tabPage5.Location = new System.Drawing.Point(154, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(994, 555);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Demand Letter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDemandLetterCutOff
            // 
            this.dateTimePickerDemandLetterCutOff.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDemandLetterCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDemandLetterCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDemandLetterCutOff.Location = new System.Drawing.Point(406, 16);
            this.dateTimePickerDemandLetterCutOff.Name = "dateTimePickerDemandLetterCutOff";
            this.dateTimePickerDemandLetterCutOff.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerDemandLetterCutOff.TabIndex = 36;
            // 
            // comboBoxDemandLetterBook
            // 
            this.comboBoxDemandLetterBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDemandLetterBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDemandLetterBook.FormattingEnabled = true;
            this.comboBoxDemandLetterBook.Location = new System.Drawing.Point(215, 16);
            this.comboBoxDemandLetterBook.Name = "comboBoxDemandLetterBook";
            this.comboBoxDemandLetterBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxDemandLetterBook.TabIndex = 34;
            // 
            // comboBoxDemandLetterZone
            // 
            this.comboBoxDemandLetterZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDemandLetterZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDemandLetterZone.FormattingEnabled = true;
            this.comboBoxDemandLetterZone.Location = new System.Drawing.Point(69, 16);
            this.comboBoxDemandLetterZone.Name = "comboBoxDemandLetterZone";
            this.comboBoxDemandLetterZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxDemandLetterZone.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cut-Off Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Book:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Zone:";
            // 
            // buttonDemandLetterSearch
            // 
            this.buttonDemandLetterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemandLetterSearch.Location = new System.Drawing.Point(581, 8);
            this.buttonDemandLetterSearch.Name = "buttonDemandLetterSearch";
            this.buttonDemandLetterSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonDemandLetterSearch.TabIndex = 30;
            this.buttonDemandLetterSearch.Text = "Search";
            this.buttonDemandLetterSearch.UseVisualStyleBackColor = true;
            // 
            // reportViewerDemandLetter
            // 
            reportDataSource5.Name = "DataSetConcessionaireReports";
            reportDataSource5.Value = null;
            this.reportViewerDemandLetter.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerDemandLetter.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportNewConnectionSummary.rdlc";
            this.reportViewerDemandLetter.Location = new System.Drawing.Point(26, 49);
            this.reportViewerDemandLetter.Name = "reportViewerDemandLetter";
            this.reportViewerDemandLetter.ServerReport.BearerToken = null;
            this.reportViewerDemandLetter.Size = new System.Drawing.Size(944, 481);
            this.reportViewerDemandLetter.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.numericUpDownDelinquentLimit);
            this.tabPage6.Controls.Add(this.reportViewerDelinquent);
            this.tabPage6.Controls.Add(this.buttonDelinquentSearch);
            this.tabPage6.Controls.Add(this.comboBoxDelinquentStatus);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.dateTimePickerDelinquentCutOff);
            this.tabPage6.Location = new System.Drawing.Point(154, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(994, 555);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Top Delinquent Accounts";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDelinquentLimit
            // 
            this.numericUpDownDelinquentLimit.Location = new System.Drawing.Point(285, 19);
            this.numericUpDownDelinquentLimit.Name = "numericUpDownDelinquentLimit";
            this.numericUpDownDelinquentLimit.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownDelinquentLimit.TabIndex = 18;
            // 
            // reportViewerDelinquent
            // 
            reportDataSource6.Name = "DataSetConcessionaireReports";
            reportDataSource6.Value = null;
            this.reportViewerDelinquent.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerDelinquent.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportAccountByStatus.rdlc";
            this.reportViewerDelinquent.Location = new System.Drawing.Point(26, 49);
            this.reportViewerDelinquent.Name = "reportViewerDelinquent";
            this.reportViewerDelinquent.ServerReport.BearerToken = null;
            this.reportViewerDelinquent.Size = new System.Drawing.Size(944, 481);
            this.reportViewerDelinquent.TabIndex = 17;
            // 
            // buttonDelinquentSearch
            // 
            this.buttonDelinquentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelinquentSearch.Location = new System.Drawing.Point(570, 8);
            this.buttonDelinquentSearch.Name = "buttonDelinquentSearch";
            this.buttonDelinquentSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonDelinquentSearch.TabIndex = 16;
            this.buttonDelinquentSearch.Text = "Search";
            this.buttonDelinquentSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxDelinquentStatus
            // 
            this.comboBoxDelinquentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelinquentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDelinquentStatus.FormattingEnabled = true;
            this.comboBoxDelinquentStatus.Location = new System.Drawing.Point(379, 16);
            this.comboBoxDelinquentStatus.Name = "comboBoxDelinquentStatus";
            this.comboBoxDelinquentStatus.Size = new System.Drawing.Size(138, 24);
            this.comboBoxDelinquentStatus.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(241, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Limit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cut Off:";
            // 
            // dateTimePickerDelinquentCutOff
            // 
            this.dateTimePickerDelinquentCutOff.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDelinquentCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDelinquentCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDelinquentCutOff.Location = new System.Drawing.Point(78, 16);
            this.dateTimePickerDelinquentCutOff.Name = "dateTimePickerDelinquentCutOff";
            this.dateTimePickerDelinquentCutOff.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerDelinquentCutOff.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dateTimePickerOtherReceivablesCutOff);
            this.tabPage7.Controls.Add(this.comboBoxOtherReceivablesBook);
            this.tabPage7.Controls.Add(this.comboBoxOtherReceivablesZone);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Controls.Add(this.buttonOtherReceivablesSearch);
            this.tabPage7.Controls.Add(this.reportViewerOtherReceivables);
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(994, 555);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Summary of Other Receivables";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerOtherReceivablesCutOff
            // 
            this.dateTimePickerOtherReceivablesCutOff.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerOtherReceivablesCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOtherReceivablesCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOtherReceivablesCutOff.Location = new System.Drawing.Point(406, 16);
            this.dateTimePickerOtherReceivablesCutOff.Name = "dateTimePickerOtherReceivablesCutOff";
            this.dateTimePickerOtherReceivablesCutOff.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerOtherReceivablesCutOff.TabIndex = 43;
            // 
            // comboBoxOtherReceivablesBook
            // 
            this.comboBoxOtherReceivablesBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOtherReceivablesBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOtherReceivablesBook.FormattingEnabled = true;
            this.comboBoxOtherReceivablesBook.Location = new System.Drawing.Point(215, 16);
            this.comboBoxOtherReceivablesBook.Name = "comboBoxOtherReceivablesBook";
            this.comboBoxOtherReceivablesBook.Size = new System.Drawing.Size(55, 24);
            this.comboBoxOtherReceivablesBook.TabIndex = 41;
            // 
            // comboBoxOtherReceivablesZone
            // 
            this.comboBoxOtherReceivablesZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOtherReceivablesZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOtherReceivablesZone.FormattingEnabled = true;
            this.comboBoxOtherReceivablesZone.Location = new System.Drawing.Point(69, 16);
            this.comboBoxOtherReceivablesZone.Name = "comboBoxOtherReceivablesZone";
            this.comboBoxOtherReceivablesZone.Size = new System.Drawing.Size(50, 24);
            this.comboBoxOtherReceivablesZone.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cut-Off Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(169, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Book:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "Zone:";
            // 
            // buttonOtherReceivablesSearch
            // 
            this.buttonOtherReceivablesSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtherReceivablesSearch.Location = new System.Drawing.Point(581, 8);
            this.buttonOtherReceivablesSearch.Name = "buttonOtherReceivablesSearch";
            this.buttonOtherReceivablesSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonOtherReceivablesSearch.TabIndex = 37;
            this.buttonOtherReceivablesSearch.Text = "Search";
            this.buttonOtherReceivablesSearch.UseVisualStyleBackColor = true;
            // 
            // reportViewerOtherReceivables
            // 
            reportDataSource7.Name = "DataSetConcessionaireReports";
            reportDataSource7.Value = null;
            this.reportViewerOtherReceivables.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewerOtherReceivables.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.ConcessionaireReports.ReportSeniorCitizenAccounts.rdlc" +
    "";
            this.reportViewerOtherReceivables.Location = new System.Drawing.Point(26, 49);
            this.reportViewerOtherReceivables.Name = "reportViewerOtherReceivables";
            this.reportViewerOtherReceivables.ServerReport.BearerToken = null;
            this.reportViewerOtherReceivables.Size = new System.Drawing.Size(944, 481);
            this.reportViewerOtherReceivables.TabIndex = 7;
            // 
            // ReceivablesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 587);
            this.Controls.Add(this.tabControlReceivablesReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceivablesReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receivables Reports";
            this.Load += new System.EventHandler(this.ReceivablesReportsForm_Load);
            this.tabControlReceivablesReports.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelinquentLimit)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReceivablesReports;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAgingAccount;
        private System.Windows.Forms.Button buttonAgingAccountSearch;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAgingBook;
        private System.Windows.Forms.Button buttonAgingBookSearch;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDetailedList;
        private System.Windows.Forms.Button buttonDetailedListSearch;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDemandLetter;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDelinquent;
        private System.Windows.Forms.Button buttonDelinquentSearch;
        private System.Windows.Forms.ComboBox comboBoxDelinquentStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelinquentCutOff;
        private System.Windows.Forms.TabPage tabPage7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOtherReceivables;
        private System.Windows.Forms.DateTimePicker dateTimePickerAgingAccountCutOff;
        private System.Windows.Forms.ComboBox comboBoxAgingAccountStatus;
        private System.Windows.Forms.ComboBox comboBoxAgingAccountBook;
        private System.Windows.Forms.ComboBox comboBoxAgingAccountZone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAgingBookCutOff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDetailedListCutOff;
        private System.Windows.Forms.ComboBox comboBoxDetailedListBook;
        private System.Windows.Forms.ComboBox comboBoxDetailedListZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerReceivablesAccountCutOff;
        private System.Windows.Forms.ComboBox comboBoxReceivablesAccountBook;
        private System.Windows.Forms.ComboBox comboBoxReceivablesAccountZone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReceivablesAccount;
        private System.Windows.Forms.Button buttonReceivablesAccountSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerDemandLetterCutOff;
        private System.Windows.Forms.ComboBox comboBoxDemandLetterBook;
        private System.Windows.Forms.ComboBox comboBoxDemandLetterZone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonDemandLetterSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownDelinquentLimit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerOtherReceivablesCutOff;
        private System.Windows.Forms.ComboBox comboBoxOtherReceivablesBook;
        private System.Windows.Forms.ComboBox comboBoxOtherReceivablesZone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonOtherReceivablesSearch;
    }
}