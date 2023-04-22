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

namespace installmentsApp.CompaniesForms
{
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            CompanyNameTB.Text = string.Empty;
            DealerNameTB.Text = string.Empty;
            DealerMobileTB.Text = string.Empty;
            CompanyMobile.Text = string.Empty;
            CompanyAddress.Text = string.Empty;
        }
        private void AddData()
        {

            if (CompanyNameTB.Text.Trim().Length == 0)
            {
                Alert alert = new Alert("يجب كتابة إسم الشركة", AlertForm.alertTypeEnum.Success);
                return;
            }
            else
            {
                ConnectionClass.OpenConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = ConnectionClass.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddCompany_proc";
                command.Parameters.AddWithValue("@comapny_name", CompanyNameTB.Text);
                command.Parameters.AddWithValue("@company_dealer_name", DealerNameTB.Text);
                command.Parameters.AddWithValue("@company_dealer_mobile", DealerMobileTB.Text);
                command.Parameters.AddWithValue("@company_landline", CompanyMobile.Text);
                command.Parameters.AddWithValue("@company_address", CompanyAddress.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    Alert alert = new Alert("تمت الإضافة بنجاح",AlertForm.alertTypeEnum.Success);
                    ClearAll();
                }

            }
        }
        private void UpdateData()
        {
            if (CompanyNameTB.Text.Trim().Length == 0)
            {
                Alert alert = new Alert("يجب كتابة إسم الشركة", AlertForm.alertTypeEnum.Success);
                return;
            }
            else
            {
                ConnectionClass.OpenConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = ConnectionClass.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateCompany_proc";
                command.Parameters.AddWithValue("@company_id", Convert.ToInt32(IDLabel.Text));
                command.Parameters.AddWithValue("@comapny_name", CompanyNameTB.Text);
                command.Parameters.AddWithValue("@company_dealer_name", DealerNameTB.Text);
                command.Parameters.AddWithValue("@company_dealer_mobile", DealerMobileTB.Text);
                command.Parameters.AddWithValue("@company_landline", CompanyMobile.Text);
                command.Parameters.AddWithValue("@company_address", CompanyAddress.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    Alert alert = new Alert("تم التعديل بنجاح", AlertForm.alertTypeEnum.Success);
                    ClearAll();
                }

            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveBtn.Text == "إضافة الشركة")
                {
                    AddData();
                }
                else UpdateData();
 
            }
            catch(SqlException EXc)
            {
                if(EXc.Message.Contains("unique "))
                {
                    Alert alert = new Alert("الشركة موجودة مسبقاً", AlertForm.alertTypeEnum.Warning);
                }
                else
                {
                    MessageBox.Show(EXc.Message);
                }
            }

        }
        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
