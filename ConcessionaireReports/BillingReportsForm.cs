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
    public partial class BillingReportsForm : Form
    {
        private string connStr;

        public BillingReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlConcessionaireReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlBillingReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlBillingReports.GetTabRect(e.Index);

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

        private void BillingReportsForm_Load(object sender, EventArgs e)
        {
            tabControlBillingReports.DrawMode = TabDrawMode.OwnerDrawFixed;

            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetZones", conn))
                    {
                        bindZone(comboBoxBillComputationRegZone, adapter);
                        bindZone(comboBoxBillSummaryBookZone, adapter);
                        bindZone(comboBoxPenaltyBillingReportZone, adapter);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBillingMonthsId", conn))
                    {
                        bindBillingMonth(comboBoxBillComputationRegBillingMonth, adapter);
                        bindBillingMonth(comboBoxBillSummaryBookBillingMonth, adapter);
                        bindBillingMonth(comboBoxBillSummaryMonthBillingMonth, adapter);
                        bindBillingMonth(comboBoxPenaltyBillingReportBillingMonth, adapter);
                        bindBillingMonth(comboBoxBillingSummaryMaterialsBillingMonth, adapter);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerBillComputationReg.RefreshReport();
            this.reportViewerBillSummaryBook.RefreshReport();
            this.reportViewerBillSummaryMonth.RefreshReport();
            this.reportViewerPenaltyBillingReport.RefreshReport();
        }

        private void bindBillingMonth(ComboBox cb, MySqlDataAdapter adap)
        {
            DataSet dsBillMonth = new DataSet();
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.Fill(dsBillMonth);

            cb.ValueMember = "billing_month_id";
            cb.DisplayMember = "month_year";
            cb.DataSource = dsBillMonth.Tables[0];
        }

        private void bindZone(ComboBox cb, MySqlDataAdapter adap)
        {
            DataSet dsZones = new DataSet();
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.Fill(dsZones);

            cb.ValueMember = "zone_code";
            cb.DisplayMember = "zone_code";
            cb.DataSource = dsZones.Tables[0];
        }

        private void bindBook(ComboBox cb, ComboBox cbZone, MySqlDataAdapter adap)
        {
            DataSet dsBooksOfZone = new DataSet();
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.AddWithValue("@zoneCode", cbZone.SelectedValue.ToString());
            adap.Fill(dsBooksOfZone);

            cb.ValueMember = "book_code";
            cb.DisplayMember = "book_code";
            cb.DataSource = dsBooksOfZone.Tables[0];
        }

        private void buttonBillComputationRegSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetComputationRegister_", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@billMonth", comboBoxBillComputationRegBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@billMonth"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxBillComputationRegZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@bookCode", comboBoxBillComputationRegBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bookCode"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "BillComputationRegister");

                        ReportDataSource rds = new ReportDataSource("DataSetBillingReports", ds.Tables["BillComputationRegister"]);
                        reportViewerBillComputationReg.LocalReport.DataSources.Clear();
                        reportViewerBillComputationReg.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterZone", comboBoxBillComputationRegZone.Text),
                            new ReportParameter("ReportParameterBook", comboBoxBillComputationRegBook.Text)
                        };
                        reportViewerBillComputationReg.LocalReport.SetParameters(param);
                        reportViewerBillComputationReg.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerBillComputationReg.RefreshReport();
        }

        private void comboBoxBillComputationRegZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        bindBook(comboBoxBillComputationRegBook, comboBoxBillComputationRegZone, adapter);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void comboBoxBillSummaryBookZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        bindBook(comboBoxBillSummaryBookBook, comboBoxBillSummaryBookZone, adapter);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void buttonBillSummaryBookSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetBillingSummaryPerBook", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_bill_month_id", comboBoxBillSummaryBookBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@in_bill_month_id"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_zone_id", comboBoxBillSummaryBookZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@in_zone_id"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_book_id", comboBoxBillSummaryBookBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@in_book_id"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "BillingSummaryPerBook");

                        ReportDataSource rds = new ReportDataSource("DataSetBillingReports", ds.Tables["BillingSummaryPerBook"]);
                        reportViewerBillSummaryBook.LocalReport.DataSources.Clear();
                        reportViewerBillSummaryBook.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", comboBoxBillSummaryBookBillingMonth.Text),
                        };
                        reportViewerBillSummaryBook.LocalReport.SetParameters(param);
                        reportViewerBillSummaryBook.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerBillSummaryBook.RefreshReport();
        }

        private void buttonBillSummaryMonthSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetBillingSummaryForTheMonth", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@bill_month", comboBoxBillSummaryMonthBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bill_month"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "BillingSummaryPerMonth");

                        ReportDataSource rds = new ReportDataSource("DataSetBillingReports", ds.Tables["BillingSummaryPerMonth"]);
                        reportViewerBillSummaryMonth.LocalReport.DataSources.Clear();
                        reportViewerBillSummaryMonth.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", comboBoxBillSummaryMonthBillingMonth.Text),
                        };
                        reportViewerBillSummaryMonth.LocalReport.SetParameters(param);
                        reportViewerBillSummaryMonth.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerBillSummaryMonth.RefreshReport();
        }

        private void comboBoxPenaltyBillingReportZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        bindBook(comboBoxPenaltyBillingReportBook, comboBoxPenaltyBillingReportZone, adapter);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void buttonPenaltyBillingReportSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_getPenaltyBilling_", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxPenaltyBillingReportZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@bookCode", comboBoxPenaltyBillingReportBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bookCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@billingMonthId", comboBoxPenaltyBillingReportBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@billingMonthId"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "PenaltyBillingReport");

                        ReportDataSource rds = new ReportDataSource("DataSetBillingReports", ds.Tables["PenaltyBillingReport"]);
                        reportViewerPenaltyBillingReport.LocalReport.DataSources.Clear();
                        reportViewerPenaltyBillingReport.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterZone", comboBoxPenaltyBillingReportZone.Text),
                            new ReportParameter("ReportParameterBook", comboBoxPenaltyBillingReportBook.Text),
                            new ReportParameter("ReportParameterDate", comboBoxPenaltyBillingReportBillingMonth.Text)
                        };
                        reportViewerPenaltyBillingReport.LocalReport.SetParameters(param);
                        reportViewerPenaltyBillingReport.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerPenaltyBillingReport.RefreshReport();
        }

        private void buttonBillingSummaryMaterialsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetBillingSummaryOfMaterialsAndOtherFees_", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000; // default is 30 seconds

                        DataSetMeterReadingReports ds = new DataSetMeterReadingReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@billMonth", comboBoxBillingSummaryMaterialsBillingMonth.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@billMonth"].Direction = ParameterDirection.Input;                     

                        adapter.Fill(ds, "BillingSummaryMaterialsFees");

                        ReportDataSource rds = new ReportDataSource("DataSetBillingReports", ds.Tables["BillingSummaryMaterialsFees"]);
                        reportViewerBillingSummaryMaterials.LocalReport.DataSources.Clear();
                        reportViewerBillingSummaryMaterials.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", comboBoxBillingSummaryMaterialsBillingMonth.Text)
                        };
                        reportViewerBillingSummaryMaterials.LocalReport.SetParameters(param);
                        reportViewerBillingSummaryMaterials.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerBillingSummaryMaterials.RefreshReport();
        }
    }
}
