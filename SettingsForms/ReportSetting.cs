using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installmentsApp.SettingsForms
{
    public partial class ReportSetting : Form
    {
        public ReportSetting()
        {
            InitializeComponent();
        }

        private void ReportSetting_Load(object sender, EventArgs e)
        {
            FooterTXT.Text = ReportSettings.Default.FooterText;
            CompanyTXT.Text = ReportSettings.Default.CompanyName;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            ReportSettings.Default.FooterText = (usernameSW.Checked) ? FooterTXT.Text:"";
            ReportSettings.Default.CompanyName = (CompanyTXT.Text.Trim().Length == 0) ? "" : CompanyTXT.Text;
            ReportSettings.Default.EmployeeName = (usernameSW.Checked) ? " الموظف: " + Settings.Default.username : "";
            ReportSettings.Default.Save();
            Alert alert = new Alert("تم الحفظ بنجاح",AlertForm.alertTypeEnum.Success);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
