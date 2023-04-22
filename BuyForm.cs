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
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.AddFatora == 0)
                AddFatoraBtn.Enabled = false;
            if (Previlage.Default.ManageFatora == 0)
                ManageFatoraBtn.Enabled = false;

        }

        private void ManageFatoraBtn_Click(object sender, EventArgs e)
        {
            BuyForms.ManageFatora manageFatora = new BuyForms.ManageFatora();
            manageFatora.TopLabel.Text = "إدارة فواتير المشتريات";
            manageFatora.Show();
        }

        private void SellFatoraManageBtn_Click(object sender, EventArgs e)
        {
            BuyForms.ManageFatora manageFatora = new BuyForms.ManageFatora();
            manageFatora.TopLabel.Text = "إدارة فواتير المبيعات النقدية";
            manageFatora.Show();
        }

        private void AddFatoraBtn_Click(object sender, EventArgs e)
        {
            BuyForms.AddFatora addFatora = new BuyForms.AddFatora();

            addFatora.Show();
        }

        private void TksetFatora_Click(object sender, EventArgs e)
        {
            BuyForms.ManageFatora manageFatora = new BuyForms.ManageFatora();
            manageFatora.TopLabel.Text = "إدارة فواتير المبيعات بالتقسيط";
            manageFatora.Show();
        }
    }
}
