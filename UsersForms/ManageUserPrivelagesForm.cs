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

namespace installmentsApp.AdminForms.ManageUsers
{
    public partial class ManageUserPrivelagesForm : Form
    {
        public ManageUserPrivelagesForm()
        {
            InitializeComponent();
        }
        private void ManageUserPrivelagesForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (SaveBtn.Text == "منح الصلاحيات")
                {
                    ConnectionClass.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select username from usersinfotable where hasprivelages=0", ConnectionClass.connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    usernameCB.DisplayMember = "username";
                    usernameCB.ValueMember = "username";
                    usernameCB.DataSource = table;
                }
                else
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter("Select * from PrivelagesTable where username='" + usernameCB.Text + "'", ConnectionClass.connection);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    
                    CreateBackupSW.Checked = (Convert.ToInt32(table1.Rows[0]["createbackup"]) == 1) ? true : false;
                    RestoreBackupSW.Checked = (Convert.ToInt32(table1.Rows[0]["restorebackup"]) == 1) ? true : false;
                    GrantPrivelagesSW.Checked = (Convert.ToInt32(table1.Rows[0]["grantprivelages"]) == 1) ? true : false;
                    ManageUsersSW.Checked = (Convert.ToInt32(table1.Rows[0]["manageusers"]) == 1) ? true : false;

                    AddCompany.Checked = (Convert.ToInt32(table1.Rows[0]["AddCompany"]) == 1) ? true : false;
                    ManageCompany.Checked = (Convert.ToInt32(table1.Rows[0]["ManageCompany"]) == 1) ? true : false;
                    ModifyCompany.Checked = (Convert.ToInt32(table1.Rows[0]["ModifyCompany"]) == 1) ? true : false;
                    DeleteCompany.Checked = (Convert.ToInt32(table1.Rows[0]["DeleteCompany"]) == 1) ? true : false;

                    AddCustomer.Checked = (Convert.ToInt32(table1.Rows[0]["AddCustomer"]) == 1) ? true : false;
                    ManageCustomers.Checked = (Convert.ToInt32(table1.Rows[0]["ManageCustomers"]) == 1) ? true : false;
                    ModifyCustomers.Checked = (Convert.ToInt32(table1.Rows[0]["ModifyCustomers"]) == 1) ? true : false;
                    DeleteCustomers.Checked = (Convert.ToInt32(table1.Rows[0]["DeleteCustomers"]) == 1) ? true : false;

                    AddOneProductSW.Checked = (Convert.ToInt32(table1.Rows[0]["AddOneProduct"]) == 1) ? true : false;
                    ManageProductSW.Checked = (Convert.ToInt32(table1.Rows[0]["ManageProducts"]) == 1) ? true : false;
                    ModifyProductSW.Checked = (Convert.ToInt32(table1.Rows[0]["ModifyProduct"]) == 1) ? true : false;
                    DeleteProductSW.Checked = (Convert.ToInt32(table1.Rows[0]["DeleteProduct"]) == 1) ? true : false;

                    PosSW.Checked = (Convert.ToInt32(table1.Rows[0]["Pos"]) == 1) ? true : false;
                    PosCashSW.Checked = (Convert.ToInt32(table1.Rows[0]["PosCash"]) == 1) ? true : false;
                    PosTksetSW.Checked = (Convert.ToInt32(table1.Rows[0]["PosTkset"]) == 1) ? true : false;
                    PosDiscountSW.Checked = (Convert.ToInt32(table1.Rows[0]["PosDiscount"]) == 1) ? true : false;

                    AddFatoraSW.Checked = (Convert.ToInt32(table1.Rows[0]["AddFatora"]) == 1) ? true : false;
                    ManageFatora.Checked = (Convert.ToInt32(table1.Rows[0]["ManageFatora"]) == 1) ? true : false;
                    DeleteFatora.Checked = (Convert.ToInt32(table1.Rows[0]["DeleteFatora"]) == 1) ? true : false;
                    ReportsSW.Checked = (Convert.ToInt32(table1.Rows[0]["ManageReports"]) == 1) ? true : false;
                    SndSW.Checked = (Convert.ToInt32(table1.Rows[0]["SndAdd"]) == 1) ? true : false;
                    DatabaseSW.Checked= (Convert.ToInt32(table1.Rows[0]["ManageDB"]) == 1) ? true : false;
                    AolModaSW.Checked = (Convert.ToInt32(table1.Rows[0]["AolModa"]) == 1) ? true : false;

                }
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("المستخدم لا يملك صلاحيات" +Environment.NewLine+ "الرجاء إضافة صلاحيات للمستخدم"+"ومن ثم القيام بتعديلها","رسالة معلومات",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveBtn.Text == "منح الصلاحيات")
            {
                if (usernameCB.SelectedIndex != -1)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = ConnectionClass.connection;
                    command.CommandText = "AddPrivelages_Proc";
                    command.Parameters.AddWithValue("@username", usernameCB.Text);
                    command.Parameters.AddWithValue("@createbackup", (CreateBackupSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@restorebackup", (RestoreBackupSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@grantprivelages", (GrantPrivelagesSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@manageusers", (ManageUsersSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@AddOneProduct", (AddOneProductSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ManageProducts", (ManageProductSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ModifyProduct", (ModifyProductSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@DeleteProduct", (DeleteProductSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@Pos", (PosSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@PosCash", (PosCashSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@PosTkset", (PosTksetSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@PosDiscount", (PosDiscountSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@AddCustomer", (AddCustomer.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ManageCustomers", (ManageCustomers.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ModifyCustomers", (ModifyCustomers.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@DeleteCustomers", (DeleteCustomers.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@AddFatora", (AddFatoraSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ManageFatora", (ManageFatora.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@DeleteFatora", (DeleteFatora.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@AddCompany", (AddCompany.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ManageCompany", (ManageCompany.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ModifyCompany", (ModifyCompany.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@DeleteCompany", (DeleteCompany.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ManageReports", (ReportsSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@SndAdd", (SndSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@ManageDB", (DatabaseSW.Checked) ? 1 : 0);
                    command.Parameters.AddWithValue("@AolModa", (AolModaSW.Checked) ? 1 : 0);

                    if (command.ExecuteNonQuery() >= 1)
                    {
                        Alert alert = new Alert("تمت الإضافة بنجاح", AlertForm.alertTypeEnum.Success);

                        Close();
                    }
                }
                else if (usernameCB.SelectedIndex==-1 || usernameCB.Text== "الرجاء إختيار المستخدم المراد إدارة صلاحياته على النظام")
                {
                    Alert alert = new Alert("يجب أختيار المستخدم أولاً", AlertForm.alertTypeEnum.Warning);
                }
            }
            else
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = ConnectionClass.connection;
                command.CommandText = "UpdatePrivelages_Proc";
                command.Parameters.AddWithValue("@username", usernameCB.Text);
                command.Parameters.AddWithValue("@createbackup", (CreateBackupSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@restorebackup", (RestoreBackupSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@grantprivelages", (GrantPrivelagesSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@manageusers", (ManageUsersSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@AddOneProduct", (AddOneProductSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ManageProducts", (ManageProductSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ModifyProduct", (ModifyProductSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@DeleteProduct", (DeleteProductSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@Pos", (PosSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@PosCash", (PosCashSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@PosTkset", (PosTksetSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@PosDiscount", (PosDiscountSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@AddCustomer", (AddCustomer.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ManageCustomers", (ManageCustomers.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ModifyCustomers", (ModifyCustomers.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@DeleteCustomers", (DeleteCustomers.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@AddFatora", (AddFatoraSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ManageFatora", (ManageFatora.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@DeleteFatora", (DeleteFatora.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@AddCompany", (AddCompany.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ManageCompany", (ManageCompany.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ModifyCompany", (ModifyCompany.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@DeleteCompany", (DeleteCompany.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ManageReports", (ReportsSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@SndAdd", (SndSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@ManageDB", (DatabaseSW.Checked) ? 1 : 0);
                command.Parameters.AddWithValue("@AolModa", (AolModaSW.Checked) ? 1 : 0);

                if (command.ExecuteNonQuery() == 1)
                {
                    Alert alert = new Alert("تم التعديل بنجاح", AlertForm.alertTypeEnum.Success);

                    Close();
                }
            }

        }
        private void ManageUserPrivelagesForm_Leave(object sender, EventArgs e)
        {

        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
