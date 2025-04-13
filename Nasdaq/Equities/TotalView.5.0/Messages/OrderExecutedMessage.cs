using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Order Executed Message: This message is sent whenever an order on the book is executed in whole or in part. It is possible to receive several Order Executed Messages for the same order reference number if that order is executed in several parts. The multiple Order Executed Messages on the same order are cumulative.
/// </summary>

public partial class OrderExecutedMessage
{
    /// <summary>
    ///  Always 0
    /// </summary>
    public ushort StockLocate => Fields.StockLocate.Value;

    /// <summary>
    ///  NASDAQ OMX internal tracking number
    /// </summary>
    public ushort TrackingNumber => Fields.TrackingNumber.Value;

    /// <summary>
    ///  Nanoseconds since midnight.
    /// </summary>
    public string Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The unique reference number assigned to the new order at the time of receipt.
    /// </summary>
    public ulong OrderReferenceNumber => Fields.OrderReferenceNumber.Value;

    /// <summary>
    ///  The number of shares executed.
    /// </summary>
    public uint ExecutedShares => Fields.ExecutedShares.Value;

    /// <summary>
    ///  The NASDAQ generated day-unique Match Number of this execution. The match number is also referenced in the Trade Break Message.
    /// </summary>
    public ulong MatchNumber => Fields.MatchNumber.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public OrderReferenceNumber OrderReferenceNumber;
        public ExecutedShares ExecutedShares;
        public MatchNumber MatchNumber;
    };

    protected Layout Fields;
};
