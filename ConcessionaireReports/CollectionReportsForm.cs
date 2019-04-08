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

        private void bindTeller(ComboBox cb, DateTimePicker dt, MySqlConnection con)
        {
            using (MySqlDataAdapter adap = new MySqlDataAdapter("sp_GilgetTellersByTransDate", con))
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
        }

        private void CollectionReportsForm_Load(object sender, EventArgs e)
        {
            tabControlCollectionReports.DrawMode = TabDrawMode.OwnerDrawFixed;

            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            //This needs to be after the connStr because of the datetimepicker changed value function;
            dateTimePickerDailyCollectionReportDate.MaxDate = DateTime.Today;
            dateTimePickerDCR2Date.MaxDate = DateTime.Today;
            dateTimePickerCollectionSummaryZoneBookDate.MaxDate = DateTime.Today;
            dateTimePickerCDCRDate.MaxDate = DateTime.Today;
            dateTimePickerMonthlyCollectionReportTo.MaxDate = DateTime.Today;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetItem", conn))
                    {
                        DataSet dsItem = new DataSet();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(dsItem);

                        comboBoxSummaryMiscellaneousFeesItem.ValueMember = "item_id";
                        comboBoxSummaryMiscellaneousFeesItem.DisplayMember = "item_desc";
                        comboBoxSummaryMiscellaneousFeesItem.DataSource = dsItem.Tables[0];
                    }

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void dateTimePickerDailyCollectionReportDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                  
                    bindTeller(comboBoxDailyCollectionReportTeller, dateTimePickerDailyCollectionReportDate, conn);
                    
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

                    bindTeller(comboBoxDCR2Teller, dateTimePickerDCR2Date, conn);
                    
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
            bindDCR(dateTimePickerDailyCollectionReportDate, comboBoxDailyCollectionReportTeller, reportViewerDailyCollectionReport, "sp_GilGetDCR2", "DailyCollectionReport");         
        }

        private void buttonDCR2Search_Click(object sender, EventArgs e)
        {
            bindDCR(dateTimePickerDCR2Date, comboBoxDCR2Teller, reportViewerDCR2, "sp_GilGetDCR", "DailyCollectionReport2");
        }

        private void buttonCollectionSummaryZoneBookSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetCollectionSummaryPerBook", conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_trans_date", dateTimePickerCollectionSummaryZoneBookDate.Value);
                        adapter.SelectCommand.Parameters["@in_trans_date"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "CollectionSummaryPerBookZone");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["CollectionSummaryPerBookZone"]);
                        reportViewerCollectionSummaryZoneBook.LocalReport.DataSources.Clear();
                        reportViewerCollectionSummaryZoneBook.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", dateTimePickerCollectionSummaryZoneBookDate.Value.ToString())
                        };
                        reportViewerCollectionSummaryZoneBook.LocalReport.SetParameters(param);
                        //reportViewerDailyCollectionReport.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerCollectionSummaryZoneBook.RefreshReport();
        }

        private void buttonCashReceiptRecordSearch_Click(object sender, EventArgs e)
        {            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    int id = (int)comboBoxCashReceiptRecordTeller.SelectedValue;
                    bindTellerDate(dateTimePickerCashReceiptRecordDate, id, reportViewerCashReceiptRecord, "sp_GilGetCashReceiptAndRemittanceRecord", "CashReceiptRemittanceRecord", conn);

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerCashReceiptRecord.RefreshReport();
        }

        private void bindTellerDate(DateTimePicker dt, int user_id, ReportViewer rv, string sp, string dataTable, MySqlConnection con)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sp, con))
            {
                DataSetCollectionReports ds = new DataSetCollectionReports();

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@in_trans_date", dt.Value);
                adapter.SelectCommand.Parameters["@in_trans_date"].Direction = ParameterDirection.Input;
                adapter.SelectCommand.Parameters.AddWithValue("@in_user_id", user_id);
                adapter.SelectCommand.Parameters["@in_user_id"].Direction = ParameterDirection.Input;

                adapter.Fill(ds, dataTable);

                ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables[dataTable]);
                rv.LocalReport.DataSources.Clear();
                rv.LocalReport.DataSources.Add(rds);

                ReportParameter[] param = new ReportParameter[]
                {
                    new ReportParameter("ReportParameterDate", dt.Value.ToString())
                };
                rv.LocalReport.SetParameters(param);
                //reportViewerDailyCollectionReport.LocalReport.Refresh();
            }   
        }

        private void dateTimePickerCashReceiptRecordDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    bindTeller(comboBoxCashReceiptRecordTeller, dateTimePickerCashReceiptRecordDate, conn);

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void buttonCDCRSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    bindTellerDate(dateTimePickerCDCRDate, 0, reportViewerCDCR, "sp_GetCDCR", "CashierDailyCollectionReport", conn);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetCDCRRecap", conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_trans_date", dateTimePickerCDCRDate.Value);
                        adapter.SelectCommand.Parameters["@in_trans_date"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "CDCRRecap");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports2", ds.Tables["CDCRRecap"]);
                        reportViewerCDCR.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerCDCR.RefreshReport();           
        }

        private void buttonMonthlyCollectionReportSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetMonthlyCollectionReport", conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_start_date", dateTimePickerMonthlyCollectionReportFrom.Value);
                        adapter.SelectCommand.Parameters["@in_start_date"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_end_date", dateTimePickerMonthlyCollectionReportTo.Value);
                        adapter.SelectCommand.Parameters["@in_end_date"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_user_id", 0);
                        adapter.SelectCommand.Parameters["@in_user_id"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "MonthlyCollectionReport");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["MonthlyCollectionReport"]);
                        reportViewerMonthlyCollectionReport.LocalReport.DataSources.Clear();
                        reportViewerMonthlyCollectionReport.LocalReport.DataSources.Add(rds);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetMonthlyCollectionReportTotal", conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_start_date", dateTimePickerMonthlyCollectionReportFrom.Value);
                        adapter.SelectCommand.Parameters["@in_start_date"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_end_date", dateTimePickerMonthlyCollectionReportTo.Value);
                        adapter.SelectCommand.Parameters["@in_end_date"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "MonthlyCollectionReportTotal");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports2", ds.Tables["MonthlyCollectionReportTotal"]);
                        reportViewerMonthlyCollectionReport.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerMonthlyCollectionReport.RefreshReport();
        }

        private void dateTimePickerMonthlyCollectionReportTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerMonthlyCollectionReportFrom.MaxDate = dateTimePickerMonthlyCollectionReportTo.Value;
        }

        private void buttonPaymentSummaryMaterialsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetPaymentSummaryOfMaterials", conn))
                    {
                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_trans_date", dateTimePickerPaymentSummaryMaterialsDate.Value);
                        adapter.SelectCommand.Parameters["@in_trans_date"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "PaymentSummaryMaterials");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["PaymentSummaryMaterials"]);
                        reportViewerPaymentSummaryMaterials.LocalReport.DataSources.Clear();
                        reportViewerPaymentSummaryMaterials.LocalReport.DataSources.Add(rds);
                    }                   
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerPaymentSummaryMaterials.RefreshReport();
        }

        private void beforeAwait(PictureBox pb, Button b)
        {
            //tabControlCollectionReports.TabPages[0].Enabled = false;
            foreach (TabPage tp in tabControlCollectionReports.TabPages)
            {
                if (!(tp == tabControlCollectionReports.SelectedTab))
                {
                    tp.Enabled = false;
                }
            }
            b.Enabled = false;
            pb.Show();
            pb.Update();
        }

        private void afterAwait(PictureBox pb, Button b)
        {
            foreach (TabPage tp in tabControlCollectionReports.TabPages)
            {
                tp.Enabled = true; 
            }
            b.Enabled = true;
            pb.Hide();
        }

        private async void buttonSummarySeniorCitizenDiscountSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingSenior, buttonSummarySeniorCitizenDiscountSearch);

            await Task.Run(() => 
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetSeniorCitizenDiscountSummary", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetCollectionReports ds = new DataSetCollectionReports();

                            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                            adapter.SelectCommand.Parameters.AddWithValue("@in_start_date", dateTimePickerSummarySeniorCitizenDiscountFrom.Value);
                            adapter.SelectCommand.Parameters["@in_start_date"].Direction = ParameterDirection.Input;
                            adapter.SelectCommand.Parameters.AddWithValue("@in_end_date", dateTimePickerSummarySeniorCitizenDiscountTo.Value);
                            adapter.SelectCommand.Parameters["@in_end_date"].Direction = ParameterDirection.Input;

                            adapter.Fill(ds, "SummarySeniorDiscount");

                            ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["SummarySeniorDiscount"]);
                            reportViewerSummarySeniorCitizenDiscount.LocalReport.DataSources.Clear();
                            reportViewerSummarySeniorCitizenDiscount.LocalReport.DataSources.Add(rds);
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });
            afterAwait(pictureBoxLoadingSenior, buttonSummarySeniorCitizenDiscountSearch);

            reportViewerSummarySeniorCitizenDiscount.RefreshReport();
        }

        private void buttonSummaryCancelledORSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetSummaryCancelledOR", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000;

                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@in_trans_date", dateTimePickerSummaryCancelledORDate.Value);
                        adapter.SelectCommand.Parameters["@in_trans_date"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "SummaryCancelledOR");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["SummaryCancelledOR"]);
                        reportViewerSummaryCancelledOR.LocalReport.DataSources.Clear();
                        reportViewerSummaryCancelledOR.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerSummaryCancelledOR.RefreshReport();
        }

        private void dateTimePickerSummarySeniorCitizenDiscountTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummarySeniorCitizenDiscountFrom.MaxDate = dateTimePickerSummarySeniorCitizenDiscountTo.Value;
        }

        private void dateTimePickerSummaryWithholdingTaxesTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummaryWithholdingTaxesFrom.MaxDate = dateTimePickerSummaryWithholdingTaxesTo.Value;
        }

        private async void buttonSummaryWithholdingTaxesSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingWithholdingTaxes, buttonSummaryWithholdingTaxesSearch);

            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetWTaxSummary", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetCollectionReports ds = new DataSetCollectionReports();

                            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                            adapter.SelectCommand.Parameters.AddWithValue("@startDate", dateTimePickerSummaryWithholdingTaxesFrom.Value);
                            adapter.SelectCommand.Parameters["@startDate"].Direction = ParameterDirection.Input;
                            adapter.SelectCommand.Parameters.AddWithValue("@endDate", dateTimePickerSummaryWithholdingTaxesTo.Value);
                            adapter.SelectCommand.Parameters["@endDate"].Direction = ParameterDirection.Input;

                            adapter.Fill(ds, "SummaryWithholdingTaxes");

                            ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["SummaryWithholdingTaxes"]);
                            reportViewerSummaryWithholdingTaxes.LocalReport.DataSources.Clear();
                            reportViewerSummaryWithholdingTaxes.LocalReport.DataSources.Add(rds);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetWTaxSummaryRecap", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetCollectionReports ds = new DataSetCollectionReports();

                            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                            adapter.SelectCommand.Parameters.AddWithValue("@startDate", dateTimePickerSummaryWithholdingTaxesFrom.Value);
                            adapter.SelectCommand.Parameters["@startDate"].Direction = ParameterDirection.Input;
                            adapter.SelectCommand.Parameters.AddWithValue("@endDate", dateTimePickerSummaryWithholdingTaxesTo.Value);
                            adapter.SelectCommand.Parameters["@endDate"].Direction = ParameterDirection.Input;

                            adapter.Fill(ds, "SummaryWithholdingTaxesRecap");

                            ReportDataSource rds = new ReportDataSource("DataSetCollectionReports2", ds.Tables["SummaryWithholdingTaxesRecap"]);
                            reportViewerSummaryWithholdingTaxes.LocalReport.DataSources.Add(rds);
                        }

                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });
            afterAwait(pictureBoxLoadingWithholdingTaxes, buttonSummaryWithholdingTaxesSearch);

            reportViewerSummaryWithholdingTaxes.RefreshReport();
        }

        private void dateTimePickerSummaryMiscellaneousFeesTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSummaryMiscellaneousFeesFrom.MaxDate = dateTimePickerSummaryMiscellaneousFeesTo.Value;
        }

        private async void buttonSummaryMiscellaneousFeesSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingMisc, buttonSummaryMiscellaneousFeesSearch);

            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_getSummaryOfMiscellaneousFees", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetCollectionReports ds = new DataSetCollectionReports();

                            Invoke((MethodInvoker) delegate() 
                            {
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.Parameters.AddWithValue("@itemId", comboBoxSummaryMiscellaneousFeesItem.SelectedValue);
                                adapter.SelectCommand.Parameters["@itemId"].Direction = ParameterDirection.Input;
                                adapter.SelectCommand.Parameters.AddWithValue("@startDate", dateTimePickerSummaryMiscellaneousFeesFrom.Value);
                                adapter.SelectCommand.Parameters["@startDate"].Direction = ParameterDirection.Input;
                                adapter.SelectCommand.Parameters.AddWithValue("@endDate", dateTimePickerSummaryMiscellaneousFeesTo.Value);
                                adapter.SelectCommand.Parameters["@endDate"].Direction = ParameterDirection.Input;
                            });
                                                       
                            adapter.Fill(ds, "SummaryMiscellaneousFees");

                            ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["SummaryMiscellaneousFees"]);
                            reportViewerSummaryMiscellaneousFees.LocalReport.DataSources.Clear();
                            reportViewerSummaryMiscellaneousFees.LocalReport.DataSources.Add(rds);

                            ReportParameter[] param = new ReportParameter[]
                            {
                                new ReportParameter("ReportParameterFrom", dateTimePickerSummaryMiscellaneousFeesFrom.Value.ToString()),
                                new ReportParameter("ReportParameterTo", dateTimePickerSummaryMiscellaneousFeesTo.Value.ToString())
                            };
                            reportViewerSummaryMiscellaneousFees.LocalReport.SetParameters(param);
                            reportViewerSummaryMiscellaneousFees.LocalReport.Refresh();
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });
            afterAwait(pictureBoxLoadingMisc, buttonSummaryMiscellaneousFeesSearch);

            reportViewerSummaryMiscellaneousFees.RefreshReport();
        }

        private void buttonDailyCollectionSummaryZoneSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetDCR3", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000;

                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@transDate", dateTimePickerDailyCollectionSummaryZoneDate.Value);
                        adapter.SelectCommand.Parameters["@transDate"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "DailyCollectionPerZone");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["DailyCollectionPerZone"]);
                        reportViewerDailyCollectionSummaryZone.LocalReport.DataSources.Clear();
                        reportViewerDailyCollectionSummaryZone.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerDailyCollectionSummaryZone.RefreshReport();
        }

        private void buttonDailyCollectionSummarySearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetDailyCollectionSummary", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000;

                        DataSetCollectionReports ds = new DataSetCollectionReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@transDate", dateTimePickerDailyCollectionSummaryDate.Value);
                        adapter.SelectCommand.Parameters["@transDate"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "DailyCollectionSummary");

                        ReportDataSource rds = new ReportDataSource("DataSetCollectionReports", ds.Tables["DailyCollectionSummary"]);
                        reportViewerDailyCollectionSummary.LocalReport.DataSources.Clear();
                        reportViewerDailyCollectionSummary.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerDailyCollectionSummary.RefreshReport();
        }
    }
}
