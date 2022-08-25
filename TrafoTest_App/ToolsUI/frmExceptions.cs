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

namespace TrafoTest_App.ToolsUI
{
    public partial class frmExceptions : Form
    {
        List<EXCEPTION_LOG> liste { get; set; }
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        public frmExceptions()
        {
            InitializeComponent();
        }

        private void frmExceptions_Load(object sender, EventArgs e)
        {
            try
            {
                Getir();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        void Getir()
        {
            try
            {
                dgExceptions.DataSource = null;
                liste = db.Exception_Loglar.Where(x => DbFunctions.TruncateTime(x.EKLE_LOG_TARIH) >= DbFunctions.TruncateTime(dpBaslangic.Value) && DbFunctions.TruncateTime(x.EKLE_LOG_TARIH) <= DbFunctions.TruncateTime(dpBitis.Value)).OrderByDescending(x => x.EKLE_LOG_TARIH).ToList();
                dgExceptions.DataSource = liste;
            }
            catch (Exception ex)
            {
                dgExceptions.DataSource = null;

                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void exceleAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelIslemleri excel = new ExcelIslemleri();
                Task.Run(() => excel.ExceleAktar(liste, typeof(EXCEPTION_LOG)).Visible = true);
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void dpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            Getir();
        }

        private void btnSecilenleriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Kayıtları Silinecektir.Devam Etmek İstiyor musunuz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }

                foreach (DataGridViewRow row in dgExceptions.SelectedRows)
                {
                    EXCEPTION_LOG exception = (EXCEPTION_LOG)row.DataBoundItem;

                    db.Exception_Loglar.Attach(exception);
                    db.Entry(exception).State = EntityState.Deleted;
                    db.SaveChanges();
                }

                Getir();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}