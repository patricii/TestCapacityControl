
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TestCapacityControl.Exceptions;

namespace TestCapacityControl.Models
{
    public class Products
    {
        [Key]
        public int products_Id { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }

        public Products()
        {

        }

        public Products(int id, string productName, string model, string status)
        {
            products_Id = id;
            ProductName = productName;
            Model = model;
            Status = status;
        }

        public double YieldInline = 0.0;
        public double YieldBrdTest = 0.0;
        public double YieldBoardTst = 0.0;
        public double Yield5GFR = 0.0;
        public double YieldDCAL = 0.0;
        public double YieldDVAL = 0.0;
        public double YieldCamCAL = 0.0;
        public double YieldCamVAL = 0.0;
        public double YieldJOT = 0.0;
        public double YieldL2Vision = 0.0;
        public double YieldL2AR = 0.0;
        public double YieldM2Cam = 0.0;
        public double YieldM2AR = 0.0;
        public double YieldJotSlim = 0.0;
        public double YieldARSlim = 0.0;
        public double YieldCFC = 0.0;
        public double YieldPatsJot = 0.0;
        public double YieldPatsM2 = 0.0;
        public double YieldPatsSlim = 0.0;

        public double NtfInline = 0.0;
        public double NtfBrdTest = 0.0;
        public double NtfBoardTst = 0.0;
        public double Ntf5GFR = 0.0;
        public double NtfDCAL = 0.0;
        public double NtfDVAL = 0.0;
        public double NtfCamCAL = 0.0;
        public double NtfCamVAL = 0.0;
        public double NtfJOT = 0.0;
        public double NtfL2Vision = 0.0;
        public double NtfL2AR = 0.0;
        public double NtfM2Cam = 0.0;
        public double NtfM2AR = 0.0;
        public double NtfJotSlim = 0.0;
        public double NtfARSlim = 0.0;
        public double NtfCFC = 0.0;
        public double NtfPatsJot = 0.0;
        public double NtfPatsM2 = 0.0;
        public double NtfPatsSlim = 0.0;

        public double MTimeInline = 0.0;
        public double MTimeBrdTest = 0.0;
        public double MTimeBoardTst = 0.0;
        public double MTime5GFR = 0.0;
        public double MTimeDCAL = 0.0;
        public double MTimeDVAL = 0.0;
        public double MTimeCamCAL = 0.0;
        public double MTimeCamVAL = 0.0;
        public double MTimeJOT = 0.0;
        public double MTimeL2Vision = 0.0;
        public double MTimeL2AR = 0.0;
        public double MTimeM2Cam = 0.0;
        public double MTimeM2AR = 0.0;
        public double MTimeJotSlim = 0.0;
        public double MTimeARSlim = 0.0;
        public double MTimeCFC = 0.0;
        public double MTimePatsJot = 0.0;
        public double MTimePatsM2 = 0.0;
        public double MTimePatsSlim = 0.0;

        private TestCapacityControlContext _context;
        public Products(TestCapacityControlContext context)
        {
            _context = context;

        }

        public void runUpdate() //To Update the data from DB
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection("server=localhost;userid=developer;password=326727;database=TestCapacityControlappdb"))
                {
                    cnn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM PRODUCTUPDATECELULAR WHERE PRODUCTNAMEUP = @ProductName", cnn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", ProductName);
                        var result = Convert.ToInt32(cmd.ExecuteScalar());
                        if (result > 0)
                        {
                            YieldInline = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldInline;
                            YieldBrdTest = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldBrdTest;
                            YieldBoardTst = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldBoardTst;
                            Yield5GFR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).Yield5GFR;
                            YieldDCAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldDCAL;
                            YieldDVAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldDVAL;
                            YieldCamCAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldCamCAL;
                            YieldCamVAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldCamVAL;
                            YieldJOT = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldJOT;
                            YieldL2Vision = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldL2Vision;
                            YieldL2AR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldL2AR;
                            YieldM2Cam = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldM2Cam;
                            YieldM2AR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldM2AR;
                            YieldJotSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldJotSlim;
                            YieldARSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldARSlim;
                            YieldCFC = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldCFC;
                            YieldPatsJot = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldPatsJot;
                            YieldPatsM2 = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldPatsM2;
                            YieldPatsSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldPatsSlim;

                            NtfInline = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfInline;
                            NtfBrdTest = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfBrdTest;
                            NtfBoardTst = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfBoardTst;
                            Ntf5GFR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).Ntf5GFR;
                            NtfDCAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfDCAL;
                            NtfDVAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfDVAL;
                            NtfCamCAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfCamCAL;
                            NtfCamVAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfCamVAL;
                            NtfJOT = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfJOT;
                            NtfL2Vision = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfL2Vision;
                            NtfL2AR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfL2AR;
                            NtfM2Cam = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfM2Cam;
                            NtfM2AR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfM2AR;
                            NtfJotSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfJotSlim;
                            NtfARSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfARSlim;
                            NtfCFC = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfCFC;
                            NtfPatsJot = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfPatsJot;
                            NtfPatsM2 = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfPatsM2;
                            NtfPatsSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfPatsSlim;

                            MTimeInline = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeInline;
                            MTimeBrdTest = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeBrdTest;
                            MTimeBoardTst = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeBoardTst;
                            MTime5GFR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTime5GFR;
                            MTimeDCAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeDCAL;
                            MTimeDVAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeDVAL;
                            MTimeCamCAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeCamCAL;
                            MTimeCamVAL = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeCamVAL;
                            MTimeJOT = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeJOT;
                            MTimeL2Vision = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldInline;
                            MTimeL2AR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeL2AR;
                            MTimeM2Cam = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeM2Cam;
                            MTimeM2AR = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeM2AR;
                            MTimeJotSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeJotSlim;
                            MTimeARSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeARSlim;
                            MTimeCFC = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeCFC;
                            MTimePatsJot = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimePatsJot;
                            MTimePatsM2 = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimePatsM2;
                            MTimePatsSlim = _context.ProductUpdateCelular.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimePatsSlim;

                        }
                    }
                }
            }
            catch
            {
                throw new NotFoundException("Product Data Not Found!!!");
            }
        }
    }
}
