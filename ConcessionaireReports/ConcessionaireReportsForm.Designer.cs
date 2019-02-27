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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlConcessionaireReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConcessionaireReports
            // 
            this.tabControlConcessionaireReports.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage1);
            this.tabControlConcessionaireReports.Controls.Add(this.tabPage2);
            this.tabControlConcessionaireReports.ItemSize = new System.Drawing.Size(35, 150);
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
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ConcessionaireReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 513);
            this.Controls.Add(this.tabControlConcessionaireReports);
            this.Name = "ConcessionaireReportsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConcessionaireReportsForm_Load);
            this.tabControlConcessionaireReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConcessionaireReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

