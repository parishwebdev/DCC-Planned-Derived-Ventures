namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingbackitineraryaddressmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItineraryAddresses",
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
            DropForeignKey("dbo.ItineraryAddresses", "ItineraryId", "dbo.Itineraries");
            DropForeignKey("dbo.ItineraryAddresses", "AddressId", "dbo.Addresses");
            DropIndex("dbo.ItineraryAddresses", new[] { "ItineraryId" });
            DropIndex("dbo.ItineraryAddresses", new[] { "AddressId" });
            DropTable("dbo.ItineraryAddresses");
        }
    }
}
