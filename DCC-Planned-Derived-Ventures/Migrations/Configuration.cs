namespace DCC_Planned_Derived_Ventures.Migrations
{
    using DCC_Planned_Derived_Ventures.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DCC_Planned_Derived_Ventures.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DCC_Planned_Derived_Ventures.Models.ApplicationDbContext context)
        {
            context.USStates.AddOrUpdate(x => x.ID,
            new USState() { ID = 1, abbrev = "AL", name = "Alabama" },
            new USState() { ID = 2, abbrev = "AK", name = "Alaska" },
            new USState() { ID = 3, abbrev = "AZ", name = "Arizona" },
            new USState() { ID = 4, abbrev = "AR", name = "Arkansas" },
            new USState() { ID = 5, abbrev = "CA", name = "California" },
            new USState() { ID = 6, abbrev = "CO", name = "Colorado" },
            new USState() { ID = 7, abbrev = "CT", name = "Connecticut" },
            new USState() { ID = 8, abbrev = "DE", name = "Delaware" },
            new USState() { ID = 9, abbrev = "FL", name = "Florida" },
            new USState() { ID = 10, abbrev = "GA", name = "Georgia" },
            new USState() { ID = 11, abbrev = "HI", name = "Hawaii" },
            new USState() { ID = 12, abbrev = "ID", name = "Idaho" },
            new USState() { ID = 13, abbrev = "IL", name = "Illinois" },
            new USState() { ID = 14, abbrev = "IN", name = "Indiana" },
            new USState() { ID = 15, abbrev = "IA", name = "Iowa" },
            new USState() { ID = 16, abbrev = "KS", name = "Kansas" },
            new USState() { ID = 17, abbrev = "KY", name = "Kentucky" },
            new USState() { ID = 18, abbrev = "LA", name = "Louisiana" },
            new USState() { ID = 19, abbrev = "ME", name = "Maine" },
            new USState() { ID = 20, abbrev = "MD", name = "Maryland" },
            new USState() { ID = 21, abbrev = "MA", name = "Massachusetts" },
            new USState() { ID = 22, abbrev = "MI", name = "Michigan" },
            new USState() { ID = 23, abbrev = "MN", name = "Minnesota" },
            new USState() { ID = 24, abbrev = "MS", name = "Mississippi" },
            new USState() { ID = 25, abbrev = "MO", name = "Missouri" },
            new USState() { ID = 26, abbrev = "MT", name = "Montana" },
            new USState() { ID = 27, abbrev = "NE", name = "Nebraska" },
            new USState() { ID = 28, abbrev = "NV", name = "Nevada" },
            new USState() { ID = 29, abbrev = "NH", name = "New Hampshire" },
            new USState() { ID = 30, abbrev = "NJ", name = "New Jersey" },
            new USState() { ID = 31, abbrev = "NM", name = "New Mexico" },
            new USState() { ID = 32, abbrev = "NY", name = "New York" },
            new USState() { ID = 33, abbrev = "NC", name = "North Carolina" },
            new USState() { ID = 34, abbrev = "ND", name = "North Dakota" },
            new USState() { ID = 35, abbrev = "OH", name = "Ohio" },
            new USState() { ID = 36, abbrev = "OK", name = "Oklahoma" },
            new USState() { ID = 37, abbrev = "OR", name = "Oregon" },
            new USState() { ID = 38, abbrev = "PA", name = "Pennsylvania" },
            new USState() { ID = 39, abbrev = "RI", name = "Rhode Island" },
            new USState() { ID = 40, abbrev = "SC", name = "South Carolina" },
            new USState() { ID = 41, abbrev = "SD", name = "South Dakota" },
            new USState() { ID = 42, abbrev = "TN", name = "Tennessee" },
            new USState() { ID = 43, abbrev = "TX", name = "Texas" },
            new USState() { ID = 44, abbrev = "UT", name = "Utah" },
            new USState() { ID = 45, abbrev = "VT", name = "Vermont" },
            new USState() { ID = 46, abbrev = "VA", name = "Virginia" },
            new USState() { ID = 47, abbrev = "WA", name = "Washington" },
            new USState() { ID = 48, abbrev = "WV", name = "West Virginia" },
            new USState() { ID = 49, abbrev = "WI", name = "Wisconsin" },
            new USState() { ID = 50, abbrev = "WY", name = "Wyoming" });

        }
    }
}
