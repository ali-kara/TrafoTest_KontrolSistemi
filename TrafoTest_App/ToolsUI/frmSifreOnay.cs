using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using TrafoTest_App;

namespace TrafoTest_App
{
    public partial class frmSifreOnay : Form
    {
        int gelen { get; set; }
        public frmSifreOnay()
        {
            InitializeComponent();
        }

        public frmSifreOnay(int _gelen)
        {
            InitializeComponent();
            gelen = _gelen;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (gelen == 1)
            {
                if (txtParola.Text.Trim() == "12345")
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Parola Yanlış. Lütfen Tekrar Deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (txtParola.Text.Trim() == "yigido1234")
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Parola Yanlış. Lütfen Tekrar Deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtParola_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo p = new ProcessStartInfo(((@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe")));
                Process aa = Process.Start(p);
            }
            catch
            {

            }
        }
    }
}
