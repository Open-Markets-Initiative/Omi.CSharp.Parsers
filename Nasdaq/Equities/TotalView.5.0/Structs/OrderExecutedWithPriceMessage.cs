using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Order Executed With Price Message: This message is sent whenever an order on the book is executed in whole or in part at a price different from the initial display price.  Since the execution price is different than the display price of the original Add Order, NASDAQ includes a price field within this execution message.
    /// </summary>

    public partial class OrderExecutedWithPriceMessage
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
            Printable Printable;
            ExecutionPrice ExecutionPrice;
        };
    };
}