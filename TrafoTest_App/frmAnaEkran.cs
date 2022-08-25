using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using TrafoTest_App.Properties;
using TrafoTest_App.ReceteIslemleri;
using TrafoTest_App.ToolsUI;
using TrafoTest_Control;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;
using TrafoTest_Model.Model;
using TrafoTest_Lib;

namespace TrafoTest_App
{
    public partial class frmAnaEkran : Form
    {
        TrafoTest_AppDBEntities db { get; set; }
        frmManuel manuel { get; set; }
        frmAlarm alarm { get; set; }
        bool acilisKontrol { get; set; } = false;
        bool PLC_BaglantiMailAtildiMi { get; set; } = false;


        public frmAnaEkran()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            db = new TrafoTest_AppDBEntities();
        }
        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            tankGosterge1.Initialize();
            tankGosterge2.Initialize();
            tankGosterge3.Initialize();
            tankGosterge4.Initialize();

            InitializeTanks();
        }

        private void KalanIslemleriGetir()
        {
            try
            {
                if (PlcTag.Db_tank1_IslemDurumu != (int)enmIslemDurumu.ISLEM_YOK)
                {
                    ISLEM_BASLIK tank1_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 1).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();
                    if (!tank1_islem.BITIS_TARIHI.HasValue)
                    {
                        tankGoruntuleme1.IslemBaslik = tank1_islem;
                        tankGosterge1.IslemDurumu = (enmIslemDurumu)PlcTag.Db_tank1_IslemDurumu;
                        tankGosterge1.IslemBaslik = tank1_islem;
                        tankGosterge1.EkranlariEsitle();
                        tankGoruntuleme1.EkranlariEsitle();
                    }
                }
                if (PlcTag.Db_tank2_IslemDurumu != (int)enmIslemDurumu.ISLEM_YOK)
                {
                    ISLEM_BASLIK tank2_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 2).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();
                    if (!tank2_islem.BITIS_TARIHI.HasValue)
                    {
                        tankGoruntuleme2.IslemBaslik = tank2_islem;
                        tankGosterge2.IslemDurumu = (enmIslemDurumu)PlcTag.Db_tank2_IslemDurumu;
                        tankGosterge2.IslemBaslik = tank2_islem;
                        tankGosterge2.EkranlariEsitle();
                        tankGoruntuleme2.EkranlariEsitle();
                    }
                }
                if (PlcTag.Db_tank3_IslemDurumu != (int)enmIslemDurumu.ISLEM_YOK)
                {
                    ISLEM_BASLIK tank3_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 3).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();
                    if (!tank3_islem.BITIS_TARIHI.HasValue)
                    {
                        tankGoruntuleme3.IslemBaslik = tank3_islem;
                        tankGosterge3.IslemDurumu = (enmIslemDurumu)PlcTag.Db_tank3_IslemDurumu;
                        tankGosterge3.IslemBaslik = tank3_islem;
                        tankGosterge3.EkranlariEsitle();
                        tankGoruntuleme3.EkranlariEsitle();
                    }
                }
                if (PlcTag.Db_tank4_IslemDurumu != (int)enmIslemDurumu.ISLEM_YOK)
                {
                    ISLEM_BASLIK tank4_islem = db.Islem_Basliklar.Where(x => x.TANK_ID == 4).OrderByDescending(x => x.ISLEM_BASLIK_ID).FirstOrDefault();
                    if (!tank4_islem.BITIS_TARIHI.HasValue)
                    {
                        tankGoruntuleme4.IslemBaslik = tank4_islem;
                        tankGosterge4.IslemDurumu = (enmIslemDurumu)PlcTag.Db_tank4_IslemDurumu;
                        tankGosterge4.IslemBaslik = tank4_islem;
                        tankGosterge4.EkranlariEsitle();
                        tankGoruntuleme4.EkranlariEsitle();
                    }
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void InitializeTanks()
        {
            try
            {
                tankGosterge1.tankGoruntuleme = tankGoruntuleme1;
                tankGosterge2.tankGoruntuleme = tankGoruntuleme2;
                tankGosterge3.tankGoruntuleme = tankGoruntuleme3;
                tankGosterge4.tankGoruntuleme = tankGoruntuleme4;

                tankGoruntuleme1.tankGosterge = tankGosterge1;
                tankGoruntuleme2.tankGosterge = tankGosterge2;
                tankGoruntuleme3.tankGosterge = tankGosterge3;
                tankGoruntuleme4.tankGosterge = tankGosterge4;

                try
                {
                    PlcTag.IsDemoMod = Settings.Default.DemoMod;
                }
                catch
                {
                    
                }


                tankGoruntuleme1.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;
                tankGoruntuleme2.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;
                tankGoruntuleme3.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;
                tankGoruntuleme4.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;

                //Ekranda gözüken değerleri gösteren timer
                tankGosterge1.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;
                tankGosterge2.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;
                tankGosterge3.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;
                tankGosterge4.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;

                PlcTag.mailList = Settings.Default.MailAdresleri.ToString().Split(';').ToList();

                //Task.Run(() => PLCBaglan());
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmAnaEkran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.E)
            {
                frmExceptions ex = new frmExceptions();
                ex.ShowDialog();
            }
        }
        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.E)
            {
                frmExceptions ex = new frmExceptions();
                ex.ShowDialog();
            }
        }
        private void lblDurum_Click(object sender, EventArgs e)
        {
            //if (PLC.Connection)
            //{
            //    if (PLC.IsBitSet(PlcTag.Db_KontrolByte00, 0))
            //    {
            //        if (MessageBox.Show("Otomatik Moddan Çıkmak İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //        {
            //            PLC.WriteBool(1, 0, 0, 0); //Man-Auto işlem secim biti
            //        }
            //    }
            //    else
            //    {
            //        PLC.WriteBool(1, 0, 0, 1);
            //    }
            //}
        }
        private void btnManuel_Click(object sender, EventArgs e)
        {
            if (manuel == null || manuel.IsDisposed)
            {
                frmSifreOnay frm = new frmSifreOnay(1);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    manuel = new frmManuel();
                    manuel.Show();
                }
            }
            else
            {
                manuel.Activate();
                if (manuel.WindowState == FormWindowState.Minimized)
                {
                    manuel.WindowState = FormWindowState.Normal;
                }
            }
        }
        private void btnDbBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string DestDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\DataBackup";
                Directory.CreateDirectory(DestDir);

                string dbName = "TrafoTestDB";
                SqlConnection con = new SqlConnection("Data Source =.; database = TrafoTestDB; Integrated Security = True;");

                try
                {
                    con.Open();
                    string dbBackupName = "TrafoTestDB_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
                    SqlCommand cmd = new SqlCommand("BACKUP DATABASE " + dbName + " TO DISK='" + DestDir + "\\" + dbBackupName + ".bak' WITH FORMAT", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Yedek Oluşturuldu.");

                }
                catch
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    con.ConnectionString = "Data Source =.\\SQLEXPRESS; database = TrafoTestDB; Integrated Security = True;";

                    string dbBackupName = "TrafoTestDB_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
                    SqlCommand cmd = new SqlCommand("BACKUP DATABASE " + dbName + " TO DISK='" + DestDir + "\\" + dbBackupName + ".bak' WITH FORMAT", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Yedek Oluşturuldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Loglama.Log(ex);
            }
        }

        #region Form Hareket Islemleri

        private bool dragging { get; set; } = false;
        private Point dragCursorPoint { get; set; }
        private Point dragFormPoint { get; set; }

        private void frmAnaEkran_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }
        private void frmAnaEkran_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void frmAnaEkran_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void tamEkran_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
                tamEkran.Text = "Simge Durumuna Küçült";
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                tamEkran.Text = "Tam Ekran";
            }
        }

        #endregion

        #region Form Cikis Islemleri
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmAnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (PLC.Connection)
                    {
                        PLC.Disconnect();
                    }

                    GC.Collect();
                    Environment.Exit(0);
                }
            }
            catch
            {
            }
        }
        #endregion

        #region Tools Menu Islemleri
        private void btnAlarmlar_Click(object sender, EventArgs e)
        {
            AlarmAc();
        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            frmReceteIslemleri recete = new frmReceteIslemleri();
            recete.ShowDialog();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            try
            {
                frmSifreOnay frm = new frmSifreOnay();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frmAyarlar ayar = new frmAyarlar();

                    if (ayar.ShowDialog() == DialogResult.OK)
                    {
                        tankGoruntuleme1.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;
                        tankGoruntuleme2.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;
                        tankGoruntuleme3.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;
                        tankGoruntuleme4.timerPeriyodikIslemler.Interval = Settings.Default.VeritabaniKayit * 1000 * 60;

                        tankGosterge1.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;
                        tankGosterge2.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;
                        tankGosterge3.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;
                        tankGosterge4.timerPeriyodikIslemler_Degerler.Interval = Settings.Default.TankGostergeEkranGuncellemeZamani * 1000;

                        PlcTag.mailList = Settings.Default.MailAdresleri.ToString().Split(';').ToList();

                        if (tankGoruntuleme1.IslemDurumu == enmIslemDurumu.ISLEM_YOK &&
                            tankGoruntuleme2.IslemDurumu == enmIslemDurumu.ISLEM_YOK &&
                            tankGoruntuleme3.IslemDurumu == enmIslemDurumu.ISLEM_YOK &&
                            tankGoruntuleme4.IslemDurumu == enmIslemDurumu.ISLEM_YOK)
                        {
                            PlcTag.IsDemoMod = Settings.Default.DemoMod;
                        }
                        else
                        {
                            MessageBox.Show("Tanklarda Aktif İşlem Olduğu İçin Demo Mod Durumu Değiştirilmedi.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            frmHakkinda hk = new frmHakkinda();
            hk.ShowDialog();
        }

        private void btnVersiyonlar_Click(object sender, EventArgs e)
        {
            frmVersiyonlar ver = new frmVersiyonlar();
            ver.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<frmRaporlarAna>().FirstOrDefault();

            if (form != null)
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                form.Activate();
            }
            else
            {
                new frmRaporlarAna().Show();
            }
        }
        #endregion

        #region Connection İslemleri
        private void tmrConnectionState_Tick(object sender, EventArgs e)
        {
            if (DBTool.DBConnectionState)
            {
                lblSistemDurumu.BackColor = Color.LimeGreen;
                lblSistemDurumu.ForeColor = Color.Black;
            }
            else
            {
                lblSistemDurumu.BackColor = Color.Red;
                lblSistemDurumu.ForeColor = Color.White;
                Task.Run(() => DBTool.CheckConnection());
            }
        }


        [DebuggerStepThrough]
        private void tmrPLC_Tick(object sender, EventArgs e)
        {
            if (!Settings.Default.DemoMod)
            {
                if (PLC.Connection)
                {
                    PLC_BaglantiMailAtildiMi = false;

                    lblPLCBaglantiDurumu.BackColor = Color.LimeGreen;
                    lblPLCBaglantiDurumu.ForeColor = Color.Black;

                    PLC.ReadByte(1, 0, 2);     //Proses Kontrol Bitleri

                    if (!PlcTag.islemBaslatiliyor)
                    {
                        PLC.ReadByte2(1, 202, 10);     //Proses Kontrol Bitleri
                    }
                    PLC.ReadInteger(1, 4, 21); //Integer Dataları
                    PLC.ReadReal(1, 70, 26);   //Real Dataları

                    PLC.ReadByteIo(9, 0, 9);   //Giris-Çıkış Bitleri


                    if (!acilisKontrol)
                    {
                        KalanIslemleriGetir();
                        acilisKontrol = true;
                    }


                    if (PLC.IsBitSet(PlcTag.Db_KontrolByte00, 0))
                    {
                        lblDurum.BackColor = Color.LimeGreen;
                        lblDurum.Text = "Otomatik Mod";
                    }
                    else
                    {
                        lblDurum.BackColor = Color.DodgerBlue;
                        lblDurum.Text = "Manuel Mod";
                    }
                }
                else
                {
                    if (!PlcTag.IsDemoMod)
                    {
                        if (!PLC_BaglantiMailAtildiMi)
                        {
                            PLC.MailAt("Dikkat!!!! PLC - Scada Bağlantısı Koptu", "Hata Zamanı: " + DateTime.Now.ToString());
                            PLC_BaglantiMailAtildiMi = true;
                        }
                    }


                    lblPLCBaglantiDurumu.BackColor = Color.Red;
                    lblPLCBaglantiDurumu.ForeColor = Color.White;

                    Task.Run(() => PLC.Connect(Settings.Default.PLC_IPAdres));
                }
            }
        }
        private void lblPLCBaglantiDurumu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (!PLC.Connection)
                {
                    Task.Run(() => PLC.Connect(Settings.Default.PLC_IPAdres));
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }

        #endregion

        #region Alarm islemleri
        [DebuggerStepThrough]
        private void tmrAlarm_Tick(object sender, EventArgs e)
        {
            if (stripAlarm.BackColor == Color.Red)
            {
                stripAlarm.BackColor = Color.SpringGreen;
            }
            else
            {
                stripAlarm.BackColor = Color.Red;
            }
        }

        private void stripAlarm_Click(object sender, EventArgs e)
        {
            AlarmAc();
        }

        void AlarmAc()
        {
            if (alarm == null || alarm.IsDisposed)
            {
                alarm = new frmAlarm();
                alarm.ShowDialog();

                alarm.Dispose();
            }
            else
            {
                if (alarm.WindowState == FormWindowState.Minimized)
                {
                    alarm.WindowState = FormWindowState.Normal;
                }
            }
        }

        [DebuggerStepThrough]
        private void tmrArizaKontrol_Tick(object sender, EventArgs e)
        {
            if (
                    PlcTag.Db_tank1AlarmWord_Old != 0 ||
                    PlcTag.Db_tank2AlarmWord_Old != 0 ||
                    PlcTag.Db_tank3AlarmWord_Old != 0 ||
                    PlcTag.Db_tank4AlarmWord_Old != 0 ||
                    PlcTag.Db_genelAlarmWord_Old != 0 //duzenledim proses calısıyorken hata varsa 
                )
            {
                tmrAlarm.Enabled = true;
            }
            else
            {
                tmrAlarm.Enabled = false;
                stripAlarm.BackColor = SystemColors.Highlight;
            }
        }

        #endregion
    }
}