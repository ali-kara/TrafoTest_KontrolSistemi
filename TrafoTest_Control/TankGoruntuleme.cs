using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TrafoTest_Lib;
using System.IO;
using System.Diagnostics;
using System.Data.Entity;
using TrafoTest_Model.Model;

namespace TrafoTest_Control
{
    public partial class TankGoruntuleme : MyUserControl
    {
        Point? clickPosition { get; set; }
        ToolTip tooltip { get; set; }
        public Timer timerPeriyodikIslemler { get; set; }
        Random random { get; set; }
        public int TankId { get; set; }
        public ISLEM_BASLIK IslemBaslik { get; set; }
        public RECETELER SecilenRecete { get; set; }
        public TankGosterge tankGosterge { get; set; }

        public void TankIsmiAta(int _TankId)
        {
            TankId = _TankId;
        }

        private enmIslemDurumu _IslemDurumu;
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
                    btnBaslat.Text = "Bitir";

                    btnDurdur.Enabled = true;
                    btnDurdur.Text = "Duraklat";

                    timerPeriyodikIslemler.Enabled = true;
                }
                else if (_IslemDurumu == enmIslemDurumu.ISLEM_BEKLEMEDE)
                {
                    btnBaslat.Text = "Bitir";

                    btnDurdur.Enabled = true;
                    btnDurdur.Text = "Devam Ettir";

                    timerPeriyodikIslemler.Enabled = false;
                }
                else if (_IslemDurumu == enmIslemDurumu.ISLEM_HATA_VAR)
                {
                    btnBaslat.Text = "Bitir";

                    btnDurdur.Enabled = true;
                    btnDurdur.Text = "Devam Ettir";

                    timerPeriyodikIslemler.Enabled = false;
                }
                else
                {
                    btnBaslat.Text = "Başlat";

                    btnDurdur.Enabled = false;
                    btnDurdur.Text = "Duraklat";

                    lblIslemAdi.Text = "-";
                    lstTrafolar.Items.Clear();

                    lblBaslangic.Text = "-";
                    lblToplamSure.Text = "-";

                    timerPeriyodikIslemler.Enabled = false;

                    SecilenRecete = null;
                    IslemBaslik = null;
                }
            }
        }

        public TankGoruntuleme()
        {
            InitializeComponent();

            tooltip = new ToolTip();
            random = new Random();

            timerPeriyodikIslemler = new Timer();
            timerPeriyodikIslemler.Interval = 1000;
            timerPeriyodikIslemler.Tick += TimerPeriyodikIslemler_Tick;
        }

        private void TankGoruntuleme_Load(object sender, EventArgs e)
        {
            InitialLoad();
        }
        public void InitialLoad()
        {
            //var chartAreaBasinc = chart1.ChartAreas[chart1.Series[0].ChartArea];
            //var chartAreaBasinc2 = chart1.ChartAreas[chart1.Series[1].ChartArea];
            //chartAreaBasinc.AxisY2.ScaleView.Zoom(-4, 3);
            //chartAreaBasinc2.AxisY2.ScaleView.Zoom(-4, 3);
            //chartAreaBasinc.AxisX.ScaleView.Zoom(0, 100);
        }

        private void TimerPeriyodikIslemler_Tick(object sender, EventArgs e)
        {
            try
            {
                if (IslemBaslik != null)
                {
                    if (PlcTag.IsDemoMod)
                    {
                        //ISLEM_DETAY islemDetay = new ISLEM_DETAY
                        //{
                        //    BASINC_1 = Math.Round(random.NextDouble() * 1, 4, MidpointRounding.AwayFromZero),
                        //    BASINC_2 = Math.Round(random.NextDouble() * 1, 4, MidpointRounding.AwayFromZero),
                        //    SICAKLIK_1 = Math.Round(random.NextDouble() * 150, 2, MidpointRounding.AwayFromZero),
                        //    SICAKLIK_2 = Math.Round(random.NextDouble() * 150, 2, MidpointRounding.AwayFromZero),
                        //    SICAKLIK_3 = Math.Round(random.NextDouble() * 150, 2, MidpointRounding.AwayFromZero),
                        //    SICAKLIK_4 = Math.Round(random.NextDouble() * 150, 2, MidpointRounding.AwayFromZero),
                        //    SICAKLIK_5 = Math.Round(random.NextDouble() * 150, 2, MidpointRounding.AwayFromZero),
                        //    EKLE_LOG_TARIH = DateTime.Now,
                        //    ISLEM_BASLIK_ID = IslemBaslik.ISLEM_BASLIK_ID,
                        //};

                        ISLEM_DETAY islemDetay = new ISLEM_DETAY
                        {
                            BASINC_1 = Math.Round(random.NextDouble() * 1, 4, MidpointRounding.AwayFromZero),
                            BASINC_2 = Math.Round(random.NextDouble() * 1, 4, MidpointRounding.AwayFromZero),
                            SICAKLIK_1 = random.Next(80, 95),
                            SICAKLIK_2 = random.Next(95, 110),
                            SICAKLIK_3 = random.Next(100, 120),
                            SICAKLIK_4 = random.Next(120, 150),
                            SICAKLIK_5 = random.Next(130, 150),
                            EKLE_LOG_TARIH = DateTime.Now,
                            ISLEM_BASLIK_ID = IslemBaslik.ISLEM_BASLIK_ID,
                        };


                        db.Islem_Detaylar.Add(islemDetay);
                        db.SaveChanges();

                        RefreshView(islemDetay);
                    }
                    else
                    {
                        ISLEM_DETAY islemDetay = new ISLEM_DETAY();
                        islemDetay.ISLEM_BASLIK_ID = IslemBaslik.ISLEM_BASLIK_ID;
                        islemDetay.EKLE_LOG_TARIH = DateTime.Now;

                        if (TankId == 1)
                        {
                            islemDetay.BASINC_1 = Math.Round(PlcTag.Db_kazan12OrtakVakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.BASINC_2 = Math.Round(PlcTag.Db_kazan1Vakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_1 = Math.Round(PlcTag.Db_kazan1Sicaklik1, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_2 = Math.Round(PlcTag.Db_kazan1Sicaklik2, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_3 = Math.Round(PlcTag.Db_kazan1Sicaklik3, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_4 = Math.Round(PlcTag.Db_kazan1Sicaklik4, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_5 = Math.Round(PlcTag.Db_kazan1Sicaklik5, 4, MidpointRounding.AwayFromZero);
                        }
                        else if (TankId == 2)
                        {
                            islemDetay.BASINC_1 = Math.Round(PlcTag.Db_kazan12OrtakVakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.BASINC_2 = Math.Round(PlcTag.Db_kazan2Vakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_1 = Math.Round(PlcTag.Db_kazan2Sicaklik1, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_2 = Math.Round(PlcTag.Db_kazan2Sicaklik2, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_3 = Math.Round(PlcTag.Db_kazan2Sicaklik3, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_4 = Math.Round(PlcTag.Db_kazan2Sicaklik4, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_5 = Math.Round(PlcTag.Db_kazan2Sicaklik5, 4, MidpointRounding.AwayFromZero);
                        }
                        else if (TankId == 3)
                        {
                            islemDetay.BASINC_1 = Math.Round(PlcTag.Db_kazan34OrtakVakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.BASINC_2 = Math.Round(PlcTag.Db_kazan3Vakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_1 = Math.Round(PlcTag.Db_kazan3Sicaklik1, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_2 = Math.Round(PlcTag.Db_kazan3Sicaklik2, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_3 = Math.Round(PlcTag.Db_kazan3Sicaklik3, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_4 = Math.Round(PlcTag.Db_kazan3Sicaklik4, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_5 = Math.Round(PlcTag.Db_kazan3Sicaklik5, 4, MidpointRounding.AwayFromZero);
                        }
                        else if (TankId == 4)
                        {
                            islemDetay.BASINC_1 = Math.Round(PlcTag.Db_kazan34OrtakVakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.BASINC_2 = Math.Round(PlcTag.Db_kazan4Vakum, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_1 = Math.Round(PlcTag.Db_kazan4Sicaklik1, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_2 = Math.Round(PlcTag.Db_kazan4Sicaklik2, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_3 = Math.Round(PlcTag.Db_kazan4Sicaklik3, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_4 = Math.Round(PlcTag.Db_kazan4Sicaklik4, 4, MidpointRounding.AwayFromZero);
                            islemDetay.SICAKLIK_5 = Math.Round(PlcTag.Db_kazan4Sicaklik5, 4, MidpointRounding.AwayFromZero);
                        }

                        db.Islem_Detaylar.Add(islemDetay);
                        db.SaveChanges();
                        RefreshView(islemDetay);
                    }
                }
                else
                {
                    //MessageBox.Show("İslem Başlatılmadı", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Normalde işlem yokken PLC'den başladı biti gelirse.
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
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
                tankGosterge.IslemDurumu = IslemDurumu;
                tankGosterge.SecilenRecete = SecilenRecete;
                tankGosterge.IslemBaslik = IslemBaslik;
                tankGosterge.lblBaslangic.Text = ((DateTime)IslemBaslik.BASLANGIC_TARIHI).ToString("dd-MM-yyyy HH:mm");
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }
        public void addValues(List<ISLEM_DETAY> ListIslemDetay)
        {
            for (int i = 0; i < ListIslemDetay.Count; i++)
            {
                ISLEM_DETAY islemDetay = ListIslemDetay[i] as ISLEM_DETAY;

                chart1.Series["Basinc1"].Points.AddY(islemDetay.BASINC_1);
                chart1.Series["Basinc2"].Points.AddY(islemDetay.BASINC_2);
                chart1.Series["Sicaklik1"].Points.AddY(islemDetay.SICAKLIK_1);
                chart1.Series["Sicaklik2"].Points.AddY(islemDetay.SICAKLIK_2);
                chart1.Series["Sicaklik3"].Points.AddY(islemDetay.SICAKLIK_3);
                chart1.Series["Sicaklik4"].Points.AddY(islemDetay.SICAKLIK_4);
                chart1.Series["Sicaklik5"].Points.AddY(islemDetay.SICAKLIK_5);
            }
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
        public void RefreshView(ISLEM_DETAY islemDetay)
        {
            try
            {
                if (PlcTag.IsDemoMod)
                {
                    lblToplamSure.Text = SureFormatla(random.Next(1, 5000));
                }
                else
                {
                    if (TankId == 1)
                    {
                        lblToplamSure.Text = SureFormatla(PlcTag.Db_tank1ToplamSure);
                    }
                    else if (TankId == 2)
                    {
                        lblToplamSure.Text = SureFormatla(PlcTag.Db_tank2ToplamSure);
                    }
                    else if (TankId == 3)
                    {
                        lblToplamSure.Text = SureFormatla(PlcTag.Db_tank3ToplamSure);
                    }
                    else if (TankId == 4)
                    {
                        lblToplamSure.Text = SureFormatla(PlcTag.Db_tank4ToplamSure);
                    }
                }

                chart1.Series["Basinc1"].Points.AddY(islemDetay.BASINC_1);
                chart1.Series["Basinc2"].Points.AddY(islemDetay.BASINC_2);
                chart1.Series["Sicaklik1"].Points.AddY(islemDetay.SICAKLIK_1);
                chart1.Series["Sicaklik2"].Points.AddY(islemDetay.SICAKLIK_2);
                chart1.Series["Sicaklik3"].Points.AddY(islemDetay.SICAKLIK_3);
                chart1.Series["Sicaklik4"].Points.AddY(islemDetay.SICAKLIK_4);
                chart1.Series["Sicaklik5"].Points.AddY(islemDetay.SICAKLIK_5);

                if (chkEkraniKaydir.Checked)
                {
                    chart1.ChartAreas[chart1.Series[0].ChartArea].AxisX.ScaleView.Position = chart1.ChartAreas[chart1.Series[0].ChartArea].AxisX.Maximum;
                    chart1.ChartAreas[chart1.Series[0].ChartArea].AxisX.ScaleView.Zoom(chart1.ChartAreas[chart1.Series[0].ChartArea].AxisX.Maximum - 100, chart1.ChartAreas[chart1.Series[0].ChartArea].AxisX.Maximum);
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        public string EkranGoruntusuAl(List<ISLEM_DETAY> list)
        {
            addValues(list);


            string asd =
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                + "\\ScreenShot_" +
                DateTime.Now.Date.Day.ToString() +
                DateTime.Now.Date.Month.ToString() +
                DateTime.Now.Date.Year.ToString() +
                "_" +
                DateTime.Now.Hour.ToString() +
                DateTime.Now.Minute.ToString() +
                ".png";

            chart1.SaveImage(asd, ChartImageFormat.Png);

            return asd;
        }
        void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickPosition.HasValue && e.Location != clickPosition)
            {
                tooltip.RemoveAll();
                clickPosition = null;
            }
        }
        void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            clickPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                         ChartElementType.PlottingArea);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);

                    tooltip.Show("X=" + xVal + ", Y=" + yVal,
                                 this.chart1, e.Location.X, e.Location.Y - 15);
                }
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
                        IslemBaslik = new ISLEM_BASLIK()
                        {
                            BASLANGIC_TARIHI = DateTime.Now,
                            ISLEM_ADI = islemBaslikGelen.ISLEM_ADI,
                            TANK_ID = TankId,
                            TRAFO_1 = islemBaslikGelen.TRAFO_1,
                            TRAFO_2 = islemBaslikGelen.TRAFO_2,
                            TRAFO_3 = islemBaslikGelen.TRAFO_3,
                            TRAFO_4 = islemBaslikGelen.TRAFO_4,
                        };

                        db.Islem_Basliklar.Add(IslemBaslik);
                        db.SaveChanges();

                        Tank_Functions.IslemReceteEkle(IslemBaslik, SecilenRecete);

                        if (!PlcTag.IsDemoMod)
                        {
                            PLC.ReceteVerileriGonder(SecilenRecete, TankId);
                        }

                        lblIslemAdi.Text = IslemBaslik.ISLEM_ADI;

                        lstTrafolar.Items.Clear();

                        if (IslemBaslik.TRAFO_1.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_1); }
                        if (IslemBaslik.TRAFO_2.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_2); }
                        if (IslemBaslik.TRAFO_3.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_3); }
                        if (IslemBaslik.TRAFO_4.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_4); }
                        if (IslemBaslik.TRAFO_5.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_5); }
                        if (IslemBaslik.TRAFO_6.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_6); }
                        if (IslemBaslik.TRAFO_7.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_7); }
                        if (IslemBaslik.TRAFO_8.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_8); }
                        if (IslemBaslik.TRAFO_9.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_9); }
                        if (IslemBaslik.TRAFO_10.Trim() != string.Empty) { lstTrafolar.Items.Add(IslemBaslik.TRAFO_10); }




                        //IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                    }
                    else
                    {
                        MessageBox.Show("Reçete Seçilmedi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    IslemBaslik.BITIS_TARIHI = DateTime.Now;
                    db.Islem_Basliklar.Attach(IslemBaslik);
                    db.Entry(IslemBaslik).State = EntityState.Modified;
                    db.SaveChanges();

                    IslemDurumu = enmIslemDurumu.ISLEM_YOK;
                }

                EkranlariEsitle();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
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
                        if (PLC.Connect())
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
                        IslemDurumu = enmIslemDurumu.ISLEM_DEVAM_EDIYOR;
                    }
                    else
                    {
                        IslemDurumu = enmIslemDurumu.ISLEM_BEKLEMEDE;
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            EkraniResetle();
        }
        public void EkraniResetle()
        {
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
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