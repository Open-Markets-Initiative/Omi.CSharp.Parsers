using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Add Order With Mpid Attribution Message: This message will be generated for attributed orders and quotations accepted by the NASDAQ system.
/// </summary>

public partial class AddOrderWithMpidAttributionMessage
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
    ///  The type of order being added.
    /// </summary>
    public BuySellIndicator BuySellIndicator => Fields.BuySellIndicator.Value;

    /// <summary>
    ///  The total number of shares associated with the order being added to the book.
    /// </summary>
    public uint Shares => Fields.Shares.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Fields.Stock.Value;

    /// <summary>
    ///  The display price of the new order.  Refer to Data Types for field processing notes.
    /// </summary>
    public uint Price => Fields.Price.Value;

    /// <summary>
    ///  NASDAQ market participant identifier associated with the entered order.
    /// </summary>
    public string Attribution => Fields.Attribution.Value;

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
        public Attribution Attribution;
    };

    protected Layout Fields;
};
