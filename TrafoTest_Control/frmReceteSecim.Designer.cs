namespace TrafoTest_Control
{
    partial class frmReceteSecim
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cmbRecete = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIslemAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrafoNo_1 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_3 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_4 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_2 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_6 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_8 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_7 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTrafoNo_10 = new System.Windows.Forms.TextBox();
            this.txtTrafoNo_9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(427, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "İşleme Başlamak İçin Listeden Reçete Seçiniz.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.SpringGreen;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(431, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 43);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Vazgeç";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelect.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelect.Location = new System.Drawing.Point(253, 322);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(172, 43);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "Tamam";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cmbRecete
            // 
            this.cmbRecete.BackColor = System.Drawing.Color.White;
            this.cmbRecete.DisplayMember = "RECETE_ADI";
            this.cmbRecete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRecete.FormattingEnabled = true;
            this.cmbRecete.Location = new System.Drawing.Point(431, 58);
            this.cmbRecete.Name = "cmbRecete";
            this.cmbRecete.Size = new System.Drawing.Size(355, 28);
            this.cmbRecete.TabIndex = 15;
            this.cmbRecete.ValueMember = "RECETE_ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "İşlem Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIslemAdi
            // 
            this.txtIslemAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemAdi.Location = new System.Drawing.Point(33, 59);
            this.txtIslemAdi.Name = "txtIslemAdi";
            this.txtIslemAdi.Size = new System.Drawing.Size(361, 27);
            this.txtIslemAdi.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Trafo No - 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trafo No - 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trafo No - 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trafo No - 4";
            // 
            // txtTrafoNo_1
            // 
            this.txtTrafoNo_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_1.Location = new System.Drawing.Point(143, 108);
            this.txtTrafoNo_1.Name = "txtTrafoNo_1";
            this.txtTrafoNo_1.Size = new System.Drawing.Size(251, 27);
            this.txtTrafoNo_1.TabIndex = 22;
            // 
            // txtTrafoNo_3
            // 
            this.txtTrafoNo_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_3.Location = new System.Drawing.Point(143, 192);
            this.txtTrafoNo_3.Name = "txtTrafoNo_3";
            this.txtTrafoNo_3.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_3.TabIndex = 22;
            // 
            // txtTrafoNo_4
            // 
            this.txtTrafoNo_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_4.Location = new System.Drawing.Point(143, 235);
            this.txtTrafoNo_4.Name = "txtTrafoNo_4";
            this.txtTrafoNo_4.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_4.TabIndex = 22;
            // 
            // txtTrafoNo_2
            // 
            this.txtTrafoNo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_2.Location = new System.Drawing.Point(143, 151);
            this.txtTrafoNo_2.Name = "txtTrafoNo_2";
            this.txtTrafoNo_2.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_2.TabIndex = 22;
            // 
            // txtTrafoNo_6
            // 
            this.txtTrafoNo_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_6.Location = new System.Drawing.Point(541, 115);
            this.txtTrafoNo_6.Name = "txtTrafoNo_6";
            this.txtTrafoNo_6.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_6.TabIndex = 27;
            // 
            // txtTrafoNo_8
            // 
            this.txtTrafoNo_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_8.Location = new System.Drawing.Point(540, 199);
            this.txtTrafoNo_8.Name = "txtTrafoNo_8";
            this.txtTrafoNo_8.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_8.TabIndex = 28;
            // 
            // txtTrafoNo_7
            // 
            this.txtTrafoNo_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_7.Location = new System.Drawing.Point(541, 156);
            this.txtTrafoNo_7.Name = "txtTrafoNo_7";
            this.txtTrafoNo_7.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_7.TabIndex = 29;
            // 
            // txtTrafoNo_5
            // 
            this.txtTrafoNo_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_5.Location = new System.Drawing.Point(142, 274);
            this.txtTrafoNo_5.Name = "txtTrafoNo_5";
            this.txtTrafoNo_5.Size = new System.Drawing.Size(251, 27);
            this.txtTrafoNo_5.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(427, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Trafo No - 8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(427, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Trafo No - 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(427, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Trafo No - 6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(29, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Trafo No - 5";
            // 
            // txtTrafoNo_10
            // 
            this.txtTrafoNo_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_10.Location = new System.Drawing.Point(540, 283);
            this.txtTrafoNo_10.Name = "txtTrafoNo_10";
            this.txtTrafoNo_10.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_10.TabIndex = 33;
            // 
            // txtTrafoNo_9
            // 
            this.txtTrafoNo_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrafoNo_9.Location = new System.Drawing.Point(540, 240);
            this.txtTrafoNo_9.Name = "txtTrafoNo_9";
            this.txtTrafoNo_9.Size = new System.Drawing.Size(250, 27);
            this.txtTrafoNo_9.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(427, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Trafo No - 10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(427, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Trafo No - 9";
            // 
            // frmReceteSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(885, 389);
            this.Controls.Add(this.txtTrafoNo_10);
            this.Controls.Add(this.txtTrafoNo_9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTrafoNo_6);
            this.Controls.Add(this.txtTrafoNo_8);
            this.Controls.Add(this.txtTrafoNo_7);
            this.Controls.Add(this.txtTrafoNo_5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTrafoNo_2);
            this.Controls.Add(this.txtTrafoNo_4);
            this.Controls.Add(this.txtTrafoNo_3);
            this.Controls.Add(this.txtTrafoNo_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIslemAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbRecete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceteSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete Seçiniz.";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmReceteSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cmbRecete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIslemAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrafoNo_1;
        private System.Windows.Forms.TextBox txtTrafoNo_3;
        private System.Windows.Forms.TextBox txtTrafoNo_4;
        private System.Windows.Forms.TextBox txtTrafoNo_2;
        private System.Windows.Forms.TextBox txtTrafoNo_6;
        private System.Windows.Forms.TextBox txtTrafoNo_8;
        private System.Windows.Forms.TextBox txtTrafoNo_7;
        private System.Windows.Forms.TextBox txtTrafoNo_5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTrafoNo_10;
        private System.Windows.Forms.TextBox txtTrafoNo_9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}