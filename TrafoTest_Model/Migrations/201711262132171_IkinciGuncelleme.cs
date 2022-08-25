namespace TrafoTest_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IkinciGuncelleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_1", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_2", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_3", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_4", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_5", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_6", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_7", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_8", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_9", c => c.String(maxLength: 25));
            AddColumn("dbo.ISLEM_BASLIK", "TRAFO_10", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_10");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_9");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_8");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_7");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_6");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_5");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_4");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_3");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_2");
            DropColumn("dbo.ISLEM_BASLIK", "TRAFO_1");
        }
    }
}
