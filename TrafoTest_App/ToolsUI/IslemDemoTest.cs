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
    public partial class IslemDemoTest : Form
    {
        public IslemDemoTest()
        {
            InitializeComponent();
        }

        private void IslemDemoTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlcTag.Db_tank1_IslemDurumu = Convert.ToInt32(txtTank1.Text);
            PlcTag.Db_tank2_IslemDurumu = Convert.ToInt32(txtTank2.Text);
            PlcTag.Db_tank3_IslemDurumu = Convert.ToInt32(txtTank3.Text);
            PlcTag.Db_tank4_IslemDurumu = Convert.ToInt32(txtTank4.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTank1.Text = PlcTag.Db_tank1_IslemDurumu.ToString();
            txtTank2.Text = PlcTag.Db_tank2_IslemDurumu.ToString();
            txtTank3.Text = PlcTag.Db_tank3_IslemDurumu.ToString();
            txtTank4.Text = PlcTag.Db_tank4_IslemDurumu.ToString();
        }
    }
}
