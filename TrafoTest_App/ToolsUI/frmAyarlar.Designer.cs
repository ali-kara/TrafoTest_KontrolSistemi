namespace TrafoTest_App
{
    partial class frmAyarlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtIPAdres = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVeritabanıKayit = new System.Windows.Forms.TextBox();
            this.txtRaporEkranYenilemeSuresi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtGostergeEkraniGuncellemeSuresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDemoMod = new System.Windows.Forms.CheckBox();
            this.btnAlarmMail = new System.Windows.Forms.Button();
            this.btnHata = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC IP Adresi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.LightYellow;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(566, 356);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(152, 50);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtIPAdres
            // 
            this.txtIPAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIPAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIPAdres.Location = new System.Drawing.Point(449, 116);
            this.txtIPAdres.Mask = "###\\.###\\.#\\.##";
            this.txtIPAdres.Name = "txtIPAdres";
            this.txtIPAdres.Size = new System.Drawing.Size(269, 29);
            this.txtIPAdres.TabIndex = 5;
            this.txtIPAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIPAdres.Click += new System.EventHandler(this.txtIPAdres_Click);
            this.txtIPAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeritabanıKayit_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Veritabanı Kayıt Süresi (dk.)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rapor Ekranı Güncelleme Süresi (dk.)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVeritabanıKayit
            // 
            this.txtVeritabanıKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeritabanıKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeritabanıKayit.Location = new System.Drawing.Point(449, 154);
            this.txtVeritabanıKayit.Name = "txtVeritabanıKayit";
            this.txtVeritabanıKayit.Size = new System.Drawing.Size(269, 29);
            this.txtVeritabanıKayit.TabIndex = 6;
            this.txtVeritabanıKayit.Click += new System.EventHandler(this.txtIPAdres_Click);
            this.txtVeritabanıKayit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeritabanıKayit_KeyPress);
            // 
            // txtRaporEkranYenilemeSuresi
            // 
            this.txtRaporEkranYenilemeSuresi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporEkranYenilemeSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRaporEkranYenilemeSuresi.Location = new System.Drawing.Point(449, 190);
            this.txtRaporEkranYenilemeSuresi.Name = "txtRaporEkranYenilemeSuresi";
            this.txtRaporEkranYenilemeSuresi.Size = new System.Drawing.Size(269, 29);
            this.txtRaporEkranYenilemeSuresi.TabIndex = 7;
            this.txtRaporEkranYenilemeSuresi.Click += new System.EventHandler(this.txtIPAdres_Click);
            this.txtRaporEkranYenilemeSuresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeritabanıKayit_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 56);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(730, 56);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ayarlar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(56, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIptal.BackColor = System.Drawing.Color.LightYellow;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(16, 356);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(137, 50);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtGostergeEkraniGuncellemeSuresi
            // 
            this.txtGostergeEkraniGuncellemeSuresi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGostergeEkraniGuncellemeSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGostergeEkraniGuncellemeSuresi.Location = new System.Drawing.Point(449, 225);
            this.txtGostergeEkraniGuncellemeSuresi.Name = "txtGostergeEkraniGuncellemeSuresi";
            this.txtGostergeEkraniGuncellemeSuresi.Size = new System.Drawing.Size(269, 29);
            this.txtGostergeEkraniGuncellemeSuresi.TabIndex = 11;
            this.txtGostergeEkraniGuncellemeSuresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeritabanıKayit_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tank Gösterge Ekranı  Güncelleme Süresi (sn.)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(449, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 29);
            this.textBox2.TabIndex = 13;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeritabanıKayit_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Boş";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(449, 295);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(269, 29);
            this.textBox4.TabIndex = 15;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeritabanıKayit_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Boş";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Demo Mod";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkDemoMod
            // 
            this.chkDemoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDemoMod.Location = new System.Drawing.Point(449, 76);
            this.chkDemoMod.Name = "chkDemoMod";
            this.chkDemoMod.Size = new System.Drawing.Size(269, 29);
            this.chkDemoMod.TabIndex = 17;
            this.chkDemoMod.UseVisualStyleBackColor = true;
            // 
            // btnAlarmMail
            // 
            this.btnAlarmMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlarmMail.BackColor = System.Drawing.Color.LightYellow;
            this.btnAlarmMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmMail.Location = new System.Drawing.Point(159, 356);
            this.btnAlarmMail.Name = "btnAlarmMail";
            this.btnAlarmMail.Size = new System.Drawing.Size(210, 50);
            this.btnAlarmMail.TabIndex = 18;
            this.btnAlarmMail.Text = "Alarm Mail Listesi";
            this.btnAlarmMail.UseVisualStyleBackColor = false;
            this.btnAlarmMail.Click += new System.EventHandler(this.btnAlarmMail_Click);
            // 
            // btnHata
            // 
            this.btnHata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHata.BackColor = System.Drawing.Color.LightYellow;
            this.btnHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHata.Location = new System.Drawing.Point(375, 356);
            this.btnHata.Name = "btnHata";
            this.btnHata.Size = new System.Drawing.Size(185, 50);
            this.btnHata.TabIndex = 18;
            this.btnHata.Text = "Hata Listesi";
            this.btnHata.UseVisualStyleBackColor = false;
            this.btnHata.Click += new System.EventHandler(this.btnHata_Click);
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(730, 429);
            this.Controls.Add(this.btnHata);
            this.Controls.Add(this.btnAlarmMail);
            this.Controls.Add(this.chkDemoMod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGostergeEkraniGuncellemeSuresi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRaporEkranYenilemeSuresi);
            this.Controls.Add(this.txtVeritabanıKayit);
            this.Controls.Add(this.txtIPAdres);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAyarlar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtIPAdres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRaporEkranYenilemeSuresi;
        private System.Windows.Forms.TextBox txtVeritabanıKayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGostergeEkraniGuncellemeSuresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDemoMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlarmMail;
        private System.Windows.Forms.Button btnHata;
    }
}