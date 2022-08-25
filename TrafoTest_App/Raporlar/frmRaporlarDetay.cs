using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_App.Properties;
using TrafoTest_Control;
using TrafoTest_Lib;
using TrafoTest_Model.Model;

namespace TrafoTest_App
{
    public partial class frmRaporlarDetay : Form
    {
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        int ISLEM_BASLIK_ID { get; set; }
        List<ISLEM_DETAY> listIslemDetay { get; set; }
        List<ISLEM_RECETE> listIslemRecete { get; set; }

        public frmRaporlarDetay(int _ISLEM_BASLIK_ID)
        {
            InitializeComponent();

            ISLEM_BASLIK_ID = _ISLEM_BASLIK_ID;
            listIslemDetay = new List<ISLEM_DETAY>();
            listIslemRecete = new List<ISLEM_RECETE>();
            timer1.Interval = Settings.Default.RaporlarEkraniEkranYenileme * 1000 * 60; //Duzenledim
        }
        private void frmRaporlarDetay_Load(object sender, EventArgs e)
        {
            try
            {
                dgIslemReceteDetaylar.DataSource = null;
                listIslemRecete = db.Islem_Receteler.Where(x => x.ISLEM_BASLIK_ID == ISLEM_BASLIK_ID).ToList();
                dgIslemReceteDetaylar.DataSource = listIslemRecete;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());                
            }

            doldur();
        }

        void doldur()
        {
            try
            {
                dgRaporDetay.DataSource = null;
                listIslemDetay = db.Islem_Detaylar.Where(x => x.ISLEM_BASLIK_ID == ISLEM_BASLIK_ID).OrderByDescending(x => x.ISLEM_DETAY_ID).ToList();
                dgRaporDetay.DataSource = listIslemDetay;
            }
            catch (Exception ex)
            {
                timer1.Stop();

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private async void exceleAktarToolStripMenuItem1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                await ExceleAktarAsync();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        async Task ExceleAktarAsync()
        {
            try
            {
                ExcelIslemleri excel = new ExcelIslemleri();

                TankGoruntuleme t = new TankGoruntuleme();
                t.InitialLoad();

                string path = t.EkranGoruntusuAl(listIslemDetay.OrderByDescending(x => x.ISLEM_DETAY_ID).ToList());

                ISLEM_BASLIK IslemBaslik = db.Islem_Basliklar.Where(x => x.ISLEM_BASLIK_ID == ISLEM_BASLIK_ID).FirstOrDefault();

                List<string> trafolar = new List<string>();

                if (IslemBaslik.TRAFO_1 != null && IslemBaslik.TRAFO_1.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_1); }
                if (IslemBaslik.TRAFO_2 != null && IslemBaslik.TRAFO_2.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_2); }
                if (IslemBaslik.TRAFO_3 != null && IslemBaslik.TRAFO_3.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_3); }
                if (IslemBaslik.TRAFO_4 != null && IslemBaslik.TRAFO_4.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_4); }
                if (IslemBaslik.TRAFO_5 != null && IslemBaslik.TRAFO_5.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_5); }
                if (IslemBaslik.TRAFO_6 != null && IslemBaslik.TRAFO_6.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_6); }
                if (IslemBaslik.TRAFO_7 != null && IslemBaslik.TRAFO_7.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_7); }
                if (IslemBaslik.TRAFO_8 != null && IslemBaslik.TRAFO_8.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_8); }
                if (IslemBaslik.TRAFO_9 != null && IslemBaslik.TRAFO_9.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_9); }
                if (IslemBaslik.TRAFO_10 != null && IslemBaslik.TRAFO_10.Trim() != string.Empty) { trafolar.Add(IslemBaslik.TRAFO_10); }

                var val = await Task.Run(() => excel.ExportExcel(trafolar,path, listIslemRecete, typeof(ISLEM_RECETE)));
                //excel.ExportExcel(trafolar, path, listIslemRecete, typeof(ISLEM_RECETE));
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doldur();
        }
    }
}