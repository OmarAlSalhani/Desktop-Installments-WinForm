namespace installmentsApp
{
    partial class BuyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TksetFatora = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SellFatoraManageBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.ManageFatoraBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.AddFatoraBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99998F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00002F));
            this.tableLayoutPanel2.Controls.Add(this.TksetFatora, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SellFatoraManageBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ManageFatoraBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddFatoraBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 472);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // TksetFatora
            // 
            this.TksetFatora.AnimationHoverSpeed = 0.07F;
            this.TksetFatora.AnimationSpeed = 0.03F;
            this.TksetFatora.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TksetFatora.BorderColor = System.Drawing.Color.Black;
            this.TksetFatora.CheckedBaseColor = System.Drawing.Color.Gray;
            this.TksetFatora.CheckedBorderColor = System.Drawing.Color.Black;
            this.TksetFatora.CheckedForeColor = System.Drawing.Color.White;
            this.TksetFatora.CheckedImage = ((System.Drawing.Image)(resources.GetObject("TksetFatora.CheckedImage")));
            this.TksetFatora.CheckedLineColor = System.Drawing.Color.DimGray;
            this.TksetFatora.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TksetFatora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TksetFatora.FocusedColor = System.Drawing.Color.Empty;
            this.TksetFatora.Font = new System.Drawing.Font("Lalezar", 17F);
            this.TksetFatora.ForeColor = System.Drawing.Color.White;
            this.TksetFatora.Image = ((System.Drawing.Image)(resources.GetObject("TksetFatora.Image")));
            this.TksetFatora.ImageSize = new System.Drawing.Size(52, 52);
            this.TksetFatora.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.TksetFatora.Location = new System.Drawing.Point(3, 239);
            this.TksetFatora.Name = "TksetFatora";
            this.TksetFatora.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.TksetFatora.OnHoverBorderColor = System.Drawing.Color.Black;
            this.TksetFatora.OnHoverForeColor = System.Drawing.Color.White;
            this.TksetFatora.OnHoverImage = null;
            this.TksetFatora.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.TksetFatora.OnPressedColor = System.Drawing.Color.Black;
            this.TksetFatora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TksetFatora.Size = new System.Drawing.Size(433, 230);
            this.TksetFatora.TabIndex = 6;
            this.TksetFatora.Text = "إدارة فواتير المبيعات بالتقسيط";
            this.TksetFatora.Click += new System.EventHandler(this.TksetFatora_Click);
            // 
            // SellFatoraManageBtn
            // 
            this.SellFatoraManageBtn.AnimationHoverSpeed = 0.07F;
            this.SellFatoraManageBtn.AnimationSpeed = 0.03F;
            this.SellFatoraManageBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SellFatoraManageBtn.BorderColor = System.Drawing.Color.Black;
            this.SellFatoraManageBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SellFatoraManageBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.SellFatoraManageBtn.CheckedForeColor = System.Drawing.Color.White;
            this.SellFatoraManageBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SellFatoraManageBtn.CheckedImage")));
            this.SellFatoraManageBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SellFatoraManageBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SellFatoraManageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellFatoraManageBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SellFatoraManageBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.SellFatoraManageBtn.ForeColor = System.Drawing.Color.White;
            this.SellFatoraManageBtn.Image = ((System.Drawing.Image)(resources.GetObject("SellFatoraManageBtn.Image")));
            this.SellFatoraManageBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.SellFatoraManageBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SellFatoraManageBtn.Location = new System.Drawing.Point(442, 239);
            this.SellFatoraManageBtn.Name = "SellFatoraManageBtn";
            this.SellFatoraManageBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SellFatoraManageBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SellFatoraManageBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SellFatoraManageBtn.OnHoverImage = null;
            this.SellFatoraManageBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SellFatoraManageBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SellFatoraManageBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SellFatoraManageBtn.Size = new System.Drawing.Size(435, 230);
            this.SellFatoraManageBtn.TabIndex = 5;
            this.SellFatoraManageBtn.Text = "إدارة فواتير المبيعات النقدية";
            this.SellFatoraManageBtn.Click += new System.EventHandler(this.SellFatoraManageBtn_Click);
            // 
            // ManageFatoraBtn
            // 
            this.ManageFatoraBtn.AnimationHoverSpeed = 0.07F;
            this.ManageFatoraBtn.AnimationSpeed = 0.03F;
            this.ManageFatoraBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ManageFatoraBtn.BorderColor = System.Drawing.Color.Black;
            this.ManageFatoraBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ManageFatoraBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.ManageFatoraBtn.CheckedForeColor = System.Drawing.Color.White;
            this.ManageFatoraBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ManageFatoraBtn.CheckedImage")));
            this.ManageFatoraBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ManageFatoraBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ManageFatoraBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageFatoraBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ManageFatoraBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.ManageFatoraBtn.ForeColor = System.Drawing.Color.White;
            this.ManageFatoraBtn.Image = ((System.Drawing.Image)(resources.GetObject("ManageFatoraBtn.Image")));
            this.ManageFatoraBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.ManageFatoraBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ManageFatoraBtn.Location = new System.Drawing.Point(3, 3);
            this.ManageFatoraBtn.Name = "ManageFatoraBtn";
            this.ManageFatoraBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ManageFatoraBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ManageFatoraBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ManageFatoraBtn.OnHoverImage = null;
            this.ManageFatoraBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ManageFatoraBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ManageFatoraBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManageFatoraBtn.Size = new System.Drawing.Size(433, 230);
            this.ManageFatoraBtn.TabIndex = 4;
            this.ManageFatoraBtn.Text = "إدارة فواتير المشتريات";
            this.ManageFatoraBtn.Click += new System.EventHandler(this.ManageFatoraBtn_Click);
            // 
            // AddFatoraBtn
            // 
            this.AddFatoraBtn.AnimationHoverSpeed = 0.07F;
            this.AddFatoraBtn.AnimationSpeed = 0.03F;
            this.AddFatoraBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddFatoraBtn.BorderColor = System.Drawing.Color.Black;
            this.AddFatoraBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddFatoraBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddFatoraBtn.CheckedForeColor = System.Drawing.Color.White;
            this.AddFatoraBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddFatoraBtn.CheckedImage")));
            this.AddFatoraBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddFatoraBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddFatoraBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFatoraBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddFatoraBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.AddFatoraBtn.ForeColor = System.Drawing.Color.White;
            this.AddFatoraBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddFatoraBtn.Image")));
            this.AddFatoraBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.AddFatoraBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddFatoraBtn.Location = new System.Drawing.Point(442, 3);
            this.AddFatoraBtn.Name = "AddFatoraBtn";
            this.AddFatoraBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddFatoraBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddFatoraBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddFatoraBtn.OnHoverImage = null;
            this.AddFatoraBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddFatoraBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddFatoraBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddFatoraBtn.Size = new System.Drawing.Size(435, 230);
            this.AddFatoraBtn.TabIndex = 2;
            this.AddFatoraBtn.Text = "إضافة فاتورة مشتريات";
            this.AddFatoraBtn.Click += new System.EventHandler(this.AddFatoraBtn_Click);
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.Filter = "Excel ملفات | *.xls";
            this.xtraSaveFileDialog1.Title = "حفظ الملف | الصالحاني للإدارة";
            this.xtraSaveFileDialog1.UseParentFormIcon = false;
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 472);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyForm";
            this.Text = "BuyForms";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI.WinForms.GunaAdvenceTileButton ManageFatoraBtn;
        private Guna.UI.WinForms.GunaAdvenceTileButton AddFatoraBtn;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaAdvenceTileButton SellFatoraManageBtn;
        private Guna.UI.WinForms.GunaAdvenceTileButton TksetFatora;
    }
}