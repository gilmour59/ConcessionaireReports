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
    public partial class JobOrdersReportsForm : Form
    {
        private string connStr;

        public JobOrdersReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlJobOrdersReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlJobOrdersReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlJobOrdersReports.GetTabRect(e.Index);

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

        private void JobOrdersReportsForm_Load(object sender, EventArgs e)
        {
            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            dateTimePickerJobOrderSumTo.MaxDate = DateTime.Today;
            dateTimePickerJobOrderWorkTo.MaxDate = DateTime.Today;
            dateTimePickerAccomplishedJOTo.MaxDate = DateTime.Today;
            dateTimePickerPendingJOTo.MaxDate = DateTime.Today;
        }

        private void beforeAwait(PictureBox pb, Button b)
        {
            //tabControlCollectionReports.TabPages[0].Enabled = false;
            foreach (TabPage tp in tabControlJobOrdersReports.TabPages)
            {
                if (!(tp == tabControlJobOrdersReports.SelectedTab))
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
            foreach (TabPage tp in tabControlJobOrdersReports.TabPages)
            {
                tp.Enabled = true;
            }
            b.Enabled = true;
            pb.Hide();
        }

        private async void buttonJobOrderSumSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingJobOrderSum, buttonJobOrderSumSearch);

            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetJobOrderSummary_", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetJobOrdersReports ds = new DataSetJobOrdersReports();

                            Invoke((MethodInvoker)delegate ()
                            {
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.Parameters.AddWithValue("@startDate", dateTimePickerJobOrderSumFrom.Value);
                                adapter.SelectCommand.Parameters["@startDate"].Direction = ParameterDirection.Input;
                                adapter.SelectCommand.Parameters.AddWithValue("@endDate", dateTimePickerJobOrderSumTo.Value);
                                adapter.SelectCommand.Parameters["@endDate"].Direction = ParameterDirection.Input;
                            });

                            adapter.Fill(ds, "JOSummary");

                            ReportDataSource rds = new ReportDataSource("DataSetJobOrdersReports", ds.Tables["JOSummary"]);
                            reportViewerJobOrderSum.LocalReport.DataSources.Clear();
                            reportViewerJobOrderSum.LocalReport.DataSources.Add(rds);

                            ReportParameter[] param = new ReportParameter[]
                            {
                                new ReportParameter("ReportParameterFrom", dateTimePickerJobOrderSumFrom.Value.ToString()),
                                new ReportParameter("ReportParameterTo", dateTimePickerJobOrderSumTo.Value.ToString())
                            };
                            reportViewerJobOrderSum.LocalReport.SetParameters(param);
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });

            afterAwait(pictureBoxLoadingJobOrderSum, buttonJobOrderSumSearch);

            reportViewerJobOrderSum.RefreshReport();
        }
    }
}
