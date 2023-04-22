namespace installmentsApp
{
    partial class DBSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ServerWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerCB = new System.Windows.Forms.ComboBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.DBNameCB = new System.Windows.Forms.ComboBox();
            this.LoginBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.WaitPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.DeleteSeedCreateWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 35);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.gunaPictureBox1, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.TopLabel, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(339, 35);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(305, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(31, 29);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 10;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Lalezar", 14F);
            this.TopLabel.ForeColor = System.Drawing.Color.White;
            this.TopLabel.Location = new System.Drawing.Point(87, 2);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(163, 30);
            this.TopLabel.TabIndex = 8;
            this.TopLabel.Text = "إعدادات قاعدة البيانات";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(329, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 227);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 217);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 10);
            this.panel5.TabIndex = 5;
            // 
            // ServerWorker
            // 
            this.ServerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ServerWorker_DoWork);
            this.ServerWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ServerWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lalezar", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(113, 138);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "إسم قاعدة البيانات";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lalezar", 12F);
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(131, 58);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "إسم السيرفر";
            // 
            // ServerCB
            // 
            this.ServerCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ServerCB.Font = new System.Drawing.Font("Lalezar", 13F);
            this.ServerCB.ForeColor = System.Drawing.Color.White;
            this.ServerCB.FormattingEnabled = true;
            this.ServerCB.Location = new System.Drawing.Point(39, 202);
            this.ServerCB.Name = "ServerCB";
            this.ServerCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ServerCB.Size = new System.Drawing.Size(267, 35);
            this.ServerCB.TabIndex = 9;
            this.ServerCB.SelectedIndexChanged += new System.EventHandler(this.ServerCB_SelectedIndexChanged);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(112, 51);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(120, 106);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 17;
            this.gunaPictureBox2.TabStop = false;
            // 
            // DBNameCB
            // 
            this.DBNameCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.DBNameCB.Font = new System.Drawing.Font("Lalezar", 13F);
            this.DBNameCB.ForeColor = System.Drawing.Color.White;
            this.DBNameCB.FormattingEnabled = true;
            this.DBNameCB.Location = new System.Drawing.Point(38, 282);
            this.DBNameCB.Name = "DBNameCB";
            this.DBNameCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DBNameCB.Size = new System.Drawing.Size(269, 35);
            this.DBNameCB.TabIndex = 9;
            this.DBNameCB.SelectedIndexChanged += new System.EventHandler(this.DBNameCB_SelectedIndexChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.LoginBtn.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.LoginBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.CheckedForeColor = System.Drawing.Color.White;
            this.LoginBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.CheckedImage")));
            this.LoginBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBtn.Font = new System.Drawing.Font("Lalezar", 14F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoginBtn.Image")));
            this.LoginBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.LoginBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LoginBtn.Location = new System.Drawing.Point(76, 353);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Radius = 7;
            this.LoginBtn.Size = new System.Drawing.Size(189, 60);
            this.LoginBtn.TabIndex = 18;
            this.LoginBtn.Text = "حفظ الإعدادات";
            this.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // WaitPanel
            // 
            this.WaitPanel.AnimationAcceleration = 4F;
            this.WaitPanel.AnimationSpeed = 4F;
            this.WaitPanel.AnimationToTextDistance = 22;
            this.WaitPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.WaitPanel.Appearance.Font = new System.Drawing.Font("Lalezar", 8F, System.Drawing.FontStyle.Bold);
            this.WaitPanel.Appearance.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.WaitPanel.Appearance.Options.UseBackColor = true;
            this.WaitPanel.Appearance.Options.UseFont = true;
            this.WaitPanel.Appearance.Options.UseForeColor = true;
            this.WaitPanel.AppearanceCaption.Font = new System.Drawing.Font("Lalezar", 15F);
            this.WaitPanel.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow;
            this.WaitPanel.AppearanceCaption.Options.UseFont = true;
            this.WaitPanel.AppearanceCaption.Options.UseForeColor = true;
            this.WaitPanel.AppearanceDescription.Font = new System.Drawing.Font("Lalezar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitPanel.AppearanceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WaitPanel.AppearanceDescription.Options.UseFont = true;
            this.WaitPanel.AppearanceDescription.Options.UseForeColor = true;
            this.WaitPanel.BarAnimationElementThickness = 2;
            this.WaitPanel.Caption = "الرجاء الأنتظار قليلاً";
            this.WaitPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.WaitPanel.Description = "أقوم بجلب أسماء السيرفرات حالياً";
            this.WaitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaitPanel.FrameInterval = 1200;
            this.WaitPanel.Location = new System.Drawing.Point(10, 45);
            this.WaitPanel.Name = "WaitPanel";
            this.WaitPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WaitPanel.Size = new System.Drawing.Size(319, 207);
            this.WaitPanel.TabIndex = 22;
            this.WaitPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.tableLayoutPanel8;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.TopLabel;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = null;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(126, 50);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(73, 64);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 23;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // DeleteSeedCreateWorker
            // 
            this.DeleteSeedCreateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DeleteSeedCreateWorker_DoWork);
            this.DeleteSeedCreateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DeleteSeedCreateWorker_RunWorkerCompleted);
            // 
            // DBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(339, 262);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.WaitPanel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.DBNameCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DBSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBSettings";
            this.Load += new System.EventHandler(this.DBSettings_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.ComponentModel.BackgroundWorker ServerWorker;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ServerCB;
        public System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        public System.Windows.Forms.Label TopLabel;
        public System.Windows.Forms.ComboBox DBNameCB;
        public Guna.UI.WinForms.GunaAdvenceButton LoginBtn;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private DevExpress.XtraWaitForm.ProgressPanel WaitPanel;
        private System.ComponentModel.BackgroundWorker DeleteSeedCreateWorker;
    }
}