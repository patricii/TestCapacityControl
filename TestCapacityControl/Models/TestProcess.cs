using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class TestProcess
    {
        public int Id { get; set; }
        public string Technology { get; set; }
        public string L2 { get; set; }
        public string M2 { get; set; }
        public string JOT_Slim { get; set; }
        public string JOT { get; set; }

        public string WUHAN_L2 { get; set; }
        public string WUHAN_JOT_Slim { get; set; }
        public string WUHAN_JOT { get; set; }
    }
}
