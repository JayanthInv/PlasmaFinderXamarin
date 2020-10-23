using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlasmaFinder.Models
{
    public class PlasmaUser
    {
        public int Id{ get; set; }
        [Required,StringLength(15)]
        public String Username { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Location { get; set; }
        public String BloodGroup { get; set; }
        public int Date { get; set; }
    
    }
}