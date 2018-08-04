namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class didIchangesomething : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Itineraries", "DestinationItineraryAddress_Id", c => c.Int());
            AddColumn("dbo.Itineraries", "StartItineraryAddress_Id", c => c.Int());
            CreateIndex("dbo.Itineraries", "DestinationItineraryAddress_Id");
            CreateIndex("dbo.Itineraries", "StartItineraryAddress_Id");
            AddForeignKey("dbo.Itineraries", "DestinationItineraryAddress_Id", "dbo.ItineraryAddresses", "Id");
            AddForeignKey("dbo.Itineraries", "StartItineraryAddress_Id", "dbo.ItineraryAddresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Itineraries", "StartItineraryAddress_Id", "dbo.ItineraryAddresses");
            DropForeignKey("dbo.Itineraries", "DestinationItineraryAddress_Id", "dbo.ItineraryAddresses");
            DropIndex("dbo.Itineraries", new[] { "StartItineraryAddress_Id" });
            DropIndex("dbo.Itineraries", new[] { "DestinationItineraryAddress_Id" });
            DropColumn("dbo.Itineraries", "StartItineraryAddress_Id");
            DropColumn("dbo.Itineraries", "DestinationItineraryAddress_Id");
        }
    }
}
