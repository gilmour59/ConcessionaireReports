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
    public partial class CollectionReportsForm : Form
    {
        private string connStr;

        public CollectionReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlCollectionReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlCollectionReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlCollectionReports.GetTabRect(e.Index);

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
            Font _tabFont = new Font("Comic Sans MS", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void bindTeller(ComboBox cb, DateTimePicker dt, MySqlDataAdapter adap)
        {
            DataSet dsTeller = new DataSet();
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.AddWithValue("@transDate", dt.Value.Date);
            adap.SelectCommand.Parameters["@transDate"].Direction = ParameterDirection.Input;
            adap.Fill(dsTeller);

            cb.ValueMember = "user_id";
            cb.DisplayMember = "full_name";
            cb.DataSource = dsTeller.Tables[0];
        }

        private void CollectionReportsForm_Load(object sender, EventArgs e)
        {
            tabControlCollectionReports.DrawMode = TabDrawMode.OwnerDrawFixed;

            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            //This needs to be after the connStr because of the datetimepicker changed value function;
            dateTimePickerDailyCollectionReportDate.MaxDate = DateTime.Today;
            dateTimePickerDCR2Date.MaxDate = DateTime.Today;
        }

        private void dateTimePickerDailyCollectionReportDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilgetTellersByTransDate", conn))
                    {
                        bindTeller(comboBoxDailyCollectionReportTeller, dateTimePickerDailyCollectionReportDate, adapter);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void dateTimePickerDCR2Date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilgetTellersByTransDate", conn))
                    {
                        bindTeller(comboBoxDCR2Teller, dateTimePickerDCR2Date, adapter);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void bindDCR(DateTimePicker dt, ComboBox cb, ReportViewer rv, string sp, string dataTable)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sp, conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_trans_date", dt.Value);
                        adapter.SelectCommand.Parameters["@in_trans_date"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_user_id", cb.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@in_user_id"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, dataTable);

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables[dataTable]);
                        rv.LocalReport.DataSources.Clear();
                        rv.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                    new ReportParameter("ReportParameterDate", dt.Value.ToString()),
                    new ReportParameter("ReportParameterTeller", cb.Text)
                        };
                        rv.LocalReport.SetParameters(param);
                        //reportViewerDailyCollectionReport.LocalReport.Refresh();
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetDCRRecap", conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@transDate", dt.Value);
                        adapter.SelectCommand.Parameters["@transDate"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@userId", cb.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@userId"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "DCRRecap");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports2", ds.Tables["DCRRecap"]);
                        rv.LocalReport.DataSources.Add(rds);
                        //reportViewerDailyCollectionReport.LocalReport.Refresh();
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetCheckPayments", conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@transDate", dt.Value);
                        adapter.SelectCommand.Parameters["@transDate"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@userId", cb.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@userId"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "DCRCheckPayments");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports3", ds.Tables["DCRCheckPayments"]);
                        rv.LocalReport.DataSources.Add(rds);
                        rv.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            rv.RefreshReport();
        }

        private void buttonDailyCollectionReportSearch_Click(object sender, EventArgs e)
        {
            bindDCR(dateTimePickerDailyCollectionReportDate, comboBoxDailyCollectionReportTeller, reportViewerDailyCollectionReport, "sp_GetDCR2", "DailyCollectionReport");         
        }

        private void buttonDCR2Search_Click(object sender, EventArgs e)
        {
            //bindDCR(dateTimePickerDailyCollectionReportDate, comboBoxDailyCollectionReportTeller, reportViewerDailyCollectionReport, "sp_GetDCR2", "DailyCollectionReport");
        }
    }
}
