using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCapacityControl.Models;

namespace TestCapacityControl.Data
{
    public class SeedingService
    {
        private TestCapacityControlContext _context;

        public SeedingService(TestCapacityControlContext context) {
            _context = context;
        }

        public void runUpdate()
        {
            CMW500 c1 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c2 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c3 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c4 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c5 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");

            try
            {
                using (MySqlConnection cnn = new MySqlConnection("server=localhost;userid=developer;password=326727;database=TestCapacityControlappdb"))
                using (MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE CMW500", cnn))
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            { }
          
            _context.CMW500.AddRange(c1,c2,c3,c4,c5);
            _context.SaveChanges();
        }
        
    }
}
