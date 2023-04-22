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
    public partial class ManageCompanies : Form
    {
        public ManageCompanies()
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

        private void ManageCompanies_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.ModifyComapny == 0)
                AddBillBtn.Enabled = false;
            if (Previlage.Default.DeleteCompany == 0)
                DeleteBtn.Enabled = false;
            FillDataGridView(@"Select company_id as 'الرمز'
                 ,company_name as 'الإسم'
                 ,company_dealer_name as 'إسم المندوب'
                 ,company_dealer_mobile as 'رقم المندوب'
, company_landline as 'هاتف الشركة'
                      from companytable");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand command = new SqlCommand("delete from companytable where company_id=" + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value), ConnectionClass.connection);
                command.ExecuteNonQuery();
                FillDataGridView(@"Select company_id as 'الرمز'
                 ,company_name as 'الإسم'
                 ,company_dealer_name as 'إسم المندوب'
                 ,company_dealer_mobile as 'رقم المندوب'
, company_landline as 'هاتف الشركة'
                      from companytable");
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void CompanyNameTB_EditValueChanged(object sender, EventArgs e)
        {
            FillDataGridView(@"Select company_id as 'الرمز'
                 ,company_name as 'الإسم'
                 ,company_dealer_name as 'إسم المندوب'
                 ,company_dealer_mobile as 'رقم المندوب'
, company_landline as 'هاتف الشركة'
                      from companytable where company_name like '%" + CompanyNameTB.Text + "%'");

        }

        private void RefreshCashBtn_Click(object sender, EventArgs e)
        {
            FillDataGridView(@"Select company_id as 'الرمز'
                 ,company_name as 'الإسم'
                 ,company_dealer_name as 'إسم المندوب'
                 ,company_dealer_mobile as 'رقم المندوب'
, company_landline as 'هاتف الشركة'
                      from companytable");
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            CompaniesForms.AddCompany addCompany = new CompaniesForms.AddCompany();
            addCompany.TopLabel.Text = "تعديل شركة";
            SqlDataAdapter adapter = new SqlDataAdapter(@"Select * from companytable where company_id="
                                                     + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value),
                                                     ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            addCompany.CompanyNameTB.Text = table.Rows[0]["company_name"].ToString();
            addCompany.DealerMobileTB.Text = table.Rows[0]["company_dealer_mobile"].ToString();
            addCompany.DealerNameTB.Text = table.Rows[0]["company_dealer_name"].ToString();
            addCompany.CompanyAddress.Text = table.Rows[0]["company_address"].ToString();
            addCompany.CompanyMobile.Text = table.Rows[0]["company_landline"].ToString();
            addCompany.SaveBtn.Text = "تعديل المادة";
            addCompany.IDLabel.Text = table.Rows[0]["company_id"].ToString();
            addCompany.SaveBtn.Image = Properties.Resources.pencil;
            addCompany.Show();
        }
    }
}
