namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AddressLine = c.String(),
                        CityId = c.Int(nullable: false),
                        ZipId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.USStates", t => t.StateId, cascadeDelete: true)
                .ForeignKey("dbo.Zips", t => t.ZipId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.ZipId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.USStates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        abbrev = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Zips",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ZipCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Itineraries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        MilesAroundRoute = c.Int(nullable: false),
                        StartAddressID = c.Int(nullable: false),
                        DestinationId = c.Int(nullable: false),
                        AspNetUserId = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ItineraryAddressJunctions",
                c => new
                    {
                        AddressId = c.Int(nullable: false),
                        ItineraryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AddressId, t.ItineraryId })
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Itineraries", t => t.ItineraryId, cascadeDelete: true)
                .Index(t => t.AddressId)
                .Index(t => t.ItineraryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItineraryAddressJunctions", "ItineraryId", "dbo.Itineraries");
            DropForeignKey("dbo.ItineraryAddressJunctions", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "ZipId", "dbo.Zips");
            DropForeignKey("dbo.Addresses", "StateId", "dbo.USStates");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.ItineraryAddressJunctions", new[] { "ItineraryId" });
            DropIndex("dbo.ItineraryAddressJunctions", new[] { "AddressId" });
            DropIndex("dbo.Addresses", new[] { "StateId" });
            DropIndex("dbo.Addresses", new[] { "ZipId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropTable("dbo.ItineraryAddressJunctions");
            DropTable("dbo.Itineraries");
            DropTable("dbo.Zips");
            DropTable("dbo.USStates");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
