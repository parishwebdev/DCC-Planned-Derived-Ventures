using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace  DCC_Planned_Derived_Ventures.Models
{
    public class Itinerary
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Itinerary Name")]
        public string name { get; set; }

        [Display(Name = "Miles Around Destination")]
        public int MilesAroundRoute { get; set; }

         
        //Destination
        public int DestinationId { get; set; }


        public string AspNetUserId { get; set; }

        public IEnumerable<Address> Addresses { get; set; } 
    }
}