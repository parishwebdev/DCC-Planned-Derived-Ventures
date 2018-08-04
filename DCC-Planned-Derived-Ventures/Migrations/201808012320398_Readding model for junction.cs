namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Readdingmodelforjunction : DbMigration
    {
        public override void Up()
        {
          
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ItineraryAddresses",
                c => new
                    {
                        Itinerary_ID = c.Int(nullable: false),
                        Address_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Itinerary_ID, t.Address_ID });
            
            CreateIndex("dbo.ItineraryAddresses", "Address_ID");
            CreateIndex("dbo.ItineraryAddresses", "Itinerary_ID");
            AddForeignKey("dbo.ItineraryAddresses", "Address_ID", "dbo.Addresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ItineraryAddresses", "Itinerary_ID", "dbo.Itineraries", "ID", cascadeDelete: true);
        }
    }
}
