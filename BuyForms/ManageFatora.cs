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

namespace installmentsApp.BuyForms
{
    public partial class ManageFatora : Form
    {
        public ManageFatora()
        {
            InitializeComponent();
        }
        private DataTable GridViewTable(string Query)
        {
           DataTable table = new DataTable();
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConnectionClass.connection);
            adapter.Fill(table);
            return table;
        }
        public void FillDataGridView(string Query)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gunaDataGridView1.DataSource = table;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        public void DeleteFatora_Load(object sender, EventArgs e)
        {
            if (TopLabel.Text == "إدارة فواتير المشتريات")
            {
                FillDataGridView(@"Select buy_id as 'رقم الفاتورة'
                 ,company_name as 'إسم الشركة'
                 ,net_amount as 'قيمة الفاتورة'
                 ,buy_date as 'تاريخ الشراء'
                      from BuyFatoraHeadTable");
            }
            else if (TopLabel.Text == "إدارة فواتير المبيعات النقدية")
            {
                FillDataGridView(@"Select bill_id as 'رقم الفاتورة'
                 ,customer_name as 'إسم الزبون'
                 ,net_amount as 'قيمة الفاتورة'
                 ,sell_date as 'تاريخ البيع'
                      from CashFatoraHeadTable where bill_type='نقداً'");
            }
            else if (TopLabel.Text == "إدارة فواتير المبيعات بالتقسيط")
            {
                FillDataGridView(@"Select c.bill_id as 'رقم الفاتورة'
                 ,c.customer_name as 'الزبون'
                 ,c.sell_date as 'تاريخ البيع'
                 ,i.full_money as 'قيمة الفاتورة'
,i.plus_money as 'الفوائد'
,i.first_money as 'الدفعة الأولية'
,i.net_money as 'الفاتورة النهائية'
,i.one_money as 'الدفعة الدورية'
,i.time_perioed as 'طريقة الدفع'
,i.aksat_number as 'الأقساط'
,i.first_date as 'أول دفعة'
,i.last_date as 'آخر دفعة'
,i.notes as 'ملاحظات'
                      from CashFatoraHeadTable c , installmentsTable i where c.bill_id=i.bill_id and bill_type='بالتقسيط'");
            }
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TopLabel.Text== "إدارة فواتير المشتريات")
                {
                    ShowFatora showFatora = new ShowFatora();
                    showFatora.IdLabel.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();
                    showFatora.TopLabel.Text = "عرض فاتورة المشتريات";
                    showFatora.gunaDataGridView1.DataSource = GridViewTable("select product_name as 'إسم المادة',quantity as 'الكمية' from BuyFatoraBodyTable where buy_id=" + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value));
                    showFatora.ShowDialog();
                    Close();
                }
                else if (TopLabel.Text == "إدارة فواتير المبيعات النقدية")
                {
                    ShowFatora showFatora = new ShowFatora();
                    showFatora.IdLabel.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();
                    showFatora.TopLabel.Text = "عرض فاتورة المبيعات النقدية";
                    showFatora.gunaDataGridView1.DataSource = GridViewTable("select product_name as 'إسم المادة',quantity as 'الكمية' from CashSellFatoraBodyTable where bill_id=" + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value));
                    showFatora.ShowDialog();
                    Close();
                }
                else if (TopLabel.Text == "إدارة فواتير المبيعات بالتقسيط")
                {
                    ShowFatora showFatora = new ShowFatora();
                    showFatora.IdLabel.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();
                    showFatora.TopLabel.Text = "عرض فاتورة المبيعات بالتقسيط";
                    showFatora.gunaDataGridView1.DataSource = GridViewTable("select product_name as 'إسم المادة',quantity as 'الكمية' from CashSellFatoraBodyTable where bill_id=" + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value));
                    showFatora.ShowDialog();
                    Close();
                }
            }
            catch(NullReferenceException)
            {
                return;
            }
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
