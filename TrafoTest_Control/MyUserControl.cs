using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafoTest_Model.Model;

namespace TrafoTest_Control
{
    public class MyUserControl : UserControl
    {
        protected TrafoTest_AppDBEntities db = new TrafoTest_AppDBEntities();
        public static string TankIsmi { get; set; }

    }
}
