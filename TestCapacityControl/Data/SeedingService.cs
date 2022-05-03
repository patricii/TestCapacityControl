﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCapacityControl.Exceptions;
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
            {
                throw new DBException("TRUNCATE TABLE error!!!");
            }

            CMW500 c1 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c2 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c3 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c4 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c5 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c6 = new CMW500(new DateTime(2021, 10, 4), "JAG", "ME", "ME01-PB01F1T01-BT005A", 200418083, 2724, 141466, "DUAL", 2, 2, 2, 2, 2, 0, 2, "NA");
            CMW500 c7 = new CMW500(new DateTime(2020, 9, 14), "MAO", "ME", "ME04-PB91F1T04-BT001A", 200418093, 2725, 141467, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c8 = new CMW500(new DateTime(2021,3,3), "MAO", "ME", "ME10-PB91F1T10-BT002A", 200418092, 2733, 141468, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c9 = new CMW500(new DateTime(2021, 4, 10), "JAG", "ME", "ME07-PB01F1T07-BT001A", 200418091, 2727, 141469, "DUAL", 2, 2, 2, 2, 2, 0, 2, "NA");
            CMW500 c10 = new CMW500(new DateTime(2021, 10, 4), "JAG", "ME", "ME03-PB01F1T03-BT005A", 200418089, 2728, 141470, "DUAL", 2, 2, 2, 2, 2, 0, 2, "NA");

            CMW500 c11= new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c12 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c13 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c14 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c15 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c16 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c17 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c18 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c19 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c20 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c21 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c22 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c23 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c24 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c25 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c26 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c27 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c28 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c29 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c30 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c31 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c32 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c33 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c34 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c35 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c36 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c37 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c38 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c39 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c40 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c41 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c42 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c43 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c44 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c45 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c46 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c47 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c48 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c49 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c50 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c51 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c52 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c53 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c54 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c55 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c56 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c57 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c58 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c59 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c60 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c61 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c62 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c63 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c64 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c65 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c66 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c67 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c68 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c69 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c70 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c71 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c72 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c73 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c74 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c75 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c76 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c77 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c78 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c79 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c80 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c81 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c82 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c83 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c84 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c85 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c86 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c87 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c88 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c89 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c90 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c91 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c92 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c93 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c94 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c95 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c96 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c97 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c98 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c99 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c100 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c101 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c102 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c103 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c104 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT003A", 200418055, 2722, 141464, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c105 = new CMW500(new DateTime(2020, 12, 11), "MAO", "ME", "ME15-PB91F1T15-BT001A", 200418066, 2723, 141465, "DUAL", 2, 2, 2, 0, 0, 0, 0, "NA");
            CMW500 c106 = new CMW500(new DateTime(2021, 3, 3), "MAO", "ME", "ME04-PB91F1T04-BT002A", 200418067, 2594, 141461, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c107 = new CMW500(new DateTime(2021, 9, 2), "JAG", "ME", "ME08-PB01F1T08-BT005A", 200418022, 2596, 141462, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");
            CMW500 c108 = new CMW500(new DateTime(2020, 9, 23), "MAO", "ME", "REPARO", 200418058, 2597, 141463, "DUAL", 2, 2, 2, 0, 0, 2, 0, "NA");

            _context.CMW500.AddRange(c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27,c28,c29,c30,c31,c32,c33,c34,c35,c36,c37,c38,c39,c40,c41,c42,c43,c44,c45,c46,c47,c48,c49,c50,c51,c52,c53,c54,c55,c56,c57,c58,c59,c60,c61,c62,c63,c64,c65,c66,c67,c68,c69,c70,c71,c72,c73,c74,c75,c76,c77,c78,c79,c80,c81,c82,c83,c84,c85,c86,c87,c88,c89,c90,c91,c92,c93,c94,c95,c96,c97,c98,c99,c100,c101,c102,c103,c104,c105,c106,c107,c108);
            _context.SaveChanges();
        }
        
    }
}
