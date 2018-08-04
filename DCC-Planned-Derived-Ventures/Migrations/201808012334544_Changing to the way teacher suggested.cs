namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changingtothewayteachersuggested : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ItineraryAddresses");
            AddColumn("dbo.ItineraryAddresses", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ItineraryAddresses", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ItineraryAddresses");
            DropColumn("dbo.ItineraryAddresses", "ID");
            AddPrimaryKey("dbo.ItineraryAddresses", new[] { "AddressId", "ItineraryId" });
        }
    }
}
