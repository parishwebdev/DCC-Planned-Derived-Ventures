using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DCC_Planned_Derived_Ventures.Models
{
    public class Zip
    {
        [Key]
        public int ID { get; set; }
        public int ZipCode { get; set; }
    }
}