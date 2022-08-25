using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafoTest_Model.Model;

namespace TrafoTest_Lib
{
    public static class Loglama
    {
        /// <summary>
        /// bla bla bla
        /// </summary>
        public static void Log(Exception ex)
        {
            try
            {
                TrafoTest_AppDBEntities db = new TrafoTest_AppDBEntities();

                EXCEPTION_LOG exception = new EXCEPTION_LOG
                {
                    MESSAGE = ex.Message,
                    STACKTRACE = ex.StackTrace,
                    INNER_EXCEPTION = Convert.ToString(ex.InnerException),
                    EKLE_LOG_TARIH = DateTime.Now
                };

                db.Exception_Loglar.Add(exception);
                db.SaveChanges();
            }
            catch
            {
                Log2File(ex);
            }
        }
        public static void Log2File(Exception ex)
        {
            string fileLoc = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Logs\Log_" + DateTime.Now.ToShortDateString() + "_" + Guid.NewGuid() + ".txt";
            Directory.CreateDirectory(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Logs");

            using (FileStream fs = File.Create(fileLoc))
            {

            }
            

            using (StreamWriter sw = File.AppendText(fileLoc))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(ex.ToString());
                sw.WriteLine("--------------------------------------------------------------------------------------------");
            }
        }
    }
}