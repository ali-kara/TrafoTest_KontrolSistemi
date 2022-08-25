using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TrafoTest_Lib;
using TrafoTest_Model.Model;

namespace TrafoTest_App.ReceteIslemleri
{
    public partial class frmReceteEkleme : Form
    {
        int RECETE_ID { get; set; }
        List<RECETE_DETAY> Receteler { get; set; }
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        public frmReceteEkleme()
        {
            InitializeComponent();
        }
        private void ReceteIslemleri_Load(object sender, EventArgs e)
        {
            Receteler = new List<RECETE_DETAY>();

            RECETE_DETAY rd = new RECETE_DETAY
            {
                ADIM = 1,
                VAKUM_DEGERI = 0,
                DERECE = 0,
            };

            Receteler.Add(rd);
            dataGridView1.DataSource = Receteler;
        }
        private void btnRowAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<RECETE_DETAY> list = dataGridView1.DataSource as List<RECETE_DETAY>;
                list.Add(new RECETE_DETAY());

                for (int i = 0; i < list.Count; i++)
                {
                    list[i].ADIM = i + 1;
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRowDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<RECETE_DETAY> list = (List<RECETE_DETAY>)dataGridView1.DataSource;

                if (list.Count > 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        RECETE_DETAY recete_detay = (RECETE_DETAY)row.DataBoundItem;
                        list.Remove(recete_detay);
                    }

                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i].ADIM = i + 1;
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCik_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                RECETELER recete = new RECETELER();
                recete.RECETE_ADI = txtReceteAdi.Text;
                recete.ACIKLAMA = txtReceteAciklama.Text;
                recete.EKLENME_TARIHI = DateTime.Now;
                recete.GUNCELLEME_TARIHI = DateTime.Now;

                db.Receteler.Add(recete);
                db.SaveChanges();

                List<RECETE_DETAY> list = (List<RECETE_DETAY>)dataGridView1.DataSource;

                foreach (RECETE_DETAY recete_detay in list)
                {
                    recete_detay.RECETE_ID = recete.RECETE_ID;
                    recete_detay.Receteler = recete;
                    db.Recete_Detaylar.Add(recete_detay);
                }

                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                double toplamSaat = 0;
                List<RECETE_DETAY> list = (List<RECETE_DETAY>)dataGridView1.DataSource;

                foreach (RECETE_DETAY item in list)
                {
                    if (item.SAAT == null)
                    {
                        item.SAAT = 0;
                    }

                    toplamSaat += (double)item.SAAT;

                    item.TOPLAM_SURE = toplamSaat;

                    TimeSpan ts = TimeSpan.FromHours(toplamSaat);

                    item.TOPLAM_ZAMAN = ts.Days.ToString() + " Gün " + 
                                        ts.Hours.ToString() + " Saat " + 
                                        ts.Minutes.ToString() + " Dakika";
                }

                dataGridView1.DataSource = list;
                dataGridView1.Refresh();
            }
        }
    }
}