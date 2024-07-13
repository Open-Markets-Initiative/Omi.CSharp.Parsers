using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Order Cancel Message: This message is sent whenever an order on the book is modified as a result of a partial cancellation.
    /// </summary>

    public partial class OrderCancelMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            OrderReferenceNumber OrderReferenceNumber;
            CanceledShares CanceledShares;
        };
    };
}