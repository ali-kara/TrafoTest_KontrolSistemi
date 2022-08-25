namespace TrafoTest_App.ToolsUI
{
    partial class frmManuel
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
            this.manuelIslemler1 = new TrafoTest_Control.ManuelIslemler();
            this.SuspendLayout();
            // 
            // manuelIslemler1
            // 
            this.manuelIslemler1.Location = new System.Drawing.Point(0, 0);
            this.manuelIslemler1.Name = "manuelIslemler1";
            this.manuelIslemler1.Size = new System.Drawing.Size(881, 818);
            this.manuelIslemler1.TabIndex = 0;
            // 
            // frmManuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(876, 830);
            this.Controls.Add(this.manuelIslemler1);
            this.MaximizeBox = false;
            this.Name = "frmManuel";
            this.Text = "İzleme ve Kontrol Sayfası ";
            this.ResumeLayout(false);

        }

        #endregion

        private TrafoTest_Control.ManuelIslemler manuelIslemler1;
    }
}