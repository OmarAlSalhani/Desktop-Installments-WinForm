using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace installmentsApp
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {

            InitializeComponent();

        }
        int A = 0;
        int B = 0;
        int Sum = 0;
        int C = 0;
        int D = 0;
        int E = 0;
        private void ShowPOS()
        {
            POSForm POSFORM = new POSForm();
            POSFORM.Show();
            DadForm dadForm = new DadForm();
            dadForm.Hide();

        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ShowPOS();
            
        }
       
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.Pos == 0)
                PosBtn.Enabled = false;
                backgroundWorker1.RunWorkerAsync();

        }

        private void RefreshCashBtn_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy)
            {
                MessageBox.Show("أنتظر");
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("select isnull(sum(first_money),0) from installmentsTable where bill_id in(select bill_id from CashFatoraHeadTable where sell_date=CONVERT(VARCHAR(10), getdate(), 110));", ConnectionClass.connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter("select isnull(sum (net_amount),0) from CashFatoraHeadTable where bill_type='نقداً' and  sell_date=CONVERT(VARCHAR(10), getdate(), 110);", ConnectionClass.connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter("select isnull(sum (net_amount),0) from CashFatoraHeadTable where bill_type='بالتقسيط' and  sell_date=CONVERT(VARCHAR(10), getdate(), 110);", ConnectionClass.connection);
            SqlDataAdapter adapter3 = new SqlDataAdapter("select isnull(sum (net_amount),0) from BuyFatoraHeadTable where bill_type='نقداً' and buy_date=CONVERT(VARCHAR(10), getdate(), 110);", ConnectionClass.connection);
            SqlDataAdapter adapter4 = new SqlDataAdapter("select isnull(sum (howpay),0) from installmentDetTable where date=CONVERT(VARCHAR(10), getdate(), 110);", ConnectionClass.connection);
            DataTable table4 = new DataTable();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            adapter.Fill(table);
            adapter1.Fill(table1);
            adapter2.Fill(table2);
            adapter3.Fill(table3);
            adapter4.Fill(table4);
                A =Convert.ToInt32( table.Rows[0][0]);
                B =Convert.ToInt32( table1.Rows[0][0]);
                C = Convert.ToInt32(table2.Rows[0][0]);
                D = Convert.ToInt32(table3.Rows[0][0]);
                E = Convert.ToInt32(table4.Rows[0][0]);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Sum = Convert.ToInt32((A + B + E)-D);

            TodayCashLabel.Text = Sum.ToString();
            TodayTksetLabel.Text = C.ToString();
            TodayBuyLabel.Text = D.ToString();

        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
