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
    public partial class ShowFatora : Form
    {
        public ShowFatora()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowFatora_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.DeleteFatora == 0)
                AddBillBtn.Enabled = false;
            if (TopLabel.Text == "إدارة فواتير المشتريات")
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from BuyFatoraHeadTable where buy_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                TotalAmountTB.Text = table.Rows[0]["total_amount"].ToString();
                DiscountsTB.Text = table.Rows[0]["discount"].ToString();
                NetAmountTB.Text = table.Rows[0]["net_amount"].ToString();
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from CashFatoraHeadTable where bill_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                TotalAmountTB.Text = table.Rows[0]["total_amount"].ToString();
                DiscountsTB.Text = table.Rows[0]["discounts"].ToString();
                NetAmountTB.Text = table.Rows[0]["net_amount"].ToString();
            }
 
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            if (TopLabel.Text == "عرض فاتورة المشتريات")
            {
                SqlCommand DecreaseQualityCommand = new SqlCommand();
                DecreaseQualityCommand.CommandText = "update ProductsTable set product_quantity=product_quantity-@Qun where product_name=@name";
                DecreaseQualityCommand.Connection = ConnectionClass.connection;
                for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
                {
                    DecreaseQualityCommand.Parameters.Clear();
                    DecreaseQualityCommand.Parameters.AddWithValue("@Qun", Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[1].Value));
                    DecreaseQualityCommand.Parameters.AddWithValue("@name", gunaDataGridView1.Rows[i].Cells[0].Value.ToString());
                    DecreaseQualityCommand.ExecuteNonQuery();
                }
                SqlCommand command = new SqlCommand("delete from BuyFatoraBodyTable where buy_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("delete from BuyFatoraHeadTable where buy_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                command2.ExecuteNonQuery();
                Close();
            }
            else if (TopLabel.Text == "عرض فاتورة المبيعات النقدية")
            {
                SqlCommand DecreaseQualityCommand = new SqlCommand();
                DecreaseQualityCommand.CommandText = "update ProductsTable set product_quantity=product_quantity+@Qun where product_name=@name";
                DecreaseQualityCommand.Connection = ConnectionClass.connection;
                for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
                {
                    DecreaseQualityCommand.Parameters.Clear();
                    DecreaseQualityCommand.Parameters.AddWithValue("@Qun", Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[1].Value));
                    DecreaseQualityCommand.Parameters.AddWithValue("@name", gunaDataGridView1.Rows[i].Cells[0].Value.ToString());
                    DecreaseQualityCommand.ExecuteNonQuery();
                }
                SqlCommand command = new SqlCommand("delete from CashSellFatoraBodyTable where bill_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("delete from CashFatoraHeadTable where bill_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                command2.ExecuteNonQuery();
                Close();
            }
            else if (TopLabel.Text == "عرض فاتورة المبيعات بالتقسيط")
            {
                SqlCommand DecreaseQualityCommand = new SqlCommand();
                DecreaseQualityCommand.CommandText = "update ProductsTable set product_quantity=product_quantity+@Qun where product_name=@name";
                DecreaseQualityCommand.Connection = ConnectionClass.connection;
                for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
                {
                    DecreaseQualityCommand.Parameters.Clear();
                    DecreaseQualityCommand.Parameters.AddWithValue("@Qun", Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[1].Value));
                    DecreaseQualityCommand.Parameters.AddWithValue("@name", gunaDataGridView1.Rows[i].Cells[0].Value.ToString());
                    DecreaseQualityCommand.ExecuteNonQuery();
                }
                SqlCommand command = new SqlCommand("delete from CashSellFatoraBodyTable where bill_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("delete from CashFatoraHeadTable where bill_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                SqlCommand command4 = new SqlCommand("delete from installmentDetTable where installment_id=(select installment_id from installmentsTable where bill_id=" + Convert.ToInt32(IdLabel.Text) + ")", ConnectionClass.connection);
                SqlCommand command3 = new SqlCommand("delete from installmentsTable where bill_id=" + Convert.ToInt32(IdLabel.Text), ConnectionClass.connection);
                command2.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                Close();
            }

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
