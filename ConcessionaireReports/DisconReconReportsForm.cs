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
    public partial class DisconReconReportsForm : Form
    {
        private string connStr;

        public DisconReconReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlDisconReconReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlDisconReconReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlDisconReconReports.GetTabRect(e.Index);

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

        private void DisconReconReportsForm_Load(object sender, EventArgs e)
        {
            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            tabControlDisconReconReports.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        private void beforeAwait(PictureBox pb, Button b)
        {
            //tabControlCollectionReports.TabPages[0].Enabled = false;
            foreach (TabPage tp in tabControlDisconReconReports.TabPages)
            {
                if (!(tp == tabControlDisconReconReports.SelectedTab))
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
            foreach (TabPage tp in tabControlDisconReconReports.TabPages)
            {
                tp.Enabled = true;
            }
            b.Enabled = true;
            pb.Hide();
        }

        private async void buttonReconnectSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingReconnect, buttonReconnectSearch);

            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetReConnectionSummary_", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetDisconReconReports ds = new DataSetDisconReconReports();

                            Invoke((MethodInvoker)delegate ()
                            {
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.Parameters.AddWithValue("@fromDate", dateTimePickerReconnectFrom.Value);
                                adapter.SelectCommand.Parameters["@fromDate"].Direction = ParameterDirection.Input;
                                adapter.SelectCommand.Parameters.AddWithValue("@toDate", dateTimePickerReconnectTo.Value);
                                adapter.SelectCommand.Parameters["@toDate"].Direction = ParameterDirection.Input;
                            });

                            adapter.Fill(ds, "Reconnect");

                            ReportDataSource rds = new ReportDataSource("DataSetDisconReconReports", ds.Tables["Reconnect"]);
                            reportViewerReconnect.LocalReport.DataSources.Clear();
                            reportViewerReconnect.LocalReport.DataSources.Add(rds);                        
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });

            afterAwait(pictureBoxLoadingReconnect, buttonReconnectSearch);

            reportViewerReconnect.RefreshReport();
        }
    }
}
