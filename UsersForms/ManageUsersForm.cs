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

namespace installmentsApp.UsersForms
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }
        DataTable table;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(@"Select user_id as 'الرمز', username as 'إسم المستخدم',pass as 'كلمة المرور',
employee_name as 'إسم الموظف',employee_mobile as 'الجوال',employee_address as 'العنوان',employee_salary as 'الراتب',
employee_position as 'المسمى الوظيفي'
from UsersInfoTable", ConnectionClass.connection) ;
             table = new DataTable();
            adapter.Fill(table);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gunaDataGridView1.DataSource = table;
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            if (Previlage.Default.GrantPrivelages == 0)
                AddBillBtn.Enabled = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(gunaDataGridView1.Rows[0].Cells[0].Value==null)
            {
                return;
            }
            else
            {
                string username = gunaDataGridView1.CurrentRow.Cells[1].Value.ToString();
                SqlCommand command = new SqlCommand("delete from UsersInfoTable where user_id=@id", ConnectionClass.connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value));
                SqlCommand command2 = new SqlCommand("delete from PrivelagesTable where username='"+username+"'", ConnectionClass.connection);
                
                if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery()==1)
                {
                    if (!backgroundWorker1.IsBusy)
                        backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AdminForms.ManageUsers.AddUserForm addUserForm = new AdminForms.ManageUsers.AddUserForm();
            addUserForm.TopLabel.Text = "تعديل بيانات المستخدم";
            addUserForm.IDLabel.Visible = true;
            addUserForm.IDLabel.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();
            addUserForm.SaveBtn.Text = "تعديل المستخدم";
            addUserForm.ShowDialog();
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            AdminForms.ManageUsers.ManageUserPrivelagesForm manageUserPrivelagesForm = new AdminForms.ManageUsers.ManageUserPrivelagesForm();
            manageUserPrivelagesForm.IDLabel.Text= gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();
            manageUserPrivelagesForm.usernameCB.Text = gunaDataGridView1.CurrentRow.Cells[1].Value.ToString();
            manageUserPrivelagesForm.SaveBtn.Text = "تعديل الصلاحيات";
            manageUserPrivelagesForm.Show();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
