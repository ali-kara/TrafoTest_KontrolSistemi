namespace TrafoTest_Control
{
    partial class Tank4_PopUp
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
            this.lblTankMesaj = new System.Windows.Forms.Label();
            this.btnProsesBitir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBitisZamani = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTankMesaj
            // 
            this.lblTankMesaj.AutoSize = true;
            this.lblTankMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTankMesaj.Location = new System.Drawing.Point(85, 68);
            this.lblTankMesaj.Name = "lblTankMesaj";
            this.lblTankMesaj.Size = new System.Drawing.Size(331, 42);
            this.lblTankMesaj.TabIndex = 0;
            this.lblTankMesaj.Text = "Tank 4 Proses Bitti";
            // 
            // btnProsesBitir
            // 
            this.btnProsesBitir.AutoEllipsis = true;
            this.btnProsesBitir.BackColor = System.Drawing.Color.Ivory;
            this.btnProsesBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProsesBitir.Location = new System.Drawing.Point(92, 198);
            this.btnProsesBitir.Name = "btnProsesBitir";
            this.btnProsesBitir.Size = new System.Drawing.Size(293, 72);
            this.btnProsesBitir.TabIndex = 1;
            this.btnProsesBitir.Text = "Proses Bitir";
            this.btnProsesBitir.UseVisualStyleBackColor = false;
            this.btnProsesBitir.Click += new System.EventHandler(this.btnProsesBitir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitiş Zamanı";
            // 
            // lblBitisZamani
            // 
            this.lblBitisZamani.AutoSize = true;
            this.lblBitisZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisZamani.Location = new System.Drawing.Point(171, 142);
            this.lblBitisZamani.Name = "lblBitisZamani";
            this.lblBitisZamani.Size = new System.Drawing.Size(21, 29);
            this.lblBitisZamani.TabIndex = 0;
            this.lblBitisZamani.Text = "-";
            // 
            // Tank4_PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 329);
            this.Controls.Add(this.btnProsesBitir);
            this.Controls.Add(this.lblBitisZamani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTankMesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tank4_PopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TankPopUp";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TankPopUp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TankPopUp_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TankPopUp_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTankMesaj;
        private System.Windows.Forms.Button btnProsesBitir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBitisZamani;
    }
}