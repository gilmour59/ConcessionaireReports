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
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

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
                    DataSet dsZones = new DataSet();
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetZones", conn);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dsZones);

                    comboBoxAccountPerBookZone.ValueMember = "zone_code";
                    comboBoxAccountPerBookZone.DisplayMember = "zone_code";
                    comboBoxAccountPerBookZone.DataSource = dsZones.Tables[0]; //this triggers the SelectedIndex property of a combobox

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                error.Text = "error: " + ex; //Change This to pop up
            }
            this.reportViewerAccountPerBook.RefreshReport();
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
                        AccountPerBookReport ds = new AccountPerBookReport();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@bookCode", comboBoxAccountPerBookBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bookCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountPerBookZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;

                        string meterStatus = comboBoxAccountPerBookMeterStatus.SelectedValue.ToString();
                        if (meterStatus == "ALL")
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@flag", meterStatus);
                            adapter.SelectCommand.Parameters["@flag"].Direction = ParameterDirection.Input;
                            adapter.SelectCommand.Parameters.AddWithValue("@status_code", null);
                            adapter.SelectCommand.Parameters["@status_code"].Direction = ParameterDirection.Input;
                        }
                        else
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@status_code", meterStatus);
                            adapter.SelectCommand.Parameters["@status_code"].Direction = ParameterDirection.Input;
                            adapter.SelectCommand.Parameters.AddWithValue("@flag", null);
                            adapter.SelectCommand.Parameters["@flag"].Direction = ParameterDirection.Input;
                        }                       
                        adapter.Fill(ds, ds.Tables[0].TableName);

                        ReportDataSource rds = new ReportDataSource("AccountPerBookReport", ds.Tables[0]);
                        reportViewerAccountPerBook.LocalReport.DataSources.Clear();
                        reportViewerAccountPerBook.LocalReport.DataSources.Add(rds);
                        reportViewerAccountPerBook.LocalReport.Refresh();
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                error.Text = "error: " + ex; //Change This to pop up
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
                error.Text = "error: " + ex; //Change This to pop up
            }
        }
    }
}
