using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors.Camera;

namespace installmentsApp.Customers
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private bool CheckIfAllGood()
        {
            if(CustomerNameTB.Text.Trim().Length==0)
            {
                Alert alert = new Alert("أدخل إسم الزبون", AlertForm.alertTypeEnum.Warning);
                return false;
            }
            return true;
        }
        private void UploadProvePic_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                ProvePictureBox.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            else return;
        }
        private void TakeProvePic_Click(object sender, EventArgs e)
        {
            TakePictureDialog d = new TakePictureDialog();
            d.Caption = "إلتقاط صورة الإثبات | الصالحاني للإدارة";

            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Image i = d.Image;
                ProvePictureBox.Image = i;
            }
        }
        private void TakePersonalPic_Click(object sender, EventArgs e)
        {
            TakePictureDialog d = new TakePictureDialog();
            d.Caption = "إلتقاط الصورة الشخصية | الصالحاني للإدارة";

            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Image i = d.Image;
                PersonalPictureBox.Image = i;
            }
        }
        private void UploadPersonalPic_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                PersonalPictureBox.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            else return;
        }
        private void DeleteProve_Click(object sender, EventArgs e)
        {
            ProvePictureBox.Image = Properties.Resources.user;
        }
        private void DeletePersonal_Click(object sender, EventArgs e)
        {
            ProvePictureBox.Image = Properties.Resources.user;
        }
        private void AddData()
        {
            if (CheckIfAllGood())
            {
                try
                {
                    byte[] PersonalImage;
                    byte[] ProveImage;
                    MemoryStream ms = new MemoryStream();
                    ProvePictureBox.Image.Save(ms, ImageFormat.Jpeg);
                    ProveImage = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(ProveImage, 0, ProveImage.Length);
                    MemoryStream ms2 = new MemoryStream();
                    PersonalPictureBox.Image.Save(ms2, ImageFormat.Jpeg);
                    PersonalImage = new byte[ms2.Length];
                    ms2.Position = 0;
                    ms2.Read(PersonalImage, 0, PersonalImage.Length);
                    ConnectionClass.OpenConnection();
                    SqlCommand command = new SqlCommand();
                    command.Connection = ConnectionClass.connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddCustomer_Proc";
                    command.Parameters.AddWithValue("@customer_name", CustomerNameTB.Text);
                    command.Parameters.AddWithValue("@customer_phone", PhoneTB.Text);
                    command.Parameters.AddWithValue("@customer_address", AddressTB.Text);
                    command.Parameters.AddWithValue("@customer_picture", PersonalImage);
                    command.Parameters.AddWithValue("@customer_prove", ProveImage);
                    command.Parameters.AddWithValue("@notes", NotesTB.Text);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Alert alert = new Alert("تمت الإضافة بنجاح", AlertForm.alertTypeEnum.Success);
                        ClearAll();
                    }
                }
                catch (SqlException Ex)
                {
                    if (Ex.Message.Contains("unique"))
                    {
                        Alert alert = new Alert("يوجد زبون مسجل بنفس الإسم", AlertForm.alertTypeEnum.Error);
                    }
                    else
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }
        private void UpdateData()
        {
            if (CheckIfAllGood())
            {
                try
                {
                    byte[] PersonalImage;
                    byte[] ProveImage;
                    MemoryStream ms = new MemoryStream();
                    ProvePictureBox.Image.Save(ms, ImageFormat.Jpeg);
                    ProveImage = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(ProveImage, 0, ProveImage.Length);
                    MemoryStream ms2 = new MemoryStream();
                    PersonalPictureBox.Image.Save(ms2, ImageFormat.Jpeg);
                    PersonalImage = new byte[ms2.Length];
                    ms2.Position = 0;
                    ms2.Read(PersonalImage, 0, PersonalImage.Length);
                    ConnectionClass.OpenConnection();
                    SqlCommand command = new SqlCommand();
                    command.Connection = ConnectionClass.connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UpdateCustomer_Proc";
                    command.Parameters.AddWithValue("@customer_id",Convert.ToInt32(IDLabel.Text));
                    command.Parameters.AddWithValue("@customer_name", CustomerNameTB.Text);
                    command.Parameters.AddWithValue("@customer_phone", PhoneTB.Text);
                    command.Parameters.AddWithValue("@customer_address", AddressTB.Text);
                    command.Parameters.AddWithValue("@customer_picture", PersonalImage);
                    command.Parameters.AddWithValue("@customer_prove", ProveImage);
                    command.Parameters.AddWithValue("@notes", NotesTB.Text);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Alert alert = new Alert("تم التعديل بنجاح", AlertForm.alertTypeEnum.Success);
                        Close();
                    }
                }
                catch (SqlException Ex)
                {
                    
                        MessageBox.Show(Ex.Message);
                    
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveBtn.Text == "إضافة الزبون")
                AddData();
            else UpdateData();


        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            CustomerNameTB.Text = string.Empty;
            PhoneTB.Text = string.Empty;
            AddressTB.Text = string.Empty;
            NotesTB.Text = string.Empty;
            ProvePictureBox.Image = ProvePictureBox.Image = Properties.Resources.user;
            PersonalPictureBox.Image = ProvePictureBox.Image = Properties.Resources.user;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
