namespace installmentsApp
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
            this.LoginBtn.Text = "ÿßŸÑÿØÿÆŸàŸÑ";
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
            this.TopLabel.Text = "ÿ™ÿ≥ÿ¨ŸäŸÑ ÿßŸÑÿØÿÆŸàŸÑ";
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
            this.label3.Text = "ÿ•ÿ≥ŸÖ ÿßŸÑŸÖÿ≥ÿ™ÿÆÿØŸÖ";
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
            this.label1.Text = "ŸÉŸÑŸÖÿ© ÿßŸÑŸÖÿ±Ÿàÿ±";
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
   ‡¿
XÅ+p`¨¿Å8∞R8∞V‡¿
XÅ+p`¨¿Å8∞V‡¿
XÅ+p`¨¿Å8∞V‡¿
»Öÿ/Ä‹Ãu˝|„Õ2∆Lc<œ3åÒ\c<«ó„Rc<€?kåü1∆%∆xñ1~⁄„¢¯˚ñÑ≈Í÷ÑT¬ejS¬çÍ§Á?=QÅnNX¢ÆH»T%Òƒ»YÍıSŒƒ?ØQÍ≥bôö ⁄G>´n9OÔgSYÚÈ˘Ùé|zG>Ω#üﬁëOÔ»ßw‰”;ÚÈ˘ú#Á”?ÚÈ˘Ùè|˙G>˝#ü˛ëOˇ»ß‰”?ÚÈ˘Ùè|˙G>˝#ü˛ëOˇ»ß‰”?ÚÈ˘Ùè|˙G>˝#ü˛ëOˇ»ß‰”?ÚÈ˘Ùè|˙G>˝#ü˛ëOˇ»ß‰”?ÚÈ˘Ùè|˙G>˝#ü˛ëOˇ»ß‰”?ÚÈ˘Ùè|˙G>˝#ü˛ëOˇ»ß‰”?ÚÈ˘Ùè|˙G>˝#ü˛¡Öÿ/Ä‹Ã«È≈xIb˚»Rıä	¢óäTÈ5M‰“qs°ñµ\®ÂB-jπPÀÖZ.‘r°ñµ\®ÂB-jπP„æ¨õàôƒ,îÑX¢a‘âÜPÿîµ\®ÂB-jπPÀÖZ.‘r°ñµ\®ÂB-jπPÀÖZ.‘r°ñµ\®ÂB-jπPÀÖZ.‘r°ñµ\®ÂB-jπPÀÖZ.‘r°ñµ\®ÂB-jπPÀÖZ.‘X£˚êõ˘$µsÒú” vï1^9≈èYÍ∂1/ûˇ6/ÊA5™yPÕÉjTÛ†ö’<®ÊA5™yPÕÉjTÛ†ö’<®ÊA5™yPÕÉjTÛ†ö’<®ÊA5™yPÕÉjTÛ†ö’<®ÊA5™yPÕÉjTÛ†ö’<®ÊA5™yPÕÉjTÛ†ö’<®ÊA5™yPÕÉjTÛ†ö’<®ÊA5™yPÕÉjTÛ†ö’<®≤F!ˆ 7Û…c˝¬¯QQ|v	˛||‰bı∫)Ñó´„ØÏæ"≤’…øƒ=+t”sBöa≤~©:<ñ£˛M3.7ÓuŸ¯πÕî3£À'°9!WmI∏J}(·:u∂tÉz≤T»Ûuå8’kß<ﬂÍ¯;≈_W™Søo2OΩ‘ÿ+{ æ˘’Ëq5’ËVÀß<Ôµ¨/ô≤˜ıÒΩ?«ﬁ¨.6nΩ»/4∆¶‹ˇ¶	.'¨‡Áåå‹¨^3Â—VN¸ú±˙-?Á*ı|cØ,cL7jÓô∆òfåg„È∆¯;c¸≠1Ó6∆Ô≥¸ç1ˇŸÎ±Ò◊U˚B±X:El?˝‚«≥ˆäΩs∂àôsM“≥suÒ√π;≈üÁ¶K£s≈‚Y%ëò*>ó∏O\|¬1«ú!]n¶>ò3•[ÕY“ÌÊ$ÈãÊqßyP¨3ãıÊNqèyH¸∆6Ì6'Jüî∑õ>%œóNóΩ‚ry≥p >qïºC< Ô_ëmíO^ mëwâØ i“◊‰=‚Î≤"}_û'=/Øì~%€•?»VÈÄºLzC^$ù®8§˘ È” ZÈ"eø∏QY!›Æ¨ñÓPVIïïRÉ≤U|WŸ ÕS∑ô>ØrŒ¶.ë*Uø™3•W‘*È¡4ëbY*•Y6ätKÜ89ˆﬂÙ/©ˇ≠/±¸SˇåÂøÙèâWıY‚w˙l1®+"MW≈oı•≥N‘óÕ⁄≠ø8Á7zÔú_Î/Õyt¨oŒØÙWÊ<0∂oŒ.˝ç9ø‘áÁ¸BsŒN˝–úüÎáÁË#sVDGÁ¸LrÓ˝©π?’üû˚˝ôπ/Îùs¨˜œ˝ëæoÓı√sOâéÃ˝ã~Ç˘ ËI≥˙ıìÕÁD?GD˜Œ”
5Ì∆ƒQmlÊà¶œÏ”gô£Õ6ø§übÓ’õ≥«>m~Qwö_–Wòóè≠4?Øﬂf˛Å˛sè~á˘˚zô˘{zπ˘ª˙›ÊÔËÊoh˜öùc_3?ßˇ÷Ï’ÕóèΩiÓ÷SÂoÎß…]z∫¸Ä∂HÆ÷rÂgı|˘ÈË’rß˛†¸åÓïü÷7ÀOÈMÚìzP~BH~\oï;ÙÔ…˝rªæKﬁÆˇ^Îì” !˝c 6›™¥È… £˙Â}°Ú-›Æ<¨B˘¶ÓPæ°ü™|]OQZıO*ÈüRZÙT•Y?M˘ö~∫‘œPzöÚU˝L•IOW¸˙"e´æXŸ¢_®l÷ó+õÙl≈ß_™xı≈£_¶4Íó+n›©4Ëπ WÙ+îı+ïÙ<•^øJ©”ÛïZ˝je£~çR£_´‹Ø_ßTÎ◊+U˙Áó^†l–oP*ıBÂ>˝6Â^˝ÀJÖ^£‹£Eπ[ﬂ¶‹•áîı˙cJπV÷È€ï2Ω]πSè(wË óı«ï/ÈO(_‘üTæ†?•|^Zπ]FπMÔTn’üUJı.•Dˇ∂R¨w+∑Ëœ)E˙wîµzØ≤FIY≠˜)´Ù~e•˛CeÖ˛#Âf˝« M˙À ç˙OîB˝ß ˙•@ˇôÚ9}@π^ˇπrùæSπVˇÖrç˛KÂj}óÚ¬»ØîG˛°‰ÎS0r¢zï~äößœQØ‘Á™WËf5WóUßÆ®óÎ™zônQsÙdıR}Åö≠/TóÎvı˝Í≈∫CΩH?UΩPOQ/–?©ûØJÕ“S’L˝4ı<˝t5C?C=WOSœ—œTóÈÈÍì#ã‘•˙ıl}≠˙YΩH˝å~ã∫D/Vˇ¨ó®ØË•Í^˝V5;zõ∫Gø]uèú5ÎO˙‘€µ/™‘ÔSˇ†{‘ﬂÎ{’}˙ü’@ÙUµ)˙ıéËê˙•Ë~µ4˙Wµ$˙_Ík—ø©£‘øGﬂTˇ;zH≠åé®’—QıﬁhÇ≈5Yä£3-ˇ–-◊O∞$G?b˘xÙDã-z≈	Ùì,FO∂$èûb˘¯®ŸÚ7]µ§åZ,ßéŒ∑8F?n˘´æ–Úàf∑Ï◊?e“S-ﬂ‘N≥åËüµƒ™Á◊j¿T)}–´ﬁˇ§‚∑i_Vˇ©ü=´T;g∫⁄MWªÈj˜!´v±Û—oôñZ •eì∏UªC-÷ÓTo—Œ∂HﬂÓq—t%ú8˜•Zô˙∫~◊Ù˘ﬂtEúÆà“ä8~˛ó 1ï´?ë÷sÂ]§≠S£∆ˇ•¯£qE¸á◊'Øàß+c∫ÂM™‚›∆9‚t5úÆÜ”’√Uﬂ^	ÔQµâˇ!4”¯Ô8;§¡◊6æ˛˙	sn1Œ5Ò™aÏ/5n5U4™	bë∂A=Sª_ˇ?G>SaÈöKïı*U´Vøb<˛˝∆XˇE±™´N3DöV£ûÆ=®‚<µBoPﬂ˛7ÔçØæ◊©¢ˆ–b©ˆ–&b?⁄ã∂ €t‚NîŒºë∏êòJ‹á†÷MƒLbJB¨—0ÍDC(l™=î»m€âÛâ^∂mF>¥ÌF6∂/@ªòß˜‚<¥Ÿë-Cãê≠Ak—~ˆ]A\çV°ïh+€6∑ÒúÎâKêüm3âUHcæî∏ëXÖBÏ@nÊí8C´UúÚﬂ°Í’Òø…ÎÜ?†N˛ßæç∆=0∆zc¨3∆öÒˇ_ftƒ]9œﬂ4]î¯∏¯™ı4È	uñ‘≠û*ÌPˇ*~•û!ÌV?.˝N˝ÑÙG2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2‰"C.2ƒÖÿ/Ä‹ÃUqöÊSSµMj≤∂Y˝∏∂E–∂™6-†~4TM—á’ÑË∑‘Oimjí∂MùØµ´ü‘WS¥o´ßj˝™™˝PU¥ü®ÌßÍ'¥]™]˚ç∫PThP´å\m0∆u∆xÁÑ>&2Ö_}∑O÷M&&)˙ŸƒñË“ƒÿÁöŒëvœyV\?Úm‘çûCœ†ß—Ë)t¢t˝»„ƒÔ¢{QJE'±˝◊ƒ_¢tA®5£t˚\éú(Â°ﬂ≥˝®í˘ìƒQ¥úy
±ÄxÒL¥›≈⁄Eîƒ”ZìZ6Ò€û{?ÌÎﬂG=ËËyÙzı¢óP–¥ÔıtÒeÓsG¸hI_{€{dƒYz≥:#˙u5ˆ