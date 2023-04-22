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

namespace installmentsApp.RepoertsForms
{
    public partial class ChoseDateForReportForm : Form
    {
        public ChoseDateForReportForm()
        {
            InitializeComponent();
        }
        DataTable table;
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            DataTable table;
            CashSellsReportForm sellsReportForm1 = new CashSellsReportForm();
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionClass.connection;
            ConnectionClass.OpenConnection();

            if (AddNewBtn.Text == "عرض تقرير المبيعات النقدية")
            {
                command.CommandText = @"select bill_id AS 'رقم الفاتورة'
,customer_name AS 'إسم الزبون'
, CONVERT(varchar, sell_date, 121) AS 'تاريخ البيع'
,total_amount AS 'القيمة الإجمالية'
,discounts AS 'الخصم'
,net_amount AS 'القيمة النهائية'
from cashfatoraheadtable where sell_date between (@firstdate) and (@lastdate) and bill_type='نقداً'";
                command.Parameters.AddWithValue("@firstdate", FirstDate.Value.ToString("yyyyMMdd"));
                command.Parameters.AddWithValue("@lastdate", LastDate.Value.ToString("yyyyMMdd"));
                sellsReportForm1.TopLabel.Text = "تقرير المبيعات النقدية";

            }
            else if(AddNewBtn.Text=="عرض تقرير المبيعات بالتقسيط")
            {
                command.CommandText = @"Select c.bill_id as 'رقم الفاتورة'
                 ,c.customer_name as 'الزبون'
                 ,c.sell_date as 'تاريخ البيع'
                 ,i.full_money as 'قيمة الفاتورة'
,i.plus_money as 'الفوائد'
,i.first_money as 'الدفعة الأولية'
,i.net_money as 'القيمة النهائية'
,i.one_money as 'الدفعة الدورية'
,i.time_perioed as 'طريقة الدفع'
,i.aksat_number as 'الأقساط'
,i.first_date as 'أول دفعة'
,i.last_date as 'آخر دفعة'
,i.notes as 'ملاحظات'
                      from CashFatoraHeadTable c , installmentsTable i where c.bill_id=i.bill_id and  sell_date between (@firstdate) and (@lastdate) and c.bill_type='بالتقسيط'";
                command.Parameters.AddWithValue("@firstdate", FirstDate.Value.ToString("yyyyMMdd"));
                command.Parameters.AddWithValue("@lastdate", LastDate.Value.ToString("yyyyMMdd"));
                sellsReportForm1.TopLabel.Text = "تقرير المبيعات بالتقسيط";

            }
            else if (AddNewBtn.Text == "عرض تقرير المشتريات النقدية")
            {
                command.CommandText = @"select buy_id AS 'رقم الفاتورة'
,company_name AS 'إسم الشركة'
, CONVERT(varchar, buy_date, 121) AS 'تاريخ الشراء'
,total_amount AS 'القيمة الإجمالية'
,discount AS 'الخصم'
,net_amount AS 'القيمة النهائية'
from BuyFatoraHeadTable where buy_date between (@firstdate) and (@lastdate) and bill_type='نقداً'";
                command.Parameters.AddWithValue("@firstdate", FirstDate.Value.ToString("yyyyMMdd"));
                command.Parameters.AddWithValue("@lastdate", LastDate.Value.ToString("yyyyMMdd"));
                sellsReportForm1.TopLabel.Text = "تقرير المشتريات النقدية";

            }
            else if (AddNewBtn.Text == "عرض تقرير المشتريات الآجلة")
            {
                command.CommandText = @"select buy_id AS 'رقم الفاتورة'
,company_name AS 'إسم الشركة'
, CONVERT(varchar, buy_date, 121) AS 'تاريخ الشراء'
,total_amount AS 'القيمة الإجمالية'
,discount AS 'الحسومات'
,net_amount AS 'القيمة النهائية'
from BuyFatoraHeadTable where buy_date between (@firstdate) and (@lastdate) and bill_type='آجل'";
                command.Parameters.AddWithValue("@firstdate", FirstDate.Value.ToString("yyyyMMdd"));
                command.Parameters.AddWithValue("@lastdate", LastDate.Value.ToString("yyyyMMdd"));
                sellsReportForm1.TopLabel.Text = "تقرير المشتريات الآجلة";
            }
            else if (AddNewBtn.Text == "كشف حساب زبون")
            {
                command.CommandText = @"Select c.bill_id as 'رقم الفاتورة'
                 ,c.sell_date as 'تاريخ البيع'
                 ,i.full_money as 'قيمة الفاتورة'
,i.plus_money as 'الفوائد'
,i.first_money as 'المقدمة'
,i.net_money as 'القيمة النهائية'
,i.one_money as 'المبلغ'
,i.time_perioed as 'الدفع'
,i.aksat_number as 'الأقساط'
,i.first_date as 'أول دفعة'
,i.last_date as 'آخر دفعة'
,i.notes as 'ملاحظات'
                      from CashFatoraHeadTable c , installmentsTable i where c.bill_id=i.bill_id and c.customer_name=@customername and sell_date between (@firstdate) and (@lastdate) and bill_type='بالتقسيط'";
                command.Parameters.AddWithValue("@firstdate", FirstDate.Value.ToString("yyyyMMdd"));
                command.Parameters.AddWithValue("@lastdate", LastDate.Value.ToString("yyyyMMdd"));
                command.Parameters.AddWithValue("@customername", CustomerCB.Text);
            
                sellsReportForm1.gridView1.BestFitColumns();
                sellsReportForm1.TopLabel.Text = "كشف حساب"+" "+CustomerCB.Text;
                sellsReportForm1.DetaielsIcon.Visible = true;
            }
            using (SqlDataReader sdr = command.ExecuteReader())
            {
                table = new DataTable();
                table.Clear();
                table.Load(sdr);
            }
            sellsReportForm1.gridControl1.DataSource = table;
           
            sellsReportForm1.DateLabel.Text = "من تاريخ" + " " + FirstDate.Value.ToString("dd-MM-yyyy") + " " + " إلى تاريخ" + " " + LastDate.Value.ToString("dd-MM-yyyy");
            sellsReportForm1.Show();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CustomerCB.DisplayMember = "customer_name";
            CustomerCB.ValueMember = "customer_name";
            CustomerCB.DataSource = table;
            CustomerCB.SelectedIndex = -1;
            CustomerCB.Text = "إسم الزبون";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("Select customer_name from customerstable", ConnectionClass.connection);
            table = new DataTable();
            adapter.Fill(table);
        }
    }
}
