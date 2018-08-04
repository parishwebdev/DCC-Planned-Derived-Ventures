namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HopeFullynowcorrectitineraryaddress : DbMigration
    {
        public override void Up()
        { 
            CreateTable(
                "dbo.ItineraryAddresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AddressId = c.Int(nullable: false),
                        ItineraryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Itineraries", t => t.ItineraryId, cascadeDelete: true)
                .Index(t => t.AddressId)
                .Index(t => t.ItineraryId);
            
            AddColumn("dbo.Itineraries", "DestinationItineraryAddress_ID", c => c.Int());
            AddColumn("dbo.Itineraries", "StartItineraryAddress_ID", c => c.Int());
            CreateIndex("dbo.Itineraries", "DestinationItineraryAddress_ID");
            CreateIndex("dbo.Itineraries", "StartItineraryAddress_ID");
            AddForeignKey("dbo.Itineraries", "DestinationItineraryAddress_ID", "dbo.ItineraryAddresses", "ID");
            AddForeignKey("dbo.Itineraries", "StartItineraryAddress_ID", "dbo.ItineraryAddresses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Itineraries", "StartItineraryAddress_ID", "dbo.ItineraryAddresses");
            DropForeignKey("dbo.Itineraries", "DestinationItineraryAddress_ID", "dbo.ItineraryAddresses");
            DropForeignKey("dbo.ItineraryAddresses", "ItineraryId", "dbo.Itineraries");
            DropForeignKey("dbo.ItineraryAddresses", "AddressId", "dbo.Addresses");
            DropIndex("dbo.ItineraryAddresses", new[] { "ItineraryId" });
            DropIndex("dbo.ItineraryAddresses", new[] { "AddressId" });
            DropIndex("dbo.Itineraries", new[] { "StartItineraryAddress_ID" });
            DropIndex("dbo.Itineraries", new[] { "DestinationItineraryAddress_ID" });
            DropColumn("dbo.Itineraries", "StartItineraryAddress_ID");
            DropColumn("dbo.Itineraries", "DestinationItineraryAddress_ID");
            DropTable("dbo.ItineraryAddresses"); 
        }
    }
}
