namespace Progame.HousesAPIApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EstateAgents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Experience = c.Int(nullable: false),
                        FullName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Square = c.Double(nullable: false),
                        Description = c.String(),
                        HouseType = c.Int(nullable: false),
                        IsSoldOut = c.Boolean(nullable: false),
                        EstateAgent_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EstateAgents", t => t.EstateAgent_Id)
                .Index(t => t.EstateAgent_Id);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "EstateAgent_Id", "dbo.EstateAgents");
            DropIndex("dbo.Houses", new[] { "EstateAgent_Id" });
            DropTable("dbo.Owners");
            DropTable("dbo.Houses");
            DropTable("dbo.EstateAgents");
            DropTable("dbo.Buyers");
        }
    }
}
