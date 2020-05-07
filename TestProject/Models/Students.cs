using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{
    public class Students
    {
        [Required]
        public int StudentId { get; set; }
        public string FirstName{ get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        public string Career  { get; set; }
        public string Institution { get; set; }
        public int  YearlyCost { get; set; }

    }
}
