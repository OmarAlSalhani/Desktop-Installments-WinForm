using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace installmentsApp
{
    class ConnectionClass
    {
        public static SqlConnection connection =
             new SqlConnection(@"Server=" + DatabaseSetting.Default.SerVer+
                 ";Database=" + DatabaseSetting.Default.DataBase+
                 ";Integrated Security=true;MultipleActiveResultSets=true");
        public static void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
           
        }
        public static void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
