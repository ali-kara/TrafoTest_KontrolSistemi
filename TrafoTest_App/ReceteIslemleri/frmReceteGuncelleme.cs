using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using TrafoTest_Lib;
using TrafoTest_Model.Model;

namespace TrafoTest_App.ReceteIslemleri
{
    public partial class frmReceteGuncelleme : Form
    {
        List<RECETE_DETAY> SilinecekReceteler { get; set; }
        List<RECETE_DETAY> list { get; set; }
        RECETELER recete { get; set; }
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        int RECETE_ID { get; set; }


        public frmReceteGuncelleme(int _RECETE_ID)
        {
            InitializeComponent();

            SilinecekReceteler = new List<RECETE_DETAY>();
            RECETE_ID = _RECETE_ID;
        }
        private void ReceteIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                recete = db.Receteler.Where(x => x.RECETE_ID == RECETE_ID).FirstOrDefault();

                txtReceteAdi.Text = recete.RECETE_ADI;
                txtReceteAciklama.Text = recete.ACIKLAMA;                

                list = db.Recete_Detaylar.Where(x => x.RECETE_ID == RECETE_ID).ToList();
                dataGridView1.DataSource = list;
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
                list = dataGridView1.DataSource as List<RECETE_DETAY>;

                foreach (RECETE_DETAY recete_detay in list)
                {
                    if (recete_detay.RECETE_ID == 0)
                    {
                        recete_detay.RECETE_ID = RECETE_ID;
                    }

                    db.Recete_Detaylar.Attach(recete_detay);

                    if (recete_detay.RECETE_DETAY_ID != 0)
                    {
                        db.Entry(recete_detay).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(recete_detay).State = EntityState.Added;
                    }

                    db.SaveChanges();
                }

                foreach (RECETE_DETAY recete_silinecek in SilinecekReceteler)
                {
                    db.Recete_Detaylar.Attach(recete_silinecek);
                    db.Entry(recete_silinecek).State = EntityState.Deleted;
                    db.SaveChanges();
                }

                recete.RECETE_ADI = txtReceteAdi.Text;
                recete.ACIKLAMA = txtReceteAciklama.Text;
                recete.GUNCELLEME_TARIHI = DateTime.Now;

                db.Receteler.Attach(recete);
                db.Entry(recete).State = EntityState.Modified;

                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRowAdd_Click(object sender, EventArgs e)
        {
            try
            {
                list = (List<RECETE_DETAY>)dataGridView1.DataSource;
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
                list = (List<RECETE_DETAY>)dataGridView1.DataSource;

                if (list.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        RECETE_DETAY recete_detay = (RECETE_DETAY)row.DataBoundItem;

                        SilinecekReceteler.Add(recete_detay);
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
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    double toplamSaat = 0;
                    list = (List<RECETE_DETAY>)dataGridView1.DataSource;

                    foreach (RECETE_DETAY item in list)
                    {
                        if (item.SAAT == null)
                        {
                            item.SAAT = 0;
                        }

                        toplamSaat += (double)item.SAAT;
                        TimeSpan ts = TimeSpan.FromHours(toplamSaat);

                        item.TOPLAM_SURE = toplamSaat;
                        item.TOPLAM_ZAMAN = ts.Days.ToString() + " Gün " + ts.Hours.ToString() + " Saat " + ts.Minutes.ToString() + " Dakika";
                    }

                    dataGridView1.DataSource = list;
                    dataGridView1.Refresh();
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