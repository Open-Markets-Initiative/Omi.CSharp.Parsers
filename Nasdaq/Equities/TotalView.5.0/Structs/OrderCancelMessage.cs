using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Order Cancel Message: This message is sent whenever an order on the book is modified as a result of a partial cancellation.
/// </summary>

public partial class OrderCancelMessage
{
    /// <summary>
    ///  Always 0
    /// </summary>
    public ushort StockLocate => Layout.StockLocate.Value;

    /// <summary>
    ///  NASDAQ OMX internal tracking number
    /// </summary>
    public ushort TrackingNumber => Layout.TrackingNumber.Value;

    /// <summary>
    ///  Nanoseconds since midnight.
    /// </summary>
    public string Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  The unique reference number assigned to the new order at the time of receipt.
    /// </summary>
    public ulong OrderReferenceNumber => Layout.OrderReferenceNumber.Value;

    /// <summary>
    ///  The number of shares being removed from the display size of the order as the result of a cancellation.
    /// </summary>
    public uint CanceledShares => Layout.CanceledShares.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public OrderReferenceNumber OrderReferenceNumber;
        public CanceledShares CanceledShares;
    };
};
