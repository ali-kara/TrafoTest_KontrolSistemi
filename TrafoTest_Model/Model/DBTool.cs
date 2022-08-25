using System;

namespace TrafoTest_Model.Model
{
    public static class DBTool
    {
        public static bool DBConnectionState { get; set; } = false;
        public static object Loglama { get; private set; }

        public static bool CheckConnection()
        {
            try
            {
                using (TrafoTest_AppDBEntities db = new TrafoTest_AppDBEntities())
                {
                    db.Database.Connection.Open();
                    db.Database.Connection.Close();
                }
                return DBConnectionState = true;
            }
            catch (Exception)
            {
                return DBConnectionState = false;
            }
        }
    }
}
