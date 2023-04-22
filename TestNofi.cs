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
    public partial class TestNofi : Form
    {
        public TestNofi()
        {
            InitializeComponent();
        }

        private void TestNofi_Load(object sender, EventArgs e)
        {
            TopLabel.Text += " " + DateTime.Now.ToString("yyyy-MM-dd");
            gunaDataGridView1.Columns.Clear();
            backgroundWorker1.RunWorkerAsync();


        }
        DataTable ManualTable;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(@"select
installmet_det_id as #
,installment_id as 'رقم الفاتورة'
,(select customer_name from installmentsTable where installmentsTable.installment_id=installmentDetTable.installment_id) as 'إسم الزبون'
,fullmoney as 'المبلغ الكامل'
,howpay as 'القيمة المدفوعة'
,howstay as 'القيمة المتبقية'
from installmentDetTable where date=CONVERT(varchar, GETDATE(), 121) and howstay>0", ConnectionClass.connection);
            ManualTable = new DataTable();
            adapter.Fill(ManualTable);
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

                gunaDataGridView1.DataSource = ManualTable;
            gunaDataGridView1.Columns[1].ReadOnly = true;
            gunaDataGridView1.Columns[2].ReadOnly = true;
            gunaDataGridView1.Columns[3].ReadOnly = true;
            gunaDataGridView1.Columns[5].ReadOnly = true;
            gunaDataGridView1.Columns[0].Visible = false;


        }

        private void gunaDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gunaDataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    gunaDataGridView1.CurrentRow.Cells[5].Value =
                   Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[3].Value)
                    - Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[4].Value);
                }
            }
            catch (InvalidCastException)
            {
                gunaDataGridView1.CancelEdit();
            }
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            int R = 0;
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionClass.connection;
            command.CommandText = @"update installmentDetTable set howpay=@howpay,howstay=@howstay where installmet_det_id=@id ";
            for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[0].Value));
                command.Parameters.AddWithValue("@howpay", Convert.ToDouble(gunaDataGridView1.Rows[i].Cells[4].Value));
                command.Parameters.AddWithValue("@howstay", Convert.ToDouble(gunaDataGridView1.Rows[i].Cells[5].Value));
                R = command.ExecuteNonQuery();
            }

            if (R >= 1)
            {
                Alert alert = new Alert("تم التسديد بنجاح", AlertForm.alertTypeEnum.Success);
            }

        }
        private void gunaDataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (gunaDataGridView1.CurrentCell.ColumnIndex == 4)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null || tb.Text.Trim().Length != 0)
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
    }
}
