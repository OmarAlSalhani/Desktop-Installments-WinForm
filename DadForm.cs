using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace installmentsApp
{
    public partial class DadForm : Form
    {
        public DadForm()
        {
            InitializeComponent();
        }
        #region عرض الواجهات

        private void ShowProducts()
        {
            HomePanel.Controls.Clear();
            ProductsForms.ProductsForm addProductForm = new ProductsForms.ProductsForm
            {
                TopLevel = false,
                WindowState = FormWindowState.Maximized
            };
            HomePanel.Controls.Add(addProductForm);
            addProductForm.Show();
        }
        private void ShowReports()
        {
            HomePanel.Controls.Clear();
            ReportsForm reportsForm = new ReportsForm
            {
                TopLevel = false,
                WindowState = FormWindowState.Maximized
            };
            HomePanel.Controls.Add(reportsForm);
            reportsForm.Show();
        }
        private void ShowSettings()
        {
            HomePanel.Controls.Clear();
            SettingForm settingForm = new SettingForm
            {
                TopLevel = false,
                WindowState = FormWindowState.Maximized
            };
            HomePanel.Controls.Add(settingForm);
            settingForm.Show();
        }
        private void ShowBuy()
        {
            HomePanel.Controls.Clear();
            BuyForm buyForms = new BuyForm
            {
                TopLevel = false,
                WindowState = FormWindowState.Maximized
            };
            HomePanel.Controls.Add(buyForms);
            buyForms.Show();
        }

        private void ShowDashboard()
        {
            HomePanel.Controls.Clear();
            DashboardForm dashboardForm = new DashboardForm
            {
                TopLevel = false,
                WindowState = FormWindowState.Maximized
            };
            HomePanel.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }
        private void ShowCustomers()
        {
            HomePanel.Controls.Clear();
            CustomersForm customersForm = new CustomersForm
            {
                TopLevel = false,
                WindowState = FormWindowState.Maximized
            };
            HomePanel.Controls.Add(customersForm);
            customersForm.Show();
        }

        #endregion
        private void DadForm_Load(object sender, EventArgs e)
        {
            if(Previlage.Default.SndAdd==0)
            {
                gunaAdvenceButton1.Visible = false;
                gunaAdvenceButton1.Enabled = false;
            }
            usernameLabel.Text = Settings.Default.username;
            ShowDashboard();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }
        private void POSBtn_Click(object sender, EventArgs e)
        {
            ShowBuy();
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد بالتأكيد إغلاق التطبيق ؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                ConnectionClass.CloseConnection();
                Application.Exit();
            }
            else return;

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void CompanyBtn_Click(object sender, EventArgs e)
        {

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {     

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            TestNofi testNofi = new TestNofi();
            testNofi.ShowDialog();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            ShowReports();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            SndQbdForm sndQbdForm = new SndQbdForm();
            sndQbdForm.Show();
        }
    }
}
