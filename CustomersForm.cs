using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace installmentsApp
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            DevExpress.Dialogs.Core.Localization.DialogsLocalizer.Active=new TestAr.CustomDialogLocalizer();
        }
       

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            Customers.AddCustomer addCustomer = new Customers.AddCustomer();
            addCustomer.ShowDialog();
            
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            Customers.ManageCustomers manageCustomers = new Customers.ManageCustomers();
          
            manageCustomers.Show();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
           

        }

  

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.AddCustomer == 0)
                AddCustomer.Enabled = false;
            if (Previlage.Default.ManageCustomers == 0)
                ManageCustomers.Enabled = false;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraSaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
