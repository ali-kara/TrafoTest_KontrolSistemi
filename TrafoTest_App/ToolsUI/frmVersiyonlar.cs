using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TrafoTest_App
{
    public partial class frmVersiyonlar : Form
    {
        public frmVersiyonlar()
        {
            InitializeComponent();   
            richTextBox1.Text = Properties.Resources.versiyonlar.ToString();
        }
    }
}
