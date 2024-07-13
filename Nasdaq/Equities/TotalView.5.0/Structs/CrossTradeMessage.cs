using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Cross Trade Message: Cross Trade message indicates that NASDAQ has completed its cross process for a specific security.  NASDAQ sends out a Cross Trade message for all active issues in the system following the Opening, Closing and EMC cross events.  Firms may use the Cross Trade message to determine when the cross for each security has been completed.  (Note:  For the halted / paused securities, firms should use the Trading Action message to determine when an issue has been released for trading.)
    /// </summary>

    public partial class CrossTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            CrossShares CrossShares;
            Stock Stock;
            CrossPrice CrossPrice;
            MatchNumber MatchNumber;
            CrossType CrossType;
        };
    };
}