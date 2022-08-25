using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrafoTest_App.Properties;
using TrafoTest_App.ToolsUI;
using TrafoTest_Lib;


namespace TrafoTest_App
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();

            txtIPAdres.ValidatingType = typeof(IPAddress);
            txtIPAdres.ResetOnSpace = false;
        }
        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            try
            {
                txtRaporEkranYenilemeSuresi.Text = Settings.Default.RaporlarEkraniEkranYenileme.ToString();
                txtVeritabanıKayit.Text = Settings.Default.VeritabaniKayit.ToString();
                txtIPAdres.Text = Settings.Default.PLC_IPAdres.ToString();
                txtGostergeEkraniGuncellemeSuresi.Text = Settings.Default.TankGostergeEkranGuncellemeZamani.ToString();

                if (Settings.Default.DemoMod)
                {
                    chkDemoMod.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(txtRaporEkranYenilemeSuresi.Text) || 
                    string.IsNullOrEmpty(txtVeritabanıKayit.Text) ||
                    string.IsNullOrEmpty(txtGostergeEkraniGuncellemeSuresi.Text)
                    )
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.", "",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                //IPAddress ip;
                //if (!IPAddress.TryParse(txtIPAdres.Text, out ip))
                //{
                //    MessageBox.Show("Girilen IP Adresi geçerli değildir. Lütfen Kontrol Ediniz.");
                //    return;
                //}

                Settings.Default.RaporlarEkraniEkranYenileme = Convert.ToInt32(txtRaporEkranYenilemeSuresi.Text.Trim());
                Settings.Default.VeritabaniKayit = Convert.ToInt32(txtVeritabanıKayit.Text.Trim());
                Settings.Default.PLC_IPAdres = txtIPAdres.Text.ToString();
                Settings.Default.TankGostergeEkranGuncellemeZamani = Convert.ToInt32(txtGostergeEkraniGuncellemeSuresi.Text.Trim());

                if (chkDemoMod.Checked)
                {
                    Settings.Default.DemoMod = true;
                }
                else
                {
                    Settings.Default.DemoMod = false;
                }


                Settings.Default.Save();

                MessageBox.Show("Ayarlar Kaydedilmiştir.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtIPAdres_Click(object sender, EventArgs e)
        {
            KlavyeAc();
        }

        public void KlavyeAc()
        {
            try
            {
                //ProcessStartInfo p = new ProcessStartInfo(((@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe")));
                //Process aa = Process.Start(p);
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }

        private void txtVeritabanıKayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlarmMail_Click(object sender, EventArgs e)
        {
            frmMailListesi mail = new frmMailListesi();
            mail.ShowDialog();
        }

        private void btnHata_Click(object sender, EventArgs e)
        {
            frmExceptions ex = new frmExceptions();
            ex.Show();
        }
    }
}