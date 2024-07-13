using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Order Executed Message: This message is sent whenever an order on the book is executed in whole or in part. It is possible to receive several Order Executed Messages for the same order reference number if that order is executed in several parts. The multiple Order Executed Messages on the same order are cumulative.
    /// </summary>

    public partial class OrderExecutedMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            OrderReferenceNumber OrderReferenceNumber;
            ExecutedShares ExecutedShares;
            MatchNumber MatchNumber;
        };
    };
}