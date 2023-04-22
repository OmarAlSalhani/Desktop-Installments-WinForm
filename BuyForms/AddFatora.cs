using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace installmentsApp.BuyForms
{
    public partial class AddFatora : Form
    {
        public AddFatora()
        {
            InitializeComponent();
        }
        Guna.UI.WinForms.GunaAdvenceTileButton button;
        public void IncreaseQuantity()
        {
            SqlCommand DecreaseQualityCommand = new SqlCommand();
            DecreaseQualityCommand.CommandText = "IncreaseQuantity";
            DecreaseQualityCommand.CommandType = CommandType.StoredProcedure;
            DecreaseQualityCommand.Connection = ConnectionClass.connection;
            for (int i = 0; i < gunaDataGridView1.Rows.Count - 1; i++)
            {
                DecreaseQualityCommand.Parameters.Clear();
                DecreaseQualityCommand.Parameters.AddWithValue("@Qun", Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[2].Value));
                DecreaseQualityCommand.Parameters.AddWithValue("@id", Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[0].Value));
                DecreaseQualityCommand.ExecuteNonQuery();
            }
        }
        private bool CheckIfAllGoodToAdd()
        {
            SqlDataAdapter HeadAdapter = new SqlDataAdapter("select isnull(max(buy_id),1) from BuyFatoraHeadTable", ConnectionClass.connection);
            SqlDataAdapter BodyAdapter = new SqlDataAdapter("Select isnull(max(buy_id),1) from BuyFatoraBodyTable", ConnectionClass.connection);
            DataTable HeadTable = new DataTable();
            DataTable BodyTable = new DataTable();
            HeadAdapter.Fill(HeadTable);
            BodyAdapter.Fill(BodyTable);
            if (HeadTable.Rows[0][0].ToString() != HeadTable.Rows[0][0].ToString())
            {
                MessageBox.Show("خطأ في قاعدة البيانات الرجاء الأتصال بالموزع" + Environment.NewLine + "رمز الخطأ ID", "خطأ");
                return false;
            }
            if (gunaDataGridView1.Rows.Count == 0)
            {
                Alert alert = new Alert("لا يمكن تسديد فاتورة فارغة", AlertForm.alertTypeEnum.Warning);

                return false;
            }
            return true;
        }
        public void AddFatoraToDatabase()
        {
            SqlCommand HeadCommand = new SqlCommand();
            HeadCommand.Connection = ConnectionClass.connection;
            HeadCommand.CommandType = CommandType.StoredProcedure;
            HeadCommand.CommandText = "SaveBuyHead";
            HeadCommand.Parameters.AddWithValue("@company_name", CompanyCB.Text);
            HeadCommand.Parameters.AddWithValue("@buy_date", DateTime.Now.ToString("yyyyMMdd"));
            HeadCommand.Parameters.AddWithValue("@total_amount", float.Parse(TotalAmountTB.Text));
            HeadCommand.Parameters.AddWithValue("@discounts", float.Parse(DiscountsTB.Text));
            HeadCommand.Parameters.AddWithValue("@net_amount", float.Parse(NetAmountTB.Text));
            HeadCommand.Parameters.AddWithValue("@bill_type", (CashRadioBtn.Checked) ? CashRadioBtn.Text : TksetRadioBtn.Text);
            HeadCommand.ExecuteNonQuery();
            SqlCommand BodyCommand = new SqlCommand();
            BodyCommand.Connection = ConnectionClass.connection;
            BodyCommand.CommandType = CommandType.StoredProcedure;
            BodyCommand.CommandText = "SaveBuyBody";
            SqlDataAdapter adapter = new SqlDataAdapter("Select max(buy_id) from BuyFatoraHeadTable", ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int Result = 0;
           int buy_id = Convert.ToInt32(table.Rows[0][0]);

            for (int i = 0; i < gunaDataGridView1.Rows.Count - 1; i++)
            {
                BodyCommand.Parameters.Clear();
                BodyCommand.Parameters.AddWithValue("@product_name", gunaDataGridView1.Rows[i].Cells[1].Value.ToString());
                BodyCommand.Parameters.AddWithValue("@quantity", gunaDataGridView1.Rows[i].Cells[2].Value.ToString());
                BodyCommand.Parameters.AddWithValue("@buy_id", buy_id);
                Result = BodyCommand.ExecuteNonQuery();
            }
            if (Result >= 1)
            {
                Alert alert = new Alert("تمت الإضافة بنجاح", AlertForm.alertTypeEnum.Success);

                IncreaseQuantity();
                gunaDataGridView1.AllowUserToAddRows = false;
                gunaDataGridView1.Rows.Clear();
                TotalAmountTB.Text = 0.ToString();
                DiscountsTB.Text = 0.ToString();
                NetAmountTB.Text = 0.ToString();
                CompanyCB.SelectedIndex = -1;
                CompanyCB.Text = "الشركة";
            }
        }
        private void FillCompanyComboBox()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select company_name from companytable", ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CompanyCB.DisplayMember = "company_name";
            CompanyCB.ValueMember = "company_name";
            CompanyCB.DataSource = table;
        }
        private void MakeGridViewReadOnly()
        {
            gunaDataGridView1.Columns[0].ReadOnly = true;
            gunaDataGridView1.Columns[1].ReadOnly = true;
            gunaDataGridView1.Columns[3].ReadOnly = true;
            gunaDataGridView1.Columns[4].ReadOnly = true;
        }
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
            row.Cells[0].Value = table.Rows[0]["product_id"].ToString();
            row.Cells[1].Value = table.Rows[0]["product_name"].ToString();
            row.Cells[2].Value = 1;
            row.Cells[3].Value = table.Rows[0]["buy_price"].ToString();
            row.Cells[4].Value = table.Rows[0]["buy_price"].ToString();
            gunaDataGridView1.Rows.Add(row);
        }
        private void AddFatora_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }
        private void gunaDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.ColumnIndex == 2)
            {

                if (gunaDataGridView1.CurrentRow.Cells[2].Value == null)
                {
                    gunaDataGridView1.CurrentRow.Cells[2].Value = 1;
                    gunaDataGridView1.CurrentRow.Cells[4].Value = gunaDataGridView1.CurrentRow.Cells[3].Value;
                }
                else
                {
                    gunaDataGridView1.CurrentRow.Cells[4].Value =
                   Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[2].Value)
                    * Convert.ToDouble(gunaDataGridView1.CurrentRow.Cells[3].Value);
                }

            }
            FillTexts();
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
        private void FillTexts()
        {
            double sum = 0;
            for (int i = 0; i < gunaDataGridView1.Rows.Count - 1; i++)
            {
                sum += Convert.ToDouble(gunaDataGridView1.Rows[i].Cells[4].Value);

            }
            double Discount = Convert.ToDouble(DiscountsTB.Text);
            TotalAmountTB.Text = sum.ToString();
            NetAmountTB.Text = (sum - Discount).ToString();

        }
        private void gunaDataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillTexts();
        }
        private void DiscountsTB_EditValueChanged(object sender, EventArgs e)
        {
            float Discount = float.Parse(DiscountsTB.Text);
            float TotalAmount = float.Parse(TotalAmountTB.Text);
            NetAmountTB.Text = (TotalAmount - Discount).ToString();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.Rows.RemoveAt(gunaDataGridView1.CurrentRow.Index);
                FillTexts();
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
        private void ProductNameTB_EditValueChanged(object sender, EventArgs e)
        {
            FillTablePanelWithButtons("Select product_name from productstable where product_name like '%" + ProductNameTB.Text + "%'");

        }
        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            if (CheckIfAllGoodToAdd())
            {
                    if (CompanyCB.SelectedIndex == -1)
                    {
                    Alert alert = new Alert("يجب أختيار الشركة", AlertForm.alertTypeEnum.Warning);

                    return;
                    }
                    else if (CompanyCB.SelectedIndex != -1)
                    {
                        AddFatoraToDatabase();
                    }
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
            FillCompanyComboBox();
            FillTablePanelWithButtons("Select product_name,product_quantity from Productstable");
            gunaDataGridView1.Columns[1].Width = gunaDataGridView1.Columns[1].Width + 20;
            CompanyCB.SelectedIndex = -1;
            CompanyCB.Text = "الشركة";

        }
    }
}
