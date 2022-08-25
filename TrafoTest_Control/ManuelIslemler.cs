using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_Lib;

namespace TrafoTest_Control
{
    public partial class ManuelIslemler : UserControl
    {
        public ManuelIslemler()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
            if (PLC.IsBitSet(PlcTag.Db_OutputByte00, 0)) { BtnManQ00.BackColor = Color.LimeGreen; } else { BtnManQ00.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte00, 1)) { BtnManQ01.BackColor = Color.LimeGreen; } else { BtnManQ01.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte00, 2)) { BtnManQ02.BackColor = Color.LimeGreen; } else { BtnManQ02.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte00, 3)) { BtnManQ03.BackColor = Color.LimeGreen; } else { BtnManQ03.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte00, 4)) { BtnManQ04.BackColor = Color.LimeGreen; } else { BtnManQ04.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte00, 5)) { BtnManQ05.BackColor = Color.LimeGreen; } else { BtnManQ05.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 0)) { BtnManQ20.BackColor = Color.LimeGreen; } else { BtnManQ20.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 1)) { BtnManQ21.BackColor = Color.LimeGreen; } else { BtnManQ21.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 2)) { BtnManQ22.BackColor = Color.LimeGreen; } else { BtnManQ22.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 3)) { BtnManQ23.BackColor = Color.LimeGreen; } else { BtnManQ23.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 4)) { BtnManQ24.BackColor = Color.LimeGreen; } else { BtnManQ24.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 5)) { BtnManQ25.BackColor = Color.LimeGreen; } else { BtnManQ25.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 6)) { BtnManQ26.BackColor = Color.LimeGreen; } else { BtnManQ26.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte02, 7)) { BtnManQ27.BackColor = Color.LimeGreen; } else { BtnManQ27.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 0)) { BtnManQ30.BackColor = Color.LimeGreen; } else { BtnManQ30.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 1)) { BtnManQ31.BackColor = Color.LimeGreen; } else { BtnManQ31.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 2)) { BtnManQ32.BackColor = Color.LimeGreen; } else { BtnManQ32.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 3)) { BtnManQ33.BackColor = Color.LimeGreen; } else { BtnManQ33.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 4)) { BtnManQ34.BackColor = Color.LimeGreen; } else { BtnManQ34.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 5)) { BtnManQ35.BackColor = Color.LimeGreen; } else { BtnManQ35.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 6)) { BtnManQ36.BackColor = Color.LimeGreen; } else { BtnManQ36.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte03, 7)) { BtnManQ37.BackColor = Color.LimeGreen; } else { BtnManQ37.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 0)) { BtnManQ40.BackColor = Color.LimeGreen; } else { BtnManQ40.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 1)) { BtnManQ41.BackColor = Color.LimeGreen; } else { BtnManQ41.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 2)) { BtnManQ42.BackColor = Color.LimeGreen; } else { BtnManQ42.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 3)) { BtnManQ43.BackColor = Color.LimeGreen; } else { BtnManQ43.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 4)) { BtnManQ44.BackColor = Color.LimeGreen; } else { BtnManQ44.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 5)) { BtnManQ45.BackColor = Color.LimeGreen; } else { BtnManQ45.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 6)) { BtnManQ46.BackColor = Color.LimeGreen; } else { BtnManQ46.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_OutputByte04, 7)) { BtnManQ47.BackColor = Color.LimeGreen; } else { BtnManQ47.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 0)) { lbl_I00.BackColor = Color.LimeGreen; } else { lbl_I00.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 1)) { lbl_I01.BackColor = Color.LimeGreen; } else { lbl_I01.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 2)) { lbl_I02.BackColor = Color.LimeGreen; } else { lbl_I02.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 3)) { lbl_I03.BackColor = Color.LimeGreen; } else { lbl_I03.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 4)) { lbl_I04.BackColor = Color.LimeGreen; } else { lbl_I04.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 5)) { lbl_I05.BackColor = Color.LimeGreen; } else { lbl_I05.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 6)) { lbl_I06.BackColor = Color.LimeGreen; } else { lbl_I06.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte00, 7)) { lbl_I07.BackColor = Color.LimeGreen; } else { lbl_I07.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_InputByte01, 0)) { lbl_I10.BackColor = Color.LimeGreen; } else { lbl_I10.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte01, 1)) { lbl_I11.BackColor = Color.LimeGreen; } else { lbl_I11.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte01, 2)) { lbl_I12.BackColor = Color.LimeGreen; } else { lbl_I12.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte01, 3)) { lbl_I13.BackColor = Color.LimeGreen; } else { lbl_I13.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte01, 4)) { lbl_I14.BackColor = Color.LimeGreen; } else { lbl_I14.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte01, 5)) { lbl_I15.BackColor = Color.LimeGreen; } else { lbl_I15.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 0)) { lbl_I20.BackColor = Color.LimeGreen; } else { lbl_I20.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 1)) { lbl_I21.BackColor = Color.LimeGreen; } else { lbl_I21.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 2)) { lbl_I22.BackColor = Color.LimeGreen; } else { lbl_I22.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 3)) { lbl_I23.BackColor = Color.LimeGreen; } else { lbl_I23.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 4)) { lbl_I24.BackColor = Color.LimeGreen; } else { lbl_I24.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 5)) { lbl_I25.BackColor = Color.LimeGreen; } else { lbl_I25.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 6)) { lbl_I26.BackColor = Color.LimeGreen; } else { lbl_I26.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte02, 7)) { lbl_I27.BackColor = Color.LimeGreen; } else { lbl_I27.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_InputByte03, 0)) { lbl_I30.BackColor = Color.LimeGreen; } else { lbl_I30.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte03, 1)) { lbl_I31.BackColor = Color.LimeGreen; } else { lbl_I31.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte03, 2)) { lbl_I32.BackColor = Color.LimeGreen; } else { lbl_I32.BackColor = Color.DodgerBlue; }
            if (PLC.IsBitSet(PlcTag.Db_InputByte03, 3)) { lbl_I33.BackColor = Color.LimeGreen; } else { lbl_I33.BackColor = Color.DodgerBlue; }

            if (PLC.IsBitSet(PlcTag.Db_KontrolByte00, 0))
            {
                btnManAuto.BackColor = Color.LimeGreen;
                btnManAuto.Text = "Otomatik Mod";
            }
            else
            {
                btnManAuto.BackColor = Color.DodgerBlue;
                btnManAuto.Text = "Manuel Mod";
            }

        }


        //kazan 1 manuel kontrol
        private void BtnManQ20_Click(object sender, EventArgs e)//vakým valfi
        {
            PLC.WriteBool(2, 0, 0, 1);
        }
        private void BtnManQ24_Click(object sender, EventArgs e)//tahliye valfi
        {
            PLC.WriteBool(2, 0, 1, 1);
        }
        private void BtnManQ00_Click(object sender, EventArgs e)//isitma kontktor
        {
            PLC.WriteBool(2, 0, 2, 1);
        }
        private void BtnManQ30_Click(object sender, EventArgs e)//kirmizi
        {
            PLC.WriteBool(2, 0, 4, 1);
        }
        private void BtnManQ31_Click(object sender, EventArgs e)//yesil
        {
            PLC.WriteBool(2, 0, 5, 1);
        }
        private void BtnManQ32_Click(object sender, EventArgs e)//sari
        {
            PLC.WriteBool(2, 0, 6, 1);
        }

        //kazan 2 manuel kontrol
        private void BtnManQ21_Click(object sender, EventArgs e)//vakým valfi
        {
            PLC.WriteBool(2, 2, 0, 1);
        }
        private void BtnManQ25_Click(object sender, EventArgs e)//tahliye valfi
        {
            PLC.WriteBool(2, 2, 1, 1);
        }
        private void BtnManQ01_Click(object sender, EventArgs e)//isitma kontktor
        {
            PLC.WriteBool(2, 2, 2, 1);
        }
        private void BtnManQ33_Click(object sender, EventArgs e)//kirmizi
        {
            PLC.WriteBool(2, 2, 4, 1);
        }
        private void BtnManQ34_Click(object sender, EventArgs e)//yesil
        {
            PLC.WriteBool(2, 2, 5, 1);
        }
        private void BtnManQ35_Click(object sender, EventArgs e)//sari
        {
            PLC.WriteBool(2, 2, 6, 1);
        }

        //kazan 3 manuel kontrol
        private void BtnManQ22_Click(object sender, EventArgs e)//vakým valfi
        {
            PLC.WriteBool(2, 4, 0, 1);
        }
        private void BtnManQ26_Click(object sender, EventArgs e)//tahliye valfi
        {
            PLC.WriteBool(2, 4, 1, 1);
        }
        private void BtnManQ02_Click(object sender, EventArgs e)//isitma kontktor
        {
            PLC.WriteBool(2, 4, 2, 1);
        }
        private void BtnManQ36_Click(object sender, EventArgs e)//kirmizi
        {
            PLC.WriteBool(2, 4, 4, 1);
        }
        private void BtnManQ37_Click(object sender, EventArgs e)//yesil
        {
            PLC.WriteBool(2, 4, 5, 1);
        }
        private void BtnManQ40_Click(object sender, EventArgs e)//sari
        {
            PLC.WriteBool(2, 4, 6, 1);
        }

        //kazan 4 manuel kontrol
        private void BtnManQ23_Click(object sender, EventArgs e)//vakým valfi
        {
            PLC.WriteBool(2, 6, 0, 1);
        }
        private void BtnManQ27_Click(object sender, EventArgs e)//tahliye valfi
        {
            PLC.WriteBool(2, 6, 1, 1);
        }
        private void BtnManQ03_Click(object sender, EventArgs e)//isitma kontktor
        {
            PLC.WriteBool(2, 6, 2, 1);
        }
        private void BtnManQ41_Click(object sender, EventArgs e)//kirmizi
        {
            PLC.WriteBool(2, 6, 4, 1);
        }
        private void BtnManQ42_Click(object sender, EventArgs e)//yesil
        {
            PLC.WriteBool(2, 6, 5, 1);
        }
        private void BtnManQ43_Click(object sender, EventArgs e)//sari
        {
            PLC.WriteBool(2, 6, 6, 1);
        }

        //Genel Kontrol     
        private void BtnManQ04_Click(object sender, EventArgs e)//sogutucu 1
        {
            PLC.WriteBool(2, 8, 0, 1);
        }
        private void BtnManQ05_Click(object sender, EventArgs e)//sogutucu 2
        {
            PLC.WriteBool(2, 8, 1, 1);
        }
        private void BtnManQ45_Click(object sender, EventArgs e)//pompa1 pid
        {
            PLC.WriteBool(2, 8, 2, 1);
        }
        private void BtnManQ47_Click(object sender, EventArgs e)//pompa2 pid
        {
            PLC.WriteBool(2, 8, 3, 1);
        }
        private void BtnManQ44_Click(object sender, EventArgs e)//pompa1 start
        {
            PLC.WriteBool(2, 0, 3, 1);
        }
        private void BtnManQ46_Click(object sender, EventArgs e)//pompa2 start 
        {
            PLC.WriteBool(2, 4, 3, 1);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (PLC.Connection)
                {
                    Guncelle();
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }

        private void btnManAuto_Click(object sender, EventArgs e)
        {
            if (PLC.Connection)
            {
                if (PLC.IsBitSet(PlcTag.Db_KontrolByte00, 0))
                {
                    if (MessageBox.Show("Otomatik Moddan Çıkmak İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        PLC.WriteBool(1, 0, 0, 0); //Man-Auto işlem secim biti
                    }
                }
                else
                {
                    PLC.WriteBool(1, 0, 0, 1);
                }
            }
        }
    }
}