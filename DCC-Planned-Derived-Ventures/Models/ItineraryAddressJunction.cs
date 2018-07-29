using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DCC_Planned_Derived_Ventures.Models
{
    public class ItineraryAddressJunction
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Itinerary")]
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
    }
}