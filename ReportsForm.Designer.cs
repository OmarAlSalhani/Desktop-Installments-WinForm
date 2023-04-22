﻿namespace installmentsApp
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.CashReports = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CutomerKshfBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.CashFatoraBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.TksetFatoraBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.TksetReports = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashReports
            // 
            this.CashReports.AnimationHoverSpeed = 0.07F;
            this.CashReports.AnimationSpeed = 0.03F;
            this.CashReports.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CashReports.BorderColor = System.Drawing.Color.Black;
            this.CashReports.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CashReports.CheckedBorderColor = System.Drawing.Color.Black;
            this.CashReports.CheckedForeColor = System.Drawing.Color.White;
            this.CashReports.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CashReports.CheckedImage")));
            this.CashReports.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CashReports.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CashReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashReports.FocusedColor = System.Drawing.Color.Empty;
            this.CashReports.Font = new System.Drawing.Font("Lalezar", 17F);
            this.CashReports.ForeColor = System.Drawing.Color.White;
            this.CashReports.Image = ((System.Drawing.Image)(resources.GetObject("CashReports.Image")));
            this.CashReports.ImageSize = new System.Drawing.Size(52, 52);
            this.CashReports.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CashReports.Location = new System.Drawing.Point(642, 3);
            this.CashReports.Name = "CashReports";
            this.CashReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CashReports.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CashReports.OnHoverForeColor = System.Drawing.Color.White;
            this.CashReports.OnHoverImage = null;
            this.CashReports.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CashReports.OnPressedColor = System.Drawing.Color.Black;
            this.CashReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CashReports.Size = new System.Drawing.Size(155, 444);
            this.CashReports.TabIndex = 2;
            this.CashReports.Text = "تقرير المبيعات النقدية";
            this.CashReports.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.CutomerKshfBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CashFatoraBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TksetFatoraBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TksetReports, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CashReports, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // CutomerKshfBtn
            // 
            this.CutomerKshfBtn.AnimationHoverSpeed = 0.07F;
            this.CutomerKshfBtn.AnimationSpeed = 0.03F;
            this.CutomerKshfBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CutomerKshfBtn.BorderColor = System.Drawing.Color.Black;
            this.CutomerKshfBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CutomerKshfBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.CutomerKshfBtn.CheckedForeColor = System.Drawing.Color.White;
            this.CutomerKshfBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CutomerKshfBtn.CheckedImage")));
            this.CutomerKshfBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CutomerKshfBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CutomerKshfBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CutomerKshfBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CutomerKshfBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.CutomerKshfBtn.ForeColor = System.Drawing.Color.White;
            this.CutomerKshfBtn.Image = ((System.Drawing.Image)(resources.GetObject("CutomerKshfBtn.Image")));
            this.CutomerKshfBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.CutomerKshfBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CutomerKshfBtn.Location = new System.Drawing.Point(323, 3);
            this.CutomerKshfBtn.Name = "CutomerKshfBtn";
            this.CutomerKshfBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CutomerKshfBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CutomerKshfBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CutomerKshfBtn.OnHoverImage = null;
            this.CutomerKshfBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CutomerKshfBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CutomerKshfBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CutomerKshfBtn.Size = new System.Drawing.Size(154, 444);
            this.CutomerKshfBtn.TabIndex = 6;
            this.CutomerKshfBtn.Text = "كشف حساب زبون";
            this.CutomerKshfBtn.Click += new System.EventHandler(this.CutomerKshfBtn_Click);
            // 
            // CashFatoraBtn
            // 
            this.CashFatoraBtn.AnimationHoverSpeed = 0.07F;
            this.CashFatoraBtn.AnimationSpeed = 0.03F;
            this.CashFatoraBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CashFatoraBtn.BorderColor = System.Drawing.Color.Black;
            this.CashFatoraBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CashFatoraBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.CashFatoraBtn.CheckedForeColor = System.Drawing.Color.White;
            this.CashFatoraBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CashFatoraBtn.CheckedImage")));
            this.CashFatoraBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CashFatoraBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CashFatoraBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashFatoraBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CashFatoraBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.CashFatoraBtn.ForeColor = System.Drawing.Color.White;
            this.CashFatoraBtn.Image = ((System.Drawing.Image)(resources.GetObject("CashFatoraBtn.Image")));
            this.CashFatoraBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.CashFatoraBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CashFatoraBtn.Location = new System.Drawing.Point(483, 3);
            this.CashFatoraBtn.Name = "CashFatoraBtn";
            this.CashFatoraBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CashFatoraBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CashFatoraBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CashFatoraBtn.OnHoverImage = null;
            this.CashFatoraBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CashFatoraBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CashFatoraBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CashFatoraBtn.Size = new System.Drawing.Size(153, 444);
            this.CashFatoraBtn.TabIndex = 5;
            this.CashFatoraBtn.Text = "تقرير المشتريات النقدية";
            this.CashFatoraBtn.Click += new System.EventHandler(this.CashFatoraBtn_Click);
            // 
            // TksetFatoraBtn
            // 
            this.TksetFatoraBtn.AnimationHoverSpeed = 0.07F;
            this.TksetFatoraBtn.AnimationSpeed = 0.03F;
            this.TksetFatoraBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TksetFatoraBtn.BorderColor = System.Drawing.Color.Black;
            this.TksetFatoraBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.TksetFatoraBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.TksetFatoraBtn.CheckedForeColor = System.Drawing.Color.White;
            this.TksetFatoraBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("TksetFatoraBtn.CheckedImage")));
            this.TksetFatoraBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.TksetFatoraBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TksetFatoraBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TksetFatoraBtn.FocusedColor = System.Drawing.Color.Empty;
            this.TksetFatoraBtn.Font = new System.Drawing.Font("Lalezar", 17F);
            this.TksetFatoraBtn.ForeColor = System.Drawing.Color.White;
            this.TksetFatoraBtn.Image = ((System.Drawing.Image)(resources.GetObject("TksetFatoraBtn.Image")));
            this.TksetFatoraBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.TksetFatoraBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.TksetFatoraBtn.Location = new System.Drawing.Point(3, 3);
            this.TksetFatoraBtn.Name = "TksetFatoraBtn";
            this.TksetFatoraBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.TksetFatoraBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.TksetFatoraBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.TksetFatoraBtn.OnHoverImage = null;
            this.TksetFatoraBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.TksetFatoraBtn.OnPressedColor = System.Drawing.Color.Black;
            this.TksetFatoraBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TksetFatoraBtn.Size = new System.Drawing.Size(154, 444);
            this.TksetFatoraBtn.TabIndex = 4;
            this.TksetFatoraBtn.Text = "تقرير المشتريات الآجلة";
            this.TksetFatoraBtn.Click += new System.EventHandler(this.TksetFatoraBtn_Click);
            // 
            // TksetReports
            // 
            this.TksetReports.AnimationHoverSpeed = 0.07F;
            this.TksetReports.AnimationSpeed = 0.03F;
            this.TksetReports.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TksetReports.BorderColor = System.Drawing.Color.Black;
            this.TksetReports.CheckedBaseColor = System.Drawing.Color.Gray;
            this.TksetReports.CheckedBorderColor = System.Drawing.Color.Black;
            this.TksetReports.CheckedForeColor = System.Drawing.Color.White;
            this.TksetReports.CheckedImage = ((System.Drawing.Image)(resources.GetObject("TksetReports.CheckedImage")));
            this.TksetReports.CheckedLineColor = System.Drawing.Color.DimGray;
            this.TksetReports.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TksetReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TksetReports.FocusedColor = System.Drawing.Color.Empty;
            this.TksetReports.Font = new System.Drawing.Font("Lalezar", 17F);
            this.TksetReports.ForeColor = System.Drawing.Color.White;
            this.TksetReports.Image = ((System.Drawing.Image)(resources.GetObject("TksetReports.Image")));
            this.TksetReports.ImageSize = new System.Drawing.Size(52, 52);
            this.TksetReports.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.TksetReports.Location = new System.Drawing.Point(163, 3);
            this.TksetReports.Name = "TksetReports";
            this.TksetReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.TksetReports.OnHoverBorderColor = System.Drawing.Color.Black;
            this.TksetReports.OnHoverForeColor = System.Drar�+�r�+�r�+�r�+�r�+�r�+�r�+�r�+�r�+�r�+�r�+�r�+�b���s#;c�X�xV�/��5�uI;և�3��?b��M��=�G��;:3�n̉wNwG���=fܝ�é3$�¸+q�Wt�3��[O��ͧ�;�0 ���n�3�7n�V�L�V����o�[&��oKz��3�5�5�Z�ܚ����_&.Ύ����OZ��� �86���pl�c�� ��e,`� �Xr.s� [��Q7�~4�ZQ5�`� �X6����l�e,`� �X6����l�e,`� �X6����l�e,`� �X6����l�e,`� �X6����l�%s�e���`&���}�{����Y��U�]ڊ�ĺ^џ ��D��6˹�0�1�5��L�a^���Ʃ_�;��\�k�s-x�ϵ�<ׂ�Z�\�k�s-x�ϵ�<ׂ�Z�\�k�s-x�ϵ�<ׂ�Z�\�k�s-x�ϵ�<ׂ�Z�\�k�s-x�ϵ�<ׂ�Z�\�k�s-x�ϵ�<ׂ�Z�\�k�s-x�ϵ�<ׂ�Z�\�k�s-x�ϵ�<ׂ�Z�s�e��Kby�uc[��H�	?�1�>a��@�o��Mg˛ƣ"@�`�y ��`�y ��`�y ��`�9�2wa��(u3�G���Q�> � �0�< � �0�< � �0�< � �0�< � �0�< � �0�< � �0�< � �0�< � �0�< � �0g���s#;cI|,>llMz�:����Y����`�ڷg��;Z�ǈ�e�FRgq<�أ�<���?�� %�=���Կ�|�L?��"E�#±�q(��S'���i�{�׉�k1���t��X���q�|���&�����G!��/׉[c�|�z��B�o�.��K���_k�����:}��1qu��Y'R'�j��챙�:�K�)��]�h}�>��x+�{�ɓ�~J�����9�O}��N���<kl9Z���g�9�GQ'��iy�
�))�E�rX�êV�*�UON�./�~�������cs���y]D��Ol�uߡoL�EǄQ�ޛR�c����sf������؟R��ؓr��M9s�u\.^���-�_��׽�׽�׽�׽�׽h̆VI��v`���h�sLņ�
�K���!td�<�.l�e�n��h��0j��R�χ]�url'ڎ�h?���b�o�ub`��h3Z���h%���	f�:�F��G�9����܂]��86[�&��n�V /����X)�<����mZ%�@-j9PˁZ�r�����@-j9Pˁ�1wa��(u3�G���Qϗ�}>�"��c;�vD�Q��}��c`��h3Z���h%���	f�:�F��G�9����܂]��86[�&��n�V /���>�&y�u��%ڭ%�t=$eȧVC�<u�&K��g����9��D���c*6�V0^����#��܅-��l�ͼ��VFM�g��p�����N��~����h���X3vڌ���h-Z�,�mB�Y��m@��n�m���9�`W�:���V�	�k�۰��:7�3��?"��ޤ����z���E��\ �G>.O텲��:�H~:�:řTѿGr��O%�7�q��Q�D.�-�~�6��QG����^����#K�;�G�X���������#��G�\-����ʏ&�%[%��\<rl��?rlf�2��amU�v�x�k9_�a��=�c����U�c�#<���-�h��Y����>,�k�1Z%��m�d1�FL��m�d1�FL��m�d1�FLrs� [��Q7�~4�ZQ5�ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���l#&ۈ�6b���d���s#;cI���<u-j-��f�4C�:��i�N3t�����c��{A6�.l�e�n��h��0j�7C�B�j�P3��!��f5C�B�j�P3��!��f5C�B�j�P3��!��f5C�B�j�P3��!��f5C�B�j