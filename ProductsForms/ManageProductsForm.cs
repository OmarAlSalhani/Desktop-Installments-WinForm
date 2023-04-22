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

namespace installmentsApp.ProductsForms
{
    public partial class ManageProductsForm : Form
    {
        public ManageProductsForm()
        {
            InitializeComponent();
        }
        public void FillDataGridView(string Query)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gunaDataGridView1.DataSource = table;
        }
        public void ManageProductsForm_Load(object sender, EventArgs e)
        {
            FillDataGridView(@"Select product_id as 'رمز المادة'
                 ,Product_name as 'إسم المادة'
                 ,buy_price as 'سعر الشراء'
                 ,cash_price as 'سعر المبيع'
                 , product_quantity as 'الكمية المتوفرة'
                      from productstable");
            if (Previlage.Default.DeleteProduct == 0)
                DeleteBtn.Enabled = false;
            if (Previlage.Default.ModifyProduct == 0)
                AddBillBtn.Enabled = false;
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            ProductsForms.AddProductForm addProductForm = new AddProductForm();
            addProductForm.TopLabel.Text = "تعديل مادة";
            SqlDataAdapter adapter = new SqlDataAdapter(@"Select * from productstable where product_id="
                                                     + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value),
                                                     ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            addProductForm.ProductNameTB.Text = table.Rows[0]["product_name"].ToString();
            addProductForm.CompanyCB.Text = table.Rows[0]["company_name"].ToString();
            addProductForm.BuyPriceTB.Text= table.Rows[0]["buy_price"].ToString();
            addProductForm.CashSellPriceTB.Text = table.Rows[0]["cash_price"].ToString();
            addProductForm.ColorTB.Text = table.Rows[0]["product_color"].ToString();
            addProductForm.WeightTB.Text = table.Rows[0]["product_weight"].ToString();
            addProductForm.ProduceDate.Value = (DateTime)table.Rows[0]["produce_date"];
            addProductForm.EndDate.Value = (DateTime)table.Rows[0]["end_date"];
            addProductForm.SaveBtn.Text = "تعديل المادة";
            addProductForm.IDLabel.Visible = true;
            addProductForm.IDLabel.Text = table.Rows[0]["product_id"].ToString();
            addProductForm.SaveBtn.Image = Properties.Resources.pencil;
            addProductForm.Show();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand command = new SqlCommand("delete from productstable where product_id=" + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value), ConnectionClass.connection);
                command.ExecuteNonQuery();
                FillDataGridView(@"Select product_id as 'رمز المادة'
                 ,Product_name as 'إسم المادة'
                 ,buy_price as 'سعر الشراء'
                 ,cash_price as 'سعر المبيع'
                 , product_quantity as 'الكمية المتوفرة'
                      from productstable");
            }
            catch(NullReferenceException)
            {
                return;
            }
        }

        private void ProductNameTB_EditValueChanged(object sender, EventArgs e)
        {
            FillDataGridView(@"Select product_id as 'رمز المادة'
                 ,Product_name as 'إسم المادة'
                 ,buy_price as 'سعر الشراء'
                 ,cash_price as 'سعر المبيع'
                 , product_quantity as 'الكمية المتوفرة'
                      from productstable where product_name like '%" + ProductNameTB.Text + "%'");
        }

        private void RefreshCashBtn_Click(object sender, EventArgs e)
        {
            FillDataGridView(@"Select product_id as 'رمز المادة'
                 ,Product_name as 'إسم المادة'
                 ,buy_price as 'سعر الشراء'
                 ,cash_price as 'سعر المبيع'
                 , product_quantity as 'الكمية المتوفرة'
                      from productstable");
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
