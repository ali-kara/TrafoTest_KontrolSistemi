using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrafoTest_Model.Model;
using TrafoTest_Lib;
using System.Diagnostics;
using System.Data.Entity;
using TrafoTest_Control.Properties;

namespace TrafoTest_Control
{
    public enum enmIslemDurumu
    {
        ISLEM_YOK = 0,
        ISLEM_BEKLEMEDE = 1,
        ISLEM_DEVAM_EDIYOR = 2,
        ISLEM_HATA_VAR = 3
    }
    public partial class TankGosterge : MyUserControl
    {
        public Random random { get; set; }
        public int TankId { get; set; }
        public ISLEM_BASLIK IslemBaslik { get; set; }
        public TankGoruntuleme tankGoruntuleme { get; set; }
        public RECETELER SecilenRecete { get; set; }
        Tank1_PopUp tank1_popUp { get; set; }
        Tank2_PopUp tank2_popUp { get; set; }
        Tank3_PopUp tank3_popUp { get; set; }
        Tank4_PopUp tank4_popUp { get; set; }
        public Timer timerPeriyodikIslemler_Degerler { get; set; }
        public Timer timerPeriyodikIslemler_Proses { get; set; }
        private enmIslemDurumu _IslemDurumu { get; set; }
        public enmIslemDurumu IslemDurumu
        {
            get
            {
                return _IslemDurumu;
            }
            set
            {
                _IslemDurumu = value;
                if (_IslemDurumu == enmIslemDurumu.ISLEM_DEVAM_EDIYOR)
                {
                    GostergePanel.BackColor = Color.Green;
                    lblIslemDurumu.Text = "İşlem Devam Ediyor";

                    btnBaslat.Text = "Bitir";

                    btnDurdur.Enabled = true;
                    btnDurdur.Text = "Duraklat";
                    btnTahliye.Visible = false;

                    timerPeriyodikIslemler_Proses.Enabled = true;
                }
                else if (_IslemDurumu == enmIslemDurumu.ISLEM_BEKLEMEDE)
                {
                    GostergePanel.BackColor = Color.Yellow;
                    lblIslemDurumu.Text = "İşlem Beklemede";

                    btnBaslat.Text = "Bitir";
                    btnTahliye.Visible = true;

                    btnDurdur.Enabled = true;
                    btnDurdur.Text = "Devam Ettir";

                    timerPeriyodikIslemler_Proses.Enabled = false;
                }
                else if (_IslemDurumu == enmIslemDurumu.ISLEM_HATA_VAR)
                {
                    GostergePanel.BackColor = Color.Red;
                    lblIslemDurumu.Text = "İşlemde Hata Var";

                    btnBaslat.Text = "Bitir";
                    btnTahliye.Visible = true;

                    btnDurdur.Enabled = true;
                    btnDurdur.Text = "Devam Ettir";

                    timerPeriyodikIslemler_Proses.Enabled = false;
                }
                else
                {
                    GostergePanel.BackColor = Color.LightBlue;
                    lblIslemDurumu.Text = "İşlem Yok";

                    btnBaslat.Text = "Başlat";
                    btnTahliye.Visible = true;

                    btnDurdur.Enabled = false;
                    btnDurdur.Text = "Duraklat";

                    timerPeriyodikIslemler_Proses.Enabled = false;

                    lblTankIslemAdim.Text = "-";
                    lblReceteAdimi.Text = "-";
                    lblReceteKalanSure.Text = "-";
                    lblToplamSure.Text = "-";
                    lblToplamKalanSure.Text = "-";
                    lblBaslangic.Text = "-";
                    lblIslemRecete.Text = "-";

                    SecilenRecete = null;
                    IslemBaslik = null;
                }
            }
        }


        public TankGosterge()
        {
            InitializeComponent();
            random = new Random();

            timerPeriyodikIslemler_Degerler = new Timer();
            timerPeriyodikIslemler_Degerler.Interval = 1000;
            timerPeriyodikIslemler_Degerler.Tick += timerPeriyodikIslemler_Degerler_Tick;
            timerPeriyodikIslemler_Degerler.Enabled = true;

            timerPeriyodikIslemler_Proses = new Timer();
            timerPeriyodikIslemler_Proses.Interval = 1000;
            timerPeriyodikIslemler_Proses.Tick += timerPeriyodikIslemler_Proses_Tick;
            timerPeriyodikIslemler_Proses.Enabled = false;
        }

        public void IslemDurumKontrolEt()
        {
            try
            {
                if (TankId == 1)
                {
                    switch (PlcTag.Db_tank1_IslemDurumu)
                    {
                        case 0:
                            if (IslemBaslik != null)
                            {
                                IslemBaslik.BITIS_TARIHI = DateTime.Now;
                                db.Islem_Basliklar.Attach(IslemBaslik);
                                db.Entry(IslemBaslik).State = EntityState.Modified;
                                db.SaveChanges();
                            }

                            IslemDurumu = enmIslemDurumu.ISLEM_YOK;
                            break;
                        case 1: IslemDurumu = enmIslemDurumu.ISLEM_BEKLEMEDE; break;
                        case 2: IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR; break;
                        case 3: IslemDurumu = enmIslemDurumu.ISLEM_HATA_VAR; break;
                        default: break;
                    }
                }
                else if (TankId == 2)
                {
                    switch (PlcTag.Db_tank2_IslemDurumu)
                    {
                        case 0:
                            if (IslemBaslik != null)
                            {
                                IslemBaslik.BITIS_TARIHI = DateTime.Now;
                                db.Islem_Basliklar.Attach(IslemBaslik);
                                db.Entry(IslemBaslik).State = EntityState.Modified;
                                db.SaveChanges();
                            }

                            IslemDurumu = enmIslemDurumu.ISLEM_YOK;
                            break;
                        case 1: IslemDurumu = enmIslemDurumu.ISLEM_BEKLEMEDE; break;
                        case 2: IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR; break;
                        case 3: IslemDurumu = enmIslemDurumu.ISLEM_HATA_VAR; break;
                        default: break;
                    }
                }
                else if (TankId == 3)
                {
                    switch (PlcTag.Db_tank3_IslemDurumu)
                    {
                        case 0:
                            if (IslemBaslik != null)
                            {
                                IslemBaslik.BITIS_TARIHI = DateTime.Now;
                                db.Islem_Basliklar.Attach(IslemBaslik);
                                db.Entry(IslemBaslik).State = EntityState.Modified;
                                db.SaveChanges();
                            }

                            IslemDurumu = enmIslemDurumu.ISLEM_YOK;
                            break;
                        case 1: IslemDurumu = enmIslemDurumu.ISLEM_BEKLEMEDE; break;
                        case 2: IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR; break;
                        case 3: IslemDurumu = enmIslemDurumu.ISLEM_HATA_VAR; break;
                        default: break;
                    }
                }
                else if (TankId == 4)
                {
                    switch (PlcTag.Db_tank4_IslemDurumu)
                    {
                        case 0:
                            if (IslemBaslik != null)
                            {
                                IslemBaslik.BITIS_TARIHI = DateTime.Now;
                                db.Islem_Basliklar.Attach(IslemBaslik);
                                db.Entry(IslemBaslik).State = EntityState.Modified;
                                db.SaveChanges();
                            }

                            IslemDurumu = enmIslemDurumu.ISLEM_YOK;
                            break;
                        case 1: IslemDurumu = enmIslemDurumu.ISLEM_BEKLEMEDE; break;
                        case 2: IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR; break;
                        case 3: IslemDurumu = enmIslemDurumu.ISLEM_HATA_VAR; break;
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
            EkranlariEsitle();
        }

        public void Initialize()
        {
            lblTankIsmi.Text = "Tank " + TankId.ToString();
        }
        private string SureFormatla(int deger)
        {
            string sonuc = "";

            try
            {
                TimeSpan result = TimeSpan.FromMinutes(deger);
                return result.Days.ToString() + " Gün " + result.Hours.ToString() + " Saat " + result.Minutes.ToString() + " Dakika";
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                sonuc = "---";
            }
            return sonuc;
        }
        private void timerPeriyodikIslemler_Proses_Tick(object sender, EventArgs e)
        {
            try
            {
                if (PlcTag.IsDemoMod)
                {
                    lblTankIslemAdim.Text = random.Next(1, 50).ToString();
                    lblReceteAdimi.Text = random.Next(1, 50).ToString();
                    lblReceteKalanSure.Text = SureFormatla(random.Next(1, 5000));
                    lblToplamSure.Text = SureFormatla(random.Next(1, 5000));
                    lblToplamKalanSure.Text = SureFormatla(random.Next(1, 5000));
                }
                else
                {
                    if (PLC.Connection)
                    {
                        if (TankId == 1)
                        {
                            lblTankIslemAdim.Text = PlcTag.Db_tank1IslemAdim.ToString();
                            lblReceteAdimi.Text = PlcTag.Db_tank1ProsesAdim.ToString();
                            lblReceteKalanSure.Text = SureFormatla(PlcTag.Db_tank1CalismaZamani);
                            lblToplamSure.Text = SureFormatla(PlcTag.Db_tank1ToplamSure);
                            lblToplamKalanSure.Text = SureFormatla(PlcTag.Db_tank1ToplamKalanSure);
                        }
                        else if (TankId == 2)
                        {
                            lblTankIslemAdim.Text = PlcTag.Db_tank2IslemAdim.ToString();
                            lblReceteAdimi.Text = PlcTag.Db_tank2ProsesAdim.ToString();
                            lblReceteKalanSure.Text = SureFormatla(PlcTag.Db_tank2CalismaZamani);
                            lblToplamSure.Text = SureFormatla(PlcTag.Db_tank2ToplamSure);
                            lblToplamKalanSure.Text = SureFormatla(PlcTag.Db_tank2ToplamKalanSure);
                        }
                        else if (TankId == 3)
                        {
                            lblTankIslemAdim.Text = PlcTag.Db_tank3IslemAdim.ToString();
                            lblReceteAdimi.Text = PlcTag.Db_tank3ProsesAdim.ToString();
                            lblReceteKalanSure.Text = SureFormatla(PlcTag.Db_tank3CalismaZamani);
                            lblToplamSure.Text = SureFormatla(PlcTag.Db_tank3ToplamSure);
                            lblToplamKalanSure.Text = SureFormatla(PlcTag.Db_tank3ToplamKalanSure);
                        }
                        else if (TankId == 4)
                        {
                            lblTankIslemAdim.Text = PlcTag.Db_tank4IslemAdim.ToString();
                            lblReceteAdimi.Text = PlcTag.Db_tank4ProsesAdim.ToString();
                            lblReceteKalanSure.Text = SureFormatla(PlcTag.Db_tank4CalismaZamani);
                            lblToplamSure.Text = SureFormatla(PlcTag.Db_tank4ToplamSure);
                            lblToplamKalanSure.Text = SureFormatla(PlcTag.Db_tank4ToplamKalanSure);
                        }

                        IslemBitmisMiKontrol();
                    }
                    else
                    {
                        //IslemDurumu = enmIslemDurumu.ISLEM_HATA_VAR;
                        EkranlariEsitle();
                    }
                }
            }
            catch (Exception ex)
            {
                IslemDurumu = enmIslemDurumu.ISLEM_HATA_VAR;
                EkranlariEsitle();

                Loglama.Log(ex);
            }
        }
        private void timerPeriyodikIslemler_Degerler_Tick(object sender, EventArgs e)
        {
            try
            {
                if (PlcTag.IsDemoMod)
                {
                    Random r = new Random();

                    PlcTag.Db_tank1AlarmWord = r.Next(0, 15);
                    PlcTag.Db_tank2AlarmWord = r.Next(0, 15);
                    PlcTag.Db_tank3AlarmWord = r.Next(0, 15);
                    PlcTag.Db_tank4AlarmWord = r.Next(0, 15);
                    PlcTag.Db_genelAlarmWord = r.Next(0, 15);

                    PLC.AlarmKontrolEt(1, PlcTag.Db_tank1AlarmWord, PlcTag.Db_tank1AlarmWord_Old, IslemBaslik);
                    PLC.AlarmKontrolEt(2, PlcTag.Db_tank2AlarmWord, PlcTag.Db_tank2AlarmWord_Old, IslemBaslik);
                    PLC.AlarmKontrolEt(3, PlcTag.Db_tank3AlarmWord, PlcTag.Db_tank3AlarmWord_Old, IslemBaslik);
                    PLC.AlarmKontrolEt(4, PlcTag.Db_tank4AlarmWord, PlcTag.Db_tank4AlarmWord_Old, IslemBaslik);
                    PLC.AlarmKontrolEt(5, PlcTag.Db_genelAlarmWord, PlcTag.Db_tank1AlarmWord_Old, IslemBaslik);

                    PlcTag.Db_tank1AlarmWord_Old = PlcTag.Db_tank1AlarmWord;
                    PlcTag.Db_tank2AlarmWord_Old = PlcTag.Db_tank2AlarmWord;
                    PlcTag.Db_tank3AlarmWord_Old = PlcTag.Db_tank3AlarmWord;
                    PlcTag.Db_tank4AlarmWord_Old = PlcTag.Db_tank4AlarmWord;
                    PlcTag.Db_genelAlarmWord_Old = PlcTag.Db_genelAlarmWord;

                    lblTankBasinc_1.Text = Math.Round(random.NextDouble() * 1000, 4, MidpointRounding.AwayFromZero).ToString();
                    lblTankBasinc_2.Text = Math.Round(random.NextDouble() * 1000, 4, MidpointRounding.AwayFromZero).ToString();
                    lblTankSicaklik_1.Text = Math.Round(random.NextDouble() * 1000, 2, MidpointRounding.AwayFromZero).ToString();
                    lblTankSicaklik_2.Text = Math.Round(random.NextDouble() * 1000, 2, MidpointRounding.AwayFromZero).ToString();
                    lblTankSicaklik_3.Text = Math.Round(random.NextDouble() * 1000, 2, MidpointRounding.AwayFromZero).ToString();
                    lblTankSicaklik_4.Text = Math.Round(random.NextDouble() * 1000, 2, MidpointRounding.AwayFromZero).ToString();
                    lblTankSicaklik_5.Text = Math.Round(random.NextDouble() * 1000, 2, MidpointRounding.AwayFromZero).ToString();

                    bool tagVakum = random.Next(2) == 1 ? true : false;
                    bool tagTahliye = random.Next(2) == 1 ? true : false;
                    bool tagRed = random.Next(2) == 1 ? true : false;
                    bool tagYellow = random.Next(2) == 1 ? true : false;
                    bool tagGreen = random.Next(2) == 1 ? true : false;

                    ledTahliyeValfi.BackgroundImage = tagTahliye == true ? Resources.ButtonGreen : Resources.ButtonRed;
                    ledVakumValfi.BackgroundImage = tagVakum == true ? Resources.ButtonGreen : Resources.ButtonRed;
                    ledRed.BackgroundImage = tagRed == true ? Resources.ButtonRed : Resources.ButtonWhite;
                    ledYellow.BackgroundImage = tagYellow == true ? Resources.ButtonYellow : Resources.ButtonWhite;
                    ledGreen.BackgroundImage = tagGreen == true ? Resources.ButtonGreen : Resources.ButtonWhite;

                    lblTahliyeValfDurum.Text = tagTahliye == true ? "Açık" : "Kapalı";
                    lblVakumValfiDurum.Text = tagVakum == true ? "Açık" : "Kapalı";
                }
                else
                {
                    if (PLC.Connection)
                    {
                        if (TankId == 1)
                        {
                            lblTankBasinc_1.Text = Math.Round(PlcTag.Db_kazan12OrtakVakum, 4).ToString();
                            lblTankBasinc_2.Text = Math.Round(PlcTag.Db_kazan1Vakum, 4).ToString();
                            lblTankSicaklik_1.Text = Math.Round(PlcTag.Db_kazan1Sicaklik1, 2).ToString();
                            lblTankSicaklik_2.Text = Math.Round(PlcTag.Db_kazan1Sicaklik2, 2).ToString();
                            lblTankSicaklik_3.Text = Math.Round(PlcTag.Db_kazan1Sicaklik3, 2).ToString();
                            lblTankSicaklik_4.Text = Math.Round(PlcTag.Db_kazan1Sicaklik4, 2).ToString();
                            lblTankSicaklik_5.Text = Math.Round(PlcTag.Db_kazan1Sicaklik5, 2).ToString();

                            ledVakumValfi.BackgroundImage = PlcTag.DB_tank1_VakumValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledTahliyeValfi.BackgroundImage = PlcTag.DB_tank1_TahliyeValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledRed.BackgroundImage = PlcTag.DB_tank1_TepeLambasiKirmizi == true ? Resources.ButtonRed : Resources.ButtonWhite;
                            ledYellow.BackgroundImage = PlcTag.DB_tank1_TepeLambasiSari == true ? Resources.ButtonYellow : Resources.ButtonWhite;
                            ledGreen.BackgroundImage = PlcTag.DB_tank1_TepeLambasiYesil == true ? Resources.ButtonGreen : Resources.ButtonWhite;

                            lblTahliyeValfDurum.Text = PlcTag.DB_tank1_TahliyeValfi == true ? "Açık" : "Kapalı";
                            lblVakumValfiDurum.Text = PlcTag.DB_tank1_VakumValfi == true ? "Açık" : "Kapalı";

                            if (PlcTag.Db_tank1AlarmWord > PlcTag.Db_tank1AlarmWord_Old)
                            {
                                PLC.AlarmKontrolEt(1, PlcTag.Db_tank1AlarmWord, PlcTag.Db_tank1AlarmWord_Old, IslemBaslik);
                            }

                            PlcTag.Db_tank1AlarmWord_Old = PlcTag.Db_tank1AlarmWord;

                        }
                        else if (TankId == 2)
                        {
                            lblTankBasinc_1.Text = Math.Round(PlcTag.Db_kazan12OrtakVakum, 4).ToString();
                            lblTankBasinc_2.Text = Math.Round(PlcTag.Db_kazan2Vakum, 4).ToString();
                            lblTankSicaklik_1.Text = Math.Round(PlcTag.Db_kazan2Sicaklik1, 2).ToString();
                            lblTankSicaklik_2.Text = Math.Round(PlcTag.Db_kazan2Sicaklik2, 2).ToString();
                            lblTankSicaklik_3.Text = Math.Round(PlcTag.Db_kazan2Sicaklik3, 2).ToString();
                            lblTankSicaklik_4.Text = Math.Round(PlcTag.Db_kazan2Sicaklik4, 2).ToString();
                            lblTankSicaklik_5.Text = Math.Round(PlcTag.Db_kazan2Sicaklik5, 2).ToString();

                            ledVakumValfi.BackgroundImage = PlcTag.DB_tank2_VakumValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledTahliyeValfi.BackgroundImage = PlcTag.DB_tank2_TahliyeValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledRed.BackgroundImage = PlcTag.DB_tank2_TepeLambasiKirmizi == true ? Resources.ButtonRed : Resources.ButtonWhite;
                            ledYellow.BackgroundImage = PlcTag.DB_tank2_TepeLambasiSari == true ? Resources.ButtonYellow : Resources.ButtonWhite;
                            ledGreen.BackgroundImage = PlcTag.DB_tank2_TepeLambasiYesil == true ? Resources.ButtonGreen : Resources.ButtonWhite;

                            lblTahliyeValfDurum.Text = PlcTag.DB_tank2_TahliyeValfi == true ? "Açık" : "Kapalı";
                            lblVakumValfiDurum.Text = PlcTag.DB_tank2_VakumValfi == true ? "Açık" : "Kapalı";

                            if (PlcTag.Db_tank2AlarmWord > PlcTag.Db_tank2AlarmWord_Old)
                            {
                                PLC.AlarmKontrolEt(2, PlcTag.Db_tank2AlarmWord, PlcTag.Db_tank2AlarmWord_Old, IslemBaslik);
                            }
                            PlcTag.Db_tank2AlarmWord_Old = PlcTag.Db_tank2AlarmWord;

                        }
                        else if (TankId == 3)
                        {
                            lblTankBasinc_1.Text = Math.Round(PlcTag.Db_kazan34OrtakVakum, 4).ToString();
                            lblTankBasinc_2.Text = Math.Round(PlcTag.Db_kazan3Vakum, 4).ToString();
                            lblTankSicaklik_1.Text = Math.Round(PlcTag.Db_kazan3Sicaklik1, 2).ToString();
                            lblTankSicaklik_2.Text = Math.Round(PlcTag.Db_kazan3Sicaklik2, 2).ToString();
                            lblTankSicaklik_3.Text = Math.Round(PlcTag.Db_kazan3Sicaklik3, 2).ToString();
                            lblTankSicaklik_4.Text = Math.Round(PlcTag.Db_kazan3Sicaklik4, 2).ToString();
                            lblTankSicaklik_5.Text = Math.Round(PlcTag.Db_kazan3Sicaklik5, 2).ToString();

                            ledVakumValfi.BackgroundImage = PlcTag.DB_tank3_VakumValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledTahliyeValfi.BackgroundImage = PlcTag.DB_tank3_TahliyeValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledRed.BackgroundImage = PlcTag.DB_tank3_TepeLambasiKirmizi == true ? Resources.ButtonRed : Resources.ButtonWhite;
                            ledYellow.BackgroundImage = PlcTag.DB_tank3_TepeLambasiSari == true ? Resources.ButtonYellow : Resources.ButtonWhite;
                            ledGreen.BackgroundImage = PlcTag.DB_tank3_TepeLambasiYesil == true ? Resources.ButtonGreen : Resources.ButtonWhite;

                            lblTahliyeValfDurum.Text = PlcTag.DB_tank3_TahliyeValfi == true ? "Açık" : "Kapalı";
                            lblVakumValfiDurum.Text = PlcTag.DB_tank3_VakumValfi == true ? "Açık" : "Kapalı";

                            if (PlcTag.Db_tank3AlarmWord > PlcTag.Db_tank3AlarmWord_Old)
                            {
                                PLC.AlarmKontrolEt(3, PlcTag.Db_tank3AlarmWord, PlcTag.Db_tank3AlarmWord_Old, IslemBaslik);
                            }

                            PlcTag.Db_tank3AlarmWord_Old = PlcTag.Db_tank3AlarmWord;
                        }
                        else if (TankId == 4)
                        {

                            lblTankBasinc_1.Text = Math.Round(PlcTag.Db_kazan34OrtakVakum, 4).ToString();
                            lblTankBasinc_2.Text = Math.Round(PlcTag.Db_kazan4Vakum, 4).ToString();
                            lblTankSicaklik_1.Text = Math.Round(PlcTag.Db_kazan4Sicaklik1, 2).ToString();
                            lblTankSicaklik_2.Text = Math.Round(PlcTag.Db_kazan4Sicaklik2, 2).ToString();
                            lblTankSicaklik_3.Text = Math.Round(PlcTag.Db_kazan4Sicaklik3, 2).ToString();
                            lblTankSicaklik_4.Text = Math.Round(PlcTag.Db_kazan4Sicaklik4, 2).ToString();
                            lblTankSicaklik_5.Text = Math.Round(PlcTag.Db_kazan4Sicaklik5, 2).ToString();

                            ledVakumValfi.BackgroundImage = PlcTag.DB_tank4_VakumValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledTahliyeValfi.BackgroundImage = PlcTag.DB_tank4_TahliyeValfi == true ? Resources.ButtonGreen : Resources.ButtonRed;
                            ledRed.BackgroundImage = PlcTag.DB_tank4_TepeLambasiKirmizi == true ? Resources.ButtonRed : Resources.ButtonWhite;
                            ledYellow.BackgroundImage = PlcTag.DB_tank4_TepeLambasiSari == true ? Resources.ButtonYellow : Resources.ButtonWhite;
                            ledGreen.BackgroundImage = PlcTag.DB_tank4_TepeLambasiYesil == true ? Resources.ButtonGreen : Resources.ButtonWhite;

                            lblTahliyeValfDurum.Text = PlcTag.DB_tank4_TahliyeValfi == true ? "Açık" : "Kapalı";
                            lblVakumValfiDurum.Text = PlcTag.DB_tank4_VakumValfi == true ? "Açık" : "Kapalı";

                            if (PlcTag.Db_tank4AlarmWord > PlcTag.Db_tank4AlarmWord_Old)
                            {
                                PLC.AlarmKontrolEt(4, PlcTag.Db_tank4AlarmWord, PlcTag.Db_tank4AlarmWord_Old, IslemBaslik);
                            }

                            PlcTag.Db_tank4AlarmWord_Old = PlcTag.Db_tank4AlarmWord;

                        }


                        if (PlcTag.Db_genelAlarmWord > PlcTag.Db_genelAlarmWord_Old)//ekledim
                        {
                            PLC.AlarmKontrolEtGenel(PlcTag.Db_genelAlarmWord, PlcTag.Db_genelAlarmWord_Old, IslemBaslik);
                        }
                        PlcTag.Db_genelAlarmWord_Old = PlcTag.Db_genelAlarmWord;
                    }
                }

                ledVakumValfi.Refresh();
                ledTahliyeValfi.Refresh();
                ledRed.Refresh();
                ledYellow.Refresh();
                ledGreen.Refresh();

                IslemDurumKontrolEt();
            }
            catch (Exception ex)
            {
                IslemDurumu = enmIslemDurumu.ISLEM_HATA_VAR;
                EkranlariEsitle();

                Loglama.Log(ex);
            }
        }
        public void IslemBitmisMiKontrol()
        {
            try
            {
                if (PLC.IsBitSet(PlcTag.Db_KontrolByte00, 1))
                {
                    PLC.MailAt(TankId + " Nolu Tanktaki Proses Bitti.", "İşlem Adı: " + IslemBaslik.ISLEM_ADI + "\nReçete Adı: " + SecilenRecete.RECETE_ADI);

                    if (tank1_popUp == null || tank1_popUp.IsDisposed)
                    {
                        tank1_popUp = new Tank1_PopUp();
                        tank1_popUp.Show();
                    }
                }

                if (PLC.IsBitSet(PlcTag.Db_KontrolByte00, 4))
                {
                    PLC.MailAt(TankId + " Nolu Tanktaki Proses Bitti.", "İşlem Adı: " + IslemBaslik.ISLEM_ADI + "\nReçete Adı: " + SecilenRecete.RECETE_ADI);

                    if (tank2_popUp == null || tank2_popUp.IsDisposed)
                    {
                        tank2_popUp = new Tank2_PopUp();
                        tank2_popUp.Show();
                    }
                }
                if (PLC.IsBitSet(PlcTag.Db_KontrolByte00, 7))
                {
                    PLC.MailAt(TankId + " Nolu Tanktaki Proses Bitti.", "İşlem Adı: " + IslemBaslik.ISLEM_ADI + "\nReçete Adı: " +  SecilenRecete.RECETE_ADI);

                    if (tank3_popUp == null || tank3_popUp.IsDisposed)
                    {
                        tank3_popUp = new Tank3_PopUp();
                        tank3_popUp.Show();
                    }
                }
                if (PLC.IsBitSet(PlcTag.Db_KontrolByte01, 2))
                {
                    PLC.MailAt(TankId + " Nolu Tanktaki Proses Bitti.", "İşlem Adı: " + IslemBaslik.ISLEM_ADI + "\nReçete Adı: " + SecilenRecete.RECETE_ADI);

                    if (tank4_popUp == null || tank4_popUp.IsDisposed)
                    {
                        tank4_popUp = new Tank4_PopUp();
                        tank4_popUp.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }
        public void IslemDurumuDegistir(enmIslemDurumu IslemDurumuGelen)
        {
            IslemDurumu = IslemDurumuGelen;
        }
        public void EkranlariEsitle()
        {
            try
            {
                tankGoruntuleme.IslemDurumu = IslemDurumu;
                tankGoruntuleme.SecilenRecete = SecilenRecete;
                tankGoruntuleme.IslemBaslik = IslemBaslik;

                if (IslemBaslik != null)
                {
                    tankGoruntuleme.lblIslemAdi.Text = IslemBaslik.ISLEM_ADI;

                    tankGoruntuleme.lstTrafolar.Items.Clear();

                    if (IslemBaslik.TRAFO_1.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_1); }
                    if (IslemBaslik.TRAFO_2.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_2); }
                    if (IslemBaslik.TRAFO_3.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_3); }
                    if (IslemBaslik.TRAFO_4.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_4); }
                    if (IslemBaslik.TRAFO_5.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_5); }
                    if (IslemBaslik.TRAFO_6.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_6); }
                    if (IslemBaslik.TRAFO_7.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_7); }
                    if (IslemBaslik.TRAFO_8.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_8); }
                    if (IslemBaslik.TRAFO_9.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_9); }
                    if (IslemBaslik.TRAFO_10.Trim() != string.Empty) { tankGoruntuleme.lstTrafolar.Items.Add(IslemBaslik.TRAFO_10); }

                    tankGoruntuleme.lblBaslangic.Text = ((DateTime)IslemBaslik.BASLANGIC_TARIHI).ToString("dd-MM-yyyy HH:mm");
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            try
            {
                ISLEM_BASLIK islemBaslikGelen;

                if (IslemDurumu == enmIslemDurumu.ISLEM_YOK)
                {
                    using (var form = new frmReceteSecim())
                    {
                        if (form.ShowDialog() != DialogResult.OK)
                        {
                            return;
                        }

                        SecilenRecete = form.SecilenRecete;
                        islemBaslikGelen = form.IslemBaslik;
                    }

                    if (SecilenRecete != null)
                    {
                        if (!PlcTag.IsDemoMod)
                        {
                            lblIslemDurumu.Text = "Değerler PLC'ye Yükleniyor";
                            if (PLC.ReceteVerileriGonder(SecilenRecete, TankId)) //donen deger true ise ekledim
                            {
                                PlcTag.islemBaslatiliyor = true;

                                //donen deger true ise 
                                if (TankId == 1)
                                {
                                    PLC.WriteBool(1, 0, 2, 1);
                                }
                                else if (TankId == 2)
                                {
                                    PLC.WriteBool(1, 0, 5, 1);
                                }
                                else if (TankId == 3)
                                {
                                    PLC.WriteBool(1, 1, 0, 1);
                                }
                                else if (TankId == 4)
                                {
                                    PLC.WriteBool(1, 1, 3, 1);
                                }


                                PLC.ReadByte2(1, 202, 10);

                                if (TankId == 1)
                                {
                                    if (PlcTag.Db_tank1_IslemDurumu == 2)
                                        IslemBaslikAc(islemBaslikGelen);
                                }
                                else if (TankId == 2)
                                {
                                    if (PlcTag.Db_tank2_IslemDurumu == 2)
                                        IslemBaslikAc(islemBaslikGelen);
                                }
                                else if (TankId == 3)
                                {
                                    if (PlcTag.Db_tank3_IslemDurumu == 2)
                                        IslemBaslikAc(islemBaslikGelen);
                                }

                                else if (TankId == 4)
                                {
                                    if (PlcTag.Db_tank4_IslemDurumu == 2)
                                        IslemBaslikAc(islemBaslikGelen);
                                }

                                //IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                            }
                        }
                        else
                        {
                            IslemBaslikAc(islemBaslikGelen);

                            IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR;

                            if (TankId == 1)
                            {
                                PlcTag.Db_tank1_IslemDurumu = (int)enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                            }
                            else if (TankId == 2)
                            {
                                PlcTag.Db_tank2_IslemDurumu = (int)enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                            }
                            else if (TankId == 3)
                            {
                                PlcTag.Db_tank3_IslemDurumu = (int)enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                            }
                            else if (TankId == 4)
                            {
                                PlcTag.Db_tank4_IslemDurumu = (int)enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Reçete Seçilmedi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show(TankId.ToString() + " Nolu Tanktaki Prosesi Bitirmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }

                    IslemBaslik.BITIS_TARIHI = DateTime.Now;
                    db.Islem_Basliklar.Attach(IslemBaslik);
                    db.Entry(IslemBaslik).State = EntityState.Modified;
                    db.SaveChanges();

                    if (PlcTag.IsDemoMod)
                    {
                        if (TankId == 1)
                        {
                            PlcTag.Db_tank1_IslemDurumu = (int)enmIslemDurumu.ISLEM_YOK;
                        }
                        else if (TankId == 2)
                        {
                            PlcTag.Db_tank2_IslemDurumu = (int)enmIslemDurumu.ISLEM_YOK;
                        }
                        else if (TankId == 3)
                        {
                            PlcTag.Db_tank3_IslemDurumu = (int)enmIslemDurumu.ISLEM_YOK;
                        }
                        else if (TankId == 4)
                        {
                            PlcTag.Db_tank4_IslemDurumu = (int)enmIslemDurumu.ISLEM_YOK;
                        }
                    }
                    else
                    {
                        if (TankId == 1)
                        {
                            PLC.WriteBool(1, 0, 2, 0);
                        }
                        else if (TankId == 2)
                        {
                            PLC.WriteBool(1, 0, 5, 0);
                        }
                        else if (TankId == 3)
                        {
                            PLC.WriteBool(1, 1, 0, 0);
                        }
                        else if (TankId == 4)
                        {
                            PLC.WriteBool(1, 1, 3, 0);
                        }
                    }
                }

                EkranlariEsitle();
                lblIslemRecete.Text = SecilenRecete.RECETE_ADI;

                PlcTag.islemBaslatiliyor = false;
            }
            catch (Exception ex)
            {
                PlcTag.islemBaslatiliyor = false;
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        void IslemBaslikAc(ISLEM_BASLIK islemBaslikGelen)
        {
            try
            {
                IslemBaslik = new ISLEM_BASLIK()
                {
                    BASLANGIC_TARIHI = DateTime.Now,
                    ISLEM_ADI = islemBaslikGelen.ISLEM_ADI,
                    TANK_ID = TankId,
                    TRAFO_1 = islemBaslikGelen.TRAFO_1,
                    TRAFO_2 = islemBaslikGelen.TRAFO_2,
                    TRAFO_3 = islemBaslikGelen.TRAFO_3,
                    TRAFO_4 = islemBaslikGelen.TRAFO_4,
                    TRAFO_5 = islemBaslikGelen.TRAFO_5,
                    TRAFO_6 = islemBaslikGelen.TRAFO_6,
                    TRAFO_7 = islemBaslikGelen.TRAFO_7,
                    TRAFO_8 = islemBaslikGelen.TRAFO_8,
                    TRAFO_9 = islemBaslikGelen.TRAFO_9,
                    TRAFO_10 = islemBaslikGelen.TRAFO_10,

                };

                db.Islem_Basliklar.Add(IslemBaslik);
                db.SaveChanges();
                Tank_Functions.IslemReceteEkle(IslemBaslik, SecilenRecete);
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            try
            {
                if (IslemDurumu == enmIslemDurumu.ISLEM_HATA_VAR)
                {
                    if (!PLC.Connection)
                    {
                        if (PLC.Connect("192.168.0.10"))//degistirdim konrol et ip ile degiştir
                        {
                            IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                        }
                    }
                    else
                    {
                        IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                    }
                }
                else
                {
                    if (IslemDurumu == enmIslemDurumu.ISLEM_BEKLEMEDE)
                    {
                        using (var form = new frmReceteSecim(IslemBaslik))
                        {
                            if (form.ShowDialog() != DialogResult.OK)
                            {
                                return;
                            }

                            ISLEM_BASLIK ib = form.IslemBaslik;
                            EkranlariEsitle();
                        }

                        if (TankId == 1)
                        {
                            PLC.WriteBool(1, 1, 5, 0);
                        }
                        else if (TankId == 2)
                        {
                            PLC.WriteBool(1, 1, 6, 0);
                        }
                        else if (TankId == 3)
                        {
                            PLC.WriteBool(1, 1, 7, 0);
                        }
                        else if (TankId == 4)
                        {
                            PLC.WriteBool(1, 2, 0, 0);
                        }

                        //IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                    }
                    else
                    {
                        if (TankId == 1)
                        {
                            PLC.WriteBool(1, 1, 5, 1);
                        }
                        else if (TankId == 2)
                        {
                            PLC.WriteBool(1, 1, 6, 1);
                        }
                        else if (TankId == 3)
                        {
                            PLC.WriteBool(1, 1, 7, 1);
                        }
                        else if (TankId == 4)
                        {
                            PLC.WriteBool(1, 2, 0, 1);
                        }

                        // IslemDurumu = enmIslemDurumu.ISLEM_BEKLEMEDE;
                    }
                }
                EkranlariEsitle();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnTahliye_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlcTag.IsDemoMod)
                {
                    MessageBox.Show("Tank Tahliye İşlemi Başladı.");
                }
                else
                {
                    if (TankId == 1)
                    {
                        PLC.WriteBool(1, 2, 1, 1);
                    }
                    else if (TankId == 2)
                    {
                        PLC.WriteBool(1, 2, 2, 1);
                    }
                    else if (TankId == 3)
                    {
                        PLC.WriteBool(1, 2, 3, 1);
                    }
                    else if (TankId == 4)
                    {
                        PLC.WriteBool(1, 2, 4, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblIslemRecete_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(lblIslemDurumu.Text.Trim()) || lblIslemDurumu.Text.Trim() != "-")
                {
                    frmIslemRecete islemRecete = new frmIslemRecete(IslemBaslik.ISLEM_BASLIK_ID);
                    islemRecete.Show();
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