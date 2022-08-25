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

namespace TrafoTest_App.ToolsUI
{
    public partial class frmMailListesi : Form
    {
        public frmMailListesi()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> mail = new List<string>();

                foreach (DataGridViewRow item in dgMailList.Rows)
                {
                    if (item.Cells[0].Value != null && (string)item.Cells[0].Value != string.Empty)
                    {
                        mail.Add(item.Cells[0].Value.ToString());
                    }
                }
                if (mail.Count == 0)
                {
                    Properties.Settings.Default.MailAdresleri = string.Empty;
                }
                else
                {
                    Properties.Settings.Default.MailAdresleri = string.Join(";", mail);
                }

                Properties.Settings.Default.Save();

                PlcTag.mailList = mail;
                Close();

            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmMailListesi_Load(object sender, EventArgs e)
        {
            Getir();
        }

        void Getir()
        {
            try
            {
                if (Properties.Settings.Default.MailAdresleri != string.Empty)
                {
                    string MailList = Properties.Settings.Default.MailAdresleri.ToString();

                    List<string> MailParseEdilmis = MailList.Split(';').ToList();

                    foreach (string item in MailParseEdilmis)
                    {
                        dgMailList.Rows.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                dgMailList.DataSource = null;
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
