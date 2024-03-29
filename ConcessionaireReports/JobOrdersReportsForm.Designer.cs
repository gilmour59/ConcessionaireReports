﻿namespace ConcessionaireReports
{
    partial class JobOrdersReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource16 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobOrdersReportsForm));
            this.JOSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetJobOrdersReports = new ConcessionaireReports.DataSetJobOrdersReports();
            this.JOSummaryWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PendingJOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccomplishedJOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlJobOrdersReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerJobOrderSumFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerJobOrderSumTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonJobOrderSumSearch = new System.Windows.Forms.Button();
            this.reportViewerJobOrderSum = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxJobOrderWorkWork = new System.Windows.Forms.ComboBox();
            this.pictureBoxLoadingJobOrderWork = new System.Windows.Forms.PictureBox();
            this.dateTimePickerJobOrderWorkFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerJobOrderWorkTo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonJobOrderWorkSearch = new System.Windows.Forms.Button();
            this.reportViewerJobOrderWork = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxLoadingPendingJO = new System.Windows.Forms.PictureBox();
            this.dateTimePickerPendingJOAsOf = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPendingJOSearch = new System.Windows.Forms.Button();
            this.reportViewerPendingJO = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxLoadingAccomplishedJO = new System.Windows.Forms.PictureBox();
            this.dateTimePickerAccomplishedJOFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAccomplishedJOTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAccomplishedJOSearch = new System.Windows.Forms.Button();
            this.reportViewerAccomplishedJO = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBoxLoadingJobOrderSum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.JOSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetJobOrdersReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JOSummaryWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PendingJOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccomplishedJOBindingSource)).BeginInit();
            this.tabControlJobOrdersReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingJobOrderWork)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingPendingJO)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingAccomplishedJO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingJobOrderSum)).BeginInit();
            this.SuspendLayout();
            // 
            // JOSummaryBindingSource
            // 
            this.JOSummaryBindingSource.DataMember = "JOSummary";
            this.JOSummaryBindingSource.DataSource = this.DataSetJobOrdersReports;
            // 
            // DataSetJobOrdersReports
            // 
            this.DataSetJobOrdersReports.DataSetName = "DataSetJobOrdersReports";
            this.DataSetJobOrdersReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JOSummaryWorkBindingSource
            // 
            this.JOSummaryWorkBindingSource.DataMember = "JOSummaryWork";
            this.JOSummaryWorkBindingSource.DataSource = this.DataSetJobOrdersReports;
            // 
            // PendingJOBindingSource
            // 
            this.PendingJOBindingSource.DataMember = "PendingJO";
            this.PendingJOBindingSource.DataSource = this.DataSetJobOrdersReports;
            // 
            // AccomplishedJOBindingSource
            // 
            this.AccomplishedJOBindingSource.DataMember = "AccomplishedJO";
            this.AccomplishedJOBindingSource.DataSource = this.DataSetJobOrdersReports;
            // 
            // tabControlJobOrdersReports
            // 
            this.tabControlJobOrdersReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlJobOrdersReports.Controls.Add(this.tabPage1);
            this.tabControlJobOrdersReports.Controls.Add(this.tabPage7);
            this.tabControlJobOrdersReports.Controls.Add(this.tabPage2);
            this.tabControlJobOrdersReports.Controls.Add(this.tabPage3);
            this.tabControlJobOrdersReports.ItemSize = new System.Drawing.Size(70, 150);
            this.tabControlJobOrdersReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlJobOrdersReports.Multiline = true;
            this.tabControlJobOrdersReports.Name = "tabControlJobOrdersReports";
            this.tabControlJobOrdersReports.SelectedIndex = 0;
            this.tabControlJobOrdersReports.Size = new System.Drawing.Size(1152, 563);
            this.tabControlJobOrdersReports.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlJobOrdersReports.TabIndex = 4;
            this.tabControlJobOrdersReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlJobOrdersReports_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxLoadingJobOrderSum);
            this.tabPage1.Controls.Add(this.dateTimePickerJobOrderSumFrom);
            this.tabPage1.Controls.Add(this.dateTimePickerJobOrderSumTo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonJobOrderSumSearch);
            this.tabPage1.Controls.Add(this.reportViewerJobOrderSum);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job Order Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerJobOrderSumFrom
            // 
            this.dateTimePickerJobOrderSumFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerJobOrderSumFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJobOrderSumFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerJobOrderSumFrom.Location = new System.Drawing.Point(71, 16);
            this.dateTimePickerJobOrderSumFrom.Name = "dateTimePickerJobOrderSumFrom";
            this.dateTimePickerJobOrderSumFrom.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerJobOrderSumFrom.TabIndex = 73;
            // 
            // dateTimePickerJobOrderSumTo
            // 
            this.dateTimePickerJobOrderSumTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerJobOrderSumTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJobOrderSumTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerJobOrderSumTo.Location = new System.Drawing.Point(290, 16);
            this.dateTimePickerJobOrderSumTo.Name = "dateTimePickerJobOrderSumTo";
            this.dateTimePickerJobOrderSumTo.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerJobOrderSumTo.TabIndex = 74;
            this.dateTimePickerJobOrderSumTo.ValueChanged += new System.EventHandler(this.dateTimePickerJobOrderSumTo_ValueChanged);
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
            // buttonJobOrderSumSearch
            // 
            this.buttonJobOrderSumSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJobOrderSumSearch.Location = new System.Drawing.Point(534, 8);
            this.buttonJobOrderSumSearch.Name = "buttonJobOrderSumSearch";
            this.buttonJobOrderSumSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonJobOrderSumSearch.TabIndex = 70;
            this.buttonJobOrderSumSearch.Text = "Search";
            this.buttonJobOrderSumSearch.UseVisualStyleBackColor = true;
            this.buttonJobOrderSumSearch.Click += new System.EventHandler(this.buttonJobOrderSumSearch_Click);
            // 
            // reportViewerJobOrderSum
            // 
            reportDataSource14.Name = "DataSetJobOrdersReports";
            reportDataSource14.Value = this.JOSummaryBindingSource;
            this.reportViewerJobOrderSum.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewerJobOrderSum.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.JobOrdersReports.ReportJOSummary.rdlc";
            this.reportViewerJobOrderSum.Location = new System.Drawing.Point(26, 49);
            this.reportViewerJobOrderSum.Name = "reportViewerJobOrderSum";
            this.reportViewerJobOrderSum.ServerReport.BearerToken = null;
            this.reportViewerJobOrderSum.Size = new System.Drawing.Size(944, 481);
            this.reportViewerJobOrderSum.TabIndex = 3;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.comboBoxJobOrderWorkWork);
            this.tabPage7.Controls.Add(this.pictureBoxLoadingJobOrderWork);
            this.tabPage7.Controls.Add(this.dateTimePickerJobOrderWorkFrom);
            this.tabPage7.Controls.Add(this.dateTimePickerJobOrderWorkTo);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Controls.Add(this.buttonJobOrderWorkSearch);
            this.tabPage7.Controls.Add(this.reportViewerJobOrderWork);
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(994, 555);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Job Order Summary Per Work";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Work:";
            // 
            // comboBoxJobOrderWorkWork
            // 
            this.comboBoxJobOrderWorkWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJobOrderWorkWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJobOrderWorkWork.FormattingEnabled = true;
            this.comboBoxJobOrderWorkWork.Items.AddRange(new object[] {
            "ALL",
            "Connected",
            "Disconnected"});
            this.comboBoxJobOrderWorkWork.Location = new System.Drawing.Point(522, 16);
            this.comboBoxJobOrderWorkWork.Name = "comboBoxJobOrderWorkWork";
            this.comboBoxJobOrderWorkWork.Size = new System.Drawing.Size(174, 24);
            this.comboBoxJobOrderWorkWork.TabIndex = 71;
            // 
            // pictureBoxLoadingJobOrderWork
            // 
            this.pictureBoxLoadingJobOrderWork.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingJobOrderWork.Image")));
            this.pictureBoxLoadingJobOrderWork.Location = new System.Drawing.Point(26, 49);
            this.pictureBoxLoadingJobOrderWork.Name = "pictureBoxLoadingJobOrderWork";
            this.pictureBoxLoadingJobOrderWork.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingJobOrderWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingJobOrderWork.TabIndex = 70;
            this.pictureBoxLoadingJobOrderWork.TabStop = false;
            this.pictureBoxLoadingJobOrderWork.Visible = false;
            // 
            // dateTimePickerJobOrderWorkFrom
            // 
            this.dateTimePickerJobOrderWorkFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerJobOrderWorkFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJobOrderWorkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerJobOrderWorkFrom.Location = new System.Drawing.Point(71, 16);
            this.dateTimePickerJobOrderWorkFrom.Name = "dateTimePickerJobOrderWorkFrom";
            this.dateTimePickerJobOrderWorkFrom.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerJobOrderWorkFrom.TabIndex = 43;
            // 
            // dateTimePickerJobOrderWorkTo
            // 
            this.dateTimePickerJobOrderWorkTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerJobOrderWorkTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJobOrderWorkTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerJobOrderWorkTo.Location = new System.Drawing.Point(290, 16);
            this.dateTimePickerJobOrderWorkTo.Name = "dateTimePickerJobOrderWorkTo";
            this.dateTimePickerJobOrderWorkTo.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerJobOrderWorkTo.TabIndex = 43;
            this.dateTimePickerJobOrderWorkTo.ValueChanged += new System.EventHandler(this.dateTimePickerJobOrderWorkTo_ValueChanged);
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
            // buttonJobOrderWorkSearch
            // 
            this.buttonJobOrderWorkSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJobOrderWorkSearch.Location = new System.Drawing.Point(742, 8);
            this.buttonJobOrderWorkSearch.Name = "buttonJobOrderWorkSearch";
            this.buttonJobOrderWorkSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonJobOrderWorkSearch.TabIndex = 37;
            this.buttonJobOrderWorkSearch.Text = "Search";
            this.buttonJobOrderWorkSearch.UseVisualStyleBackColor = true;
            this.buttonJobOrderWorkSearch.Click += new System.EventHandler(this.buttonJobOrderWorkSearch_Click);
            // 
            // reportViewerJobOrderWork
            // 
            reportDataSource15.Name = "DataSetJobOrdersReports";
            reportDataSource15.Value = this.JOSummaryWorkBindingSource;
            this.reportViewerJobOrderWork.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewerJobOrderWork.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.JobOrdersReports.ReportJOSummaryWork.rdlc";
            this.reportViewerJobOrderWork.Location = new System.Drawing.Point(26, 49);
            this.reportViewerJobOrderWork.Name = "reportViewerJobOrderWork";
            this.reportViewerJobOrderWork.ServerReport.BearerToken = null;
            this.reportViewerJobOrderWork.Size = new System.Drawing.Size(944, 481);
            this.reportViewerJobOrderWork.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBoxLoadingPendingJO);
            this.tabPage2.Controls.Add(this.dateTimePickerPendingJOAsOf);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonPendingJOSearch);
            this.tabPage2.Controls.Add(this.reportViewerPendingJO);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(994, 555);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "Summary of Pending Job Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLoadingPendingJO
            // 
            this.pictureBoxLoadingPendingJO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingPendingJO.Image")));
            this.pictureBoxLoadingPendingJO.Location = new System.Drawing.Point(27, 49);
            this.pictureBoxLoadingPendingJO.Name = "pictureBoxLoadingPendingJO";
            this.pictureBoxLoadingPendingJO.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingPendingJO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingPendingJO.TabIndex = 77;
            this.pictureBoxLoadingPendingJO.TabStop = false;
            this.pictureBoxLoadingPendingJO.Visible = false;
            // 
            // dateTimePickerPendingJOAsOf
            // 
            this.dateTimePickerPendingJOAsOf.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerPendingJOAsOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPendingJOAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPendingJOAsOf.Location = new System.Drawing.Point(78, 13);
            this.dateTimePickerPendingJOAsOf.Name = "dateTimePickerPendingJOAsOf";
            this.dateTimePickerPendingJOAsOf.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerPendingJOAsOf.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "As Of:";
            // 
            // buttonPendingJOSearch
            // 
            this.buttonPendingJOSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPendingJOSearch.Location = new System.Drawing.Point(325, 8);
            this.buttonPendingJOSearch.Name = "buttonPendingJOSearch";
            this.buttonPendingJOSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonPendingJOSearch.TabIndex = 72;
            this.buttonPendingJOSearch.Text = "Search";
            this.buttonPendingJOSearch.UseVisualStyleBackColor = true;
            this.buttonPendingJOSearch.Click += new System.EventHandler(this.buttonPendingJOSearch_Click);
            // 
            // reportViewerPendingJO
            // 
            reportDataSource16.Name = "DataSetJobOrdersReports";
            reportDataSource16.Value = this.PendingJOBindingSource;
            this.reportViewerPendingJO.LocalReport.DataSources.Add(reportDataSource16);
            this.reportViewerPendingJO.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.JobOrdersReports.ReportPendingJobOrders.rdlc";
            this.reportViewerPendingJO.Location = new System.Drawing.Point(27, 49);
            this.reportViewerPendingJO.Name = "reportViewerPendingJO";
            this.reportViewerPendingJO.ServerReport.BearerToken = null;
            this.reportViewerPendingJO.Size = new System.Drawing.Size(944, 481);
            this.reportViewerPendingJO.TabIndex = 71;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBoxLoadingAccomplishedJO);
            this.tabPage3.Controls.Add(this.dateTimePickerAccomplishedJOFrom);
            this.tabPage3.Controls.Add(this.dateTimePickerAccomplishedJOTo);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.buttonAccomplishedJOSearch);
            this.tabPage3.Controls.Add(this.reportViewerAccomplishedJO);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(994, 555);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "Summary of Accomplished Job Orders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLoadingAccomplishedJO
            // 
            this.pictureBoxLoadingAccomplishedJO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingAccomplishedJO.Image")));
            this.pictureBoxLoadingAccomplishedJO.Location = new System.Drawing.Point(27, 49);
            this.pictureBoxLoadingAccomplishedJO.Name = "pictureBoxLoadingAccomplishedJO";
            this.pictureBoxLoadingAccomplishedJO.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingAccomplishedJO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingAccomplishedJO.TabIndex = 77;
            this.pictureBoxLoadingAccomplishedJO.TabStop = false;
            this.pictureBoxLoadingAccomplishedJO.Visible = false;
            // 
            // dateTimePickerAccomplishedJOFrom
            // 
            this.dateTimePickerAccomplishedJOFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerAccomplishedJOFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAccomplishedJOFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAccomplishedJOFrom.Location = new System.Drawing.Point(72, 16);
            this.dateTimePickerAccomplishedJOFrom.Name = "dateTimePickerAccomplishedJOFrom";
            this.dateTimePickerAccomplishedJOFrom.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerAccomplishedJOFrom.TabIndex = 75;
            // 
            // dateTimePickerAccomplishedJOTo
            // 
            this.dateTimePickerAccomplishedJOTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerAccomplishedJOTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAccomplishedJOTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAccomplishedJOTo.Location = new System.Drawing.Point(291, 16);
            this.dateTimePickerAccomplishedJOTo.Name = "dateTimePickerAccomplishedJOTo";
            this.dateTimePickerAccomplishedJOTo.Size = new System.Drawing.Size(129, 24);
            this.dateTimePickerAccomplishedJOTo.TabIndex = 76;
            this.dateTimePickerAccomplishedJOTo.ValueChanged += new System.EventHandler(this.dateTimePickerAccomplishedJOTo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "From:";
            // 
            // buttonAccomplishedJOSearch
            // 
            this.buttonAccomplishedJOSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccomplishedJOSearch.Location = new System.Drawing.Point(535, 8);
            this.buttonAccomplishedJOSearch.Name = "buttonAccomplishedJOSearch";
            this.buttonAccomplishedJOSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccomplishedJOSearch.TabIndex = 72;
            this.buttonAccomplishedJOSearch.Text = "Search";
            this.buttonAccomplishedJOSearch.UseVisualStyleBackColor = true;
            this.buttonAccomplishedJOSearch.Click += new System.EventHandler(this.buttonAccomplishedJOSearch_Click);
            // 
            // reportViewerAccomplishedJO
            // 
            reportDataSource13.Name = "DataSetJobOrdersReports";
            reportDataSource13.Value = this.AccomplishedJOBindingSource;
            this.reportViewerAccomplishedJO.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewerAccomplishedJO.LocalReport.ReportEmbeddedResource = "ConcessionaireReports.RDLC.JobOrdersReports.ReportAccomplishedJO.rdlc";
            this.reportViewerAccomplishedJO.Location = new System.Drawing.Point(27, 49);
            this.reportViewerAccomplishedJO.Name = "reportViewerAccomplishedJO";
            this.reportViewerAccomplishedJO.ServerReport.BearerToken = null;
            this.reportViewerAccomplishedJO.Size = new System.Drawing.Size(944, 481);
            this.reportViewerAccomplishedJO.TabIndex = 71;
            // 
            // pictureBoxLoadingJobOrderSum
            // 
            this.pictureBoxLoadingJobOrderSum.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingJobOrderSum.Image")));
            this.pictureBoxLoadingJobOrderSum.Location = new System.Drawing.Point(26, 49);
            this.pictureBoxLoadingJobOrderSum.Name = "pictureBoxLoadingJobOrderSum";
            this.pictureBoxLoadingJobOrderSum.Size = new System.Drawing.Size(944, 481);
            this.pictureBoxLoadingJobOrderSum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingJobOrderSum.TabIndex = 75;
            this.pictureBoxLoadingJobOrderSum.TabStop = false;
            this.pictureBoxLoadingJobOrderSum.Visible = false;
            // 
            // JobOrdersReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 587);
            this.Controls.Add(this.tabControlJobOrdersReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JobOrdersReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobOrdersReportsForm";
            this.Load += new System.EventHandler(this.JobOrdersReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JOSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetJobOrdersReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JOSummaryWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PendingJOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccomplishedJOBindingSource)).EndInit();
            this.tabControlJobOrdersReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingJobOrderWork)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingPendingJO)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingAccomplishedJO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingJobOrderSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlJobOrdersReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePickerJobOrderSumFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerJobOrderSumTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonJobOrderSumSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerJobOrderSum;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox pictureBoxLoadingJobOrderWork;
        private System.Windows.Forms.DateTimePicker dateTimePickerJobOrderWorkFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerJobOrderWorkTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonJobOrderWorkSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerJobOrderWork;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxLoadingPendingJO;
        private System.Windows.Forms.DateTimePicker dateTimePickerPendingJOAsOf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPendingJOSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPendingJO;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBoxLoadingAccomplishedJO;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccomplishedJOFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccomplishedJOTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAccomplishedJOSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAccomplishedJO;
        private System.Windows.Forms.BindingSource JOSummaryBindingSource;
        private DataSetJobOrdersReports DataSetJobOrdersReports;
        private System.Windows.Forms.ComboBox comboBoxJobOrderWorkWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource JOSummaryWorkBindingSource;
        private System.Windows.Forms.BindingSource PendingJOBindingSource;
        private System.Windows.Forms.BindingSource AccomplishedJOBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxLoadingJobOrderSum;
    }
}