namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gotridofextraproperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ItineraryAddresses", "thebestproptoeverexist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItineraryAddresses", "thebestproptoeverexist", c => c.Int(nullable: false));
        }
    }
}
