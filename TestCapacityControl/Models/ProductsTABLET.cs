

using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TestCapacityControl.Exceptions;

namespace TestCapacityControl.Models
{
    public class ProductsTABLET
    {
        [Key]
        public int productTablet_Id { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }

        public ProductsTABLET()
        {

        }
        public ProductsTABLET(int id, string productName, string model, string status)
        {
            productTablet_Id = id;
            ProductName = productName;
            Model = model;
            Status = status;
        }

        public double YieldInline = 0.0;
        public double YieldWifi = 0.0;
        public double YieldRFCal = 0.0;
        public double YieldNSFT = 0.0;
        public double YieldRadCurr = 0.0;
        public double YieldTOF = 0.0;
        public double YieldANT = 0.0;
        public double YieldMMI1 = 0.0;
        public double YieldMMI2 = 0.0;
        public double YieldAUDIO = 0.0;
        public double YieldWriteNumber = 0.0;
        public double YieldCFCUp = 0.0;
        public double YieldMMI3 = 0.0;

        public double NTFInline = 0.0;
        public double NTFWifi = 0.0;
        public double NTFRFCal = 0.0;
        public double NTFNSFT = 0.0;
        public double NTFRadCurr = 0.0;
        public double NTFTOF = 0.0;
        public double NTFANT = 0.0;
        public double NTFMMI1 = 0.0;
        public double NTFMMI2 = 0.0;
        public double NTFAUDIO = 0.0;
        public double NTFWriteNumber = 0.0;
        public double NTFCFCUp = 0.0;
        public double NTFMMI3 = 0.0;

        public double MTimeInline = 0.0;
        public double MTimeWifi = 0.0;
        public double MTimeRFCal = 0.0;
        public double MTimeNSFT = 0.0;
        public double MTimeRadCurr = 0.0;
        public double MTimeTOF = 0.0;
        public double MTimeANT = 0.0;
        public double MTimeMMI1 = 0.0;
        public double MTimeMMI2 = 0.0;
        public double MTimeAUDIO = 0.0;
        public double MTimeWriteNumber = 0.0;
        public double MTimeCFCUp = 0.0;
        public double MTimeMMI3 = 0.0;

        private TestCapacityControlContext _context;
        public ProductsTABLET(TestCapacityControlContext context)
        {
            _context = context;
        }
        public void runUpdate()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection("server=localhost;userid=developer;password=326727;database=TestCapacityControlappdb"))
                {
                    cnn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM PRODUCTUPDATETABLET WHERE PRODUCTNAMEUP = @ProductName", cnn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", ProductName);
                        var result = Convert.ToInt32(cmd.ExecuteScalar());
                        if (result > 0)
                        {
                            YieldInline = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldInline;
                            YieldWifi = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldWifi;
                            YieldRFCal = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldRFCal;
                            YieldNSFT = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldNSFT;
                            YieldRadCurr = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldRadCurr;
                            YieldTOF = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldTOF;
                            YieldANT = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldANT;
                            YieldMMI1 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldMMI1;
                            YieldMMI2 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldMMI2;
                            YieldAUDIO = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldAudio;
                            YieldWriteNumber = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldWriteNumber;
                            YieldCFCUp = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldCFCUp;
                            YieldMMI3 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldMMI3;

                            NTFInline = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfInline;
                            NTFWifi = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfWifi;
                            NTFRFCal = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfRFCal;
                            NTFNSFT = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfNSFT;
                            NTFRadCurr = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfRadCurr;
                            NTFTOF = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfTOF;
                            NTFANT = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfANT;
                            NTFMMI1 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfMMI1;
                            NTFMMI2 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfMMI2;
                            NTFAUDIO = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfAudio;
                            NTFWriteNumber = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfWriteNumber;
                            NTFCFCUp = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfCFCUp;
                            NTFMMI3 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).NtfMMI3;

                            MTimeInline = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).YieldInline;
                            MTimeWifi = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeWifi;
                            MTimeRFCal = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeRFCal;
                            MTimeNSFT = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeNSFT;
                            MTimeRadCurr = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeRadCurr;
                            MTimeTOF = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeTOF;
                            MTimeANT = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeANT;
                            MTimeMMI1 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeMMI1;
                            MTimeMMI2 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeMMI2;
                            MTimeAUDIO = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeAudio;
                            MTimeWriteNumber = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeWriteNumber;
                            MTimeCFCUp = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeCFCUp;
                            MTimeMMI3 = _context.ProductUpdateTablet.FirstOrDefault(x => x.ProductNameUp == ProductName).MTimeMMI3;
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
