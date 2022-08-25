namespace TrafoTest_App.ReceteIslemleri
{
    partial class frmReceteEkleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rECETEDETAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRowDelete = new System.Windows.Forms.Button();
            this.btnRowAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceteAciklama = new System.Windows.Forms.TextBox();
            this.txtReceteAdi = new System.Windows.Forms.TextBox();
            this.rECETEDETAYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dERECEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSITMADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vAKUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vAKUMDEGERIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAHLIYEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tAHLIYEDEGERIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOPLAMZAMANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOPLAMSUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rECETEDETAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rECETEDETAYBindingSource
            // 
            this.rECETEDETAYBindingSource.DataSource = typeof(TrafoTest_Model.Model.RECETE_DETAY);
            // 
            // btnRowDelete
            // 
            this.btnRowDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRowDelete.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRowDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRowDelete.Location = new System.Drawing.Point(169, 682);
            this.btnRowDelete.Name = "btnRowDelete";
            this.btnRowDelete.Size = new System.Drawing.Size(151, 41);
            this.btnRowDelete.TabIndex = 10;
            this.btnRowDelete.Text = "Satır Sil";
            this.btnRowDelete.UseVisualStyleBackColor = false;
            this.btnRowDelete.Click += new System.EventHandler(this.btnRowDelete_Click);
            // 
            // btnRowAdd
            // 
            this.btnRowAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRowAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRowAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRowAdd.Location = new System.Drawing.Point(12, 682);
            this.btnRowAdd.Name = "btnRowAdd";
            this.btnRowAdd.Size = new System.Drawing.Size(151, 41);
            this.btnRowAdd.TabIndex = 11;
            this.btnRowAdd.Text = "Satır Ekle";
            this.btnRowAdd.UseVisualStyleBackColor = false;
            this.btnRowAdd.Click += new System.EventHandler(this.btnRowAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rECETEDETAYIDDataGridViewTextBoxColumn,
            this.aDIMDataGridViewTextBoxColumn,
            this.sAATDataGridViewTextBoxColumn,
            this.dERECEDataGridViewTextBoxColumn,
            this.ıSITMADataGridViewCheckBoxColumn,
            this.vAKUMDataGridViewCheckBoxColumn,
            this.vAKUMDEGERIDataGridViewTextBoxColumn,
            this.tAHLIYEDataGridViewCheckBoxColumn,
            this.tAHLIYEDEGERIDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn,
            this.tOPLAMZAMANDataGridViewTextBoxColumn,
            this.tOPLAMSUREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rECETEDETAYBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 545);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(1047, 27);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(229, 41);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCik
            // 
            this.btnCik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCik.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.Location = new System.Drawing.Point(1047, 77);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(229, 41);
            this.btnCik.TabIndex = 6;
            this.btnCik.Text = "İptal";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtReceteAciklama);
            this.groupBox1.Controls.Add(this.txtReceteAdi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(473, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reçete Adı";
            // 
            // txtReceteAciklama
            // 
            this.txtReceteAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceteAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceteAciklama.Location = new System.Drawing.Point(556, 23);
            this.txtReceteAciklama.Multiline = true;
            this.txtReceteAciklama.Name = "txtReceteAciklama";
            this.txtReceteAciklama.Size = new System.Drawing.Size(454, 83);
            this.txtReceteAciklama.TabIndex = 2;
            // 
            // txtReceteAdi
            // 
            this.txtReceteAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceteAdi.Location = new System.Drawing.Point(114, 38);
            this.txtReceteAdi.Name = "txtReceteAdi";
            this.txtReceteAdi.Size = new System.Drawing.Size(333, 27);
            this.txtReceteAdi.TabIndex = 2;
            // 
            // rECETEDETAYIDDataGridViewTextBoxColumn
            // 
            this.rECETEDETAYIDDataGridViewTextBoxColumn.DataPropertyName = "RECETE_DETAY_ID";
            this.rECETEDETAYIDDataGridViewTextBoxColumn.HeaderText = "RECETE ADIM NO";
            this.rECETEDETAYIDDataGridViewTextBoxColumn.Name = "rECETEDETAYIDDataGridViewTextBoxColumn";
            this.rECETEDETAYIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECETEDETAYIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDIMDataGridViewTextBoxColumn
            // 
            this.aDIMDataGridViewTextBoxColumn.DataPropertyName = "ADIM";
            this.aDIMDataGridViewTextBoxColumn.HeaderText = "ADIM";
            this.aDIMDataGridViewTextBoxColumn.Name = "aDIMDataGridViewTextBoxColumn";
            // 
            // sAATDataGridViewTextBoxColumn
            // 
            this.sAATDataGridViewTextBoxColumn.DataPropertyName = "SAAT";
            this.sAATDataGridViewTextBoxColumn.HeaderText = "SÜRE (Saat)";
            this.sAATDataGridViewTextBoxColumn.Name = "sAATDataGridViewTextBoxColumn";
            // 
            // dERECEDataGridViewTextBoxColumn
            // 
            this.dERECEDataGridViewTextBoxColumn.DataPropertyName = "DERECE";
            this.dERECEDataGridViewTextBoxColumn.HeaderText = "SICAKLIK (°C)";
            this.dERECEDataGridViewTextBoxColumn.Name = "dERECEDataGridViewTextBoxColumn";
            // 
            // ıSITMADataGridViewCheckBoxColumn
            // 
            this.ıSITMADataGridViewCheckBoxColumn.DataPropertyName = "ISITMA";
            this.ıSITMADataGridViewCheckBoxColumn.HeaderText = "ISITMA";
            this.ıSITMADataGridViewCheckBoxColumn.Name = "ıSITMADataGridViewCheckBoxColumn";
            // 
            // vAKUMDataGridViewCheckBoxColumn
            // 
            this.vAKUMDataGridViewCheckBoxColumn.DataPropertyName = "VAKUM";
            this.vAKUMDataGridViewCheckBoxColumn.HeaderText = "VAKUM";
            this.vAKUMDataGridViewCheckBoxColumn.Name = "vAKUMDataGridViewCheckBoxColumn";
            // 
            // vAKUMDEGERIDataGridViewTextBoxColumn
            // 
            this.vAKUMDEGERIDataGridViewTextBoxColumn.DataPropertyName = "VAKUM_DEGERI";
            this.vAKUMDEGERIDataGridViewTextBoxColumn.HeaderText = "VAKUM DEGERİ";
            this.vAKUMDEGERIDataGridViewTextBoxColumn.Name = "vAKUMDEGERIDataGridViewTextBoxColumn";
            this.vAKUMDEGERIDataGridViewTextBoxColumn.Visible = false;
            // 
            // tAHLIYEDataGridViewCheckBoxColumn
            // 
            this.tAHLIYEDataGridViewCheckBoxColumn.DataPropertyName = "TAHLIYE";
            this.tAHLIYEDataGridViewCheckBoxColumn.HeaderText = "TAHLIYE";
            this.tAHLIYEDataGridViewCheckBoxColumn.Name = "tAHLIYEDataGridViewCheckBoxColumn";
            // 
            // tAHLIYEDEGERIDataGridViewTextBoxColumn
            // 
            this.tAHLIYEDEGERIDataGridViewTextBoxColumn.DataPropertyName = "TAHLIYE_DEGERI";
            this.tAHLIYEDEGERIDataGridViewTextBoxColumn.HeaderText = "TAHLIYE DEĞERI";
            this.tAHLIYEDEGERIDataGridViewTextBoxColumn.Name = "tAHLIYEDEGERIDataGridViewTextBoxColumn";
            this.tAHLIYEDEGERIDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCIKLAMADataGridViewTextBoxColumn
            // 
            this.aCIKLAMADataGridViewTextBoxColumn.DataPropertyName = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.HeaderText = "AÇIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.Name = "aCIKLAMADataGridViewTextBoxColumn";
            // 
            // tOPLAMZAMANDataGridViewTextBoxColumn
            // 
            this.tOPLAMZAMANDataGridViewTextBoxColumn.DataPropertyName = "TOPLAM_ZAMAN";
            this.tOPLAMZAMANDataGridViewTextBoxColumn.HeaderText = "TOPLAM ZAMAN";
            this.tOPLAMZAMANDataGridViewTextBoxColumn.Name = "tOPLAMZAMANDataGridViewTextBoxColumn";
            this.tOPLAMZAMANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOPLAMSUREDataGridViewTextBoxColumn
            // 
            this.tOPLAMSUREDataGridViewTextBoxColumn.DataPropertyName = "TOPLAM_SURE";
            this.tOPLAMSUREDataGridViewTextBoxColumn.HeaderText = "TOPLAM SÜRE";
            this.tOPLAMSUREDataGridViewTextBoxColumn.Name = "tOPLAMSUREDataGridViewTextBoxColumn";
            this.tOPLAMSUREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmReceteEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1288, 743);
            this.Controls.Add(this.btnRowDelete);
            this.Controls.Add(this.btnRowAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReceteEkleme";
            this.Text = "Reçete Ekleme";
            this.Load += new System.EventHandler(this.ReceteIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rECETEDETAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceteAciklama;
        private System.Windows.Forms.TextBox txtReceteAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rECETEDETAYBindingSource;
        private System.Windows.Forms.Button btnRowDelete;
        private System.Windows.Forms.Button btnRowAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECETEDETAYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dERECEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ıSITMADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vAKUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAKUMDEGERIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tAHLIYEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAHLIYEDEGERIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOPLAMZAMANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOPLAMSUREDataGridViewTextBoxColumn;
    }
}