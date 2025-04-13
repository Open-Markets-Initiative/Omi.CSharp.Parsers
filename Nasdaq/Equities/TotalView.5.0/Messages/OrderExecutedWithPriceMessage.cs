using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Order Executed With Price Message: This message is sent whenever an order on the book is executed in whole or in part at a price different from the initial display price.  Since the execution price is different than the display price of the original Add Order, NASDAQ includes a price field within this execution message.
/// </summary>

public partial class OrderExecutedWithPriceMessage
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

    /// <summary>
    ///  Indicates if the execution should be reflected on time and sale displays and volume calculations.
    /// </summary>
    public Printable Printable => Fields.Printable.Value;

    /// <summary>
    ///  The price at which the order execution occurred. Refer to Data Types for field processing notes.
    /// </summary>
    public uint ExecutionPrice => Fields.ExecutionPrice.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public OrderReferenceNumber OrderReferenceNumber;
        public ExecutedShares ExecutedShares;
        public MatchNumber MatchNumber;
        public Printable Printable;
        public ExecutionPrice ExecutionPrice;
    };

    protected Layout Fields;
};
