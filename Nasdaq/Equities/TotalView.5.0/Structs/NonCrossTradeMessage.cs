using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Non Cross Trade Message: Trade Messages should be included in NASDAQ time-and-sales displays as well as volume and other market statistics.  Since Trade Messages do not affect the book, however, they may be ignored by firms just looking to build and track the NASDAQ execution system display.
    /// </summary>

    public partial class NonCrossTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            OrderReferenceNumber OrderReferenceNumber;
            BuySellIndicator BuySellIndicator;
            Shares Shares;
            Stock Stock;
            Price Price;
            MatchNumber MatchNumber;
        };
    };
}