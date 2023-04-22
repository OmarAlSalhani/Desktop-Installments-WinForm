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

namespace installmentsApp.AdminForms.ManageUsers
{
    public partial class AddUserForm : Form
    {
        private bool CheckTexts()
        {
            if (EmployeeNameTB.Text.Trim().Length == 0)
            {
                Alert alert = new Alert("الرجاء كتابة إسم الموظف", AlertForm.alertTypeEnum.Info);
                return false;
            }
            if (usernameTB.Text.Trim().Length == 0)
            {
                Alert alert = new Alert("الرجاء كتابة إسم المستخدم", AlertForm.alertTypeEnum.Info);
                return false;
            }
            if (passwordTB.Text.Trim().Length == 0)
            {
                Alert alert = new Alert("الرجاء كتابة كلمة المرور", AlertForm.alertTypeEnum.Info);
                return false;
            }
            return true;
        }
        public AddUserForm()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            usernameTB.Text = string.Empty;
            passwordTB.Text = string.Empty;
            EmployeeNameTB.Text = string.Empty;
            MobileTB.Text = string.Empty;
            AddressTB.Text = string.Empty;
            SalaryTB.Text = 0.ToString();
            PositionTB.Text = string.Empty;
            PersonalPictureBox.Image = Properties.Resources.user;
        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveBtn.Text == "تعديل المستخدم")
            {
                if (CheckTexts())
                {
                    byte[] PersonalImage;
                    MemoryStream ms2 = new MemoryStream();
                    PersonalPictureBox.Image.Save(ms2, ImageFormat.Jpeg);
                    PersonalImage = new byte[ms2.Length];
                    ms2.Position = 0;
                    ms2.Read(PersonalImage, 0, PersonalImage.Length);
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = ConnectionClass.connection;
                    command.CommandText = "UpdateUser_Proc";
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(IDLabel.Text));
                    command.Parameters.AddWithValue("@username", usernameTB.Text);
                    command.Parameters.AddWithValue("@pass", passwordTB.Text);
                    command.Parameters.AddWithValue("employee_name", EmployeeNameTB.Text);
                    command.Parameters.AddWithValue("employee_mobile", MobileTB.Text);
                    command.Parameters.AddWithValue("@employee_address", AddressTB.Text);
                    command.Parameters.AddWithValue("@employee_salary", SalaryTB.Text);
                    command.Parameters.AddWithValue("@employee_position", PositionTB.Text);
                    command.Parameters.AddWithValue("@employee_pic", PersonalImage);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Alert alert = new Alert("تم التعديل بنجاح", AlertForm.alertTypeEnum.Success);
                        Close();
                    }
                }
                
            }
            else
            {
                if (CheckTexts())
                {
                    try
                    {

                        byte[] PersonalImage;
                        MemoryStream ms2 = new MemoryStream();
                        PersonalPictureBox.Image.Save(ms2, ImageFormat.Jpeg);
                        PersonalImage = new byte[ms2.Length];
                        ms2.Position = 0;
                        ms2.Read(PersonalImage, 0, PersonalImage.Length);
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Connection = ConnectionClass.connection;
                        command.CommandText = "AddUser_Proc";
                        command.Parameters.AddWithValue("@username", usernameTB.Text);
                        command.Parameters.AddWithValue("@pass", passwordTB.Text);
                        command.Parameters.AddWithValue("employee_name", EmployeeNameTB.Text);
                        command.Parameters.AddWithValue("employee_mobile", MobileTB.Text);
                        command.Parameters.AddWithValue("@employee_address", AddressTB.Text);
                        command.Parameters.AddWithValue("@employee_salary", SalaryTB.Text);
                        command.Parameters.AddWithValue("@employee_position", PositionTB.Text);
                        command.Parameters.AddWithValue("@employee_pic", PersonalImage);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            Alert alert = new Alert("تمت الإضافة بنجاح", AlertForm.alertTypeEnum.Success);
                            ClearAll();
                        }
                    }
                    catch (SqlException EE)
                    {
                        if (EE.Message.Contains("unique"))
                        {
                            Alert alert = new Alert("الإسم موجود مسبقاً", AlertForm.alertTypeEnum.Warning);
                        }
                    }
                }
            }
            
       
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            ConnectionClass.OpenConnection();
            if (SaveBtn.Text == "تعديل المستخدم")
                UpdateDataWorker.RunWorkerAsync();
            else OpenConnectionWorker.RunWorkerAsync();
        }

        private void UploadPersonal_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                PersonalPictureBox.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            else return;
        }

        private void TakePersonal_Click(object sender, EventArgs e)
        {
            TakePictureDialog d = new TakePictureDialog();
            d.Caption = "إلتقاط الصورة الشخصية";

            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image i = d.Image;
                PersonalPictureBox.Image = i;
            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenConnectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();
        }
        DataTable Table;
        private void UpdateDataWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionClass.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from UsersInfoTable where user_id='"+Convert.ToInt32(IDLabel.Text)+"'", ConnectionClass.connection);
            Table = new DataTable();
            adapter.Fill(Table);
        }

        private void UpdateDataWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            usernameTB.Text = Table.Rows[0]["username"].ToString();
            passwordTB.Text = Table.Rows[0]["pass"].ToString();

            EmployeeNameTB.Text = Table.Rows[0]["employee_name"].ToString();
            MobileTB.Text = Table.Rows[0]["employee_mobile"].ToString();
            AddressTB.Text = Table.Rows[0]["employee_address"].ToString();
            PositionTB.Text = Table.Rows[0]["employee_position"].ToString();
            SalaryTB.Text = Table.Rows[0]["employee_salary"].ToString();
            if(Table.Rows[0]["employee_pic"].ToString().Trim().Length==0)
            {
                PersonalPictureBox.Image = Properties.Resources.user;
            }
            else
            {
                byte[] photo_aray;
                photo_aray = (byte[])Table.Rows[0]["employee_pic"];

                MemoryStream ms = new MemoryStream(photo_aray);
                PersonalPictureBox.Image = Image.FromStream(ms);
            }

        }

        private void DeletePersonal_Click(object sender, EventArgs e)
        {
            PersonalPictureBox.Image = Properties.Resources.user;

        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
