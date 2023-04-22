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

namespace installmentsApp.Customers
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
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

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.ModifyCustomer == 0)
                AddBillBtn.Enabled = false;
            if (Previlage.Default.DeleteCustomer == 0)
                DeleteBtn.Enabled = false;
            FillDataGridView(@"Select customer_id as 'رمز الزبون'
,customer_name as 'إسم الزبون'
,customer_phone as 'هاتف الزبون'
,customer_address as 'عنوان الزبون'
from CustomersTable");
            if (gunaDataGridView1.Rows.Count == 0)
            {
                AddBillBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }
        private void AddBillBtn_Click(object sender, EventArgs e)
        {
           
                try
                {
                    Customers.AddCustomer addCustomer = new Customers.AddCustomer();
                    addCustomer.TopLabel.Text = "تعديل زبون";
                    SqlDataAdapter adapter = new SqlDataAdapter(@"Select * from CustomersTable where customer_id="
                                                             + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value),
                                                             ConnectionClass.connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    byte[] PersonalImage;
                    byte[] ProveImage;
                    PersonalImage = (byte[])table.Rows[0]["customer_picture"];
                    ProveImage = (byte[])table.Rows[0]["customer_prove"];
                    MemoryStream PersonalStramer = new MemoryStream(PersonalImage);
                    MemoryStream ProveStramer = new MemoryStream(ProveImage);
                    addCustomer.CustomerNameTB.Text = table.Rows[0]["customer_name"].ToString();
                    addCustomer.PhoneTB.Text = table.Rows[0]["customer_phone"].ToString();
                    addCustomer.AddressTB.Text = table.Rows[0]["customer_address"].ToString();
                    addCustomer.NotesTB.Text = table.Rows[0]["notes"].ToString();
                    addCustomer.PersonalPictureBox.Image = Image.FromStream(PersonalStramer);
                    addCustomer.ProvePictureBox.Image = Image.FromStream(ProveStramer);
                    addCustomer.SaveBtn.Text = "تعديل الزبون";
                    addCustomer.IDLabel.Visible = true;
                    addCustomer.IDLabel.Text = table.Rows[0]["customer_id"].ToString();
                    addCustomer.SaveBtn.Image = Properties.Resources.pencil;
                    addCustomer.Show();
                }
                catch (NullReferenceException)
                {
                Alert alert = new Alert("الرجاء أختيار الزبون أولاً", AlertForm.alertTypeEnum.Info);
                }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from customerstable where customer_id=" + Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value), ConnectionClass.connection);
            command.ExecuteNonQuery();
            FillDataGridView(@"Select customer_id as 'رمز الزبون'
,customer_name as 'إسم الزبون'
,customer_phone as 'هاتف الزبون'
,customer_address as 'عنوان الزبون'
from CustomersTable");
        }

        private void RefreshCashBtn_Click(object sender, EventArgs e)
        {
            FillDataGridView(@"Select customer_id as 'رمز الزبون'
,customer_name as 'إسم الزبون'
,customer_phone as 'هاتف الزبون'
,customer_address as 'عنوان الزبون'
from CustomersTable");
        }

        private void CustomerNameTB_EditValueChanged(object sender, EventArgs e)
        {
            FillDataGridView(@"Select customer_id as 'رمز الزبون'
,customer_name as 'إسم الزبون'
,customer_phone as 'هاتف الزبون'
,customer_address as 'عنوان الزبون'
from CustomersTable where customer_name like '%"+CustomerNameTB.Text+"%'");
        }
    }
}
