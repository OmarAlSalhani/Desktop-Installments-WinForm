namespace installmentsApp
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ManageCustomers = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.AddCustomer = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ManageCustomers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddCustomer, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 472);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // ManageCustomers
            // 
            this.ManageCustomers.AnimationHoverSpeed = 0.07F;
            this.ManageCustomers.AnimationSpeed = 0.03F;
            this.ManageCustomers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ManageCustomers.BorderColor = System.Drawing.Color.Black;
            this.ManageCustomers.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ManageCustomers.CheckedBorderColor = System.Drawing.Color.Black;
            this.ManageCustomers.CheckedForeColor = System.Drawing.Color.White;
            this.ManageCustomers.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ManageCustomers.CheckedImage")));
            this.ManageCustomers.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ManageCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ManageCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageCustomers.FocusedColor = System.Drawing.Color.Empty;
            this.ManageCustomers.Font = new System.Drawing.Font("Lalezar", 17F);
            this.ManageCustomers.ForeColor = System.Drawing.Color.White;
            this.ManageCustomers.Image = ((System.Drawing.Image)(resources.GetObject("ManageCustomers.Image")));
            this.ManageCustomers.ImageSize = new System.Drawing.Size(52, 52);
            this.ManageCustomers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ManageCustomers.Location = new System.Drawing.Point(3, 3);
            this.ManageCustomers.Name = "ManageCustomers";
            this.ManageCustomers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ManageCustomers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ManageCustomers.OnHoverForeColor = System.Drawing.Color.White;
            this.ManageCustomers.OnHoverImage = null;
            this.ManageCustomers.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ManageCustomers.OnPressedColor = System.Drawing.Color.Black;
            this.ManageCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManageCustomers.Size = new System.Drawing.Size(433, 466);
            this.ManageCustomers.TabIndex = 4;
            this.ManageCustomers.Text = "إدارة الزبائن";
            this.ManageCustomers.Click += new System.EventHandler(this.gunaAdvenceTileButton3_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.AnimationHoverSpeed = 0.07F;
            this.AddCustomer.AnimationSpeed = 0.03F;
            this.AddCustomer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddCustomer.BorderColor = System.Drawing.Color.Black;
            this.AddCustomer.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddCustomer.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddCustomer.CheckedForeColor = System.Drawing.Color.White;
            this.AddCustomer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddCustomer.CheckedImage")));
            this.AddCustomer.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.AddCustomer.Font = new System.Drawing.Font("Lalezar", 17F);
            this.AddCustomer.ForeColor = System.Drawing.Color.White;
            this.AddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("AddCustomer.Image")));
            this.AddCustomer.ImageSize = new System.Drawing.Size(52, 52);
            this.AddCustomer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddCustomer.Location = new System.Drawing.Point(442, 3);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.AddCustomer.OnHoverImage = null;
            this.AddCustomer.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.AddCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddCustomer.Size = new System.Drawing.Size(435, 466);
            this.AddCustomer.TabIndex = 2;
            this.AddCustomer.Text = "إضافة زبون";
            this.AddCustomer.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 472);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI.WinForms.GunaAdvenceTileButton ManageCustomers;
        private Guna.UI.WinForms.GunaAdvenceTileButton AddCustomer;
    }
}