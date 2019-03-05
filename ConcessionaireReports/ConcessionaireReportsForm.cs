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
    public partial class ConcessionaireReportsForm : Form
    {
        private string connStr;

        public ConcessionaireReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlConcessionaireReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlConcessionaireReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlConcessionaireReports.GetTabRect(e.Index);

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

        private void ConcessionaireReportsForm_Load(object sender, EventArgs e)
        {
            tabControlConcessionaireReports.DrawMode = TabDrawMode.OwnerDrawFixed;

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

                        comboBoxAccountPerBookZone.ValueMember = "zone_code";
                        comboBoxAccountPerBookZone.DisplayMember = "zone_code";
                        comboBoxAccountPerBookZone.DataSource = dsZones.Tables[0]; //this triggers the SelectedIndex property of a combobox

                        comboBoxAccountPerClassificationZone.ValueMember = "zone_code";
                        comboBoxAccountPerClassificationZone.DisplayMember = "zone_code";
                        comboBoxAccountPerClassificationZone.DataSource = dsZones.Tables[0]; //this triggers the SelectedIndex property of a combobox
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetTowns", conn))
                    {
                        DataSet dsTowns = new DataSet();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(dsTowns);

                        comboBoxAccountPerBarangayTown.ValueMember = "town_id";
                        comboBoxAccountPerBarangayTown.DisplayMember = "town_name";
                        comboBoxAccountPerBarangayTown.DataSource = dsTowns.Tables[0]; //this triggers the SelectedIndex property of a combobox
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetClassification", conn))
                    {
                        DataSet dsClassifications = new DataSet();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(dsClassifications);

                        comboBoxAccountPerClassificationClassification.ValueMember = "classification_id";
                        comboBoxAccountPerClassificationClassification.DisplayMember = "class_desc";
                        comboBoxAccountPerClassificationClassification.DataSource = dsClassifications.Tables[0]; //this triggers the SelectedIndex property of a combobox
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetAccountSummaryPerClass", conn))
                    {
                        DataSetConcessionaireReports ds = new DataSetConcessionaireReports();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(ds, "SummaryAccountPerClass");

                        ReportDataSource rds = new ReportDataSource("DataSetConcessionaireReports", ds.Tables["SummaryAccountPerClass"]);
                        reportViewerSummaryAccountsPerClass.LocalReport.DataSources.Clear();
                        reportViewerSummaryAccountsPerClass.LocalReport.DataSources.Add(rds);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerAccountPerBook.RefreshReport();
            this.reportViewerAccountPerBarangay.RefreshReport();
            this.reportViewerAccountPerClassification.RefreshReport();
            this.reportViewerSummaryAccountsPerClass.RefreshReport();
        }

        private void buttonAccountPerBookSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetAccountPerBook_", conn))
                    {
                        DataSetConcessionaireReports ds = new DataSetConcessionaireReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@bookCode", comboBoxAccountPerBookBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bookCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountPerBookZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;

                        int meterStatus = comboBoxAccountPerBookMeterStatus.SelectedIndex;
                        if (meterStatus == 0)
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@flag", "ALL");
                            adapter.SelectCommand.Parameters["@flag"].Direction = ParameterDirection.Input;
                            adapter.SelectCommand.Parameters.AddWithValue("@status_code", null);
                            adapter.SelectCommand.Parameters["@status_code"].Direction = ParameterDirection.Input;
                        }
                        else
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@status_code", ((meterStatus == 1) ? 4 : 5));
                            adapter.SelectCommand.Parameters["@status_code"].Direction = ParameterDirection.Input;
                            adapter.SelectCommand.Parameters.AddWithValue("@flag", null);
                            adapter.SelectCommand.Parameters["@flag"].Direction = ParameterDirection.Input;
                        }                       
                        adapter.Fill(ds, "AccountPerBook");

                        ReportDataSource rds = new ReportDataSource("DataSetConcessionaireReports", ds.Tables["AccountPerBook"]);
                        reportViewerAccountPerBook.LocalReport.DataSources.Clear();
                        reportViewerAccountPerBook.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterZone", comboBoxAccountPerBookZone.SelectedValue.ToString()),
                            new ReportParameter("ReportParameterBook", comboBoxAccountPerBookBook.SelectedValue.ToString())
                        };
                        reportViewerAccountPerBook.LocalReport.SetParameters(param);
                        reportViewerAccountPerBook.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            } 
            this.reportViewerAccountPerBook.RefreshReport();
        }

        private void comboBoxAccountPerBookZone_SelectedIndexChanged(object sender, EventArgs e)
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
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountPerBookZone.SelectedValue.ToString());
                        adapter.Fill(dsBooksOfZone);

                        comboBoxAccountPerBookBook.ValueMember = "book_code";
                        comboBoxAccountPerBookBook.DisplayMember = "book_code";

                        DataRow rowBook = dsBooksOfZone.Tables[0].NewRow();
                        rowBook[0] = "ALL";
                        dsBooksOfZone.Tables[0].Rows.InsertAt(rowBook, 0);

                        comboBoxAccountPerBookBook.DataSource = dsBooksOfZone.Tables[0];
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetMeterStatus", conn))
                    {
                        DataSet dsMeterStatus = new DataSet();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(dsMeterStatus);

                        comboBoxAccountPerBookMeterStatus.ValueMember = "ms_desc";
                        comboBoxAccountPerBookMeterStatus.DisplayMember = "ms_desc";

                        DataRow rowMeterStatus = dsMeterStatus.Tables[0].NewRow();
                        rowMeterStatus[0] = "ALL";
                        dsMeterStatus.Tables[0].Rows.InsertAt(rowMeterStatus, 0);

                        comboBoxAccountPerBookMeterStatus.DataSource = dsMeterStatus.Tables[0];
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void comboBoxAccountPerBarangayTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBarangaysOfTown", conn))
                    {
                        DataSet dsBarangaysOfTown = new DataSet();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@townId", comboBoxAccountPerBarangayTown.SelectedValue.ToString());
                        adapter.Fill(dsBarangaysOfTown);

                        comboBoxAccountPerBarangayBarangay.ValueMember = "barangay_id";
                        comboBoxAccountPerBarangayBarangay.DisplayMember = "brgy_name";

                        DataRow rowBook = dsBarangaysOfTown.Tables[0].NewRow();
                        rowBook[0] = "00"; //barangay_id
                        rowBook[1] = "Select Here"; // brgy_name 
                        dsBarangaysOfTown.Tables[0].Rows.InsertAt(rowBook, 0);

                        comboBoxAccountPerBarangayBarangay.DataSource = dsBarangaysOfTown.Tables[0];
                    }

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void buttonAccountPerBarangaySearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetAccountPerBrgy_", conn))
                    {
                        DataSetConcessionaireReports ds = new DataSetConcessionaireReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@townId", comboBoxAccountPerBarangayTown.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@townId"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@brgyId", comboBoxAccountPerBarangayBarangay.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@brgyId"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@connectedCode", 4);
                        adapter.SelectCommand.Parameters["@connectedCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@disconnectedCode", 5);
                        adapter.SelectCommand.Parameters["@disconnectedCode"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "AccountPerBarangay");

                        ReportDataSource rds = new ReportDataSource("DataSetConcessionaireReports", ds.Tables["AccountPerBarangay"]);
                        reportViewerAccountPerBarangay.LocalReport.DataSources.Clear();
                        reportViewerAccountPerBarangay.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterTown", comboBoxAccountPerBarangayTown.Text),
                            new ReportParameter("ReportParameterBarangay", (comboBoxAccountPerBarangayBarangay.SelectedIndex == 0 || comboBoxAccountPerBarangayBarangay.SelectedIndex == 1 ? "ALL" : comboBoxAccountPerBarangayBarangay.Text))
                        };
                        reportViewerAccountPerBarangay.LocalReport.SetParameters(param);
                        reportViewerAccountPerBarangay.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerAccountPerBarangay.RefreshReport();
        }

        private void buttonAccountPerClassificationSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetAccountPerClass_", conn))
                    {
                        DataSetConcessionaireReports ds = new DataSetConcessionaireReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountPerClassificationZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@classId", Convert.ToByte(comboBoxAccountPerClassificationClassification.SelectedValue.ToString()));
                        adapter.SelectCommand.Parameters["@classId"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@class_desc", comboBoxAccountPerClassificationClassification.Text);
                        adapter.SelectCommand.Parameters["@class_desc"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@connectedCode", 4);
                        adapter.SelectCommand.Parameters["@connectedCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@disconnectedCode", 5);
                        adapter.SelectCommand.Parameters["@disconnectedCode"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "AccountPerClassification");

                        ReportDataSource rds = new ReportDataSource("DataSetConcessionaireReports", ds.Tables["AccountPerClassification"]);
                        reportViewerAccountPerClassification.LocalReport.DataSources.Clear();
                        reportViewerAccountPerClassification.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterZone", comboBoxAccountPerClassificationZone.Text),
                            new ReportParameter("ReportParameterClassification", comboBoxAccountPerClassificationClassification.Text)
                        };
                        reportViewerAccountPerClassification.LocalReport.SetParameters(param);
                        reportViewerAccountPerClassification.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            this.reportViewerAccountPerClassification.RefreshReport();
        }
    }
}
