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

                        //Account Per Book Zone
                        comboBoxReadingSlipZone.ValueMember = "zone_code";
                        comboBoxReadingSlipZone.DisplayMember = "zone_code";
                        comboBoxReadingSlipZone.DataSource = dsZones.Tables[0]; //this triggers the SelectedIndex property of a combobox
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBillingMonthsId", conn))
                    {
                        DataSet dsBillMonth = new DataSet();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.Fill(dsBillMonth);

                        comboBoxReadingSlipBillingMonth.ValueMember = "billing_month_id";
                        comboBoxReadingSlipBillingMonth.DisplayMember = "month_year"; 
                        comboBoxReadingSlipBillingMonth.DataSource = dsBillMonth.Tables[0]; //this triggers the SelectedIndex property of a combobox
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
    }
}
