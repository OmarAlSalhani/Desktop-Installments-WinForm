namespace installmentsApp
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateBackupBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.GrantPrivelagesBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.ManageUsersBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.RestoreBackupBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton2 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.CreateBackupBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.GrantPrivelagesBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gunaAdvenceTileButton1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ManageUsersBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.RestoreBackupBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.gunaAdvenceTileButton2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 477);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // CreateBackupBtn
            // 
            this.CreateBackupBtn.AnimationHoverSpeed = 0.07F;
            this.CreateBackupBtn.AnimationSpeed = 0.03F;
            this.CreateBackupBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CreateBackupBtn.BorderColor = System.Drawing.Color.Black;
            this.CreateBackupBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CreateBackupBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.CreateBackupBtn.CheckedForeColor = System.Drawing.Color.White;
            this.CreateBackupBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CreateBackupBtn.CheckedImage")));
            this.CreateBackupBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CreateBackupBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateBackupBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateBackupBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CreateBackupBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.CreateBackupBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBackupBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateBackupBtn.Image")));
            this.CreateBackupBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.CreateBackupBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CreateBackupBtn.Location = new System.Drawing.Point(605, 3);
            this.CreateBackupBtn.Name = "CreateBackupBtn";
            this.CreateBackupBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CreateBackupBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreateBackupBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CreateBackupBtn.OnHoverImage = null;
            this.CreateBackupBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CreateBackupBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CreateBackupBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreateBackupBtn.Size = new System.Drawing.Size(295, 232);
            this.CreateBackupBtn.TabIndex = 5;
            this.CreateBackupBtn.Text = "إنشاء نسخة أحتياطية";
            this.CreateBackupBtn.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // GrantPrivelagesBtn
            // 
            this.GrantPrivelagesBtn.AnimationHoverSpeed = 0.07F;
            this.GrantPrivelagesBtn.AnimationSpeed = 0.03F;
            this.GrantPrivelagesBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GrantPrivelagesBtn.BorderColor = System.Drawing.Color.Black;
            this.GrantPrivelagesBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.GrantPrivelagesBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.GrantPrivelagesBtn.CheckedForeColor = System.Drawing.Color.White;
            this.GrantPrivelagesBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("GrantPrivelagesBtn.CheckedImage")));
            this.GrantPrivelagesBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.GrantPrivelagesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GrantPrivelagesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrantPrivelagesBtn.FocusedColor = System.Drawing.Color.Empty;
            this.GrantPrivelagesBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.GrantPrivelagesBtn.ForeColor = System.Drawing.Color.White;
            this.GrantPrivelagesBtn.Image = ((System.Drawing.Image)(resources.GetObject("GrantPrivelagesBtn.Image")));
            this.GrantPrivelagesBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.GrantPrivelagesBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.GrantPrivelagesBtn.Location = new System.Drawing.Point(3, 3);
            this.GrantPrivelagesBtn.Name = "GrantPrivelagesBtn";
            this.GrantPrivelagesBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.GrantPrivelagesBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GrantPrivelagesBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.GrantPrivelagesBtn.OnHoverImage = null;
            this.GrantPrivelagesBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.GrantPrivelagesBtn.OnPressedColor = System.Drawing.Color.Black;
            this.GrantPrivelagesBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrantPrivelagesBtn.Size = new System.Drawing.Size(295, 232);
            this.GrantPrivelagesBtn.TabIndex = 12;
            this.GrantPrivelagesBtn.Text = "منح الصلاحيات";
            this.GrantPrivelagesBtn.Click += new System.EventHandler(this.gunaAdvenceTileButton2_Click);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Lalezar", 17F);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.Image")));
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(304, 241);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(295, 233);
            this.gunaAdvenceTileButton1.TabIndex = 15;
            this.gunaAdvenceTileButton1.Text = "إعدادات قاعدة البيانات";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click_1);
            // 
            // ManageUsersBtn
            // 
            this.ManageUsersBtn.AnimationHoverSpeed = 0.07F;
            this.ManageUsersBtn.AnimationSpeed = 0.03F;
            this.ManageUsersBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ManageUsersBtn.BorderColor = System.Drawing.Color.Black;
            this.ManageUsersBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ManageUsersBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.ManageUsersBtn.CheckedForeColor = System.Drawing.Color.White;
            this.ManageUsersBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ManageUsersBtn.CheckedImage")));
            this.ManageUsersBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ManageUsersBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ManageUsersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageUsersBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ManageUsersBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.ManageUsersBtn.ForeColor = System.Drawing.Color.White;
            this.ManageUsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("ManageUsersBtn.Image")));
            this.ManageUsersBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.ManageUsersBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ManageUsersBtn.Location = new System.Drawing.Point(3, 241);
            this.ManageUsersBtn.Name = "ManageUsersBtn";
            this.ManageUsersBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ManageUsersBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ManageUsersBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ManageUsersBtn.OnHoverImage = null;
            this.ManageUsersBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ManageUsersBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ManageUsersBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManageUsersBtn.Size = new System.Drawing.Size(295, 233);
            this.ManageUsersBtn.TabIndex = 11;
            this.ManageUsersBtn.Text = "إدارة المستخدمين والصلاحيات";
            this.ManageUsersBtn.Click += new System.EventHandler(this.ManageUsersBtn_Click);
            // 
            // RestoreBackupBtn
            // 
            this.RestoreBackupBtn.AnimationHoverSpeed = 0.07F;
            this.RestoreBackupBtn.AnimationSpeed = 0.03F;
            this.RestoreBackupBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RestoreBackupBtn.BorderColor = System.Drawing.Color.Black;
            this.RestoreBackupBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.RestoreBackupBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.RestoreBackupBtn.CheckedForeColor = System.Drawing.Color.White;
            this.RestoreBackupBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("RestoreBackupBtn.CheckedImage")));
            this.RestoreBackupBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.RestoreBackupBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RestoreBackupBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestoreBackupBtn.FocusedColor = System.Drawing.Color.Empty;
            this.RestoreBackupBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.RestoreBackupBtn.ForeColor = System.Drawing.Color.White;
            this.RestoreBackupBtn.Image = ((System.Drawing.Image)(resources.GetObject("RestoreBackupBtn.Image")));
            this.RestoreBackupBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.RestoreBackupBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RestoreBackupBtn.Location = new System.Drawing.Point(605, 241);
            this.RestoreBackupBtn.Name = "RestoreBackupBtn";
            this.RestoreBackupBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.RestoreBackupBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RestoreBackupBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.RestoreBackupBtn.OnHoverImage = null;
            this.RestoreBackupBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RestoreBackupBtn.OnPressedColor = System.Drawing.Color.Black;
            this.RestoreBackupBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RestoreBackupBtn.Size = new System.Drawing.Size(295, 233);
            this.RestoreBackupBtn.TabIndex = 7;
            this.RestoreBackupBtn.Text = "إستعادة نسخة أحتياطية";
            this.RestoreBackupBtn.Click += new System.EventHandler(this.gunaAdvenceTileButton3_Click);
            // 
            // gunaAdvenceTileButton2
            // 
            this.gunaAdvenceTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton2.CheckedImage")));
            this.gunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton2.Font = new System.Drawing.Font("Lalezar", 17F);
            this.gunaAdvenceTileButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton2.Image")));
            this.gunaAdvenceTileButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.Location = new System.Drawing.Point(304, 3);
            this.gunaAdvenceTileButton2.Name = "gunaAdvenceTileButton2";
            this.gunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.OnHoverImage = null;
            this.gunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaAdvenceTileButton2.Size = new System.Drawing.Size(295, 232);
            this.gunaAdvenceTileButton2.TabIndex = 14;
            this.gunaAdvenceTileButton2.Text = "إعدادات التقرير";
            this.gunaAdvenceTileButton2.Click += new System.EventHandler(this.gunaAdvenceTileButton2_Click_1);
            // 
            // xtraFolderBrowserDialog1
            // 
            this.xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            this.xtraOpenFileDialog1.Filter = "ملفات قاعدة البيانات|*.bak";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 477);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI.WinForms.GunaAdvenceTileButton CreateBackupBtn;
        private Guna.UI.WinForms.GunaAdvenceTileButton RestoreBackupBtn;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private Guna.UI.WinForms.GunaAdvenceTileButton ManageUsersBtn;
        private Guna.UI.WinForms.GunaAdvenceTileButton GrantPrivelagesBtn;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton2;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
    }
}