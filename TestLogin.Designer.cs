﻿namespace installmentsApp
{
    partial class TestLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestLogin));
            this.LoginBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.WaitPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.usernameTB = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.backgroundWorker100 = new System.ComponentModel.BackgroundWorker();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTB.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.LoginBtn.Location = new System.Drawing.Point(36, 366);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Radius = 7;
            this.LoginBtn.Size = new System.Drawing.Size(269, 54);
            this.LoginBtn.TabIndex = 14;
            this.LoginBtn.Text = "الدخول";
            this.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // WaitPanel
            // 
            this.WaitPanel.AnimationAcceleration = 4F;
            this.WaitPanel.AnimationSpeed = 4F;
            this.WaitPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.WaitPanel.Appearance.Font = new System.Drawing.Font("Lalezar", 8F, System.Drawing.FontStyle.Bold);
            this.WaitPanel.Appearance.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.WaitPanel.Appearance.Options.UseBackColor = true;
            this.WaitPanel.Appearance.Options.UseFont = true;
            this.WaitPanel.Appearance.Options.UseForeColor = true;
            this.WaitPanel.AppearanceCaption.Font = new System.Drawing.Font("Lalezar", 12F);
            this.WaitPanel.AppearanceCaption.Options.UseFont = true;
            this.WaitPanel.BarAnimationElementThickness = 2;
            this.WaitPanel.Caption = "";
            this.WaitPanel.Description = "";
            this.WaitPanel.Location = new System.Drawing.Point(36, 368);
            this.WaitPanel.Name = "WaitPanel";
            this.WaitPanel.ShowCaption = false;
            this.WaitPanel.ShowDescription = false;
            this.WaitPanel.Size = new System.Drawing.Size(269, 54);
            this.WaitPanel.TabIndex = 3;
            this.WaitPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            this.WaitPanel.Click += new System.EventHandler(this.WaitPanel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 42);
            this.panel1.TabIndex = 14;
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
            this.tableLayoutPanel8.Size = new System.Drawing.Size(338, 42);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(304, 6);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(31, 30);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 10;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Lalezar", 17F);
            this.TopLabel.ForeColor = System.Drawing.Color.White;
            this.TopLabel.Location = new System.Drawing.Point(98, 2);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(140, 37);
            this.TopLabel.TabIndex = 8;
            this.TopLabel.Text = "تسجيل الدخول";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(104, 71);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(120, 106);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 15;
            this.gunaPictureBox2.TabStop = false;
            // 
            // usernameTB
            // 
            this.usernameTB.EnterMoveNextControl = true;
            this.usernameTB.Location = new System.Drawing.Point(26, 219);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.usernameTB.Properties.Appearance.Font = new System.Drawing.Font("Lalezar", 15F);
            this.usernameTB.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.usernameTB.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("usernameTB.Properties.Appearance.Image")));
            this.usernameTB.Properties.Appearance.Options.UseBackColor = true;
            this.usernameTB.Properties.Appearance.Options.UseFont = true;
            this.usernameTB.Properties.Appearance.Options.UseForeColor = true;
            this.usernameTB.Properties.Appearance.Options.UseImage = true;
            this.usernameTB.Properties.Appearance.Options.UseTextOptions = true;
            this.usernameTB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.usernameTB.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.usernameTB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.usernameTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameTB.Size = new System.Drawing.Size(289, 40);
            this.usernameTB.TabIndex = 12;
            this.usernameTB.EditValueChanged += new System.EventHandler(this.usernameTB_EditValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lalezar", 12F);
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(124, 183);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "إسم المستخدم";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(26, 303);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.passwordTB.Properties.Appearance.Font = new System.Drawing.Font("Lalezar", 15F);
            this.passwordTB.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.passwordTB.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.passwordTB.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("passwordTB.Properties.Appearance.Image")));
            this.passwordTB.Properties.Appearance.Options.UseBackColor = true;
            this.passwordTB.Properties.Appearance.Options.UseFont = true;
            this.passwordTB.Properties.Appearance.Options.UseForeColor = true;
            this.passwordTB.Properties.Appearance.Options.UseImage = true;
            this.passwordTB.Properties.Appearance.Options.UseTextOptions = true;
            this.passwordTB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.passwordTB.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.passwordTB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.passwordTB.Properties.PasswordChar = '*';
            this.passwordTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordTB.Size = new System.Drawing.Size(289, 40);
            this.passwordTB.TabIndex = 13;
            this.passwordTB.EditValueChanged += new System.EventHandler(this.passwordTB_EditValueChanged);
            this.passwordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTB_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lalezar", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(136, 268);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "كلمة المرور";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.tableLayoutPanel8;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.TopLabel;
            // 
            // backgroundWorker100
            // 
            this.backgroundWorker100.WorkerSupportsCancellation = true;
            this.backgroundWorker100.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker100_DoWork);
            this.backgroundWorker100.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // gunaElipse1
            // 
   ��
X�+p`���8�R8�V��
X�+p`���8�V��
X�+p`���8�V��
���/���u�|��2�Lc<�3��\c<���Rc<�?k��1�%�x�1~��������քT�ejS��?=Q�nNX��H�T%���Y��S��?�Q�b�� �G>�n9O�gSY����|zG>�#�ޑO�ȧw��;����#��?����|�G>�#���O�ȧ��?����|�G>�#���O�ȧ��?����|�G>�#���O�ȧ��?����|�G>�#���O�ȧ��?����|�G>�#���O�ȧ��?����|�G>�#���O�ȧ��?����|�G>�#�����/������xIb��R��	���T�5M��qs���\��B-j�P˅Z.�r���\��B-j�P㾬����,��X�aԉ�Pؔ�\��B-j�P˅Z.�r���\��B-j�P˅Z.�r���\��B-j�P˅Z.�r���\��B-j�P˅Z.�r���\��B-j�P˅Z.�X�����$�s�� v�1^9ŏY��1/��6/�A5�yP̓jT��<��A5�yP̓jT��<��A5�yP̓jT��<��A5�yP̓jT��<��A5�yP̓jT��<��A5�yP̓jT��<��A5�yP̓jT��<��A5�yP̓jT��<��F!� 7��c���QQ|v	�||�b��)�����"��ɿ�=+t�sB�a�~�:<���M3.7�u���͔3��'�9!WmI�J}(�:u�t�z�T��u�8�k�<���;�_W�S�o2O���+{ʾ���q5��V˧<ﵬ/�����?���.6n��/4�����	.'��猌ܬ^3��VN����-?�*�|c�,cL7j�Ƙf�g����;c��1�6�����1�����U�B�X:El?��ǳ���s���sMҳsu�ù;ş�K�s��Y%��*>��O\|�1ǜ!]n�>�3�[�Y���$��q�yP�3���Nq�yH��6�6'J����>%ϗN���ry�p�>q��C< �_�m�O^ m�w���i���=��"}_�'=/��~%ۥ?�V逼LzC^$��8������Z�"e��QY!ݮ���PVI��R��U|W� �S��>�rΦ.�*U��3�W�*��4�bY*�Y6�tK�89���/���/��S����W�Y�w�l1�+"MW�o���Nԗ�ڭ�8�7z�_�/�yt�oί�W�<0�o�.��9�ԇ��Bs�N�М����#sVDG��Lr����?՟�����/�s������o���sO�����~����I������D?GD���
5���Qml戦���g���6���b�����>m~Qw�_�W����4?��f���s�~���z��{z���������oh���c_3?�����͗��i��S�o��]z����H��r�g�|����r������7�O�M�zP~BH~\o�;����r��Kޮ�^����!�c�6ݪ���ʣ��}��-ݮ<�B���P����|]OQZ�O*�RZ�T�Y?M��~���Pz��U�L�IOW��"e��X٢_�l֗+��lŧ_�x�ţ_�4�+nݩ4��W�+��+��<�^�J���Z�je�~�R�_�ܯ_�T��+U���^�l�oP*�B�>�6�^��J�^�ܣE�[ߦܥ����cJ�V��ە2�]�S�(w�ʗ�Ǖ/�O(_ԟT��?�|^Z�]F�M�Tn՟UJ�.�D��R�w+���)E�w��z��FIY��)��~e��Ce��#�f���M��ʍ�O�B�����@���9}@�^��r��S�V��r��K�j}���ȯ�G����S0r�z�~����Q���W�f5W�U�����z�nQs�d�R}���/T��v���źC�H?U�POQ/�?���J��S�L�4�<�t5C?C=WOS���T����#�ԥ��l}��Y�H��~��D/V�������^�V5;z��G�]u��5�O��۵/���S��{���{�}���@�U�)�������~�4�W�$�_�kѿ��ԿG�T�;zH������Q��h��5Y��3-��-�O�$G?b�x�D�-z�	��,FO�$��b�����7]���Z,��η8F?n�����f���?e�S-��N��蟵Ī��j�T)}Ы�����i_V���=�T;g��MW��j�!�v���o��Zʥe��U�C-��To�ζH��q�t%�8��Z���~����tE���Ҋ8~�� 1��?��s�]��S������qE���'���+c��M����9�t5�������U�^	�Q���!4���8;���6���	sn1�5�a�/5n5U4�	b��A=S�_�?G>Sa�K��*U�V�b<���X�E���N3D�V���=��<�BoP��7���ש���b���&b?ڋ� �t�N�μ����J܇��M�LbJB��0�DC(l�=��mۉ�^�mF>��F6�/@�����<�ّ-C���Ak�~�]A\�V��h+�6���K��m3�UHc����X�B�@n�8C�U��ߡ������?�N�����=0�zc�3ƚ��_ft�]9��4]������4�	u�ԭ�*�P�*~��!�V?.�N���G2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2�"C.2���/���Uq��SS�Mj��Y���Eж�6-�~4TMчՄ��Oimj��M������WS�o��j����PU�����'�]�]���PThP��\m0�u�x�>&2�_}�O�M&&)��Ė�����Αv�yV\?�mԍ�CϠ���)t�t�����{QJE'����_�tA�5�t�\��(�߳������Q��y
��x�L����E���Z�Z6�۞{?���G=��y�z���Pд��t�e�sG�hI_{�{d�Yz�:#�u5�