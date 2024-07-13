using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Order Replace Message: This message is sent whenever an order on the book has been cancel-replaced.  All remaining shares from the original order are no longer accessible, and must be removed.  The new order details are provided for the replacement, along with a new order reference number which will be used henceforth.  Since the side, stock symbol and attribution (if any) cannot be changed by an Order Replace event, these fields are not included in the message.  Firms should retain the side, stock symbol and MPID from the original Add Order message.
    /// </summary>

    public partial class OrderReplaceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            OriginalOrderReferenceNumber OriginalOrderReferenceNumber;
            NewOrderReferenceNumber NewOrderReferenceNumber;
            Shares Shares;
            Price Price;
        };
    };
}