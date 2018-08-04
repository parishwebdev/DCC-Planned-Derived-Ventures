namespace DCC_Planned_Derived_Ventures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIdentitytruetoidinitinaddres : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItineraryAddresses", "ID", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
        }
    }
}
