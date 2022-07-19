using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class ProductUpdateCelular
    {
        [Key]
        public int pUC_Id { get; set; }

        public string ProductNameUp { get; set; }
        public double YieldInline { get; set; }
        public double YieldBrdTest { get; set; }
        public double YieldBoardTst { get; set; }
        public double Yield5GFR { get; set; }
        public double YieldDCAL { get; set; }
        public double YieldDVAL { get; set; }
        public double YieldCamCAL { get; set; }
        public double YieldCamVAL { get; set; }
        public double YieldJOT { get; set; }
        public double YieldL2Vision { get; set; }
        public double YieldL2AR { get; set; }
        public double YieldM2Cam { get; set; }
        public double YieldM2AR { get; set; }
        public double YieldJotSlim { get; set; }
        public double YieldARSlim { get; set; }
        public double YieldCFC { get; set; }
        public double YieldPatsJot { get; set; }
        public double YieldPatsM2 { get; set; }
        public double YieldPatsSlim { get; set; }

        public double NtfInline { get; set; }
        public double NtfBrdTest { get; set; }
        public double NtfBoardTst { get; set; }
        public double Ntf5GFR { get; set; }
        public double NtfDCAL { get; set; }
        public double NtfDVAL { get; set; }
        public double NtfCamCAL { get; set; }
        public double NtfCamVAL { get; set; }
        public double NtfJOT { get; set; }
        public double NtfL2Vision { get; set; }
        public double NtfL2AR { get; set; }
        public double NtfM2Cam { get; set; }
        public double NtfM2AR { get; set; }
        public double NtfJotSlim { get; set; }
        public double NtfARSlim { get; set; }
        public double NtfCFC { get; set; }
        public double NtfPatsJot { get; set; }
        public double NtfPatsM2 { get; set; }
        public double NtfPatsSlim { get; set; }

        public double MTimeInline { get; set; }
        public double MTimeBrdTest { get; set; }
        public double MTimeBoardTst { get; set; }
        public double MTime5GFR { get; set; }
        public double MTimeDCAL { get; set; }
        public double MTimeDVAL { get; set; }
        public double MTimeCamCAL { get; set; }
        public double MTimeCamVAL { get; set; }
        public double MTimeJOT { get; set; }
        public double MTimeL2Vision { get; set; }
        public double MTimeL2AR { get; set; }
        public double MTimeM2Cam { get; set; }
        public double MTimeM2AR { get; set; }

        public double MTimeJotSlim { get; set; }
        public double MTimeARSlim { get; set; }
        public double MTimeCFC { get; set; }
        public double MTimePatsJot { get; set; }
        public double MTimePatsM2 { get; set; }
        public double MTimePatsSlim { get; set; }

        public ProductUpdateCelular(string productNameUp, double yieldInline, double yieldBrdTest, double yieldBoardTst, double yield5GFR, double yieldDCAL, double yieldDVAL, double yieldCamCAL, double yieldCamVAL, double yieldJOT, double yieldL2Vision, double yieldL2AR, double yieldM2Cam, double yieldM2AR, double yieldJotSlim, double yieldARSlim, double yieldCFC, double yieldPatsJot, double yieldPatsM2, double yieldPatsSlim, double ntfInline, double ntfBrdTest, double ntfBoardTst, double ntf5GFR, double ntfDCAL, double ntfDVAL, double ntfCamCAL, double ntfCamVAL, double ntfJOT, double ntfL2Vision, double ntfL2AR, double ntfM2Cam, double ntfM2AR, double ntfJotSlim, double ntfARSlim, double ntfCFC, double ntfPatsJot, double ntfPatsM2, double ntfPatsSlim, double mTimeInline, double mTimeBrdTest, double mTimeBoardTst, double mTime5GFR, double mTimeDCAL, double mTimeDVAL, double mTimeCamCAL, double mTimeCamVAL, double mTimeJOT, double mTimeL2Vision, double mTimeL2AR, double mTimeM2Cam, double mTimeM2AR, double mTimeJotSlim, double mTimeARSlim, double mTimeCFC, double mTimePatsJot, double mTimePatsM2, double mTimePatsSlim)
        {
            ProductNameUp = productNameUp;
            YieldInline = yieldInline;
            YieldBrdTest = yieldBrdTest;
            YieldBoardTst = yieldBoardTst;
            Yield5GFR = yield5GFR;
            YieldDCAL = yieldDCAL;
            YieldDVAL = yieldDVAL;
            YieldCamCAL = yieldCamCAL;
            YieldCamVAL = yieldCamVAL;
            YieldJOT = yieldJOT;
            YieldL2Vision = yieldL2Vision;
            YieldL2AR = yieldL2AR;
            YieldM2Cam = yieldM2Cam;
            YieldM2AR = yieldM2AR;
            YieldJotSlim = yieldJotSlim;
            YieldARSlim = yieldARSlim;
            YieldCFC = yieldCFC;
            YieldPatsJot = yieldPatsJot;
            YieldPatsM2 = yieldPatsM2;
            YieldPatsSlim = yieldPatsSlim;
            NtfInline = ntfInline;
            NtfBrdTest = ntfBrdTest;
            NtfBoardTst = ntfBoardTst;
            Ntf5GFR = ntf5GFR;
            NtfDCAL = ntfDCAL;
            NtfDVAL = ntfDVAL;
            NtfCamCAL = ntfCamCAL;
            NtfCamVAL = ntfCamVAL;
            NtfJOT = ntfJOT;
            NtfL2Vision = ntfL2Vision;
            NtfL2AR = ntfL2AR;
            NtfM2Cam = ntfM2Cam;
            NtfM2AR = ntfM2AR;
            NtfJotSlim = ntfJotSlim;
            NtfARSlim = ntfARSlim;
            NtfCFC = ntfCFC;
            NtfPatsJot = ntfPatsJot;
            NtfPatsM2 = ntfPatsM2;
            NtfPatsSlim = ntfPatsSlim;
            MTimeInline = mTimeInline;
            MTimeBrdTest = mTimeBrdTest;
            MTimeBoardTst = mTimeBoardTst;
            MTime5GFR = mTime5GFR;
            MTimeDCAL = mTimeDCAL;
            MTimeDVAL = mTimeDVAL;
            MTimeCamCAL = mTimeCamCAL;
            MTimeCamVAL = mTimeCamVAL;
            MTimeJOT = mTimeJOT;
            MTimeL2Vision = mTimeL2Vision;
            MTimeL2AR = mTimeL2AR;
            MTimeM2Cam = mTimeM2Cam;
            MTimeM2AR = mTimeM2AR;
            MTimeJotSlim = mTimeJotSlim;
            MTimeARSlim = mTimeARSlim;
            MTimeCFC = mTimeCFC;
            MTimePatsJot = mTimePatsJot;
            MTimePatsM2 = mTimePatsM2;
            MTimePatsSlim = mTimePatsSlim;
        }
        public ProductUpdateCelular()
        {
        }
    }
}
