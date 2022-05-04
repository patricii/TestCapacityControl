using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class TestProcess
    {
        public int Id { get; set; }
        public string Technology { get; set; }

        [Display(Name = "L2")]
        public string L2 { get; set; }

        [Display(Name = "M2")]
        public string M2 { get; set; }

        [Display(Name = "JOT Slim")]
        public string JOT_Slim { get; set; }

        [Display(Name = "JOT")]
        public string JOT { get; set; }

        [Display(Name = " | WUHAN - L2")]
        public string WUHAN_L2 { get; set; }

        [Display(Name = "WUHAN - JOT Slim")]
        public string WUHAN_JOT_Slim { get; set; }

        [Display(Name = "WUHAN - JOT")]
        public string WUHAN_JOT { get; set; }
    }
}
