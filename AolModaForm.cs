using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace installmentsApp
{
    public partial class AolModaForm : Form
    {
        public AolModaForm()
        {
            InitializeComponent();
        }
        Guna.UI.WinForms.GunaAdvenceTileButton button;
        int RowNumber = 1;
        private void FillTablePanelWithButtons(string Query)
        {
            tableLayoutPanel1.Controls.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, ConnectionClass.connection);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (tableLayoutPanel1.Controls.Count < 16)
                {

                    button = new Guna.UI.WinForms.GunaAdvenceTileButton();
                    button.Text = table.Rows[i][0].ToString();
                    button.RightToLeft = RightToLeft.Yes;
                    button.Font = new Font("Lalezar", 15);
                    button.ImageSize = new Size(0, 0);
                    button.Radius = 5;
                    button.BaseColor = Color.FromArgb(100, 88, 255);
                    tableLayoutPanel1.Controls.Add(button);
                    button.Click += new EventHandler(button_click);
                }
            }
        }
        private void button_click(object sender, EventArgs e)
        {

            Guna.UI.WinForms.GunaAdvenceTileButton btn = sender as Guna.UI.WinForms.GunaAdvenceTileButton;
            gunaDataGridView1.AllowUserToAddRows = true;

            SqlDataAdapter adapter = new SqlDataAdapter("Select * from productstable where product_name='" + btn.Text + "'", ConnectionClass.connection);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        DataGridViewRow row = (DataGridViewRow)gunaDataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = RowNumber;
                        row.Cells[1].Value = table.Rows[0]["product_name"].ToString();
                        row.Cells[2].Value = 1;
                        gunaDataGridView1.Rows.Add(row);
                        RowNumber++;
                    
                
               
        }
        private void ProductNameTB_EditValueChanged(object sender, EventArgs e)
        {
            FillTablePanelWithButtons("Select product_name from productstable where product_name like '%" + ProductNameTB.Text + "%'");

        }
        private void MakeGridViewReadOnly()
        {
            gunaDataGridView1.Columns[0].ReadOnly = true;
            gunaDataGridView1.Columns[1].ReadOnly = true;
        }

        private void gunaDataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (gunaDataGridView1.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.Rows.RemoveAt(gunaDataGridView1.CurrentRow.Index);
            }
            catch (InvalidOperationException)
            {
                return;
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if (gunaDataGridView1.Rows.Count != 0)
            {
                if (gunaDataGridView1.Rows[0].Cells[0].Value != null)
                {
                    DialogResult result = MessageBox.Show(@"هل تريد الخروج من دون حفظ الفاتورة ؟"
                         , "رسالة تنبيه"
                         , MessageBoxButtons.YesNo
                         , MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) Close();
                    else return;
                }

            }
            else
            {
                Close();

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MakeGridViewReadOnly();
            FillTablePanelWithButtons("Select product_name,product_quantity from Productstable");
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من المعلومات المدخلة ؟" + Environment.NewLine + "الرجاء التأكد منها لأن العملية لا يمكن التراجع عنها" + Environment.NewLine + "إذا كنت متأكد أضغط على نعم", "تأكيد الأضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                gunaDataGridView1.AllowUserToAddRows = false;
                SqlCommand command = new SqlCommand();
                command.Connection = ConnectionClass.connection;
                command.CommandText = @"update ProductsTable
                set
                product_quantity=product_quantity+@quantity
                where product_name=@product_name";
                int Result = 0;
                for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@product_name", gunaDataGridView1.Rows[i].Cells[1].Value.ToString());
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[2].Value));
                    Result = command.ExecuteNonQuery();

                }
                if (Result > 0)
                {
                    Alert alert = new Alert("تمت الإضافة بنجاح", AlertForm.alertTypeEnum.Success);
                    gunaDataGridView1.Rows.Clear();
            }
        }
            else
            {
                return;
            }
        }
        private void AolModaForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void gunaDataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
