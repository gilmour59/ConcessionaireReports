using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcessionaireReports
{
    public partial class ReportMenuForm : Form
    {
        public ReportMenuForm()
        {
            InitializeComponent();
        }

        private void buttonConcessionaire_Click(object sender, EventArgs e)
        {
            ConcessionaireReportsForm form = new ConcessionaireReportsForm();
            form.ShowDialog();
        }

        private void buttonMeter_Click(object sender, EventArgs e)
        {
            MeterReportsForm form = new MeterReportsForm();
            form.ShowDialog();
        }

        private void buttonMeterReading_Click(object sender, EventArgs e)
        {
            MeterReadingReportsForm form = new MeterReadingReportsForm();
            form.ShowDialog();
        }

        private void buttonBilling_Click(object sender, EventArgs e)
        {
            BillingReportsForm form = new BillingReportsForm();
            form.ShowDialog();
        }

        private void buttonCollection_Click(object sender, EventArgs e)
        {
            CollectionReportsForm form = new CollectionReportsForm();
            form.ShowDialog();
        }

        private void buttonReceivable_Click(object sender, EventArgs e)
        {
            ReceivablesReportsForm form = new ReceivablesReportsForm();
            form.ShowDialog();
        }

        private void buttonARMaintenance_Click(object sender, EventArgs e)
        {
            ARMaintenanceReportsForm form = new ARMaintenanceReportsForm();
            form.ShowDialog();
        }

        private void buttonDisconRecon_Click(object sender, EventArgs e)
        {
            DisconReconReportsForm form = new DisconReconReportsForm();
            form.ShowDialog();
        }

        private void buttonJobOrders_Click(object sender, EventArgs e)
        {
            JobOrdersReportsForm form = new JobOrdersReportsForm();
            form.ShowDialog();
        }
    }
}
