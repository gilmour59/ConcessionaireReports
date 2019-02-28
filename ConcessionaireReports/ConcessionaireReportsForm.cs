using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    comboBoxAccountPerBookZone.DataSource = dsZones.Tables[0];
                    comboBoxAccountPerBookZone.DisplayMember = "zone_code";
                    comboBoxAccountPerBookZone.ValueMember = "zone_code";
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
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "sp_GetAccountPerBook_";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@bookCode", comboBoxAccountPerBookBook); //needs value
                cmd.Parameters["@bookCode"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@zoneCode", comboBoxAccountPerBookZone); //needs value
                cmd.Parameters["@zoneCode"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@statusCode", comboBoxAccountPerBookMeterStatus); //needs value
                cmd.Parameters["@statusCode"].Direction = ParameterDirection.Input;

            }
            catch (MySqlException ex)
            {
                error.Text = "error: " + ex; //Change This to pop up
            }
            finally
            {
                conn.Close();
            }

            this.reportViewerAccountPerBook.RefreshReport();
        }

        private void comboBoxAccountPerBookZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    DataSet dsBooksOfZone = new DataSet();
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetBooksOfZone", conn))
                    {
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@zoneCode", comboBoxAccountPerBookZone.SelectedValue.ToString());
                        adapter.Fill(dsBooksOfZone);
                        comboBoxAccountPerBookBook.DataSource = dsBooksOfZone.Tables[0];
                    }
                }
            }
            catch (MySqlException ex)
            {
                error.Text = "error: " + ex; //Change This to pop up
            }
        }
    }
}
