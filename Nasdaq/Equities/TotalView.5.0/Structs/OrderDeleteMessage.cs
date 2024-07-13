using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Order Delete Message: This message is sent whenever an order on the book is being cancelled.  All remaining shares are no longer accessible so the order must be removed from the book.
    /// </summary>

    public partial class OrderDeleteMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            OrderReferenceNumber OrderReferenceNumber;
        };
    };
}