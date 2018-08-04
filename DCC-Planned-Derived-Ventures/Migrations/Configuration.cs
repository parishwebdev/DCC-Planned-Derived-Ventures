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
            new USStates() { ID = 1, abbrev = "AL", name = "Alabama" },
            new USStates() { ID = 2, abbrev = "AK", name = "Alaska" },
            new USStates() { ID = 3, abbrev = "AZ", name = "Arizona" },
            new USStates() { ID = 4, abbrev = "AR", name = "Arkansas" },
            new USStates() { ID = 5, abbrev = "CA", name = "California" },
            new USStates() { ID = 6, abbrev = "CO", name = "Colorado" },
            new USStates() { ID = 7, abbrev = "CT", name = "Connecticut" },
            new USStates() { ID = 8, abbrev = "DE", name = "Delaware" },
            new USStates() { ID = 9, abbrev = "FL", name = "Florida" },
            new USStates() { ID = 10, abbrev = "GA", name = "Georgia" },
            new USStates() { ID = 11, abbrev = "HI", name = "Hawaii" },
            new USStates() { ID = 12, abbrev = "ID", name = "Idaho" },
            new USStates() { ID = 13, abbrev = "IL", name = "Illinois" },
            new USStates() { ID = 14, abbrev = "IN", name = "Indiana" },
            new USStates() { ID = 15, abbrev = "IA", name = "Iowa" },
            new USStates() { ID = 16, abbrev = "KS", name = "Kansas" },
            new USStates() { ID = 17, abbrev = "KY", name = "Kentucky" },
            new USStates() { ID = 18, abbrev = "LA", name = "Louisiana" },
            new USStates() { ID = 19, abbrev = "ME", name = "Maine" },
            new USStates() { ID = 20, abbrev = "MD", name = "Maryland" },
            new USStates() { ID = 21, abbrev = "MA", name = "Massachusetts" },
            new USStates() { ID = 22, abbrev = "MI", name = "Michigan" },
            new USStates() { ID = 23, abbrev = "MN", name = "Minnesota" },
            new USStates() { ID = 24, abbrev = "MS", name = "Mississippi" },
            new USStates() { ID = 25, abbrev = "MO", name = "Missouri" },
            new USStates() { ID = 26, abbrev = "MT", name = "Montana" },
            new USStates() { ID = 27, abbrev = "NE", name = "Nebraska" },
            new USStates() { ID = 28, abbrev = "NV", name = "Nevada" },
            new USStates() { ID = 29, abbrev = "NH", name = "New Hampshire" },
            new USStates() { ID = 30, abbrev = "NJ", name = "New Jersey" },
            new USStates() { ID = 31, abbrev = "NM", name = "New Mexico" },
            new USStates() { ID = 32, abbrev = "NY", name = "New York" },
            new USStates() { ID = 33, abbrev = "NC", name = "North Carolina" },
            new USStates() { ID = 34, abbrev = "ND", name = "North Dakota" },
            new USStates() { ID = 35, abbrev = "OH", name = "Ohio" },
            new USStates() { ID = 36, abbrev = "OK", name = "Oklahoma" },
            new USStates() { ID = 37, abbrev = "OR", name = "Oregon" },
            new USStates() { ID = 38, abbrev = "PA", name = "Pennsylvania" },
            new USStates() { ID = 39, abbrev = "RI", name = "Rhode Island" },
            new USStates() { ID = 40, abbrev = "SC", name = "South Carolina" },
            new USStates() { ID = 41, abbrev = "SD", name = "South Dakota" },
            new USStates() { ID = 42, abbrev = "TN", name = "Tennessee" },
            new USStates() { ID = 43, abbrev = "TX", name = "Texas" },
            new USStates() { ID = 44, abbrev = "UT", name = "Utah" },
            new USStates() { ID = 45, abbrev = "VT", name = "Vermont" },
            new USStates() { ID = 46, abbrev = "VA", name = "Virginia" },
            new USStates() { ID = 47, abbrev = "WA", name = "Washington" },
            new USStates() { ID = 48, abbrev = "WV", name = "West Virginia" },
            new USStates() { ID = 49, abbrev = "WI", name = "Wisconsin" },
            new USStates() { ID = 50, abbrev = "WY", name = "Wyoming" });
        }
    }
}
