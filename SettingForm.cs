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
using System.IO;

namespace installmentsApp
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            DevExpress.Dialogs.Core.Localization.DialogsLocalizer.Active = new TestAr.CustomDialogLocalizer();

        }
        public SqlConnection Backupconnection;

        private void RestoreBackup()
        {
            try
            {


                if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string FileName = xtraOpenFileDialog1.FileName;
                    Backupconnection = new SqlConnection("Data Source=" + DatabaseSetting.Default.SerVer + ";initial Catalog=master;Integrated Security=true");
                    ConnectionClass.connection.Close();
                    Backupconnection.Open();
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Backupconnection;
                    Command.CommandText = "ALTER DATABASE installmentsDB SET OFFLINE WITH ROLLBACK IMMEDIATE;RESTORE DATABASE installmentsDB FROM DISK ='" + FileName + "'with replace";
                    Command.ExecuteNonQuery();
                    MessageBox.Show("تمت العملية بنجاح");
                    Command.CommandText = "ALTER DATABASE installmentsDB SET ONLINE WITH ROLLBACK IMMEDIATE";
                    Command.ExecuteNonQuery();
                    MessageBox.Show("يرجى إعادة تشغيل البرنامج من جديد", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            catch(SqlException Exc)
            {
                if(Exc.Message.Contains("It is being used by database"))
                {
                    MessageBox.Show("قاعدة البيانات مفتوحة");
                }
            }

        }
        private void CreateBackup(string _name)
        {
            try
            {
                if (File.Exists(_name + "\\installmentsDB.bak"))
                {
                    File.Delete(_name + "\\installmentsDB.bak");
                    SqlCommand command = new SqlCommand();
                    command.Connection = ConnectionClass.connection;
                    command.CommandText = "Backup database installmentsDB to disk='" + _name + "\\installmentsDB.bak'";
                    command.ExecuteNonQuery();
                    if (File.Exists(_name + "\\installmentsDB.bak"))
                        MessageBox.Show("تمت العملية بنجاح");
                }
                else
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = ConnectionClass.connection;
                    command.CommandText = "Backup database installmentsDB to disk='" + _name + "\\installmentsDB.bak'";
                    command.ExecuteNonQuery();

                    if (File.Exists(_name + "\\installmentsDB.bak"))
                        MessageBox.Show("تمت العملية بنجاح");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Access is denied"))
                {
                    MessageBox.Show("لا يمكن التخزين في هذا المسار");
                }
            }

        }
        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string FolderName = xtraFolderBrowserDialog1.SelectedPath;
                CreateBackup(FolderName);
            }
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            RestoreBackup();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.CreateBackup == 0)
                CreateBackupBtn.Enabled = false;
            if (Previlage.Default.RestoreBackup == 0)
                RestoreBackupBtn.Enabled = false;
            if (Previlage.Default.ManageUsers == 0)
                ManageUsersBtn.Enabled = false;
            if (Previlage.Default.GrantPrivelages == 0)
                GrantPrivelagesBtn.Enabled = false;
            if (Previlage.Default.ManageDB == 0)
                gunaAdvenceTileButton1.Enabled = false;

        }

        private void AddUsersBtn_Click(object sender, EventArgs e)
        {
            AdminForms.ManageUsers.AddUserForm addUserForm = new AdminForms.ManageUsers.AddUserForm();
            addUserForm.ShowDialog();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {

            AdminForms.ManageUsers.ManageUserPrivelagesForm manageUserPrivelagesForm = new AdminForms.ManageUsers.ManageUserPrivelagesForm();
            manageUserPrivelagesForm.Show();
        }

        private void ManageUsersBtn_Click(object sender, EventArgs e)
        {
            SettingsForms.UsersPrivelagesForm usersPrivelagesForm = new SettingsForms.UsersPrivelagesForm();
            usersPrivelagesForm.ShowDialog();
        }

        private void gunaAdvenceTileButton2_Click_1(object sender, EventArgs e)
        {
            SettingsForms.ReportSetting reportSetting = new SettingsForms.ReportSetting();
            reportSetting.Show();
        }

        private void gunaAdvenceTileButton1_Click_1(object sender, EventArgs e)
        {
            DBSettings dBSettings = new DBSettings();
            dBSettings.ShowDialog();
        }
    }
}
