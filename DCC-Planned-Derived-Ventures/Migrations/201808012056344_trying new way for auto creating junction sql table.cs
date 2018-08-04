namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingnewwayforautocreatingjunctionsqltable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItineraryAddresses",
                c => new
                    {
                        Itinerary_ID = c.Int(nullable: false),
                        Address_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Itinerary_ID, t.Address_ID })
                .ForeignKey("dbo.Itineraries", t => t.Itinerary_ID, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.Address_ID, cascadeDelete: true)
                .Index(t => t.Itinerary_ID)
                .Index(t => t.Address_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItineraryAddresses", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.ItineraryAddresses", "Itinerary_ID", "dbo.Itineraries");
            DropIndex("dbo.ItineraryAddresses", new[] { "Address_ID" });
            DropIndex("dbo.ItineraryAddresses", new[] { "Itinerary_ID" });
            DropTable("dbo.ItineraryAddresses");
        }
    }
}
