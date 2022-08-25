namespace TrafoTest_Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrafoTest_Model.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<TrafoTest_AppDBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TrafoTest_AppDBEntities db)
        {
            db.SaveChanges();
        }
    }
}