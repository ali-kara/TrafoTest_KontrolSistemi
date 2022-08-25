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

namespace TrafoTest_Control
{
    public partial class Tank3_PopUp : Form
    {
        public Tank3_PopUp()
        {
            InitializeComponent();
            lblBitisZamani.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private bool dragging { get; set; } = false;
        private Point dragCursorPoint { get; set; }
        private Point dragFormPoint { get; set; }

        private void TankPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void TankPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void TankPopUp_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnProsesBitir_Click(object sender, EventArgs e)
        {
            try
            {
                PLC.WriteBool(1, 1, 1, 1);
                Close();
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}