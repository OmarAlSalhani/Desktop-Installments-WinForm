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
namespace installmentsApp
{
    public partial class SndQbdForm : Form
    {
        public SndQbdForm()
        {
            InitializeComponent();
        }
        DataTable CustomersTable;
        int S;
        private void fillgrid()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"
select
installmet_det_id as #
,date as 'تاريخ تسديد الدفعة'
,fullmoney as 'المبلغ الواجب تسديده'
,howpay as 'المبلغ المدفوع'
,howstay as 'المبلغ المتبقي'
from installmentDetTable where installment_id=
" + Convert.ToInt32(DiscountsTB.Text), ConnectionClass.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gunaDataGridView1.DataSource = table;
            }
            catch(FormatException)
            {
                return;
            }
        }

        private void SndQbdForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }
        private void CustomersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select installment_id from installmentsTable where customer_name='" + CustomersCB.Text + "'", ConnectionClass.connection);
            table.Clear();
            adapter.Fill(table);
            BillCB.DisplayMember = "installment_id";
            BillCB.ValueMember = "installment_id";
            BillCB.DataSource = table;
            BillCB.Text="رقم الفاتورة";
            DiscountsTB.Text = string.Empty;

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("Select customer_name from CustomersTable where customer_name in (select customer_name from installmentsTable)", ConnectionClass.connection);
            CustomersTable = new DataTable();
            adapter.Fill(CustomersTable);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                CustomersCB.DisplayMember = "customer_name";
                CustomersCB.ValueMember = "customer_name";
                CustomersCB.DataSource = CustomersTable;
                S = Convert.ToInt32(BillCB.Text);
            }
            catch(FormatException)
            {
                return;
            }
        }

        private void BillCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            DiscountsTB.Text = BillCB.Text;

        }

        private void gunaDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gunaDataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    gunaDataGridView1.CurrentRow.Cells[4].Value =
                   Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[2].Value)
                    - Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[3].Value);
                    SqlCommand command = new SqlCommand();
                    command.Connection = ConnectionClass.connection;
                    command.CommandText = @"update installmentDetTable set howpay=@howpay,howstay=@howstay where installmet_det_id=@id";
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value));
                    command.Parameters.AddWithValue("@howpay", Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[3].Value));
                    command.Parameters.AddWithValue("@howstay", Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[4].Value));
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Alert alert = new Alert("تم التسديد بنجاح", AlertForm.alertTypeEnum.Success);
                        fillgrid();
                    }
                }
            }
            catch(InvalidCastException)
            {
                gunaDataGridView1.CancelEdit();
            }
        }
        private void gunaDataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (gunaDataGridView1.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null || tb.Text.Trim().Length!=0)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            fillgrid();
            gunaDataGridView1.Columns[0].Visible = false;
            gunaDataGridView1.Columns[1].ReadOnly = true;
            gunaDataGridView1.Columns[2].ReadOnly = true;
            gunaDataGridView1.Columns[4].ReadOnly = true;
        }
    }
}
