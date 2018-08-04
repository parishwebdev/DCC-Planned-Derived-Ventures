namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedspellinginitinadd : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Itineraries", new[] { "DestinationItineraryAddress_Id" });
            DropIndex("dbo.Itineraries", new[] { "StartItineraryAddress_Id" });
            CreateIndex("dbo.Itineraries", "DestinationItineraryAddress_ID");
            CreateIndex("dbo.Itineraries", "StartItineraryAddress_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Itineraries", new[] { "StartItineraryAddress_ID" });
            DropIndex("dbo.Itineraries", new[] { "DestinationItineraryAddress_ID" });
            CreateIndex("dbo.Itineraries", "StartItineraryAddress_Id");
            CreateIndex("dbo.Itineraries", "DestinationItineraryAddress_Id");
        }
    }
}
