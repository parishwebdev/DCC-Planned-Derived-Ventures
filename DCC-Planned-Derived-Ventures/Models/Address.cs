using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DCC_Planned_Derived_Ventures.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        public string AddressLine { get; set; }
        

        [ForeignKey("City")]
        [Display(Name = "City")]
        public int CityId { get; set; }
        public City City { get; set; }

        [ForeignKey("ZipCode")]
        [Display(Name = "Zip Code")]
        public int ZipId { get; set; }
        public Zip ZipCode { get; set; }

        [ForeignKey("State")]
        [Display(Name = "State")]
        public int StateId { get; set; }
        public USStates State { get; set; }


    }
}