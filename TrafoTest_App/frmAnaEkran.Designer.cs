namespace TrafoTest_App
{
    partial class frmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            this.tmrConnectionState = new System.Windows.Forms.Timer(this.components);
            this.tmrPLC = new System.Windows.Forms.Timer(this.components);
            this.tmrAlarm = new System.Windows.Forms.Timer(this.components);
            this.tmrArizaKontrol = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSistemDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPLCBaglantiDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripAlarm = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tamEkran = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGiris = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tankGosterge1 = new TrafoTest_Control.TankGosterge();
            this.tankGosterge2 = new TrafoTest_Control.TankGosterge();
            this.tankGosterge3 = new TrafoTest_Control.TankGosterge();
            this.tankGosterge4 = new TrafoTest_Control.TankGosterge();
            this.tabTank_1 = new System.Windows.Forms.TabPage();
            this.tankGoruntuleme1 = new TrafoTest_Control.TankGoruntuleme();
            this.tabTank_2 = new System.Windows.Forms.TabPage();
            this.tankGoruntuleme2 = new TrafoTest_Control.TankGoruntuleme();
            this.tabTank_3 = new System.Windows.Forms.TabPage();
            this.tankGoruntuleme3 = new TrafoTest_Control.TankGoruntuleme();
            this.tabTank_4 = new System.Windows.Forms.TabPage();
            this.tankGoruntuleme4 = new TrafoTest_Control.TankGoruntuleme();
            this.tabAraclar = new System.Windows.Forms.TabPage();
            this.btnDbBackup = new System.Windows.Forms.Button();
            this.btnManuel = new System.Windows.Forms.Button();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.btnVersiyonlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnAlarmlar = new System.Windows.Forms.Button();
            this.btnRecete = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGiris.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabTank_1.SuspendLayout();
            this.tabTank_2.SuspendLayout();
            this.tabTank_3.SuspendLayout();
            this.tabTank_4.SuspendLayout();
            this.tabAraclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrConnectionState
            // 
            this.tmrConnectionState.Enabled = true;
            this.tmrConnectionState.Interval = 1000;
            this.tmrConnectionState.Tick += new System.EventHandler(this.tmrConnectionState_Tick);
            // 
            // tmrPLC
            // 
            this.tmrPLC.Enabled = true;
            this.tmrPLC.Interval = 1000;
            this.tmrPLC.Tick += new System.EventHandler(this.tmrPLC_Tick);
            // 
            // tmrAlarm
            // 
            this.tmrAlarm.Interval = 2000;
            this.tmrAlarm.Tick += new System.EventHandler(this.tmrAlarm_Tick);
            // 
            // tmrArizaKontrol
            // 
            this.tmrArizaKontrol.Enabled = true;
            this.tmrArizaKontrol.Interval = 1000;
            this.tmrArizaKontrol.Tick += new System.EventHandler(this.tmrArizaKontrol_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSistemDurumu,
            this.lblPLCBaglantiDurumu,
            this.stripAlarm,
            this.lblDurum,
            this.tamEkran});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1045);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 35);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSistemDurumu
            // 
            this.lblSistemDurumu.BackColor = System.Drawing.Color.Red;
            this.lblSistemDurumu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemDurumu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSistemDurumu.Margin = new System.Windows.Forms.Padding(6, 4, 0, 2);
            this.lblSistemDurumu.Name = "lblSistemDurumu";
            this.lblSistemDurumu.Size = new System.Drawing.Size(175, 29);
            this.lblSistemDurumu.Text = "   Sistem Durumu   ";
            // 
            // lblPLCBaglantiDurumu
            // 
            this.lblPLCBaglantiDurumu.BackColor = System.Drawing.Color.Red;
            this.lblPLCBaglantiDurumu.DoubleClickEnabled = true;
            this.lblPLCBaglantiDurumu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPLCBaglantiDurumu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPLCBaglantiDurumu.Margin = new System.Windows.Forms.Padding(16, 4, 0, 2);
            this.lblPLCBaglantiDurumu.Name = "lblPLCBaglantiDurumu";
            this.lblPLCBaglantiDurumu.Size = new System.Drawing.Size(131, 29);
            this.lblPLCBaglantiDurumu.Text = "PLC Bağlantısı";
            this.lblPLCBaglantiDurumu.DoubleClick += new System.EventHandler(this.lblPLCBaglantiDurumu_DoubleClick);
            // 
            // stripAlarm
            // 
            this.stripAlarm.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.stripAlarm.BackColor = System.Drawing.SystemColors.Highlight;
            this.stripAlarm.DoubleClickEnabled = true;
            this.stripAlarm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stripAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stripAlarm.Margin = new System.Windows.Forms.Padding(16, 4, 0, 2);
            this.stripAlarm.Name = "stripAlarm";
            this.stripAlarm.Size = new System.Drawing.Size(124, 29);
            this.stripAlarm.Text = "     Alamlar    ";
            this.stripAlarm.Click += new System.EventHandler(this.stripAlarm_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.Red;
            this.lblDurum.DoubleClickEnabled = true;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDurum.Margin = new System.Windows.Forms.Padding(16, 4, 0, 2);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(111, 29);
            this.lblDurum.Text = "Man / Auto";
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click);
            // 
            // tamEkran
            // 
            this.tamEkran.AutoSize = false;
            this.tamEkran.BackColor = System.Drawing.Color.Cyan;
            this.tamEkran.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tamEkran.Margin = new System.Windows.Forms.Padding(16, 4, 0, 2);
            this.tamEkran.Name = "tamEkran";
            this.tamEkran.Size = new System.Drawing.Size(1294, 29);
            this.tamEkran.Spring = true;
            this.tamEkran.Text = "Simge Durumuna Küçült";
            this.tamEkran.Click += new System.EventHandler(this.tamEkran_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGiris);
            this.tabControl1.Controls.Add(this.tabTank_1);
            this.tabControl1.Controls.Add(this.tabTank_2);
            this.tabControl1.Controls.Add(this.tabTank_3);
            this.tabControl1.Controls.Add(this.tabTank_4);
            this.tabControl1.Controls.Add(this.tabAraclar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1920, 1080);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabGiris
            // 
            this.tabGiris.BackColor = System.Drawing.Color.LightBlue;
            this.tabGiris.Controls.Add(this.tableLayoutPanel1);
            this.tabGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabGiris.Location = new System.Drawing.Point(4, 43);
            this.tabGiris.Name = "tabGiris";
            this.tabGiris.Size = new System.Drawing.Size(1912, 1033);
            this.tabGiris.TabIndex = 5;
            this.tabGiris.Text = "Giriş";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tankGosterge1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tankGosterge2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tankGosterge3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tankGosterge4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1912, 1033);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tankGosterge1
            // 
            this.tankGosterge1.BackColor = System.Drawing.Color.Transparent;
            this.tankGosterge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGosterge1.IslemBaslik = null;
            this.tankGosterge1.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGosterge1.Location = new System.Drawing.Point(3, 3);
            this.tankGosterge1.Name = "tankGosterge1";
            this.tankGosterge1.random = ((System.Random)(resources.GetObject("tankGosterge1.random")));
            this.tankGosterge1.SecilenRecete = null;
            this.tankGosterge1.Size = new System.Drawing.Size(950, 510);
            this.tankGosterge1.TabIndex = 2;
            this.tankGosterge1.tankGoruntuleme = null;
            this.tankGosterge1.TankId = 1;
            // 
            // tankGosterge2
            // 
            this.tankGosterge2.BackColor = System.Drawing.Color.Transparent;
            this.tankGosterge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGosterge2.IslemBaslik = null;
            this.tankGosterge2.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGosterge2.Location = new System.Drawing.Point(959, 3);
            this.tankGosterge2.Name = "tankGosterge2";
            this.tankGosterge2.random = ((System.Random)(resources.GetObject("tankGosterge2.random")));
            this.tankGosterge2.SecilenRecete = null;
            this.tankGosterge2.Size = new System.Drawing.Size(950, 510);
            this.tankGosterge2.TabIndex = 1;
            this.tankGosterge2.tankGoruntuleme = null;
            this.tankGosterge2.TankId = 2;
            // 
            // tankGosterge3
            // 
            this.tankGosterge3.BackColor = System.Drawing.Color.Transparent;
            this.tankGosterge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGosterge3.IslemBaslik = null;
            this.tankGosterge3.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGosterge3.Location = new System.Drawing.Point(3, 519);
            this.tankGosterge3.Name = "tankGosterge3";
            this.tankGosterge3.random = ((System.Random)(resources.GetObject("tankGosterge3.random")));
            this.tankGosterge3.SecilenRecete = null;
            this.tankGosterge3.Size = new System.Drawing.Size(950, 511);
            this.tankGosterge3.TabIndex = 4;
            this.tankGosterge3.tankGoruntuleme = null;
            this.tankGosterge3.TankId = 3;
            // 
            // tankGosterge4
            // 
            this.tankGosterge4.BackColor = System.Drawing.Color.Transparent;
            this.tankGosterge4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGosterge4.IslemBaslik = null;
            this.tankGosterge4.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGosterge4.Location = new System.Drawing.Point(959, 519);
            this.tankGosterge4.Name = "tankGosterge4";
            this.tankGosterge4.random = ((System.Random)(resources.GetObject("tankGosterge4.random")));
            this.tankGosterge4.SecilenRecete = null;
            this.tankGosterge4.Size = new System.Drawing.Size(950, 511);
            this.tankGosterge4.TabIndex = 3;
            this.tankGosterge4.tankGoruntuleme = null;
            this.tankGosterge4.TankId = 4;
            // 
            // tabTank_1
            // 
            this.tabTank_1.Controls.Add(this.tankGoruntuleme1);
            this.tabTank_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabTank_1.Location = new System.Drawing.Point(4, 43);
            this.tabTank_1.Name = "tabTank_1";
            this.tabTank_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTank_1.Size = new System.Drawing.Size(1912, 1033);
            this.tabTank_1.TabIndex = 0;
            this.tabTank_1.Text = "Tank 1";
            this.tabTank_1.UseVisualStyleBackColor = true;
            // 
            // tankGoruntuleme1
            // 
            this.tankGoruntuleme1.BackColor = System.Drawing.Color.LightBlue;
            this.tankGoruntuleme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGoruntuleme1.IslemBaslik = null;
            this.tankGoruntuleme1.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGoruntuleme1.Location = new System.Drawing.Point(3, 3);
            this.tankGoruntuleme1.Margin = new System.Windows.Forms.Padding(0);
            this.tankGoruntuleme1.Name = "tankGoruntuleme1";
            this.tankGoruntuleme1.SecilenRecete = null;
            this.tankGoruntuleme1.Size = new System.Drawing.Size(1906, 1027);
            this.tankGoruntuleme1.TabIndex = 0;
            this.tankGoruntuleme1.tankGosterge = null;
            this.tankGoruntuleme1.TankId = 1;
            // 
            // tabTank_2
            // 
            this.tabTank_2.Controls.Add(this.tankGoruntuleme2);
            this.tabTank_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabTank_2.Location = new System.Drawing.Point(4, 43);
            this.tabTank_2.Name = "tabTank_2";
            this.tabTank_2.Padding = new System.Windows.Forms.Padding(3);
            this.tabTank_2.Size = new System.Drawing.Size(1912, 1033);
            this.tabTank_2.TabIndex = 1;
            this.tabTank_2.Text = "Tank 2";
            this.tabTank_2.UseVisualStyleBackColor = true;
            // 
            // tankGoruntuleme2
            // 
            this.tankGoruntuleme2.AutoSize = true;
            this.tankGoruntuleme2.BackColor = System.Drawing.Color.LightBlue;
            this.tankGoruntuleme2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGoruntuleme2.IslemBaslik = null;
            this.tankGoruntuleme2.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGoruntuleme2.Location = new System.Drawing.Point(3, 3);
            this.tankGoruntuleme2.Margin = new System.Windows.Forms.Padding(6);
            this.tankGoruntuleme2.Name = "tankGoruntuleme2";
            this.tankGoruntuleme2.SecilenRecete = null;
            this.tankGoruntuleme2.Size = new System.Drawing.Size(1906, 1027);
            this.tankGoruntuleme2.TabIndex = 0;
            this.tankGoruntuleme2.tankGosterge = null;
            this.tankGoruntuleme2.TankId = 2;
            // 
            // tabTank_3
            // 
            this.tabTank_3.Controls.Add(this.tankGoruntuleme3);
            this.tabTank_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabTank_3.Location = new System.Drawing.Point(4, 43);
            this.tabTank_3.Name = "tabTank_3";
            this.tabTank_3.Padding = new System.Windows.Forms.Padding(3);
            this.tabTank_3.Size = new System.Drawing.Size(1912, 1033);
            this.tabTank_3.TabIndex = 2;
            this.tabTank_3.Text = "Tank 3";
            this.tabTank_3.UseVisualStyleBackColor = true;
            // 
            // tankGoruntuleme3
            // 
            this.tankGoruntuleme3.AutoSize = true;
            this.tankGoruntuleme3.BackColor = System.Drawing.Color.LightBlue;
            this.tankGoruntuleme3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGoruntuleme3.IslemBaslik = null;
            this.tankGoruntuleme3.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGoruntuleme3.Location = new System.Drawing.Point(3, 3);
            this.tankGoruntuleme3.Margin = new System.Windows.Forms.Padding(6);
            this.tankGoruntuleme3.Name = "tankGoruntuleme3";
            this.tankGoruntuleme3.SecilenRecete = null;
            this.tankGoruntuleme3.Size = new System.Drawing.Size(1906, 1027);
            this.tankGoruntuleme3.TabIndex = 0;
            this.tankGoruntuleme3.tankGosterge = null;
            this.tankGoruntuleme3.TankId = 3;
            // 
            // tabTank_4
            // 
            this.tabTank_4.Controls.Add(this.tankGoruntuleme4);
            this.tabTank_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabTank_4.Location = new System.Drawing.Point(4, 43);
            this.tabTank_4.Name = "tabTank_4";
            this.tabTank_4.Padding = new System.Windows.Forms.Padding(3);
            this.tabTank_4.Size = new System.Drawing.Size(1912, 1033);
            this.tabTank_4.TabIndex = 3;
            this.tabTank_4.Text = "Tank 4";
            this.tabTank_4.UseVisualStyleBackColor = true;
            // 
            // tankGoruntuleme4
            // 
            this.tankGoruntuleme4.AutoSize = true;
            this.tankGoruntuleme4.BackColor = System.Drawing.Color.LightBlue;
            this.tankGoruntuleme4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankGoruntuleme4.IslemBaslik = null;
            this.tankGoruntuleme4.IslemDurumu = TrafoTest_Control.enmIslemDurumu.ISLEM_YOK;
            this.tankGoruntuleme4.Location = new System.Drawing.Point(3, 3);
            this.tankGoruntuleme4.Margin = new System.Windows.Forms.Padding(6);
            this.tankGoruntuleme4.Name = "tankGoruntuleme4";
            this.tankGoruntuleme4.SecilenRecete = null;
            this.tankGoruntuleme4.Size = new System.Drawing.Size(1906, 1027);
            this.tankGoruntuleme4.TabIndex = 0;
            this.tankGoruntuleme4.tankGosterge = null;
            this.tankGoruntuleme4.TankId = 4;
            // 
            // tabAraclar
            // 
            this.tabAraclar.BackColor = System.Drawing.Color.LightBlue;
            this.tabAraclar.Controls.Add(this.btnDbBackup);
            this.tabAraclar.Controls.Add(this.btnManuel);
            this.tabAraclar.Controls.Add(this.btnHakkinda);
            this.tabAraclar.Controls.Add(this.btnVersiyonlar);
            this.tabAraclar.Controls.Add(this.btnCikis);
            this.tabAraclar.Controls.Add(this.btnAyarlar);
            this.tabAraclar.Controls.Add(this.btnAlarmlar);
            this.tabAraclar.Controls.Add(this.btnRecete);
            this.tabAraclar.Controls.Add(this.btnRaporlar);
            this.tabAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabAraclar.Location = new System.Drawing.Point(4, 43);
            this.tabAraclar.Name = "tabAraclar";
            this.tabAraclar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAraclar.Size = new System.Drawing.Size(1912, 1033);
            this.tabAraclar.TabIndex = 4;
            this.tabAraclar.Text = "Araçlar";
            // 
            // btnDbBackup
            // 
            this.btnDbBackup.BackColor = System.Drawing.Color.Ivory;
            this.btnDbBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDbBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnDbBackup.Image")));
            this.btnDbBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbBackup.Location = new System.Drawing.Point(271, 247);
            this.btnDbBackup.Name = "btnDbBackup";
            this.btnDbBackup.Size = new System.Drawing.Size(221, 84);
            this.btnDbBackup.TabIndex = 5;
            this.btnDbBackup.Text = "Veritabanı Yedekle";
            this.btnDbBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDbBackup.UseVisualStyleBackColor = false;
            this.btnDbBackup.Click += new System.EventHandler(this.btnDbBackup_Click);
            // 
            // btnManuel
            // 
            this.btnManuel.BackColor = System.Drawing.Color.Ivory;
            this.btnManuel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManuel.Image = global::TrafoTest_App.Properties.Resources.Manuel;
            this.btnManuel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManuel.Location = new System.Drawing.Point(29, 247);
            this.btnManuel.Name = "btnManuel";
            this.btnManuel.Size = new System.Drawing.Size(221, 84);
            this.btnManuel.TabIndex = 5;
            this.btnManuel.Text = "Manuel Kontroller";
            this.btnManuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManuel.UseVisualStyleBackColor = false;
            this.btnManuel.Click += new System.EventHandler(this.btnManuel_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHakkinda.BackColor = System.Drawing.Color.Ivory;
            this.btnHakkinda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHakkinda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkinda.Image = global::TrafoTest_App.Properties.Resources.hakkinda;
            this.btnHakkinda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHakkinda.Location = new System.Drawing.Point(1372, 136);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(221, 84);
            this.btnHakkinda.TabIndex = 4;
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHakkinda.UseVisualStyleBackColor = false;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // btnVersiyonlar
            // 
            this.btnVersiyonlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVersiyonlar.BackColor = System.Drawing.Color.Ivory;
            this.btnVersiyonlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVersiyonlar.Image = global::TrafoTest_App.Properties.Resources.versions;
            this.btnVersiyonlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersiyonlar.Location = new System.Drawing.Point(1372, 29);
            this.btnVersiyonlar.Name = "btnVersiyonlar";
            this.btnVersiyonlar.Size = new System.Drawing.Size(221, 84);
            this.btnVersiyonlar.TabIndex = 3;
            this.btnVersiyonlar.Text = "Versiyonlar";
            this.btnVersiyonlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVersiyonlar.UseVisualStyleBackColor = false;
            this.btnVersiyonlar.Click += new System.EventHandler(this.btnVersiyonlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Ivory;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Image = global::TrafoTest_App.Properties.Resources.Cikis;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(1614, 29);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(221, 84);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Ivory;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.Image = global::TrafoTest_App.Properties.Resources.Ayarlar;
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(271, 136);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(221, 84);
            this.btnAyarlar.TabIndex = 1;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnAlarmlar
            // 
            this.btnAlarmlar.BackColor = System.Drawing.Color.Ivory;
            this.btnAlarmlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmlar.Image = global::TrafoTest_App.Properties.Resources.Alarm;
            this.btnAlarmlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarmlar.Location = new System.Drawing.Point(29, 136);
            this.btnAlarmlar.Name = "btnAlarmlar";
            this.btnAlarmlar.Size = new System.Drawing.Size(221, 84);
            this.btnAlarmlar.TabIndex = 0;
            this.btnAlarmlar.Text = "Alarmlar";
            this.btnAlarmlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarmlar.UseVisualStyleBackColor = false;
            this.btnAlarmlar.Click += new System.EventHandler(this.btnAlarmlar_Click);
            // 
            // btnRecete
            // 
            this.btnRecete.BackColor = System.Drawing.Color.Ivory;
            this.btnRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecete.Image = global::TrafoTest_App.Properties.Resources.Recete;
            this.btnRecete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecete.Location = new System.Drawing.Point(271, 29);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(221, 84);
            this.btnRecete.TabIndex = 0;
            this.btnRecete.Text = "Reçete İşlemleri";
            this.btnRecete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecete.UseVisualStyleBackColor = false;
            this.btnRecete.Click += new System.EventHandler(this.btnRecete_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.Ivory;
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.Image = global::TrafoTest_App.Properties.Resources.Report;
            this.btnRaporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaporlar.Location = new System.Drawing.Point(29, 29);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(221, 84);
            this.btnRaporlar.TabIndex = 0;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaEkran";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceteIslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaEkran_FormClosing);
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAnaEkran_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAnaEkran_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAnaEkran_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAnaEkran_MouseUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGiris.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabTank_1.ResumeLayout(false);
            this.tabTank_2.ResumeLayout(false);
            this.tabTank_2.PerformLayout();
            this.tabTank_3.ResumeLayout(false);
            this.tabTank_3.PerformLayout();
            this.tabTank_4.ResumeLayout(false);
            this.tabTank_4.PerformLayout();
            this.tabAraclar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmAnaEkran_Resize(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabPage tabTank_4;
        private System.Windows.Forms.TabPage tabTank_3;
        private System.Windows.Forms.TabPage tabTank_2;
        private System.Windows.Forms.TabPage tabTank_1;
        private System.Windows.Forms.TabControl tabControl1;
        private TrafoTest_Control.TankGoruntuleme tankGoruntuleme4;
        private TrafoTest_Control.TankGoruntuleme tankGoruntuleme3;
        private TrafoTest_Control.TankGoruntuleme tankGoruntuleme2;
        private TrafoTest_Control.TankGoruntuleme tankGoruntuleme1;
        private System.Windows.Forms.TabPage tabGiris;
        private System.Windows.Forms.TabPage tabAraclar;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Button btnVersiyonlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSistemDurumu;
        private System.Windows.Forms.ToolStripStatusLabel lblPLCBaglantiDurumu;
        private System.Windows.Forms.Button btnAlarmlar;
        private System.Windows.Forms.ToolStripStatusLabel tamEkran;
        private System.Windows.Forms.Timer tmrConnectionState;
        private System.Windows.Forms.Timer tmrPLC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TrafoTest_Control.TankGosterge tankGosterge1;
        private TrafoTest_Control.TankGosterge tankGosterge4;
        private TrafoTest_Control.TankGosterge tankGosterge3;
        private TrafoTest_Control.TankGosterge tankGosterge2;
        private System.Windows.Forms.ToolStripStatusLabel stripAlarm;
        private System.Windows.Forms.Timer tmrAlarm;
        private System.Windows.Forms.Timer tmrArizaKontrol;
        private System.Windows.Forms.ToolStripStatusLabel lblDurum;
        private System.Windows.Forms.Button btnManuel;
        private System.Windows.Forms.Button btnDbBackup;
    }
}