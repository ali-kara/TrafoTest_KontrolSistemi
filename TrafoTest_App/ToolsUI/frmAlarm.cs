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
using TrafoTest_Model.Arizalar;
using TrafoTest_Model.Model;

namespace TrafoTest_App.ToolsUI
{
    public partial class frmAlarm : Form
    {
        List<ALARM> listAlarm { get; set; }
        List<ALARM> listAnlikAlarm { get; set; }
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        public frmAlarm()
        {
            InitializeComponent();
        }
        private void frmAlarm_Load(object sender, EventArgs e)
        {
            cmbTank.DisplayMember = "Text";
            cmbTank.ValueMember = "Value";

            var items = new[] {
                    new { Text = "Tümü"  , Value = "99" },
                    new { Text = "Genel Alarmlar"  , Value = "0" },
                    new { Text = "Tank 1", Value = "1" },
                    new { Text = "Tank 2", Value = "2" },
                    new { Text = "Tank 3", Value = "3" },
                    new { Text = "Tank 4", Value = "4" }
                };

            cmbTank.DataSource = items;

            AnlikAlarmListesiGetir();
            AlarmGetir();
        }
        public void AnlikAlarmListesiGetir()
        {
            try
            {
                listAnlikAlarm = new List<ALARM>();

                int[] bitsOld1 = ARIZA_TURLERI.ArizayiListeyeCevir(PlcTag.Db_tank1AlarmWord_Old);
                int[] bitsOld2 = ARIZA_TURLERI.ArizayiListeyeCevir(PlcTag.Db_tank2AlarmWord_Old);
                int[] bitsOld3 = ARIZA_TURLERI.ArizayiListeyeCevir(PlcTag.Db_tank3AlarmWord_Old);
                int[] bitsOld4 = ARIZA_TURLERI.ArizayiListeyeCevir(PlcTag.Db_tank4AlarmWord_Old);
                int[] bitsOldG = ARIZA_TURLERI.ArizayiListeyeCevir(PlcTag.Db_genelAlarmWord_Old); //degistirdim proses calısırsa hata bas

                ListeyeEkle(bitsOld1, 1);
                ListeyeEkle(bitsOld2, 2);
                ListeyeEkle(bitsOld3, 3);
                ListeyeEkle(bitsOld4, 4);
                ListeyeEkleGenel(bitsOldG);

                dgAnlikAlarm.DataSource = listAnlikAlarm ;

            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        void ListeyeEkle(int[] bits, int TankId)
        {
            ARIZA_TURLERI ariza = new ARIZA_TURLERI();

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    listAnlikAlarm.Add(new ALARM
                    {
                        TANK_ID = TankId,
                        ACIKLAMA = ariza.ArizaBul(i)
                    });
                }
            }
        }
        void ListeyeEkleGenel(int[] bits)
        {
            ARIZA_GENEL arizaGenel = new ARIZA_GENEL();

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    listAnlikAlarm.Add(new ALARM
                    {
                        TANK_ID = 0,
                        ACIKLAMA = arizaGenel.ArizaBul(i)
                    });
                }
            }
        }
        private void dpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                AlarmGetir();
            }
            catch (Exception ex)
            {
                dgAlarmlar.DataSource = null;

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void AlarmGetir()
        {
            try
            {
                dgAlarmlar.DataSource = null;

                int secilenTank = Convert.ToInt32(cmbTank.SelectedValue);

                if (secilenTank != 99)
                {
                    listAlarm = db.Alarmlar.Where(x => x.TANK_ID == secilenTank && 
                            DbFunctions.TruncateTime(x.OLUSMA_TARIHI) >= DbFunctions.TruncateTime(dpBaslangic.Value) && 
                            DbFunctions.TruncateTime(x.OLUSMA_TARIHI) <= DbFunctions.TruncateTime(dpBitis.Value))
                            .OrderByDescending(x => x.ALARM_ID).ToList();//son alarm en basta gorunmesi icin
                }
                else
                {
                    listAlarm = db.Alarmlar.Where(x => DbFunctions.TruncateTime(x.OLUSMA_TARIHI) >= DbFunctions.TruncateTime(dpBaslangic.Value) && 
                    DbFunctions.TruncateTime(x.OLUSMA_TARIHI) <= DbFunctions.TruncateTime(dpBitis.Value))
                    .OrderByDescending(x => x.ALARM_ID).ToList();//son alarm en basta gorunmesi icin
                }

                dgAlarmlar.DataSource = listAlarm;
            }
            catch (Exception ex)
            {
                dgAlarmlar.DataSource = null;

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void mailListesşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMailListesi mailListe = new frmMailListesi();
            mailListe.ShowDialog();
        }

        private void cmbTank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AlarmGetir();
            }
            catch (Exception ex)
            {
                dgAlarmlar.DataSource = null;

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSecilenleriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Kayıtları Silinecektir.\n\nDikkat: Bu işlem geri alınamaz.\n\nDevam Etmek İstiyor musunuz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }

                foreach (DataGridViewRow row in dgAlarmlar.SelectedRows)
                {
                    ALARM alarm = (ALARM)row.DataBoundItem;

                    db.Alarmlar.Attach(alarm);
                    db.Entry(alarm).State = EntityState.Deleted;
                    db.SaveChanges();
                }

                AlarmGetir();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelIslemleri excel = new ExcelIslemleri();
                excel.ExportExcelAlarm(listAlarm, typeof(ALARM));

            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }

        }
    }
}