using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Non Cross Trade Message: Trade Messages should be included in NASDAQ time-and-sales displays as well as volume and other market statistics.  Since Trade Messages do not affect the book, however, they may be ignored by firms just looking to build and track the NASDAQ execution system display.
/// </summary>

public partial class NonCrossTradeMessage
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
    ///  The type of order being added.
    /// </summary>
    public BuySellIndicator BuySellIndicator => Layout.BuySellIndicator.Value;

    /// <summary>
    ///  The total number of shares associated with the order being added to the book.
    /// </summary>
    public uint Shares => Layout.Shares.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Layout.Stock.Value;

    /// <summary>
    ///  The display price of the new order.  Refer to Data Types for field processing notes.
    /// </summary>
    public uint Price => Layout.Price.Value;

    /// <summary>
    ///  The NASDAQ generated day-unique Match Number of this execution. The match number is also referenced in the Trade Break Message.
    /// </summary>
    public ulong MatchNumber => Layout.MatchNumber.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public OrderReferenceNumber OrderReferenceNumber;
        public BuySellIndicator BuySellIndicator;
        public Shares Shares;
        public Stock Stock;
        public Price Price;
        public MatchNumber MatchNumber;
    };
};
