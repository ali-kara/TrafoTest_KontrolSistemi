namespace TrafoTest_App.ToolsUI
{
    partial class frmExceptions
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
            this.dgExceptions = new System.Windows.Forms.DataGridView();
            this.eXCEPTIONLOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceleAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSecilenleriSil = new System.Windows.Forms.Button();
            this.dpBitis = new System.Windows.Forms.DateTimePicker();
            this.dpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.eXCEPTIONLOGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESSAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTACKTRACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eKLELOGTARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgExceptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCEPTIONLOGBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgExceptions
            // 
            this.dgExceptions.AllowUserToAddRows = false;
            this.dgExceptions.AllowUserToDeleteRows = false;
            this.dgExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgExceptions.AutoGenerateColumns = false;
            this.dgExceptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExceptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgExceptions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExceptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgExceptions.ColumnHeadersHeight = 40;
            this.dgExceptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXCEPTIONLOGIDDataGridViewTextBoxColumn,
            this.mESSAGEDataGridViewTextBoxColumn,
            this.sTACKTRACEDataGridViewTextBoxColumn,
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn,
            this.eKLELOGTARIHDataGridViewTextBoxColumn});
            this.dgExceptions.DataSource = this.eXCEPTIONLOGBindingSource;
            this.dgExceptions.Location = new System.Drawing.Point(19, 86);
            this.dgExceptions.Margin = new System.Windows.Forms.Padding(15);
            this.dgExceptions.Name = "dgExceptions";
            this.dgExceptions.ReadOnly = true;
            this.dgExceptions.Size = new System.Drawing.Size(1234, 526);
            this.dgExceptions.TabIndex = 0;
            // 
            // eXCEPTIONLOGBindingSource
            // 
            this.eXCEPTIONLOGBindingSource.DataSource = typeof(TrafoTest_Model.Model.EXCEPTION_LOG);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exceleAktarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exceleAktarToolStripMenuItem
            // 
            this.exceleAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exceleAktarToolStripMenuItem1});
            this.exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            this.exceleAktarToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.exceleAktarToolStripMenuItem.Text = "İşlemler";
            // 
            // exceleAktarToolStripMenuItem1
            // 
            this.exceleAktarToolStripMenuItem1.Name = "exceleAktarToolStripMenuItem1";
            this.exceleAktarToolStripMenuItem1.Size = new System.Drawing.Size(172, 28);
            this.exceleAktarToolStripMenuItem1.Text = "Excele Aktar";
            this.exceleAktarToolStripMenuItem1.Click += new System.EventHandler(this.exceleAktarToolStripMenuItem1_Click);
            // 
            // btnSecilenleriSil
            // 
            this.btnSecilenleriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecilenleriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecilenleriSil.Location = new System.Drawing.Point(1021, 37);
            this.btnSecilenleriSil.Name = "btnSecilenleriSil";
            this.btnSecilenleriSil.Size = new System.Drawing.Size(232, 37);
            this.btnSecilenleriSil.TabIndex = 9;
            this.btnSecilenleriSil.Text = "Seçilen Kayıtları Sil";
            this.btnSecilenleriSil.UseVisualStyleBackColor = true;
            this.btnSecilenleriSil.Click += new System.EventHandler(this.btnSecilenleriSil_Click);
            // 
            // dpBitis
            // 
            this.dpBitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpBitis.Location = new System.Drawing.Point(176, 45);
            this.dpBitis.Name = "dpBitis";
            this.dpBitis.Size = new System.Drawing.Size(151, 29);
            this.dpBitis.TabIndex = 8;
            this.dpBitis.ValueChanged += new System.EventHandler(this.dpBaslangic_ValueChanged);
            // 
            // dpBaslangic
            // 
            this.dpBaslangic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpBaslangic.Location = new System.Drawing.Point(19, 45);
            this.dpBaslangic.Name = "dpBaslangic";
            this.dpBaslangic.Size = new System.Drawing.Size(151, 29);
            this.dpBaslangic.TabIndex = 7;
            this.dpBaslangic.ValueChanged += new System.EventHandler(this.dpBaslangic_ValueChanged);
            // 
            // eXCEPTIONLOGIDDataGridViewTextBoxColumn
            // 
            this.eXCEPTIONLOGIDDataGridViewTextBoxColumn.DataPropertyName = "EXCEPTION_LOG_ID";
            this.eXCEPTIONLOGIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.eXCEPTIONLOGIDDataGridViewTextBoxColumn.HeaderText = "LOG_ID";
            this.eXCEPTIONLOGIDDataGridViewTextBoxColumn.Name = "eXCEPTIONLOGIDDataGridViewTextBoxColumn";
            this.eXCEPTIONLOGIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mESSAGEDataGridViewTextBoxColumn
            // 
            this.mESSAGEDataGridViewTextBoxColumn.DataPropertyName = "MESSAGE";
            this.mESSAGEDataGridViewTextBoxColumn.FillWeight = 25F;
            this.mESSAGEDataGridViewTextBoxColumn.HeaderText = "MESSAGE";
            this.mESSAGEDataGridViewTextBoxColumn.Name = "mESSAGEDataGridViewTextBoxColumn";
            this.mESSAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTACKTRACEDataGridViewTextBoxColumn
            // 
            this.sTACKTRACEDataGridViewTextBoxColumn.DataPropertyName = "STACKTRACE";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sTACKTRACEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sTACKTRACEDataGridViewTextBoxColumn.FillWeight = 25F;
            this.sTACKTRACEDataGridViewTextBoxColumn.HeaderText = "STACKTRACE";
            this.sTACKTRACEDataGridViewTextBoxColumn.Name = "sTACKTRACEDataGridViewTextBoxColumn";
            this.sTACKTRACEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıNNEREXCEPTIONDataGridViewTextBoxColumn
            // 
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn.DataPropertyName = "INNER_EXCEPTION";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn.FillWeight = 25F;
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn.HeaderText = "INNER_EXCEPTION";
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn.Name = "ıNNEREXCEPTIONDataGridViewTextBoxColumn";
            this.ıNNEREXCEPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eKLELOGTARIHDataGridViewTextBoxColumn
            // 
            this.eKLELOGTARIHDataGridViewTextBoxColumn.DataPropertyName = "EKLE_LOG_TARIH";
            this.eKLELOGTARIHDataGridViewTextBoxColumn.FillWeight = 15F;
            this.eKLELOGTARIHDataGridViewTextBoxColumn.HeaderText = "EKLE_LOG_TARIH";
            this.eKLELOGTARIHDataGridViewTextBoxColumn.Name = "eKLELOGTARIHDataGridViewTextBoxColumn";
            this.eKLELOGTARIHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmExceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1265, 623);
            this.Controls.Add(this.btnSecilenleriSil);
            this.Controls.Add(this.dpBitis);
            this.Controls.Add(this.dpBaslangic);
            this.Controls.Add(this.dgExceptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmExceptions";
            this.Text = "frmExceptions";
            this.Load += new System.EventHandler(this.frmExceptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgExceptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCEPTIONLOGBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgExceptions;
        private System.Windows.Forms.BindingSource eXCEPTIONLOGBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exceleAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceleAktarToolStripMenuItem1;
        private System.Windows.Forms.Button btnSecilenleriSil;
        private System.Windows.Forms.DateTimePicker dpBitis;
        private System.Windows.Forms.DateTimePicker dpBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXCEPTIONLOGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESSAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTACKTRACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıNNEREXCEPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eKLELOGTARIHDataGridViewTextBoxColumn;
    }
}