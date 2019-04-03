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
            dateTimePickerSummaryAlterationFrom.MaxDate = dateTimePickerSummaryAlterationTo.Value.Date;

            dateTimePickerChangedMeterPreviousReadYear.MaxDate = DateTime.Today;
            dateTimePickerSummaryPulledOutMetersYear.MaxDate = DateTime.Today;

            tabControlMeterReports.DrawMode = TabDrawMode.OwnerDrawFixed;

            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";
        }

        private void bindDate(MySqlConnection con, string sp, string paramFrom, string paramTo, DateTimePicker dtFrom, DateTimePicker dtTo, string dataTable, ReportViewer rv)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sp, con))
            {
                adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                DataSetMeterReports ds = new DataSetMeterReports();

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue(paramFrom, dtFrom.Value.Date);
                adapter.SelectCommand.Parameters[paramFrom].Direction = ParameterDirection.Input;
                adapter.SelectCommand.Parameters.AddWithValue(paramTo, dtTo.Value.Date);
                adapter.SelectCommand.Parameters[paramTo].Direction = ParameterDirection.Input;

                adapter.Fill(ds, dataTable);

                ReportDataSource rds = new ReportDataSource("DataSetMeterReports", ds.Tables[dataTable]);
                rv.LocalReport.DataSources.Clear();
                rv.LocalReport.DataSources.Add(rds);
            }
        }

        private void buttonSummaryChangedMetersSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    bindDate(conn, "sp_GilGetChangedMeterSummary_", "@asOfFrom", "@asOfTo", dateTimePickerSummaryChangedMetersFrom, dateTimePickerSummaryChangedMetersTo, "SummaryChangedMeters", reportViewerSummaryChangedMeters);

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerSummaryChangedMeters.RefreshReport();
        }

        private void dateTimePickerSummaryChangedMetersTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummaryChangedMetersFrom.MaxDate = dateTimePickerSummaryChangedMetersTo.Value.Date;
        }

        private void dateTimePickerSummaryReceivedMetersTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummaryReceivedMetersFrom.MaxDate = dateTimePickerSummaryReceivedMetersTo.Value.Date;
        }

        private void dateTimePickerSummaryDisposedMetersTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummaryDisposedMetersFrom.MaxDate = dateTimePickerSummaryDisposedMetersTo.Value.Date;
        }

        private void dateTimePickerSummaryTestedMetersTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummaryTestedMetersFrom.MaxDate = dateTimePickerSummaryTestedMetersTo.Value.Date;
        }

        private void buttonSummaryTestedMetersSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    bindDate(conn, "sp_getTestedMetersSummary_", "@fromDate", "@toDate", dateTimePickerSummaryTestedMetersFrom, dateTimePickerSummaryTestedMetersTo, "SummaryTestedMeters", reportViewerSummaryTestedMeters);
                  
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerSummaryTestedMeters.RefreshReport();
        }

        private void buttonChangedMeterPreviousReadSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_getChangedMeterSummaryWithPrevRdng_", conn))
                    {
                        //label5.Text = dateTimePickerChangedMeterPreviousReadMonth.Value.ToString("MM") + dateTimePickerChangedMeterPreviousReadYear.Value.ToString("yyyy");
                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReports ds = new DataSetMeterReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@asOfMonth", (dateTimePickerChangedMeterPreviousReadMonth.Value.ToString("MM") + dateTimePickerChangedMeterPreviousReadYear.Value.ToString("yyyy")));
                        adapter.SelectCommand.Parameters["@asOfMonth"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "ChangedMeterPreviousRead");

                        ReportDataSource rds = new ReportDataSource("DataSetMeterReports", ds.Tables["ChangedMeterPreviousRead"]);
                        reportViewerChangedMeterPreviousRead.LocalReport.DataSources.Clear();
                        reportViewerChangedMeterPreviousRead.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerChangedMeterPreviousRead.RefreshReport();
        }

        private void buttonSummaryPulledOutMetersSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_getPulledOutMeterSummary_", conn))
                    {
                        //label5.Text = dateTimePickerChangedMeterPreviousReadMonth.Value.ToString("MM") + dateTimePickerChangedMeterPreviousReadYear.Value.ToString("yyyy");
                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReports ds = new DataSetMeterReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@asOfMonth", (dateTimePickerSummaryPulledOutMetersMonth.Value.ToString("MM") + dateTimePickerSummaryPulledOutMetersYear.Value.ToString("yyyy")));
                        adapter.SelectCommand.Parameters["@asOfMonth"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "SummaryPulledOutMeters");

                        ReportDataSource rds = new ReportDataSource("DataSetMeterReports", ds.Tables["SummaryPulledOutMeters"]);
                        reportViewerSummaryPulledOutMeters.LocalReport.DataSources.Clear();
                        reportViewerSummaryPulledOutMeters.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerSummaryPulledOutMeters.RefreshReport();
        }

        private void dateTimePickerSummaryAlterationTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummaryAlterationFrom.MaxDate = dateTimePickerSummaryAlterationTo.Value.Date;
        }

        private void buttonSummaryAlterationSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    bindDate(conn, "sp_GilGetAlterationByDate", "@asOfFrom", "@asOfTo", dateTimePickerSummaryAlterationFrom, dateTimePickerSummaryAlterationTo, "SummaryAlteration", reportViewerSummaryAlteration);

                    ReportParameter[] param = new ReportParameter[]
                    {
                        new ReportParameter("ReportParameterFrom", dateTimePickerSummaryAlterationFrom.Value.Date.ToString("MMMM dd, yyyy")),
                        new ReportParameter("ReportParameterTo", dateTimePickerSummaryAlterationTo.Value.Date.ToString("MMMM dd, yyyy"))
                    };
                    reportViewerSummaryAlteration.LocalReport.SetParameters(param);
                    reportViewerSummaryAlteration.LocalReport.Refresh();
                    
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerSummaryAlteration.RefreshReport();
        }

        private void buttonSummaryReceivedMetersSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    bindDate(conn, "sp_getReceivedMetersSummary_", "@fromDate", "@toDate", dateTimePickerSummaryReceivedMetersFrom, dateTimePickerSummaryReceivedMetersTo, "SummaryReceivedMeters", reportViewerSummaryReceivedMeters);
                   
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerSummaryReceivedMeters.RefreshReport();
        }

        private void buttonSummaryDisposedMetersSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    bindDate(conn, "sp_getDisposedMetersSummary_", "@fromDate", "@toDate", dateTimePickerSummaryDisposedMetersFrom, dateTimePickerSummaryDisposedMetersTo, "SummaryDisposedMeters", reportViewerSummaryDisposedMeters);
                 
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerSummaryDisposedMeters.RefreshReport();
        }
    }
}
