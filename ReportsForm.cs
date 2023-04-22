using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installmentsApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            RepoertsForms.ChoseDateForReportForm choseDateForReportForm = new RepoertsForms.ChoseDateForReportForm();
            choseDateForReportForm.AddNewBtn.Text = "عرض تقرير المبيعات النقدية";
            choseDateForReportForm.ShowDialog();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            RepoertsForms.ChoseDateForReportForm choseDateForReportForm = new RepoertsForms.ChoseDateForReportForm();
            choseDateForReportForm.AddNewBtn.Text = "عرض تقرير المبيعات بالتقسيط";
            choseDateForReportForm.ShowDialog();
        }

        private void CashFatoraBtn_Click(object sender, EventArgs e)
        {
            RepoertsForms.ChoseDateForReportForm choseDateForReportForm = new RepoertsForms.ChoseDateForReportForm();
            choseDateForReportForm.AddNewBtn.Text = "عرض تقرير المشتريات النقدية";
            choseDateForReportForm.ShowDialog();
        }

        private void TksetFatoraBtn_Click(object sender, EventArgs e)
        {
            RepoertsForms.ChoseDateForReportForm choseDateForReportForm = new RepoertsForms.ChoseDateForReportForm();
            choseDateForReportForm.AddNewBtn.Text = "عرض تقرير المشتريات الآجلة";
            choseDateForReportForm.ShowDialog();
        }

        private void CutomerKshfBtn_Click(object sender, EventArgs e)
        {
            RepoertsForms.CashSellsReportForm cashSellsReportForm = new RepoertsForms.CashSellsReportForm();
            RepoertsForms.ChoseDateForReportForm choseDateForReportForm = new RepoertsForms.ChoseDateForReportForm();
            cashSellsReportForm.gridView1.OptionsView.ColumnAutoWidth = false;

            choseDateForReportForm.AddNewBtn.Text = "كشف حساب زبون";
            choseDateForReportForm.backgroundWorker1.RunWorkerAsync();
            choseDateForReportForm.tableLayoutPanel6.Visible = true;
            choseDateForReportForm.ShowDialog();
        }
    }
}
