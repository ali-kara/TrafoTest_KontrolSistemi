using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_Lib;
using TrafoTest_Model.Model;

namespace TrafoTest_Control
{
    public static class Tank_Functions
    {
        public static bool IslemReceteEkle(ISLEM_BASLIK IslemBaslik, RECETELER secilenRecete)
        {
            try
            {
                TrafoTest_AppDBEntities db = new TrafoTest_AppDBEntities();

                List<RECETE_DETAY> listReceteDetay = db.Recete_Detaylar.Where(x => x.RECETE_ID == secilenRecete.RECETE_ID).ToList();

                foreach (RECETE_DETAY receteDetay in listReceteDetay)
                {
                    db.Islem_Receteler.Add(new ISLEM_RECETE
                    {
                        ISLEM_BASLIK_ID = IslemBaslik.ISLEM_BASLIK_ID,
                        RECETE_ID = IslemBaslik.ISLEM_BASLIK_ID,
                        RECETE_ADI = secilenRecete.RECETE_ADI,
                        DERECE = receteDetay.DERECE,
                        ADIM = receteDetay.ADIM,
                        ISITMA = receteDetay.ISITMA,
                        SAAT = receteDetay.SAAT,
                        TAHLIYE = receteDetay.TAHLIYE,
                        TAHLIYE_DEGERI = receteDetay.TAHLIYE_DEGERI,
                        VAKUM = receteDetay.VAKUM,
                        VAKUM_DEGERI = receteDetay.VAKUM_DEGERI,
                        ACIKLAMA = receteDetay.ACIKLAMA,
                        TOPLAM_SURE = receteDetay.TOPLAM_SURE,
                        TOPLAM_ZAMAN = receteDetay.TOPLAM_ZAMAN,
                        EKLE_LOG_TARIH = DateTime.Now
                    });
                }

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}