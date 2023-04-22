﻿using System;
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
    public partial class installmentForm : Form
    {
        public installmentForm()
        {
            InitializeComponent();
        }
        DataTable Table;
        private bool ValidateAdd()
        {
            if (gunaDataGridView1.Rows.Count == 0)
            {              
                return false;
            }
            return true;
        }
        private void IncreaseQuantity()
        {
            int Bill_id = Convert.ToInt32(Bill_idTB.Text);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from CashSellFatoraBodyTable where bill_id=" + Bill_id, ConnectionClass.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionClass.connection;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int Quantity = Convert.ToInt32(dataTable.Rows[i]["quantity"]);
                string ProductName = dataTable.Rows[i]["product_name"].ToString();
                command.CommandText = "update productstable set product_quantity=product_quantity+" + Quantity + "where product_name='" + ProductName + "'";
                command.ExecuteNonQuery();
            }
            DeleteLastFatora();

        }
        private void DeleteLastFatora()
        {
            SqlCommand command = new SqlCommand("Delete from CashFatoraHeadTable where bill_id=" + Convert.ToInt32(Bill_idTB.Text), ConnectionClass.connection);
            SqlCommand command2 = new SqlCommand("Delete from CashSellFatoraBodyTable where bill_id=" + Convert.ToInt32(Bill_idTB.Text), ConnectionClass.connection);
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }
        private void CalcualteNetAmount()
        {
            float Benefits = float.Parse(BenefitsTB.Text);
            float Total = float.Parse(TotalAmountTB.Text);
            float FirstPay = float.Parse(FirstPayTB.Text);
            NetAmountTB.Text = ((Total + Benefits) - FirstPay).ToString();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            IncreaseQuantity();
            this.Close();
        }

        private void BenefitsTB_EditValueChanged(object sender, EventArgs e)
        {
            CalcualteNetAmount();
        }
        private void FirstPayTB_EditValueChanged(object sender, EventArgs e)
        {
            CalcualteNetAmount();
        }

        private void TimePerioedCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AksatNumberTB.Text == 0.ToString())
            {
                TimePerioedCB.SelectedIndex = -1;
                Alert alert = new Alert("الرجاء إدخال قيمة القسط الواحد", AlertForm.alertTypeEnum.Info);
                return;
            }
            else
            {
                Table = new DataTable();
                Table.Clear();
                Table.Columns.Add("تاريخ تسديد الدفعة");
                Table.Columns.Add("قيمة الدفعة");
                gunaDataGridView1.Columns.Clear();
                DateTime date = gunaDateTimePicker1.Value;
                if (TimePerioedCB.SelectedIndex == 0)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["تاريخ تسديد الدفعة"] = date.ToString("yyyy-MM-dd");
                        row["قيمة الدفعة"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddDays(1);
                    }
                }
                if (TimePerioedCB.SelectedIndex == 1)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["تاريخ تسديد الدفعة"] = date.ToString("yyyy-MM-dd");
                        row["قيمة الدفعة"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddDays(7);
                    }
                }
                if (TimePerioedCB.SelectedIndex == 2)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["تاريخ تسديد الدفعة"] = date.ToString("yyyy-MM-dd");
                        row["قيمة الدفعة"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddMonths(1);
                    }
                }
                if (TimePerioedCB.SelectedIndex == 3)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["تاريخ تسديد الدفعة"] = date.ToString("yyyy-MM-dd");
                        row["قيمة الدفعة"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddYears(1);
                    }
                }
                gunaDataGridView1.DataSource = Table;
                panel8.Visible = true;
                label10.Text = "القيمة النهائية : " + " " + NetAmountTB.Text;
            }
        }

        private void OneMoneyTB_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                float NetAmount = float.Parse(NetAmountTB.Text);
                float OneMoney = float.Parse(OneMoneyTB.Text);
                int Aksat = Convert.ToInt32(NetAmount / OneMoney);
                AksatNumberTB.Text = Aksat.ToString();
                TimePerioedCB.Enabled = true;
            }
            catch (OverflowException)
            {
                return;
            }
        }

        private void installmentForm_Load(object sender, EventArgs e)
        {
            NetAmountTB.Text = TotalAmountTB.Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateAdd())
            { 
                SqlCommand command = new SqlCommand();
            command.Connection = ConnectionClass.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddInstallment_Proc";
            command.Parameters.AddWithValue("@customer_name", CustomerNameTB.Text);
            command.Parameters.AddWithValue("@bill_id", Convert.ToInt32(Bill_idTB.Text));
            command.Parameters.AddWithValue("@full_money", float.Parse(TotalAmountTB.Text));
            command.Parameters.AddWithValue("@plus_money", float.Parse(BenefitsTB.Text));
            command.Parameters.AddWithValue("@first_money", float.Parse(FirstPayTB.Text));
            command.Parameters.AddWithValue("@net_money", float.Parse(NetAmountTB.Text));
            command.Parameters.AddWithValue("@one_money", float.Parse(OneMoneyTB.Text));
            command.Parameters.AddWithValue("@time_perioed", TimePerioedCB.Text);
            command.Parameters.AddWithValue("@aksat_number", Convert.ToInt32(AksatNumberTB.Text));
            command.Parameters.AddWithValue("@first_date", gunaDateTimePicker1.Value);
            command.Parameters.AddWithValue("@last_date", gunaDataGridView1.Rows[gunaDataGridView1.Rows.Count - 1].Cells[0].Value);
            command.Parameters.AddWithValRY?@|	4�'3a&�'�-�׊#̂�?�mO�a�?�� X���:ئji����8=��8�+��ڡ�S0 ΀I����D�k�o���w�:�[h��l���3��h�G^���p
���Lb:�¹p6�~��O<Ѿ�mo�g�%��.�K� ��ˠ.�<ȇp������h^O��N�%�߳�ʝ��G����Y����jEQG]����CU�F*��J)�RJ��*��J)�RJ��*��J)�RJ��*��J)�RJ��*��J)�RJ��*��J)�RJ��*��J)�RJ��*��J)�RJ��*��Ja?�[���H��{a����N4�u�u�5B=l/$���ӈ;�6���N����"(�>�]H\�a4�WF��k.#fA}Q�rҞC�"��vHe� �%�h�D̄�p2� �D^+r�0Zx�x�=�Y���`�n��`�6���^�w��?�㈯�~Xh�"N��8&�_C�*�J)�R��zh�;a�wE�-����]N���v��#�EH8��&1r�\8�?��'� �h�Ͷ�Ҏ���K	�RB��p\�p9�A>,�����pl$�Է��gԁ�x��ج�Rs��˫��¡���v�{?.>���?UO��s����瓟�3��3�\��o�_���gx���7���ώ_I?7~%���?���8��.����ҭ^)�}��Oϒ��}���`�H��/�f���G=U�Cl3�+",Z����)wO9F�O���g�yߔ\�Ҕ���)_��c��ӎi���^.:�.Y|̝r�1w��1�d}��r���d��{��ke��_�ک�m�òk��٩��7��J�sj���)�=(S��R~m�c��i����m����90�M~8�[j�>.��}J�?�]���gd˱��cO�Wۏ��ڙ��	�����K�e�]������|��_�K�fJd�c��;S��"���9�\yʔ�ŕSΖ���#�;%F��������-�?�T��)��My5�b����)���D�����)#WZ}�Ǯ�,��v��~>%r���x�+7��-��&X%����l9-�@���	��)�6Ƞ=Ri��Xo%fs 	zX�!�tZ���y���H����a+x!�~젝F�I��p�\�7A1���B�X����2�^s1Z�"�C��b�:خjiK�f��ɑsu�u��ƺk������k��f���a�_&?b陼ɲm�*��L�`*S1���T�b0��L�`*S1������J�&�@���C�>��`*S1���T�b0��L�`*S1���T�b0��L�`*S1���T�b0��L�`*S1���T�b0��L�`*S1���T�b0�)֡��ڠ��E���x0���O���O�0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���Cy0���C�C۵A-m)zï����p��sO���C<nyj��͓���n�S��O~���d�x�w��i��H����9�KG�볟A��[⇇�E