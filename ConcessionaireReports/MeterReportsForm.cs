using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ConcessionaireReports
{
    public partial class MeterReportsForm : Form
    {
        private string connStr;

        public MeterReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlMeterReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlMeterReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlMeterReports.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            // Use our own font.
            Font _tabFont = new Font("Comic Sans MS", (float)13.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void MeterReportsForm_Load(object sender, EventArgs e)
        {
            dateTimePickerSummaryChangedMetersFrom.MaxDate = dateTimePickerSummaryChangedMetersTo.Value.Date;
            dateTimePickerSummaryReceivedMetersFrom.MaxDate = dateTimePickerSummaryReceivedMetersTo.Value.Date;
            dateTimePickerSummaryDisposedMetersFrom.MaxDate = dateTimePickerSummaryDisposedMetersTo.Value.Date;
            dateTimePickerSummaryTestedMetersFrom.MaxDate = dateTimePickerSummaryTestedMetersTo.Value.Date;

            dateTimePickerChangedMeterPreviousReadYear.MaxDate = DateTime.Today;
            dateTimePickerSummaryPulledOutMetersYear.MaxDate = DateTime.Today;
            dateTimePickerSummaryAlterationDate.MaxDate = DateTime.Today;

            tabControlMeterReports.DrawMode = TabDrawMode.OwnerDrawFixed;

            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            this.reportViewerSummaryChangedMeters.RefreshReport();
            this.reportViewerChangedMeterPreviousRead.RefreshReport();
            this.reportViewerSummaryPulledOutMeters.RefreshReport();
            this.reportViewerSummaryAlteration.RefreshReport();
            this.reportViewerSummaryReceivedMeters.RefreshReport();
            this.reportViewerSummaryDisposedMeters.RefreshReport();
            this.reportViewerSummaryTestedMeters.RefreshReport();
        }

        private void buttonSummaryChangedMetersSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
