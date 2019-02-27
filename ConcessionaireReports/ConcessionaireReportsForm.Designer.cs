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
            this.tabControlConcessionaireReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAccountPerBookSearch = new System.Windows.Forms.Button();
            this.comboBoxAccountPerBookMeterStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerBookBook = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountPerBookZone = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControlConcessionaireReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // buttonAccountPerBookSearch
            // 
            this.buttonAccountPerBookSearch.Location = new System.Drawing.Point(597, 15);
            this.buttonAccountPerBookSearch.Name = "buttonAccountPerBookSearch";
            this.buttonAccountPerBookSearch.Size = new System.Drawing.Size(74, 38);
            this.buttonAccountPerBookSearch.TabIndex = 2;
            this.buttonAccountPerBookSearch.Text = "Search";
            this.buttonAccountPerBookSearch.UseVisualStyleBackColor = true;
            this.buttonAccountPerBookSearch.Click += new System.EventHandler(this.buttonAccountPerBookSearch_Click);
            // 
            // comboBoxAccountPerBookMeterStatus
            // 
            this.comboBoxAccountPerBookMeterStatus.FormattingEnabled = true;
            this.comboBoxAccountPerBookMeterStatus.Location = new System.Drawing.Point(489, 25);
            this.comboBoxAccountPerBookMeterStatus.Name = "comboBoxAccountPerBookMeterStatus";
            this.comboBoxAccountPerBookMeterStatus.Size = new System.Drawing.Size(55, 21);
            this.comboBoxAccountPerBookMeterStatus.TabIndex = 1;
            // 
            // comboBoxAccountPerBookBook
            // 
            this.comboBoxAccountPerBookBook.FormattingEnabled = true;
            this.comboBoxAccountPerBookBook.Location = new System.Drawing.Point(297, 25);
            this.comboBoxAccountPerBookBook.Name = "comboBoxAccountPerBookBook";
            this.comboBoxAccountPerBookBook.Size = new System.Drawing.Size(55, 21);
            this.comboBoxAccountPerBookBook.TabIndex = 1;
            // 
            // comboBoxAccountPerBookZone
            // 
            this.comboBoxAccountPerBookZone.FormattingEnabled = true;
            this.comboBoxAccountPerBookZone.Location = new System.Drawing.Point(147, 25);
            this.comboBoxAccountPerBookZone.Name = "comboBoxAccountPerBookZone";
            this.comboBoxAccountPerBookZone.Size = new System.Drawing.Size(55, 21);
            this.comboBoxAccountPerBookZone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meter Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account List Per Barangay";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(824, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Account List Per Classification";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(824, 481);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Summary of Accounts Per Classification";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(154, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(824, 481);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "New Connection Summary";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(154, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(824, 481);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Account List By Status";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(824, 481);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Senior Citizen Accounts";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(154, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(824, 481);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Account List Per Meter Size";
            this.tabPage8.UseVisualStyleBackColor = true;
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
            this.tabControlConcessionaireReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

