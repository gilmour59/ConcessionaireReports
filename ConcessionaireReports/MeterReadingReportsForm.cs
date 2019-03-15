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
    public partial class MeterReadingReportsForm : Form
    {
        private string connStr;

        public MeterReadingReportsForm()
        {
            InitializeComponent();
        }

        private void MeterReadingReportsForm_Load(object sender, EventArgs e)
        {
            tabControlMeterReadingReports.DrawMode = TabDrawMode.OwnerDrawFixed;

            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetZones", conn))
                    {
                        DataSet dsZones = new DataSet();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(dsZones);

                        //Reading Slip
                        comboBoxReadingSlipZone.ValueMember = "zone_code";
                        comboBoxReadingSlipZone.DisplayMember = "zone_code";
                        comboBoxReadingSlipZone.DataSource = dsZones.Tables[0]; //this triggers the SelectedIndex property of a combobox

                        //Sudden Inc/Dec
                        comboBoxAccountsSuddenIncDecConsumptionZone.ValueMember = "zone_code";
                        comboBoxAccountsSuddenIncDecConsumptionZone.DisplayMember = "zone_code";
                        comboBoxAccountsSuddenIncDecConsumptionZone.DataSource = dsZones.Tables[0]; //this triggers the SelectedIndex property of a combobox

                        //Min Consumption
                        comboBoxAccountsMinimumConsumptionZone.ValueMember = "zone_code";
                        comboBoxAccountsMinimumConsumptionZone.DisplayMember = "zone_code";
                        comboBoxAccountsMinimumConsumptionZone.DataSource = dsZones.Tables[0]; //this triggers the SelectedIndex property of a combobox
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBillingMonthsId", conn))
                    {
                        DataSet dsBillMonth = new DataSet();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(dsBillMonth);

                        //Reading Slip
                        comboBoxReadingSlipBillingMonth.ValueMember = "billing_month_id";
                        comboBoxReadingSlipBillingMonth.DisplayMember = "month_year"; 
                        comboBoxReadingSlipBillingMonth.DataSource = dsBillMonth.Tables[0]; //this triggers the SelectedIndex property of a combobox

                        //Sudden Inc/Dec
                        comboBoxAccountsSuddenIncDecConsumptionBillingMonth.ValueMember = "billing_month_id";
                        comboBoxAccountsSuddenIncDecConsumptionBillingMonth.DisplayMember = "month_year";
                        comboBoxAccountsSuddenIncDecConsumptionBillingMonth.DataSource = dsBillMonth.Tables[0]; //this triggers the SelectedIndex property of a combobox

                        //Min Consumption
                        comboBoxAccountsMinimumConsumptionBillingMonth.ValueMember = "billing_month_id";
                        comboBoxAccountsMinimumConsumptionBillingMonth.DisplayMember = "month_year";
                        comboBoxAccountsMinimumConsumptionBillingMonth.DataSource = dsBillMonth.Tables[0]; //this triggers the SelectedIndex property of a combobox
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerReadingSlip.RefreshReport();
            this.reportViewerReadBillSOA.RefreshReport();
            this.reportViewerMeterReaderAccomplishment.RefreshReport();
            this.reportViewerAccountsSuddenIncDecConsumption.RefreshReport();
            this.reportViewerAccountsMinimumConsumption.RefreshReport();
            this.reportViewerUnreadMeters.RefreshReport();
        }

        private void tabControlMeterReadingReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlMeterReadingReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlMeterReadingReports.GetTabRect(e.Index);

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

        private void comboBoxReadingSlipZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        DataSet dsBooksOfZone = new DataSet();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxReadingSlipZone.SelectedValue.ToString());
                        adapter.Fill(dsBooksOfZone);

                        comboBoxReadingSlipBook.ValueMember = "book_code";
                        comboBoxReadingSlipBook.DisplayMember = "book_code";
                        comboBoxReadingSlipBook.DataSource = dsBooksOfZone.Tables[0];
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void buttonReadingSlipSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetReadingSlipData_", conn))
                    {

                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@zone", comboBoxReadingSlipZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zone"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@book", comboBoxReadingSlipBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@book"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@bill_month_id", comboBoxReadingSlipBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bill_month_id"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "ReadingSlip");

                        ReportDataSource rds = new ReportDataSource("DataSetMeterReadingReports", ds.Tables["ReadingSlip"]);
                        reportViewerReadingSlip.LocalReport.DataSources.Clear();
                        reportViewerReadingSlip.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", comboBoxReadingSlipBillingMonth.Text),
                        };
                        reportViewerReadingSlip.LocalReport.SetParameters(param);
                        reportViewerReadingSlip.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerReadingSlip.RefreshReport();
        }

        private void buttonAccountsSuddenIncDecConsumptionSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetSuddenUpDownInComsumption_", conn))
                    {

                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@billMonth", comboBoxAccountsSuddenIncDecConsumptionBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@billMonth"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountsSuddenIncDecConsumptionZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@bookCode", comboBoxAccountsSuddenIncDecConsumptionBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bookCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_change", numericUpDownAccountsSuddenIncDecConsumptionChange.Value);
                        adapter.SelectCommand.Parameters["@in_change"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "AccountsSuddenIncDecConsumption");

                        ReportDataSource rds = new ReportDataSource("DataSetMeterReadingReports", ds.Tables["AccountsSuddenIncDecConsumption"]);
                        reportViewerAccountsSuddenIncDecConsumption.LocalReport.DataSources.Clear();
                        reportViewerAccountsSuddenIncDecConsumption.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", comboBoxAccountsSuddenIncDecConsumptionBillingMonth.Text),
                            new ReportParameter("ReportParameterZone", comboBoxAccountsSuddenIncDecConsumptionZone.Text),
                            new ReportParameter("ReportParameterBook", comboBoxAccountsSuddenIncDecConsumptionBook.Text)
                        };
                        reportViewerAccountsSuddenIncDecConsumption.LocalReport.SetParameters(param);
                        reportViewerAccountsSuddenIncDecConsumption.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerAccountsSuddenIncDecConsumption.RefreshReport();
        }

        private void comboBoxAccountsSuddenIncDecConsumptionZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        DataSet dsBooksOfZone = new DataSet();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountsSuddenIncDecConsumptionZone.SelectedValue.ToString());
                        adapter.Fill(dsBooksOfZone);

                        comboBoxAccountsSuddenIncDecConsumptionBook.ValueMember = "book_code";
                        comboBoxAccountsSuddenIncDecConsumptionBook.DisplayMember = "book_code";
                        comboBoxAccountsSuddenIncDecConsumptionBook.DataSource = dsBooksOfZone.Tables[0];
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void comboBoxAccountsMinimumConsumptionZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        DataSet dsBooksOfZone = new DataSet();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountsMinimumConsumptionZone.SelectedValue.ToString());
                        adapter.Fill(dsBooksOfZone);

                        comboBoxAccountsMinimumConsumptionBook.ValueMember = "book_code";
                        comboBoxAccountsMinimumConsumptionBook.DisplayMember = "book_code";
                        comboBoxAccountsMinimumConsumptionBook.DataSource = dsBooksOfZone.Tables[0];
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void buttonAccountsMinimumConsumptionSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetAccountsWithMinConsumption_", conn))
                    {

                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@billMonth", comboBoxAccountsMinimumConsumptionBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@billMonth"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountsMinimumConsumptionZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@bookCode", comboBoxAccountsMinimumConsumptionBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bookCode"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "AccountsMinimumConsumption");

                        ReportDataSource rds = new ReportDataSource("DataSetMeterReadingReports", ds.Tables["AccountsMinimumConsumption"]);
                        reportViewerAccountsMinimumConsumption.LocalReport.DataSources.Clear();
                        reportViewerAccountsMinimumConsumption.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", comboBoxAccountsMinimumConsumptionBillingMonth.Text),
                            new ReportParameter("ReportParameterZone", comboBoxAccountsMinimumConsumptionZone.Text),
                            new ReportParameter("ReportParameterBook", comboBoxAccountsMinimumConsumptionBook.Text)
                        };
                        reportViewerAccountsMinimumConsumption.LocalReport.SetParameters(param);
                        reportViewerAccountsMinimumConsumption.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerAccountsMinimumConsumption.RefreshReport();
        }
    }
}
