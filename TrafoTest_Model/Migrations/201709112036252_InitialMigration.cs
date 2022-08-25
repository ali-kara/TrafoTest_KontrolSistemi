namespace TrafoTest_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ALARMLAR",
                c => new
                    {
                        ALARM_ID = c.Int(nullable: false, identity: true),
                        TANK_ID = c.Int(),
                        ISLEM_BASLIK_ID = c.Int(nullable: false),
                        ACIKLAMA = c.String(maxLength: 250),
                        OLUSMA_TARIHI = c.DateTime(),
                    })
                .PrimaryKey(t => t.ALARM_ID)
                .ForeignKey("dbo.ISLEM_BASLIK", t => t.ISLEM_BASLIK_ID, cascadeDelete: true)
                .Index(t => t.ISLEM_BASLIK_ID);
            
            CreateTable(
                "dbo.ISLEM_BASLIK",
                c => new
                    {
                        ISLEM_BASLIK_ID = c.Int(nullable: false, identity: true),
                        ISLEM_ADI = c.String(maxLength: 50),
                        TANK_ID = c.Int(),
                        ACIKLAMA = c.String(maxLength: 250),
                        BASLANGIC_TARIHI = c.DateTime(),
                        BITIS_TARIHI = c.DateTime(),
                    })
                .PrimaryKey(t => t.ISLEM_BASLIK_ID);
            
            CreateTable(
                "dbo.EXCEPTION_LOG",
                c => new
                    {
                        EXCEPTION_LOG_ID = c.Int(nullable: false, identity: true),
                        MESSAGE = c.String(),
                        STACKTRACE = c.String(),
                        INNER_EXCEPTION = c.String(),
                        EKLE_LOG_TARIH = c.DateTime(),
                    })
                .PrimaryKey(t => t.EXCEPTION_LOG_ID);
            
            CreateTable(
                "dbo.ISLEM_DETAY",
                c => new
                    {
                        ISLEM_DETAY_ID = c.Int(nullable: false, identity: true),
                        ISLEM_BASLIK_ID = c.Int(nullable: false),
                        SICAKLIK_1 = c.Double(),
                        SICAKLIK_2 = c.Double(),
                        SICAKLIK_3 = c.Double(),
                        SICAKLIK_4 = c.Double(),
                        SICAKLIK_5 = c.Double(),
                        BASINC_1 = c.Double(),
                        BASINC_2 = c.Double(),
                        EKLE_LOG_TARIH = c.DateTime(),
                    })
                .PrimaryKey(t => t.ISLEM_DETAY_ID)
                .ForeignKey("dbo.ISLEM_BASLIK", t => t.ISLEM_BASLIK_ID, cascadeDelete: true)
                .Index(t => t.ISLEM_BASLIK_ID);
            
            CreateTable(
                "dbo.ISLEM_RECETE",
                c => new
                    {
                        ISLEM_RECETE_ID = c.Int(nullable: false, identity: true),
                        ISLEM_BASLIK_ID = c.Int(nullable: false),
                        RECETE_ID = c.Int(nullable: false),
                        RECETE_ADI = c.String(maxLength: 50),
                        ADIM = c.Int(),
                        SAAT = c.Double(),
                        DERECE = c.Int(),
                        ISITMA = c.Boolean(),
                        VAKUM = c.Boolean(),
                        VAKUM_DEGERI = c.Int(),
                        TAHLIYE = c.Boolean(),
                        TAHLIYE_DEGERI = c.Int(),
                        ACIKLAMA = c.String(maxLength: 250),
                        TOPLAM_ZAMAN = c.String(maxLength: 50),
                        TOPLAM_SURE = c.Double(),
                        EKLE_LOG_TARIH = c.DateTime(),
                    })
                .PrimaryKey(t => t.ISLEM_RECETE_ID)
                .ForeignKey("dbo.ISLEM_BASLIK", t => t.ISLEM_BASLIK_ID, cascadeDelete: true)
                .Index(t => t.ISLEM_BASLIK_ID);
            
            CreateTable(
                "dbo.RECETE_DETAY",
                c => new
                    {
                        RECETE_DETAY_ID = c.Int(nullable: false, identity: true),
                        RECETE_ID = c.Int(nullable: false),
                        ADIM = c.Int(),
                        SAAT = c.Double(),
                        DERECE = c.Int(),
                        ISITMA = c.Boolean(),
                        VAKUM = c.Boolean(),
                        VAKUM_DEGERI = c.Int(),
                        TAHLIYE = c.Boolean(),
                        TAHLIYE_DEGERI = c.Int(),
                        ACIKLAMA = c.String(maxLength: 250),
                        TOPLAM_ZAMAN = c.String(maxLength: 50),
                        TOPLAM_SURE = c.Double(),
                    })
                .PrimaryKey(t => t.RECETE_DETAY_ID)
                .ForeignKey("dbo.RECETELER", t => t.RECETE_ID, cascadeDelete: true)
                .Index(t => t.RECETE_ID);
            
            CreateTable(
                "dbo.RECETELER",
                c => new
                    {
                        RECETE_ID = c.Int(nullable: false, identity: true),
                        RECETE_ADI = c.String(maxLength: 50),
                        PASIF = c.Boolean(),
                        ACIKLAMA = c.String(maxLength: 250),
                        EKLENME_TARIHI = c.DateTime(),
                        GUNCELLEME_TARIHI = c.DateTime(),
                    })
                .PrimaryKey(t => t.RECETE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RECETE_DETAY", "RECETE_ID", "dbo.RECETELER");
            DropForeignKey("dbo.ISLEM_RECETE", "ISLEM_BASLIK_ID", "dbo.ISLEM_BASLIK");
            DropForeignKey("dbo.ISLEM_DETAY", "ISLEM_BASLIK_ID", "dbo.ISLEM_BASLIK");
            DropForeignKey("dbo.ALARMLAR", "ISLEM_BASLIK_ID", "dbo.ISLEM_BASLIK");
            DropIndex("dbo.RECETE_DETAY", new[] { "RECETE_ID" });
            DropIndex("dbo.ISLEM_RECETE", new[] { "ISLEM_BASLIK_ID" });
            DropIndex("dbo.ISLEM_DETAY", new[] { "ISLEM_BASLIK_ID" });
            DropIndex("dbo.ALARMLAR", new[] { "ISLEM_BASLIK_ID" });
            DropTable("dbo.RECETELER");
            DropTable("dbo.RECETE_DETAY");
            DropTable("dbo.ISLEM_RECETE");
            DropTable("dbo.ISLEM_DETAY");
            DropTable("dbo.EXCEPTION_LOG");
            DropTable("dbo.ISLEM_BASLIK");
            DropTable("dbo.ALARMLAR");
        }
    }
}
