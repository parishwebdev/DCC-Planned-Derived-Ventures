namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hopefullydropitinaddr : DbMigration
    {
        public override void Up()
        { 
            DropForeignKey("dbo.ItineraryAddresses", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.ItineraryAddresses", "ItineraryId", "dbo.Itineraries");
            DropForeignKey("dbo.Itineraries", "DestinationItineraryAddress_ID", "dbo.ItineraryAddresses");
            DropForeignKey("dbo.Itineraries", "StartItineraryAddress_ID", "dbo.ItineraryAddresses");
            DropIndex("dbo.Itineraries", new[] { "DestinationItineraryAddress_ID" });
            DropIndex("dbo.Itineraries", new[] { "StartItineraryAddress_ID" });
            DropIndex("dbo.ItineraryAddresses", new[] { "AddressId" });
            DropIndex("dbo.ItineraryAddresses", new[] { "ItineraryId" });
            DropColumn("dbo.Itineraries", "DestinationItineraryAddress_ID");
            DropColumn("dbo.Itineraries", "StartItineraryAddress_ID");
            DropTable("dbo.ItineraryAddresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ItineraryAddresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AddressId = c.Int(nullable: false),
                        ItineraryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Itineraries", "StartItineraryAddress_ID", c => c.Int());
            AddColumn("dbo.Itineraries", "DestinationItineraryAddress_ID", c => c.Int());
            CreateIndex("dbo.ItineraryAddresses", "ItineraryId");
            CreateIndex("dbo.ItineraryAddresses", "AddressId");
            CreateIndex("dbo.Itineraries", "StartItineraryAddress_ID");
            CreateIndex("dbo.Itineraries", "DestinationItineraryAddress_ID");
            AddForeignKey("dbo.Itineraries", "StartItineraryAddress_ID", "dbo.ItineraryAddresses", "ID");
            AddForeignKey("dbo.Itineraries", "DestinationItineraryAddress_ID", "dbo.ItineraryAddresses", "ID");
            AddForeignKey("dbo.ItineraryAddresses", "ItineraryId", "dbo.Itineraries", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ItineraryAddresses", "AddressId", "dbo.Addresses", "ID", cascadeDelete: true); 
        }
    }
}
