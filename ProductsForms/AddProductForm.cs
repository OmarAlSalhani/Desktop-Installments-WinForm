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
    public partial class AddProductForm : Form
    {
        #region التوابع
        private void ClearAll()
        {
            ProduceDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
            ProductNameTB.Text = string.Empty;
            BuyPriceTB.Text = string.Empty;
            CashSellPriceTB.Text = string.Empty;
            ColorTB.Text = string.Empty;
            WeightTB.Text = string.Empty;
        }
        private bool CheckIfTrue()
        {
            if (string.IsNullOrEmpty(ProductNameTB.Text) ||
               string.IsNullOrWhiteSpace(ProductNameTB.Text) ||
               ProductNameTB.Text.Length <= 0)
            {
                Alert alert = new Alert("أدخل إسم المنتج", AlertForm.alertTypeEnum.Warning);
                return false;
            }
            else if (CompanyCB.SelectedIndex==-1)
            {
                Alert alert = new Alert("يجب أختيار الشركة المصنعة", AlertForm.alertTypeEnum.Warning);
                return false;
            }
            return true;
        }
        private void UpdateData()
        {
            try
            {
                ConnectionClass.OpenConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = ConnectionClass.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateProduct_proc";
                command.Parameters.AddWithValue("product_id", Convert.ToInt32(IDLabel.Text));
                command.Parameters.AddWithValue("@product_name", ProductNameTB.Text);
                command.Parameters.AddWithValue("@company_name", CompanyCB.Text);
                command.Parameters.AddWithValue("@buy_price", float.Parse(BuyPriceTB.Text));
                command.Parameters.AddWithValue("@cash_price", float.Parse(CashSellPriceTB.Text));
                command.Parameters.AddWithValue("@product_color", ColorTB.Text);
                command.Parameters.AddWithValue("@product_weight", (WeightTB.Text.Length != 0) ? float.Parse(WeightTB.Text) : 0);
                command.Parameters.AddWithValue("@produce_date", ProduceDate.Value.ToString("yyyyMMdd"));
                command.Parameters.AddWithValue("@end_date", EndDate.Value.ToString("yyyyMMdd"));
                if (command.ExecuteNonQuery() == 1)
                {
                    Alert alert = new Alert("تمت عملية التعديل بنجاح", AlertForm.alertTypeEnum.Success);
                    Close();
                    
                }
                else
                {
                    Alert alert = new Alert("فشل التعديل", AlertForm.alertTypeEnum.Error);
                }
            }
            catch (SqlException Exc)
            {
                if (Exc.Message.Contains("PRIMARY"))
                {
                    Alert alert = new Alert("يوجد مادة مسجلة بنفس الإسم", AlertForm.alertTypeEnum.Warning);
                }
                else
                {
                    MessageBox.Show(Exc.Message
                   , "فشل العملية"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
                }


            }
        }
        private void AddData()
        {
            try
            {

                    ConnectionClass.OpenConnection();
                    SqlCommand command = new SqlCommand();
                    command.Connection = ConnectionClass.connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddProduct_proc";

                    command.Parameters.AddWithValue("@product_name", ProductNameTB.Text);
                    command.Parameters.AddWithValue("@company_name", CompanyCB.Text);
                    command.Parameters.AddWithValue("@buy_price", float.Parse(BuyPriceTB.Text));
                    command.Parameters.AddWithValue("@cash_price", float.Parse(CashSellPriceTB.Text));
                    command.Parameters.AddWithValue("@product_color", ColorTB.Text);
                    command.Parameters.AddWithValue("@product_weight", (WeightTB.Text.Length != 0) ? float.Parse(WeightTB.Text) : 0);
                    command.Parameters.AddWithValue("@produce_date", ProduceDate.Value.ToString("yyyyMMdd"));
                    command.Parameters.AddWithValue("@end_date", EndDate.Value.ToString("yyyyMMdd"));
                    if (command.ExecuteNonQuery() == 1)
                    {
                    Alert alert = new Alert("تمت الإضافة بنجاح", AlertForm.alertTypeEnum.Success);
                    ClearAll();
                    }
                    else
                    {
                    Alert alert = new Alert("فشل الإضافة", AlertForm.alertTypeEnum.Error);
                    }
                
               
            }
            catch (SqlException Exc)
            {
                if(Exc.Message.Contains("PRIMARY"))
                {
                    Alert alert = new Alert("يوجد مادة مسجلة بنفس الإسم", AlertForm.alertTypeEnum.Warning);
                }
                else
                {
                    MessageBox.Show(Exc.Message
                   , "فشل العملية"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
                }
               

            }
        }
        #endregion
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            CompanyCB.SelectedIndex = -1;
            CompanyCB.Text = "الشركة المصنعة";

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckIfTrue())
            {
                    if (SaveBtn.Text == "حفظ المادة")
                        AddData();
                    else UpdateData();             
            }
        }

        private void ProductNameTB_Validated(object sender, EventArgs e)
        {
            
                
        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select company_name from companytable", ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CompanyCB.DisplayMember = "company_name";
            CompanyCB.ValueMember = "company_name";
            CompanyCB.DataSource = table;
        }

        private void BuyPriceTB_EditValueChanged(object sender, EventArgs e)
        {
            if (BuyPriceTB.Text.Trim().Length == 0)
                BuyPriceTB.Text = 0.ToString();
        }

        private void CashSellPriceTB_EditValueChanged(object sender, EventArgs e)
        {
            if (CashSellPriceTB.Text.Trim().Length == 0)
                CashSellPriceTB.Text = 0.ToString();
        }
    }
}
