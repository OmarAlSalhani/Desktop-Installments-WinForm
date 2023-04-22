using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installmentsApp.SettingsForms
{
    public partial class UsersPrivelagesForm : Form
    {
        public UsersPrivelagesForm()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
                AdminForms.ManageUsers.AddUserForm addUserForm = new AdminForms.ManageUsers.AddUserForm();
                addUserForm.ShowDialog();            

        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
                UsersForms.ManageUsersForm manageUsersForm = new UsersForms.ManageUsersForm();
                manageUsersForm.Show();
        }
    }
}
