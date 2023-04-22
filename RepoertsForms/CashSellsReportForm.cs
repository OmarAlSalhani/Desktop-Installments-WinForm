using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System.Data.SqlClient;
using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using System.Data;
namespace installmentsApp.RepoertsForms
{
    public partial class CashSellsReportForm : Form
    {
        public CashSellsReportForm()
        {
            InitializeComponent();
        }

        private void gridView1_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            (e.PrintingSystem as PrintingSystemBase).PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.DisplayText.Length == 0)
                e.DisplayText = 0.ToString();

        }
        private void SellsReportForm_Load(object sender, EventArgs e)
        {

            GridColumnSummaryItem summaryItem = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "القيمة النهائية", "المجموع = " + "{0}");
            summaryItem.DisplayFormat ="المجموع:"+" "+ "{0:#,##}";         
            gridView1.Columns["القيمة النهائية"].Summary.Add(summaryItem);
            gridView1.Columns["القيمة النهائية"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["القيمة النهائية"].DisplayFormat.FormatString = "n2";


        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            SqlDataAdapter adapter = new SqlDataAdapter(@"
select
date as 'تاريخ تسديد الدفعة'
,fullmoney as 'المبلغ الواجب تسديده'
,howpay as 'المبلغ المدفوع'
,howstay as 'المبلغ المتبقي'
from installmentDetTable where installment_id=
" + Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0])),ConnectionClass.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Customers.KshfReport kshfReport = new Customers.KshfReport();
            kshfReport.gridControl1.DataSource = table;
            kshfReport.TopLabel.Text = TopLabel.Text+" "+"بشكل تفصيلي";
            kshfReport.BillLabel.Text += ": " + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            kshfReport.ShowDialog();
        }
        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.DataAware;
            XlsxExportOptionsEx options = new XlsxExportOptionsEx();

            options.CustomizeSheetHeader += options_CustomizeSheetHeader;
            xtraSaveFileDialog1.Filter = "ملفات إكسل|*.xlsx";
            xtraSaveFileDialog1.FileName = TopLabel.Text;
            if (xtraSaveFileDialog1.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXlsx(xtraSaveFileDialog1.FileName, options);
        }
        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            CellObject row = new CellObject();
            row.Value = TopLabel.Text + "|" + DateLabel.Text;
            XlFormattingObject rowFormatting = new XlFormattingObject();
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 12 };
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            e.ExportContext.AddRow(new[] { row });
            e.ExportContext.AddRow();
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(gridView1.Columns.Count-1, 1)));
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
\pard\qc" + DateLabel.Text + @"\fs30\par}";
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
\pard\qc" + DateLabel.Text + @"\fs30\par}";
                gridView1.OptionsPrint.RtfPageHeader = Header;
                string footer = @"{\rtf1\utf-8\deff0
{\fonttbl{\f0 Adobe Arabic;}}
\pard\qc\par
\pard\qr" + ReportSettings.Default.FooterText + @"\par
\pard\qr" + ReportSettings.Default.EmployeeName + @"\par}";
                gridView1.OptionsPrint.RtfPageFooter = footer;
                if (TopLabel.Text.Contains("كشف حساب"))
                {
                    PrintingSystem printingSystem1 = new PrintingSystem();
                    PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
                    printingSystem1.Links.AddRange(new object[] { printableComponentLink1 });
                    printableComponentLink1.Component = gridControl1;
                    printableComponentLink1.Landscape = true;
                    printableComponentLink1.Print();
                }
                else
                    gridView1.Print();

            }
        }
    }
    }
