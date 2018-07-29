using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DCC_Planned_Derived_Ventures.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }

        public string name { get; set; }
    }
}