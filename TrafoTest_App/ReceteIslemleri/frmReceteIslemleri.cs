using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_Model.Model;
using TrafoTest_Lib;
using System.Data.Entity;

namespace TrafoTest_App.ReceteIslemleri
{
    public partial class frmReceteIslemleri : Form
    {
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        public frmReceteIslemleri()
        {
            InitializeComponent();
        }

        private void frmReceteIslemleri_Load(object sender, EventArgs e)
        {
            ReceteleriGetir();
        }

        private void ReceteleriGetir()
        {
            try
            {
                lstReceteler.DataSource = db.Receteler.Where(x => x.PASIF != true).ToList();
                lstReceteler.Refresh();

                if (((List<RECETELER>)lstReceteler.DataSource).Count == 0)
                {
                    txtReceteAdi.Text = "";
                    txtReceteAciklama.Text = "";
                    lblReceteId.Text = "";
                    lblEklemeTarihi.Text = "";
                    lblGuncellemeTarihi.Text = "";
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void lstReceteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RECETELER recete = lstReceteler.SelectedItem as RECETELER;

                txtReceteAdi.Text = recete.RECETE_ADI;
                txtReceteAciklama.Text = recete.ACIKLAMA;
                lblReceteId.Text = recete.RECETE_ID.ToString();
                lblEklemeTarihi.Text = "";
                lblGuncellemeTarihi.Text = "";

                if (recete.EKLENME_TARIHI.HasValue)
                {
                    lblEklemeTarihi.Text = recete.EKLENME_TARIHI.Value.ToString("dd-MM-yyyy HH:mm");

                }
                if (recete.GUNCELLEME_TARIHI.HasValue)
                {
                    lblGuncellemeTarihi.Text = recete.GUNCELLEME_TARIHI.Value.ToString("dd-MM-yyyy HH:mm");
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                frmReceteEkleme ekle = new frmReceteEkleme();

                if (ekle.ShowDialog() == DialogResult.OK)
                {
                    ReceteleriGetir();
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstReceteler.SelectedItem != null)
                {
                    RECETELER recete = lstReceteler.SelectedItem as RECETELER;
                    frmReceteGuncelleme guncel = new frmReceteGuncelleme(recete.RECETE_ID);                    

                    if (guncel.ShowDialog() == DialogResult.OK)
                    {
                        ReceteleriGetir();
                    }
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstReceteler.SelectedItem != null)
                {
                    if (MessageBox.Show("Seçilen Reçeteyi Kalıcı Olarak Silmek İstediğinize Emin misiniz?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }

                    RECETELER recete = lstReceteler.SelectedItem as RECETELER;

                    recete.PASIF = true;

                    db.Receteler.Attach(recete);
                    db.Entry(recete).State = EntityState.Modified;

                    db.SaveChanges();
                    ReceteleriGetir();
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
