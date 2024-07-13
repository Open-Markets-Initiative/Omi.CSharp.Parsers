using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Reg Sho Short Sale Price Test Restricted Indicator Message: NASDAQ processes orders based on the most Reg SHO Restriction status value.
    /// </summary>

    public partial class RegShoShortSalePriceTestRestrictedIndicatorMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LocateCode LocateCode;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Stock Stock;
            RegShoAction RegShoAction;
        };
    };
}