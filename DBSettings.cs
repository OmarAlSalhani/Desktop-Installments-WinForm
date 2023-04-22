using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Microsoft.SqlServer.Management.Smo;
using System.Collections;
using System.Data.SqlClient;
namespace installmentsApp
{
    public partial class DBSettings : Form
    {
        public DBSettings()
        {
            InitializeComponent();
        }
        bool CheckIfThisIsRightDatabase = false;
        List<string> Servers;
        private void GetServers()
        {
            Servers = new List<string>();
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow Row in servers.Rows)
            {
                Servers.Add(Row[0].ToString());
            }
            DataTable dataTable = SmoApplication.EnumAvailableSqlServers(true);
            foreach (DataRow row in dataTable.Rows)
            {
                Servers.Add(row["Name"].ToString());
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (CheckIfThisIsRightDatabase)
            {
                DatabaseSetting.Default.SerVer = ServerCB.SelectedItem.ToString();
                DatabaseSetting.Default.DataBase = DBNameCB.SelectedItem.ToString();
                DatabaseSetting.Default.Save();
                DeleteSeedCreateWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(
                    "قاعدة البيانات المختارة خاطئة" + Environment.NewLine +
                    "الرجاء أختيار قاعدة البيانات الخاصة بالنظام" + Environment.NewLine +
                    "أو التواصل مع المطور", "خطأ في أختيار قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void ServerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBNameCB.Items.Clear();
            string serverName = ServerCB.Text;
            Server server = new Server(serverName);

            foreach (Database database in server.Databases)
            {
                DBNameCB.Items.Add(database.Name);
            }

        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            DatabaseSetting.Default.SerVer ="";
            DatabaseSetting.Default.DataBase ="";
            DatabaseSetting.Default.Save();
            Application.Exit();
        }
        private void DBSettings_Load(object sender, EventArgs e)
        {
            ServerWorker.RunWorkerAsync();
        }
        private void ServerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            GetServers();
        }
        private void ServerWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConnectionClass.OpenConnection();

            foreach (string s in Servers)
            {
                ServerCB.Items.Add(s);
            }
            gunaPictureBox3.Visible = false;
            WaitPanel.Visible = false;
            this.Size = new Size(339, 479);
        }
        private void DBNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseSetting.Default.SerVer = ServerCB.Text;
            DatabaseSetting.Default.DataBase = DBNameCB.Text;
            DatabaseSetting.Default.Save();
            ConnectionClass.OpenConnection();
            if(DatabaseSetting.Default.DataBase.ToString().Trim().Length!=0)
            {
               SqlDataAdapter adapter = new SqlDataAdapter($@"

SELECT TABLE_NAME 
FROM {DatabaseSetting.Default.DataBase}.INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE';
", ConnectionClass.connection);
                DataTable t = new DataTable();
                adapter.Fill(t);
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    if(t.Rows[i][0].ToString() == "sndtable")
                    {
                        CheckIfThisIsRightDatabase = true;
                        break;
                    }
                    else CheckIfThisIsRightDatabase = false;
                }
            }
        }
        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void DeleteSeedCreateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand UseCommand = new SqlCommand();
            UseCommand.Connection = ConnectionClass.connection;
            UseCommand.CommandText = "use installmentsDB;";
            UseCommand.ExecuteNonQuery();
            SqlCommand DeleteCommand = new SqlCommand();
            DeleteCommand.Connection = ConnectionClass.connection;
            DeleteCommand.CommandType = CommandType.StoredProcedure;
            DeleteCommand.CommandText = "DeleteAll";
            DeleteCommand.ExecuteNonQuery();
            SqlCommand ReseedCommand = new SqlCommand();
            ReseedCommand.Connection = ConnectionClass.connection;
            ReseedCommand.CommandType = CommandType.StoredProcedure;
            ReseedCommand.CommandText = "Reseed";
            ReseedCommand.ExecuteNonQuery();
        }
        private void DeleteSeedCreateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SqlCommand UseCommand = new SqlCommand();
            UseCommand.Connection = ConnectionClass.connection;
            UseCommand.CommandText = "use installmentsDB;";
            UseCommand.ExecuteNonQuery();
            SqlCommand CreateAdminCommand = new SqlCommand();
            CreateAdminCommand.Connection = ConnectionClass.connection;
            CreateAdminCommand.CommandType = CommandType.StoredProcedure;
            CreateAdminCommand.CommandText = "CreateAdmin";
            CreateAdminCommand.ExecuteNonQuery();
            MessageBox.Show(
               "تم أختيار قاعدة البيانات بنجاح" + Environment.NewLine +
               "يرجى إعادة تشغيل النظام  ",
               "رسالة معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
