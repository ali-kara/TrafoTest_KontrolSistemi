using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafoTest_Model.Migrations;

namespace TrafoTest_Model.Model
{
    public class TrafoTest_AppDBEntities : DbContext
    {
        public TrafoTest_AppDBEntities() : base("TrafoTest_AppDBEntities")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrafoTest_AppDBEntities, Configuration>());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<RECETELER> Receteler { get; set; }
        public DbSet<RECETE_DETAY> Recete_Detaylar { get; set; }
        public DbSet<ISLEM_BASLIK> Islem_Basliklar { get; set; }
        public DbSet<ISLEM_DETAY> Islem_Detaylar { get; set; }
        public DbSet<ISLEM_RECETE> Islem_Receteler { get; set; }
        public DbSet<EXCEPTION_LOG> Exception_Loglar { get; set; }
        public DbSet<ALARM> Alarmlar { get; set; }
    }
}