﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DCC_Planned_Derived_Ventures.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<DCC_Planned_Derived_Ventures.Models.Address> Addresses { get; set; }
        public System.Data.Entity.DbSet<DCC_Planned_Derived_Ventures.Models.Itinerary> Itineraries { get; set; }
        public System.Data.Entity.DbSet<DCC_Planned_Derived_Ventures.Models.ItineraryAddressJunction> ItineraryAddressJunctions { get; set; }
        public System.Data.Entity.DbSet<DCC_Planned_Derived_Ventures.Models.City> Cities { get; set; }
        public System.Data.Entity.DbSet<DCC_Planned_Derived_Ventures.Models.USStates> USStates { get; set; }
        public System.Data.Entity.DbSet<DCC_Planned_Derived_Ventures.Models.Zip> Zips { get; set; }

    }
}