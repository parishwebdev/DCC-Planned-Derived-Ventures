using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DCC_Planned_Derived_Ventures.Models
{
    public class ItineraryAddresses
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
         [ForeignKey("Itinerary")]
        public int ItineraryId { get; set; }

         public  Address Address { get; set; }
         public  Itinerary Itinerary { get; set; }
    }
}