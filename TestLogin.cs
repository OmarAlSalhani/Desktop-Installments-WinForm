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
using System.Globalization;

namespace installmentsApp
{
    public partial class TestLogin : Form
    {
        string username = null;
        string password = null;
        bool OK = false;
        public TestLogin()
        {

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text.Trim().Length == 0 || passwordTB.Text.Trim().Length == 0)
            {
                MessageBox.Show("يجب كتابة إسم المستخدم وكلمة المرور", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LoginBtn.Visible = false;
                if (!backgroundWorker100.IsBusy)
                    backgroundWorker100.RunWorkerAsync();
            }

        }
        private void usernameTB_EditValueChanged(object sender, EventArgs e)
        {
            username = usernameTB.Text;
        }

        private void passwordTB_EditValueChanged(object sender, EventArgs e)
        {
            password = passwordTB.Text;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (OK)
            {
                Hide();
                DadForm form = new DadForm();
                form.Show();

            }
            else LoginBtn.Visible = true;

        }


        private void WaitPanel_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void TestLogin_Load(object sender, EventArgs e)
        {

            if (DatabaseSetting.Default.DataBase.ToString().Trim().Length==0 || DatabaseSetting.Default.SerVer.ToString().Trim().Length == 0)
            {
                DBSettings dBSettings = new DBSettings();
                dBSettings.ShowDialog();
            }

        }

        private void TestLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TestLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void backgroundWorker100_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ConnectionClass.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from UsersInfoTable where username='" + username + "'and pass='" + password + "'", ConnectionClass.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("خطأ في بيانات الدخول" + Environment.NewLine + "الرجاء المحاولة مجدداً", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Settings.Default.username = username;
                    SqlDataAdapter adapter1 = new SqlDataAdapter("select * from PrivelagesTable where username='" + username + "'", ConnectionClass.connection);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    Previlage.Default.CreateBackup = (Convert.ToInt32(table1.Rows[0]["createbackup"])) == 0 ? 0 : 1;
                    Previlage.Default.RestoreBackup = (Convert.ToInt32(table1.Rows[0]["restorebackup"])) == 0 ? 0 : 1;
                    Previlage.Default.GrantPrivelages = (Convert.ToInt32(table1.Rows[0]["grantprivelages"])) == 0 ? 0 : 1;
                    Previlage.Default.ManageUsers = (Convert.ToInt32(table1.Rows[0]["manageusers"])) == 0 ? 0 : 1;
                    Previlage.Default.AddOneProduct = (Convert.ToInt32(table1.Rows[0]["AddOneProduct"])) == 0 ? 0 : 1;
                    Previlage.Default.ManageProduct = (Convert.ToInt32(table1.Rows[0]["ManageProducts"])) == 0 ? 0 : 1;
                    Previlage.Default.ModifyProduct = (Convert.ToInt32(table1.Rows[0]["ModifyProduct"])) == 0 ? 0 : 1;
                    Previlage.Default.DeleteProduct = (Convert.ToInt32(table1.Rows[0]["DeleteProduct"])) == 0 ? 0 : 1;
                    Previlage.Default.Pos = (Convert.ToInt32(table1.Rows[0]["Pos"])) == 0 ? 0 : 1;
                    Previlage.Default.PosCash = (Convert.ToInt32(table1.Rows[0]["PosCash"])) == 0 ? 0 : 1;
                    Previlage.Default.PosDiscount = (Convert.ToInt32(table1.Rows[0]["PosDiscount"])) == 0 ? 0 : 1;
                    Previlage.Default.PosTkset = (Convert.ToInt32(table1.Rows[0]["PosTkset"])) == 0 ? 0 : 1;
                    Previlage.Default.AddCustomer = (Convert.ToInt32(table1.Rows[0]["AddCustomer"])) == 0 ? 0 : 1;
                    Previlage.Default.DeleteCustomer = (Convert.ToInt32(table1.Rows[0]["DeleteCustomers"])) == 0 ? 0 : 1;
                    Previlage.Default.ManageCustomers = (Convert.ToInt32(table1.Rows[0]["ManageCustomers"])) == 0 ? 0 : 1;
                    Previlage.Default.ModifyCustomer = (Convert.ToInt32(table1.Rows[0]["ModifyCustomers"])) == 0 ? 0 : 1;
                    Previlage.Default.AddFatora = (Convert.ToInt32(table1.Rows[0]["AddFatora"])) == 0 ? 0 : 1;
                    Previlage.Default.DeleteFatora = (Convert.ToInt32(table1.Rows[0]["DeleteFatora"])) == 0 ? 0 : 1;
                    Previlage.Default.ManageFatora = (Convert.ToInt32(table1.Rows[0]["ManageFatora"])) == 0 ? 0 : 1;
                    Previlage.Default.AddCompany = (Convert.ToInt32(table1.Rows[0]["AddCompany"])) == 0 ? 0 : 1;
                    Previlage.Default.ManageCompany = (Convert.ToInt32(table1.Rows[0]["ManageCompany"])) == 0 ? 0 : 1;
                    Previlage.Default.ModifyComapny = (Convert.ToInt32(table1.Rows[0]["ModifyCompany"])) == 0 ? 0 : 1;
                    Previlage.Default.DeleteCompany = (Convert.ToInt32(table1.Rows[0]["DeleteCompany"])) == 0 ? 0 : 1;

                    Previlage.Default.ManageReports = (Convert.ToInt32(table1.Rows[0]["ManageReports"])) == 0 ? 0 : 1;
                    Previlage.Default.SndAdd = (Convert.ToInt32(table1.Rows[0]["SndAdd"])) == 0 ? 0 : 1;
                    Previlage.Default.ManageDB = (Convert.ToInt32(table1.Rows[0]["ManageDB"])) == 0 ? 0 : 1;


                    Settings.Default.Save();
                    OK = true;


                }

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("المستخدم لا يملك أي صلاحيات" + Environment.NewLine + "لا يمكن تسجيل الدخول");
                OK = false;
            }
            catch(SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
