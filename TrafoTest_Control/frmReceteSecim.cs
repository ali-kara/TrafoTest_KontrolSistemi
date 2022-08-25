using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_Lib;
using TrafoTest_Model.Model;

namespace TrafoTest_Control
{
    public partial class frmReceteSecim : Form
    {
        public RECETELER SecilenRecete { get; set; }
        public ISLEM_BASLIK IslemBaslik { get; set; }

        TrafoTest_AppDBEntities db = new TrafoTest_AppDBEntities();

        public frmReceteSecim()
        {
            InitializeComponent();
        }

        public frmReceteSecim(ISLEM_BASLIK islemBaslikGelen)
        {
            InitializeComponent();
            IslemBaslik = islemBaslikGelen;
        }

        private void frmReceteSecim_Load(object sender, EventArgs e)
        {
            try
            {
                if (IslemBaslik != null)
                {
                    cmbRecete.Visible = false;
                    txtIslemAdi.Enabled = false;
                    txtIslemAdi.Text = IslemBaslik.ISLEM_ADI;

                    if (IslemBaslik.TRAFO_1.Trim() != string.Empty) { txtTrafoNo_1.Text = IslemBaslik.TRAFO_1; txtTrafoNo_1.Enabled = false; }
                    if (IslemBaslik.TRAFO_2.Trim() != string.Empty) { txtTrafoNo_2.Text = IslemBaslik.TRAFO_2; txtTrafoNo_2.Enabled = false; }
                    if (IslemBaslik.TRAFO_3.Trim() != string.Empty) { txtTrafoNo_3.Text = IslemBaslik.TRAFO_3; txtTrafoNo_3.Enabled = false; }
                    if (IslemBaslik.TRAFO_4.Trim() != string.Empty) { txtTrafoNo_4.Text = IslemBaslik.TRAFO_4; txtTrafoNo_4.Enabled = false; }
                    if (IslemBaslik.TRAFO_5.Trim() != string.Empty) { txtTrafoNo_5.Text = IslemBaslik.TRAFO_5; txtTrafoNo_5.Enabled = false; }
                    if (IslemBaslik.TRAFO_6.Trim() != string.Empty) { txtTrafoNo_6.Text = IslemBaslik.TRAFO_6; txtTrafoNo_6.Enabled = false; }
                    if (IslemBaslik.TRAFO_7.Trim() != string.Empty) { txtTrafoNo_7.Text = IslemBaslik.TRAFO_7; txtTrafoNo_7.Enabled = false; }
                    if (IslemBaslik.TRAFO_8.Trim() != string.Empty) { txtTrafoNo_8.Text = IslemBaslik.TRAFO_8; txtTrafoNo_8.Enabled = false; }
                    if (IslemBaslik.TRAFO_9.Trim() != string.Empty) { txtTrafoNo_9.Text = IslemBaslik.TRAFO_9; txtTrafoNo_9.Enabled = false; }
                    if (IslemBaslik.TRAFO_10.Trim() != string.Empty) { txtTrafoNo_10.Text = IslemBaslik.TRAFO_10; txtTrafoNo_10.Enabled = false; }
                }
                else
                {
                    cmbRecete.DataSource = db.Receteler.Where(x => x.PASIF != true).ToList();
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (IslemBaslik != null)
                {
                    IslemBaslik.TRAFO_1 = txtTrafoNo_1.Text;
                    IslemBaslik.TRAFO_2 = txtTrafoNo_2.Text;
                    IslemBaslik.TRAFO_3 = txtTrafoNo_3.Text;
                    IslemBaslik.TRAFO_4 = txtTrafoNo_4.Text;
                    IslemBaslik.TRAFO_5 = txtTrafoNo_5.Text;
                    IslemBaslik.TRAFO_6 = txtTrafoNo_6.Text;
                    IslemBaslik.TRAFO_7 = txtTrafoNo_7.Text;
                    IslemBaslik.TRAFO_8 = txtTrafoNo_8.Text;
                    IslemBaslik.TRAFO_9 = txtTrafoNo_9.Text;
                    IslemBaslik.TRAFO_10 = txtTrafoNo_10.Text;

                    db.Islem_Basliklar.Attach(IslemBaslik);
                    db.Entry(IslemBaslik).State = EntityState.Modified;
                    db.SaveChanges();

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {

                    RECETELER recete = cmbRecete.SelectedItem as RECETELER;
                    SecilenRecete = recete;

                    IslemBaslik = new ISLEM_BASLIK();
                    IslemBaslik.ISLEM_ADI = txtIslemAdi.Text.ToString();

                    IslemBaslik.TRAFO_1 = txtTrafoNo_1.Text;
                    IslemBaslik.TRAFO_2 = txtTrafoNo_2.Text;
                    IslemBaslik.TRAFO_3 = txtTrafoNo_3.Text;
                    IslemBaslik.TRAFO_4 = txtTrafoNo_4.Text;
                    IslemBaslik.TRAFO_5 = txtTrafoNo_5.Text;
                    IslemBaslik.TRAFO_6 = txtTrafoNo_6.Text;
                    IslemBaslik.TRAFO_7 = txtTrafoNo_7.Text;
                    IslemBaslik.TRAFO_8 = txtTrafoNo_8.Text;
                    IslemBaslik.TRAFO_9 = txtTrafoNo_9.Text;
                    IslemBaslik.TRAFO_10 = txtTrafoNo_10.Text;

                    if (recete != null)
                    {
                        List<RECETE_DETAY> receteDetay = db.Recete_Detaylar.Where(x => x.RECETE_ID == recete.RECETE_ID).ToList();

                        if (receteDetay.Count < 1)
                        {
                            MessageBox.Show("Seçilen Reçetenin İşlem Adımları Kaydedilmemiştir. Lüften Ekleyip Tekrar Deneyiniz.");
                            return;
                        }
                        else
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Reçete Seçilmedi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
