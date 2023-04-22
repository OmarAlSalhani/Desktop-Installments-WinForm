namespace installmentsApp.SettingsForms
{
    partial class UsersPrivelagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPrivelagesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ManageBtn = new Guna.UI.WinForms.GunaTileButton();
            this.AddBtn = new Guna.UI.WinForms.GunaTileButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 42);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.gunaPictureBox1, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.IDLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.TopLabel, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(526, 42);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(492, 6);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(31, 30);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 10;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Lalezar", 10F);
            this.IDLabel.ForeColor = System.Drawing.Color.Yellow;
            this.IDLabel.Location = new System.Drawing.Point(56, 10);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 22);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "0";
            this.IDLabel.Visible = false;
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Lalezar", 17F);
            this.TopLabel.ForeColor = System.Drawing.Color.White;
            this.TopLabel.Location = new System.Drawing.Point(204, 2);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(116, 37);
            this.TopLabel.TabIndex = 8;
            this.TopLabel.Text = "المستخدمين";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(516, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 324);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 324);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(506, 10);
            this.panel5.TabIndex = 5;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ManageBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 304);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ManageBtn
            // 
            this.ManageBtn.AnimationHoverSpeed = 0.07F;
            this.ManageBtn.AnimationSpeed = 0.03F;
            this.ManageBtn.BackColor = System.Drawing.Color.Transparent;
            this.ManageBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ManageBtn.BorderColor = System.Drawing.Color.Black;
            this.ManageBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ManageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ManageBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.ManageBtn.ForeColor = System.Drawing.Color.White;
            this.ManageBtn.Image = ((System.Drawing.Image)(resources.GetObject("ManageBtn.Image")));
            this.ManageBtn.ImageSize = new System.Drawing.Size(55, 55);
            this.ManageBtn.Location = new System.Drawing.Point(3, 3);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ManageBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ManageBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ManageBtn.OnHoverImage = null;
            this.ManageBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ManageBtn.Radius = 9;
            this.ManageBtn.Size = new System.Drawing.Size(247, 298);
            this.ManageBtn.TabIndex = 2;
            this.ManageBtn.Text = "إدارة المستخدمين";
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AnimationHoverSpeed = 0.07F;
            this.AddBtn.AnimationSpeed = 0.03F;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddBtn.BorderColor = System.Drawing.Color.Black;
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageSize = new System.Drawing.Size(55, 55);
            this.AddBtn.Location = new System.Drawing.Point(256, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddBtn.OnHoverImage = null;
            this.AddBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddBtn.Radius = 9;
            this.AddBtn.Size = new System.Drawing.Size(247, 298);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "إضافة مستخدم";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.TopLabel;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.tableLayoutPanel8;
            // 
            // UsersPrivelagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(526, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersPrivelagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsersform";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.Label TopLabel;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel5;
        public Guna.UI.WinForms.GunaElipse gunaElipse1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Guna.UI.WinForms.GunaTileButton ManageBtn;
        public Guna.UI.WinForms.GunaTileButton AddBtn;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
    }
}