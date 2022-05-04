
using System.ComponentModel.DataAnnotations;

namespace TestCapacityControl.Models
{
    public class ProductSetup
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string Product { get; set; }

        [Display(Name = "Testset Models")]
        public string TestSets { get; set; }

        [Display(Name = "Power Supply Models")]
        public string PowerSupply { get; set; }
        public string License { get; set; }

        [Display(Name = "PS-Aux")]
        public string PSAUX { get; set; }
        public string TDD { get; set; }

        [Display(Name = "6Ghz Freq.")]
        public string Freq6Ghz { get; set; }


    }
}
