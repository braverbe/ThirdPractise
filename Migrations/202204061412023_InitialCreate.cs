namespace ThirdPractise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zakazchiks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Zakazs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Predmet = c.String(),
                        Colichestvo = c.Int(nullable: false),
                        ZakazchikId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Zakazchiks", t => t.ZakazchikId)
                .Index(t => t.ZakazchikId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zakazs", "ZakazchikId", "dbo.Zakazchiks");
            DropIndex("dbo.Zakazs", new[] { "ZakazchikId" });
            DropTable("dbo.Zakazs");
            DropTable("dbo.Zakazchiks");
        }
    }
}
