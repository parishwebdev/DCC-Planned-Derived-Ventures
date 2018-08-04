namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedachangetoitineraryaddressmodelinhopetoseetableaddedtodb : DbMigration
    {
        public override void Up()
        {

            CreateTable(
            "dbo.ItineraryAddresses",
            c => new
            {
                ID = c.Int(nullable: false),
                AddressId = c.Int(nullable: false),
                ItineraryId = c.Int(nullable: false),
            })
            .PrimaryKey(t => new { t.ID })
            .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
            .ForeignKey("dbo.Itineraries", t => t.ItineraryId, cascadeDelete: true)
            .Index(t => t.AddressId)
            .Index(t => t.ItineraryId);

 
            AddColumn("dbo.ItineraryAddresses", "thebestproptoeverexist", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItineraryAddresses", "thebestproptoeverexist");
        }
    }
}
