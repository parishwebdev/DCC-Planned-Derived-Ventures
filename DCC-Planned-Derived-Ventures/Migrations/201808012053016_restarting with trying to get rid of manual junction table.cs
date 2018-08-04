namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restartingwithtryingtogetridofmanualjunctiontable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItineraryAddressJunctions", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.ItineraryAddressJunctions", "ItineraryId", "dbo.Itineraries");
            DropIndex("dbo.ItineraryAddressJunctions", new[] { "AddressId" });
            DropIndex("dbo.ItineraryAddressJunctions", new[] { "ItineraryId" });
            DropTable("dbo.ItineraryAddressJunctions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ItineraryAddressJunctions",
                c => new
                    {
                        AddressId = c.Int(nullable: false),
                        ItineraryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AddressId, t.ItineraryId });
            
            CreateIndex("dbo.ItineraryAddressJunctions", "ItineraryId");
            CreateIndex("dbo.ItineraryAddressJunctions", "AddressId");
            AddForeignKey("dbo.ItineraryAddressJunctions", "ItineraryId", "dbo.Itineraries", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ItineraryAddressJunctions", "AddressId", "dbo.Addresses", "ID", cascadeDelete: true);
        }
    }
}
