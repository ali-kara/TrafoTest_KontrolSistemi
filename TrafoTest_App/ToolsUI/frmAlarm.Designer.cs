namespace TrafoTest_App.ToolsUI
{
    partial class frmAlarm
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.dgAnlikAlarm = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLARMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.btnSecilenleriSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTank = new System.Windows.Forms.ComboBox();
            this.dpBitis = new System.Windows.Forms.DateTimePicker();
            this.dpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dgAlarmlar = new System.Windows.Forms.DataGridView();
            this.aLARMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSLEMBASLIKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLUSMATARIHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailListesşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnlikAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLARMBindingSource)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarmlar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabControl1.Location = new System.Drawing.Point(0, 31);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new System.Drawing.Point(20, 3);
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1053, 628);
            this.TabControl1.TabIndex = 7;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.dgAnlikAlarm);
            this.TabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabPage1.Location = new System.Drawing.Point(4, 33);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1045, 591);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Anlık Alarm Listesi";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // dgAnlikAlarm
            // 
            this.dgAnlikAlarm.AllowUserToAddRows = false;
            this.dgAnlikAlarm.AllowUserToDeleteRows = false;
            this.dgAnlikAlarm.AutoGenerateColumns = false;
            this.dgAnlikAlarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnlikAlarm.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgAnlikAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnlikAlarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgAnlikAlarm.DataSource = this.aLARMBindingSource;
            this.dgAnlikAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAnlikAlarm.Location = new System.Drawing.Point(3, 3);
            this.dgAnlikAlarm.Name = "dgAnlikAlarm";
            this.dgAnlikAlarm.ReadOnly = true;
            this.dgAnlikAlarm.Size = new System.Drawing.Size(1039, 585);
            this.dgAnlikAlarm.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TANK_ID";
            this.dataGridViewTextBoxColumn2.FillWeight = 20F;
            this.dataGridViewTextBoxColumn2.HeaderText = "TANK NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ACIKLAMA";
            this.dataGridViewTextBoxColumn4.FillWeight = 80F;
            this.dataGridViewTextBoxColumn4.HeaderText = "AÇIKLAMA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // aLARMBindingSource
            // 
            this.aLARMBindingSource.DataSource = typeof(TrafoTest_Model.Model.ALARM);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.btnSecilenleriSil);
            this.TabPage2.Controls.Add(this.label1);
            this.TabPage2.Controls.Add(this.cmbTank);
            this.TabPage2.Controls.Add(this.dpBitis);
            this.TabPage2.Controls.Add(this.dpBaslangic);
            this.TabPage2.Controls.Add(this.dgAlarmlar);
            this.TabPage2.Location = new System.Drawing.Point(4, 33);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1045, 591);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Arşiv";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSecilenleriSil
            // 
            this.btnSecilenleriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecilenleriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecilenleriSil.Location = new System.Drawing.Point(805, 11);
            this.btnSecilenleriSil.Name = "btnSecilenleriSil";
            this.btnSecilenleriSil.Size = new System.Drawing.Size(232, 37);
            this.btnSecilenleriSil.TabIndex = 59;
            this.btnSecilenleriSil.Text = "Seçilen Kayıtları Sil";
            this.btnSecilenleriSil.UseVisualStyleBackColor = true;
            this.btnSecilenleriSil.Click += new System.EventHandler(this.btnSecilenleriSil_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(357, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbTank
            // 
            this.cmbTank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTank.FormattingEnabled = true;
            this.cmbTank.Location = new System.Drawing.Point(434, 16);
            this.cmbTank.Name = "cmbTank";
            this.cmbTank.Size = new System.Drawing.Size(169, 28);
            this.cmbTank.TabIndex = 57;
            this.cmbTank.SelectedIndexChanged += new System.EventHandler(this.cmbTank_SelectedIndexChanged);
            // 
            // dpBitis
            // 
            this.dpBitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpBitis.Location = new System.Drawing.Point(167, 16);
            this.dpBitis.Name = "dpBitis";
            this.dpBitis.Size = new System.Drawing.Size(151, 29);
            this.dpBitis.TabIndex = 56;
            this.dpBitis.ValueChanged += new System.EventHandler(this.dpBaslangic_ValueChanged);
            // 
            // dpBaslangic
            // 
            this.dpBaslangic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpBaslangic.Location = new System.Drawing.Point(10, 16);
            this.dpBaslangic.Name = "dpBaslangic";
            this.dpBaslangic.Size = new System.Drawing.Size(151, 29);
            this.dpBaslangic.TabIndex = 55;
            this.dpBaslangic.ValueChanged += new System.EventHandler(this.dpBaslangic_ValueChanged);
            // 
            // dgAlarmlar
            // 
            this.dgAlarmlar.AllowUserToAddRows = false;
            this.dgAlarmlar.AllowUserToDeleteRows = false;
            this.dgAlarmlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAlarmlar.AutoGenerateColumns = false;
            this.dgAlarmlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlarmlar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgAlarmlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlarmlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLARMIDDataGridViewTextBoxColumn,
            this.tANKIDDataGridViewTextBoxColumn,
            this.ıSLEMBASLIKIDDataGridViewTextBoxColumn,
            this.oLUSMATARIHIDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn});
            this.dgAlarmlar.DataSource = this.aLARMBindingSource;
            this.dgAlarmlar.Location = new System.Drawing.Point(3, 54);
            this.dgAlarmlar.Name = "dgAlarmlar";
            this.dgAlarmlar.ReadOnly = true;
            this.dgAlarmlar.Size = new System.Drawing.Size(1039, 534);
            this.dgAlarmlar.TabIndex = 54;
            // 
            // aLARMIDDataGridViewTextBoxColumn
            // 
            this.aLARMIDDataGridViewTextBoxColumn.DataPropertyName = "ALARM_ID";
            this.aLARMIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.aLARMIDDataGridViewTextBoxColumn.HeaderText = "ALARM NO";
            this.aLARMIDDataGridViewTextBoxColumn.Name = "aLARMIDDataGridViewTextBoxColumn";
            this.aLARMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tANKIDDataGridViewTextBoxColumn
            // 
            this.tANKIDDataGridViewTextBoxColumn.DataPropertyName = "TANK_ID";
            this.tANKIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.tANKIDDataGridViewTextBoxColumn.HeaderText = "TANK NO";
            this.tANKIDDataGridViewTextBoxColumn.Name = "tANKIDDataGridViewTextBoxColumn";
            this.tANKIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıSLEMBASLIKIDDataGridViewTextBoxColumn
            // 
            this.ıSLEMBASLIKIDDataGridViewTextBoxColumn.DataPropertyName = "ISLEM_BASLIK_ID";
            this.ıSLEMBASLIKIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.ıSLEMBASLIKIDDataGridViewTextBoxColumn.HeaderText = "iŞLEM NO";
            this.ıSLEMBASLIKIDDataGridViewTextBoxColumn.Name = "ıSLEMBASLIKIDDataGridViewTextBoxColumn";
            this.ıSLEMBASLIKIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oLUSMATARIHIDataGridViewTextBoxColumn
            // 
            this.oLUSMATARIHIDataGridViewTextBoxColumn.DataPropertyName = "OLUSMA_TARIHI";
            this.oLUSMATARIHIDataGridViewTextBoxColumn.FillWeight = 25F;
            this.oLUSMATARIHIDataGridViewTextBoxColumn.HeaderText = "OLUŞMA TARİHİ";
            this.oLUSMATARIHIDataGridViewTextBoxColumn.Name = "oLUSMATARIHIDataGridViewTextBoxColumn";
            this.oLUSMATARIHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCIKLAMADataGridViewTextBoxColumn
            // 
            this.aCIKLAMADataGridViewTextBoxColumn.DataPropertyName = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.FillWeight = 45F;
            this.aCIKLAMADataGridViewTextBoxColumn.HeaderText = "AÇIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.Name = "aCIKLAMADataGridViewTextBoxColumn";
            this.aCIKLAMADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 31);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genelToolStripMenuItem
            // 
            this.genelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailListesşToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.genelToolStripMenuItem.Name = "genelToolStripMenuItem";
            this.genelToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.genelToolStripMenuItem.Text = "Genel";
            // 
            // mailListesşToolStripMenuItem
            // 
            this.mailListesşToolStripMenuItem.Name = "mailListesşToolStripMenuItem";
            this.mailListesşToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.mailListesşToolStripMenuItem.Text = "Mail Listesi";
            this.mailListesşToolStripMenuItem.Click += new System.EventHandler(this.mailListesşToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // frmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1053, 659);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MinimizeBox = false;
            this.Name = "frmAlarm";
            this.Text = "Alarmlar";
            this.Load += new System.EventHandler(this.frmAlarm_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnlikAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLARMBindingSource)).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarmlar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.DataGridView dgAlarmlar;
        private System.Windows.Forms.Button btnSecilenleriSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTank;
        private System.Windows.Forms.DateTimePicker dpBitis;
        private System.Windows.Forms.DateTimePicker dpBaslangic;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn pASIFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource aLARMBindingSource;
        private System.Windows.Forms.DataGridView dgAnlikAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailListesşToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLARMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tANKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSLEMBASLIKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLUSMATARIHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
    }
}