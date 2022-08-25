using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_App;
using TrafoTest_Lib;
using System.Data.Entity;
using TrafoTest_Model.Model;

namespace TrafoTest_App
{
    public partial class frmRaporlarAna : Form
    {
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        List<ISLEM_BASLIK> islemlistesi { get; set; }
        public frmRaporlarAna()
        {
            InitializeComponent();
            cmbTank.DisplayMember = "Text";
            cmbTank.ValueMember = "Value";

            var items = new[] {
                    new { Text = "Tümü"  , Value = "0" },
                    new { Text = "Tank 1", Value = "1" },
                    new { Text = "Tank 2", Value = "2" },
                    new { Text = "Tank 3", Value = "3" },
                    new { Text = "Tank 4", Value = "4" }
                };

            cmbTank.DataSource = items;
        }        
        private void frmRaporlarAna_Load(object sender, EventArgs e)
        {
            IslemBasliklariGetir();
            dgRaporlarAna.ColumnHeadersHeight = 30;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                IslemBasliklariGetir();
            }
            catch (Exception ex)
            {
                dgRaporlarAna.DataSource = null;

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            IslemBasliklariGetir();
        }
        void IslemBasliklariGetir()
        {
            try
            {
                dgRaporlarAna.DataSource = null;

                int secilenTank = Convert.ToInt32(cmbTank.SelectedValue);

                if (secilenTank != 0)
                {
                    islemlistesi = db.Islem_Basliklar.Where(x => x.TANK_ID == secilenTank && DbFunctions.TruncateTime(x.BASLANGIC_TARIHI) >= DbFunctions.TruncateTime(dpBaslangic.Value) && DbFunctions.TruncateTime(x.BASLANGIC_TARIHI) <= DbFunctions.TruncateTime(dpBitis.Value)).ToList();
                }
                else
                {
                    islemlistesi = db.Islem_Basliklar.Where(x => DbFunctions.TruncateTime(x.BASLANGIC_TARIHI) >= DbFunctions.TruncateTime(dpBaslangic.Value) && DbFunctions.TruncateTime(x.BASLANGIC_TARIHI) <= DbFunctions.TruncateTime(dpBitis.Value)).ToList();
                }


                if (!String.IsNullOrEmpty(txtFiltre.Text.Trim()))
                {
                    List<ISLEM_BASLIK> newList = new List<ISLEM_BASLIK>();

                    newList = islemlistesi.Where(data =>
                    (data.TRAFO_1 != null && data.TRAFO_1.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_2 != null && data.TRAFO_2.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_3 != null && data.TRAFO_3.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_4 != null && data.TRAFO_4.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_5 != null && data.TRAFO_5.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_6 != null && data.TRAFO_6.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_7 != null && data.TRAFO_7.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_8 != null && data.TRAFO_8.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_9 != null && data.TRAFO_9.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper())) ||
                    (data.TRAFO_10 != null && data.TRAFO_10.ToUpper().Contains(txtFiltre.Text.Trim().ToUpper()))
                    ).ToList();

                    islemlistesi = newList;
                }

                dgRaporlarAna.DataSource = islemlistesi;
            }
            catch (Exception ex)
            {
                dgRaporlarAna.DataSource = null;

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgRaporlarAna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (e.ColumnIndex == 0)
                    {
                        ISLEM_BASLIK baslik = dgRaporlarAna.Rows[Convert.ToInt32(e.RowIndex)].DataBoundItem as ISLEM_BASLIK;

                        frmRaporlarDetay raporDetay = new frmRaporlarDetay(baslik.ISLEM_BASLIK_ID);
                        raporDetay.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void cmbTank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IslemBasliklariGetir();
            }
            catch (Exception ex)
            {
                dgRaporlarAna.DataSource = null;

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSecilenleriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Kayıtları Silinecektir.\n\nDikkat: Silinecek işlemler ile ilgili tüm detaylar ve reçete kayıtları da silinecektir. Bu işlem geri alınamaz.\n\nDevam Etmek İstiyor musunuz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }

                ISLEM_BASLIK tank1_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 1).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();
                ISLEM_BASLIK tank2_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 2).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();
                ISLEM_BASLIK tank3_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 3).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();
                ISLEM_BASLIK tank4_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 4).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();


                foreach (DataGridViewRow row in dgRaporlarAna.SelectedRows)
                {
                    ISLEM_BASLIK islemBaslik = (ISLEM_BASLIK)row.DataBoundItem;

                    if (PlcTag.Db_tank1_IslemDurumu != 0 && !tank1_islem.BITIS_TARIHI.HasValue && tank1_islem.ISLEM_BASLIK_ID == islemBaslik.ISLEM_BASLIK_ID)
                    {
                        MessageBox.Show("Seçili Kayıtların İçinde Aktif Prosesin Kayıtları Vardır.\n\nBu Kayıtlar Silinemez ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IslemBasliklariGetir();
                        return;
                    }
                    if (PlcTag.Db_tank2_IslemDurumu != 0 && !tank2_islem.BITIS_TARIHI.HasValue && tank2_islem.ISLEM_BASLIK_ID == islemBaslik.ISLEM_BASLIK_ID)
                    {
                        MessageBox.Show("Seçili Kayıtların İçinde Aktif Prosesin Kayıtları Vardır.\n\nBu Kayıtlar Silinemez ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IslemBasliklariGetir();
                        return;
                    }
                    if (PlcTag.Db_tank3_IslemDurumu != 0 && !tank3_islem.BITIS_TARIHI.HasValue && tank3_islem.ISLEM_BASLIK_ID == islemBaslik.ISLEM_BASLIK_ID)
                    {
                        MessageBox.Show("Seçili Kayıtların İçinde Aktif Prosesin Kayıtları Vardır.\n\nBu Kayıtlar Silinemez ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IslemBasliklariGetir();
                        return;
                    }
                    if (PlcTag.Db_tank4_IslemDurumu != 0 && !tank4_islem.BITIS_TARIHI.HasValue && tank4_islem.ISLEM_BASLIK_ID == islemBaslik.ISLEM_BASLIK_ID)
                    {
                        MessageBox.Show("Seçili Kayıtların İçinde Aktif Prosesin Kayıtları Vardır.\n\nBu Kayıtlar Silinemez ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IslemBasliklariGetir();
                        return;
                    }



                    db.Islem_Basliklar.Attach(islemBaslik);
                    db.Entry(islemBaslik).State = EntityState.Deleted;
                    db.SaveChanges();
                }

                IslemBasliklariGetir();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());                    
            }
        }
    }
}