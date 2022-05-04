using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display (Name = "Job Title")]
        public string JobTitle { get; set; }
        public string Scope { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
