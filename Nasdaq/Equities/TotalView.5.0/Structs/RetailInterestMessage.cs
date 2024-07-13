using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Retail Interest Message: Identifies a retail interest indication of the Bid, Ask or both the Bid and Ask for NASDAQ-listed securities.
    /// </summary>

    public partial class RetailInterestMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Stock Stock;
            InterestFlag InterestFlag;
        };
    };
}