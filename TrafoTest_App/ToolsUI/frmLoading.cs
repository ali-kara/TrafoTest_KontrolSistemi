using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafoTest_App.ToolsUI
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            i++;

            if (i == 100)
            {
                i = 0;
            }
        }
    }
}
