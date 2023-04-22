using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installmentsApp.Customers
{
    public partial class KshfReport : Form
    {
        public KshfReport()
        {
            InitializeComponent();
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                Alert alert = new Alert("لا يمكن طباعة تقرير فارغ", AlertForm.alertTypeEnum.Warning);
            }
            else
            {


                DateTime dateTime = DateTime.Now;
                string TheDate = dateTime.ToString("yyyy-MM-dd");
                string TheTime = dateTime.ToString("hh:mm:ss");
                gridView1.OptionsPrint.AllowMultilineHeaders = true;
                string Header = @"{\rtf1\utf-8\deff0
{\fonttbl{\f0 Adobe Arabic;}}
\pard\qr" + "التاريخ " + TheDate + @"\par
\pard\qr" + "الساعة  " + TheTime + @"\par
\pard\fs30\qc" + ReportSettings.Default.CompanyName + @"\par
\pard\qc" + TopLabel.Text + @"\par
\pard\qc" + BillLabel.Text + @"\fs30\par}";
                gridView1.OptionsPrint.RtfPageHeader = Header;
                string footer = @"{\rtf1\utf-8\deff0
{\fonttbl{\f0 Adobe Arabic;}}
\pard\qc\par
\pard\qr" + ReportSettings.Default.FooterText + @"\par
\pard\qr" + ReportSettings.Default.EmployeeName + @"\par}";
                gridView1.OptionsPrint.RtfPageFooter = footer;
             
                    gridView1.Print();

            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.DataAware;
            XlsxExportOptionsEx options = new XlsxExportOptionsEx();
            
            options.CustomizeSheetHeader += options_CustomizeSheetHeader;
            xtraSaveFileDialog1.Filter = "ملفات إكسل|*.xlsx";
            xtraSaveFileDialog1.FileName = TopLabel.Text;
            if (xtraSaveFileDialog1.ShowDialog()==DialogResult.OK)
            gridView1.ExportToXlsx(xtraSaveFileDialog1.FileName,options);
        }
        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            CellObject row = new CellObject();
            row.Value = TopLabel.Text+"|"+BillLabel.Text.Replace(':',' ');
            XlFormattingObject rowFormatting = new XlFormattingObject();
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 12 };
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            e.ExportContext.AddRow(new[] { row });
            e.ExportContext.AddRow();
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(3, 1)));
        }
        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string TheDate = dateTime.ToString("yyyy-MM-dd");
            string TheTime = dateTime.ToString("hh:mm:ss");
            gridView1.OptionsPrint.AllowMultilineHeaders = true;
            string Header = @"{\rtf1\utf-8\deff0
{\fonttbl{\f0 Adobe Arabic;}}
\pard\qr" + "التاريخ " + TheDate + @"\par
\pard\qr" + "الساعة  " + TheTime + @"\par
\pard\fs30\qc" + ReportSettings.Default.CompanyName + @"\par
\pard\qc" + TopLabel.Text + @"\par
\pard\qc" + BillLabel.Text + @"\fs30\par}";
            gridView1.OptionsPrint.RtfPageHeader = Header;
            string footer = @"{\rtf1\utf-8\deff0
{\fonttbl{\f0 Adobe Arabic;}}
\pard\qc\par
\pard\qr" + ReportSettings.Default.FooterText + @"\par
\pard\qr" + ReportSettings.Default.EmployeeName + @"\par}";
            gridView1.OptionsPrint.RtfPageFooter = footer;
            xtraSaveFileDialog1.Filter = "ملفات وورد|*.docx";         
            xtraSaveFileDialog1.FileName = TopLabel.Text;
            if (xtraSaveFileDialog1.ShowDialog() == DialogResult.OK)
                gridView1.ExportToDocx(xtraSaveFileDialog1.FileName);
        }
    }
}
