namespace TrafoTest_App.ReceteIslemleri
{
    partial class frmReceteIslemleri
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
            this.lstReceteler = new System.Windows.Forms.ListBox();
            this.rECETELERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblGuncellemeTarihi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEklemeTarihi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReceteId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceteAciklama = new System.Windows.Forms.TextBox();
            this.txtReceteAdi = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rECETELERBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReceteler
            // 
            this.lstReceteler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstReceteler.DataSource = this.rECETELERBindingSource;
            this.lstReceteler.DisplayMember = "RECETE_ADI";
            this.lstReceteler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstReceteler.FormattingEnabled = true;
            this.lstReceteler.ItemHeight = 24;
            this.lstReceteler.Location = new System.Drawing.Point(13, 72);
            this.lstReceteler.Name = "lstReceteler";
            this.lstReceteler.Size = new System.Drawing.Size(290, 364);
            this.lstReceteler.Sorted = true;
            this.lstReceteler.TabIndex = 0;
            this.lstReceteler.ValueMember = "RECETE_ID";
            this.lstReceteler.SelectedIndexChanged += new System.EventHandler(this.lstReceteler_SelectedIndexChanged);
            // 
            // rECETELERBindingSource
            // 
            this.rECETELERBindingSource.DataSource = typeof(TrafoTest_Model.Model.RECETELER);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reçeteler";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.lblGuncellemeTarihi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblEklemeTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblReceteId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtReceteAciklama);
            this.groupBox1.Controls.Add(this.txtReceteAdi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(309, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 361);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete Bilgileri";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(27, 307);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(229, 41);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblGuncellemeTarihi
            // 
            this.lblGuncellemeTarihi.AutoSize = true;
            this.lblGuncellemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblGuncellemeTarihi.Location = new System.Drawing.Point(173, 270);
            this.lblGuncellemeTarihi.Name = "lblGuncellemeTarihi";
            this.lblGuncellemeTarihi.Size = new System.Drawing.Size(0, 20);
            this.lblGuncellemeTarihi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label7.Location = new System.Drawing.Point(23, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Güncelleme Tarihi";
            // 
            // lblEklemeTarihi
            // 
            this.lblEklemeTarihi.AutoSize = true;
            this.lblEklemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblEklemeTarihi.Location = new System.Drawing.Point(173, 237);
            this.lblEklemeTarihi.Name = "lblEklemeTarihi";
            this.lblEklemeTarihi.Size = new System.Drawing.Size(0, 20);
            this.lblEklemeTarihi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.Location = new System.Drawing.Point(56, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ekleme Tarihi";
            // 
            // lblReceteId
            // 
            this.lblReceteId.AutoSize = true;
            this.lblReceteId.Location = new System.Drawing.Point(174, 34);
            this.lblReceteId.Name = "lblReceteId";
            this.lblReceteId.Size = new System.Drawing.Size(0, 18);
            this.lblReceteId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.Location = new System.Drawing.Point(79, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reçete No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reçete Adı";
            // 
            // txtReceteAciklama
            // 
            this.txtReceteAciklama.Enabled = false;
            this.txtReceteAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceteAciklama.Location = new System.Drawing.Point(177, 120);
            this.txtReceteAciklama.Multiline = true;
            this.txtReceteAciklama.Name = "txtReceteAciklama";
            this.txtReceteAciklama.ReadOnly = true;
            this.txtReceteAciklama.Size = new System.Drawing.Size(452, 105);
            this.txtReceteAciklama.TabIndex = 2;
            // 
            // txtReceteAdi
            // 
            this.txtReceteAdi.Enabled = false;
            this.txtReceteAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceteAdi.Location = new System.Drawing.Point(177, 70);
            this.txtReceteAdi.Name = "txtReceteAdi";
            this.txtReceteAdi.ReadOnly = true;
            this.txtReceteAdi.Size = new System.Drawing.Size(452, 27);
            this.txtReceteAdi.TabIndex = 2;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.SpringGreen;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(309, 12);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(229, 41);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(262, 307);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 41);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmReceteIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(974, 451);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReceteler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmReceteIslemleri";
            this.Text = "Reçete İşlemleri";
            this.Load += new System.EventHandler(this.frmReceteIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rECETELERBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReceteler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource rECETELERBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceteAciklama;
        private System.Windows.Forms.TextBox txtReceteAdi;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblReceteId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGuncellemeTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEklemeTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}