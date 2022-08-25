using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_Lib;
using TrafoTest_Model.Model;

namespace TrafoTest_Control
{
    public partial class frmIslemRecete : Form
    {
        TrafoTest_AppDBEntities db { get; set; } = new TrafoTest_AppDBEntities();

        int ISLEM_BASLIK_ID { get; set; }
        public frmIslemRecete(int _ISLEM_BASLIK_ID)
        {
            InitializeComponent();
            ISLEM_BASLIK_ID = _ISLEM_BASLIK_ID;
        }

        private void frmIslemRecete_Load(object sender, EventArgs e)
        {
            try
            {
                dgIslemReceteDetaylar.DataSource = db.Islem_Receteler.Where(x => x.ISLEM_BASLIK_ID == ISLEM_BASLIK_ID).ToList();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
