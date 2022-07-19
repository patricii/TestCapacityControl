using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class CMW500
    {
        [Key]
        public int CMW_Id { get; set; }

        [DataType (DataType.Date)]
        public DateTime Updated { get; set; }
        public string Site { get; set; }
        public string Group { get; set; }

        [Display (Name = "Last Station")]
        public string Last_Station { get; set; }

        [Display(Name = "ID Motorola")]
        public int Id_Motorola { get; set; }

        [Display(Name = "ID FLEX")]
        public int Id_Flex { get; set; }

        [Display(Name = "Serial Number")]
        public int SerialNumber { get; set; }

        public string Type { get; set; }

        [Display(Name = "KM550 LTE TDD")]
        public int KM550_LTE_TDD { get; set; }

        [Display(Name = "KM011 QC CAL")]
        public int KM011_QC_CAL { get; set; }

        [Display(Name = "KV113 MTK CAL")]
        public int KV113_MTK_CAL { get; set; }

        [Display(Name = "KM800 CDMA")]
        public int KM800_CDMA { get; set; }

        [Display(Name = "KB036 6GHz")]
        public int KB036_6GHz { get; set; }

        [Display(Name = "KV120 UNISOC")]
        public int KV120_Unisoc { get; set; }

        [Display(Name = "WIFI KM650/KM651 KM656/KM610")]
        public int WiFi_KM650_KM610 { get; set; }

        public string Comments { get; set; }

        public CMW500(DateTime updated, string site, string group, string last_Station, int id_Motorola, int id_Flex, int serialNumber, string type, int kM550_LTE_TDD, int kM011_QC_CAL, int kV113_MTK_CAL, int kM800_CDMA, int kB036_6GHz, int kV120_Unisoc, int wiFi_KM650_KM610, string comments)
        {
            Updated = updated;
            Site = site;
            Group = group;
            Last_Station = last_Station;
            Id_Motorola = id_Motorola;
            Id_Flex = id_Flex;
            SerialNumber = serialNumber;
            Type = type;
            KM550_LTE_TDD = kM550_LTE_TDD;
            KM011_QC_CAL = kM011_QC_CAL;
            KV113_MTK_CAL = kV113_MTK_CAL;
            KM800_CDMA = kM800_CDMA;
            KB036_6GHz = kB036_6GHz;
            KV120_Unisoc = kV120_Unisoc;
            WiFi_KM650_KM610 = wiFi_KM650_KM610;
            Comments = comments;
        }
        public CMW500()
        {
        }
    }
}
