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
    public partial class ReceivablesReportsForm : Form
    {
        private string connStr;

        public ReceivablesReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlConcessionaireReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlReceivablesReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlReceivablesReports.GetTabRect(e.Index);

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

        private void bindZone(ComboBox cb, MySqlConnection con)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetZones", con))
            {
                DataSet dsZones = new DataSet();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dsZones);

                cb.ValueMember = "zone_code";
                cb.DisplayMember = "zone_code";
                cb.DataSource = dsZones.Tables[0];
            }
        }

        private void bindBook(ComboBox cb, ComboBox cbZone)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adap = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        DataSet dsBooksOfZone = new DataSet();
                        adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adap.SelectCommand.Parameters.AddWithValue("@zoneCode", cbZone.SelectedValue.ToString());
                        adap.Fill(dsBooksOfZone);

                        cb.ValueMember = "book_code";
                        cb.DisplayMember = "book_code";
                        cb.DataSource = dsBooksOfZone.Tables[0];
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void ReceivablesReportsForm_Load(object sender, EventArgs e)
        {
            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            tabControlReceivablesReports.DrawMode = TabDrawMode.OwnerDrawFixed;

            dateTimePickerAgingAccountCutOff.MaxDate = DateTime.Today;
            dateTimePickerAgingBookCutOff.MaxDate = DateTime.Today;
            dateTimePickerDetailedListCutOff.MaxDate = DateTime.Today;
            dateTimePickerReceivablesAccountCutOff.MaxDate = DateTime.Today;
            dateTimePickerDemandLetterCutOff.MaxDate = DateTime.Today;
            dateTimePickerDelinquentCutOff.MaxDate = DateTime.Today;
            dateTimePickerOtherReceivablesCutOff.MaxDate = DateTime.Today;

            comboBoxAgingAccountStatus.SelectedIndex = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    bindZone(comboBoxAgingAccountZone, conn);
                    bindZone(comboBoxDetailedListZone, conn);
                    bindZone(comboBoxReceivablesAccountZone, conn);
                    bindZone(comboBoxDemandLetterZone, conn);
                    bindZone(comboBoxOtherReceivablesZone, conn);

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
        }

        private void buttonAgingAccountSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.connStr))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_getAgingPerAccount_", conn))
                    {
                        adapter.SelectCommand.CommandTimeout = 5000;

                        DataSetReceivablesReports ds = new DataSetReceivablesReports();

                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@cutOff", dateTimePickerAgingAccountCutOff.Value);
                        adapter.SelectCommand.Parameters["@cutOff"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAgingAccountZone.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@zoneCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@bookCode", comboBoxAgingAccountBook.SelectedValue.ToString());
                        adapter.SelectCommand.Parameters["@bookCode"].Direction = ParameterDirection.Input;
                        adapter.SelectCommand.Parameters.AddWithValue("@status", comboBoxAgingAccountStatus.SelectedIndex);
                        adapter.SelectCommand.Parameters["@status"].Direction = ParameterDirection.Input;

                        adapter.Fill(ds, "AgingPerAccount");

                        ReportDataSource rds = new ReportDataSource("DataSetReceivablesReports", ds.Tables["AgingPerAccount"]);
                        reportViewerAgingAccount.LocalReport.DataSources.Clear();
                        reportViewerAgingAccount.LocalReport.DataSources.Add(rds);

                        ReportParameter[] param = new ReportParameter[]
                        {
                            new ReportParameter("ReportParameterDate", dateTimePickerAgingAccountCutOff.Value.ToString())
                        };
                        reportViewerAgingAccount.LocalReport.SetParameters(param);
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex, "Error!");
            }
            reportViewerAgingAccount.RefreshReport();
        }

        private void comboBoxAgingAccountZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBook(comboBoxAgingAccountBook, comboBoxAgingAccountZone);
        }

        private void comboBoxDetailedListZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBook(comboBoxDetailedListBook, comboBoxDetailedListZone);
        }

        private void comboBoxReceivablesAccountZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBook(comboBoxReceivablesAccountBook, comboBoxReceivablesAccountZone);
        }

        private void comboBoxDemandLetterZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBook(comboBoxDemandLetterBook, comboBoxDemandLetterZone);
        }

        private void comboBoxOtherReceivablesZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindBook(comboBoxOtherReceivablesBook, comboBoxOtherReceivablesZone);
        }
    }
}
