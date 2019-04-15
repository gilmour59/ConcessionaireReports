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
    public partial class ARMaintenanceReportsForm : Form
    {
        private string connStr;

        public ARMaintenanceReportsForm()
        {
            InitializeComponent();
        }

        private void tabControlARMaintenanceReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlARMaintenanceReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlARMaintenanceReports.GetTabRect(e.Index);

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

        private void ARMaintenanceReportsForm_Load(object sender, EventArgs e)
        {
            connStr = "server=localhost;user=root;database=mrwdbcsys;port=3306;password=";

            tabControlARMaintenanceReports.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        private void beforeAwait(PictureBox pb, Button b)
        {
            //tabControlCollectionReports.TabPages[0].Enabled = false;
            foreach (TabPage tp in tabControlARMaintenanceReports.TabPages)
            {
                if (!(tp == tabControlARMaintenanceReports.SelectedTab))
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
            foreach (TabPage tp in tabControlARMaintenanceReports.TabPages)
            {
                tp.Enabled = true;
            }
            b.Enabled = true;
            pb.Hide();
        }

        private async void buttonPromissoryNoteSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingPromissoryNote, buttonPromissoryNoteSearch);

            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GilGetPromissoryNotesSummary_", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetARMaintenanceReports ds = new DataSetARMaintenanceReports();

                            Invoke((MethodInvoker)delegate () 
                            {
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.Parameters.AddWithValue("@startDate", dateTimePickerPromissoryNoteFrom.Value);
                                adapter.SelectCommand.Parameters["@startDate"].Direction = ParameterDirection.Input;
                                adapter.SelectCommand.Parameters.AddWithValue("@endDate", dateTimePickerPromissoryNoteTo.Value);
                                adapter.SelectCommand.Parameters["@endDate"].Direction = ParameterDirection.Input;
                            });
                            
                            adapter.Fill(ds, "PromissoryNotes");

                            ReportDataSource rds = new ReportDataSource("DataSetARMaintenanceReports", ds.Tables["PromissoryNotes"]);
                            reportViewerPromissoryNote.LocalReport.DataSources.Clear();
                            reportViewerPromissoryNote.LocalReport.DataSources.Add(rds);

                            ReportParameter[] param = new ReportParameter[]
                            {
                                new ReportParameter("ReportParameterFrom", dateTimePickerPromissoryNoteFrom.Value.ToString()),
                                new ReportParameter("ReportParameterTo", dateTimePickerPromissoryNoteTo.Value.ToString())
                            };
                            reportViewerPromissoryNote.LocalReport.SetParameters(param);
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });

            afterAwait(pictureBoxLoadingPromissoryNote, buttonPromissoryNoteSearch);
            
            reportViewerPromissoryNote.RefreshReport();
        }

        private async void buttonOverduePromiNoteSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingOverduePromiNote, buttonOverduePromiNoteSearch);

            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetOverDuePromissoryNotesSummary_", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetARMaintenanceReports ds = new DataSetARMaintenanceReports();

                            Invoke((MethodInvoker)delegate ()
                            {
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.Parameters.AddWithValue("@asOfDate", dateTimePickerOverduePromiNoteAsOf.Value);
                                adapter.SelectCommand.Parameters["@asOfDate"].Direction = ParameterDirection.Input;                               
                            });

                            adapter.Fill(ds, "OverduePN");

                            ReportDataSource rds = new ReportDataSource("DataSetARMaintenanceReports", ds.Tables["OverduePN"]);
                            reportViewerOverduePromiNote.LocalReport.DataSources.Clear();
                            reportViewerOverduePromiNote.LocalReport.DataSources.Add(rds);

                            ReportParameter[] param = new ReportParameter[]
                            {
                                new ReportParameter("ReportParameterDate", dateTimePickerOverduePromiNoteAsOf.Value.ToString())
                            };
                            reportViewerOverduePromiNote.LocalReport.SetParameters(param);
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });

            afterAwait(pictureBoxLoadingOverduePromiNote, buttonOverduePromiNoteSearch);

            reportViewerOverduePromiNote.RefreshReport();
        }

        private async void buttonDebCredMemoSearch_Click(object sender, EventArgs e)
        {
            beforeAwait(pictureBoxLoadingDebCredMemo, buttonDebCredMemoSearch);

            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(this.connStr))
                    {
                        conn.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter("sp_GetDMCMSummary_", conn))
                        {
                            adapter.SelectCommand.CommandTimeout = 5000;

                            DataSetARMaintenanceReports ds = new DataSetARMaintenanceReports();

                            Invoke((MethodInvoker)delegate ()
                            {
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.Parameters.AddWithValue("@startDate", dateTimePickerDebCredMemoFrom.Value);
                                adapter.SelectCommand.Parameters["@startDate"].Direction = ParameterDirection.Input;
                                adapter.SelectCommand.Parameters.AddWithValue("@endDate", dateTimePickerDebCredMemoTo.Value);
                                adapter.SelectCommand.Parameters["@endDate"].Direction = ParameterDirection.Input;
                            });

                            adapter.Fill(ds, "DMCM");

                            ReportDataSource rds = new ReportDataSource("DataSetARMaintenanceReports", ds.Tables["DMCM"]);
                            reportViewerDebCredMemo.LocalReport.DataSources.Clear();
                            reportViewerDebCredMemo.LocalReport.DataSources.Add(rds);

                            ReportParameter[] param = new ReportParameter[]
                            {
                                new ReportParameter("ReportParameterFrom", dateTimePickerDebCredMemoFrom.Value.ToString()),
                                new ReportParameter("ReportParameterTo", dateTimePickerDebCredMemoTo.Value.ToString())
                            };
                            reportViewerDebCredMemo.LocalReport.SetParameters(param);
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error: " + ex, "Error!");
                }
            });

            afterAwait(pictureBoxLoadingDebCredMemo, buttonDebCredMemoSearch);

            reportViewerDebCredMemo.RefreshReport();
        }
    }
}
