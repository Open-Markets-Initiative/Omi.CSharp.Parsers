using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Order Replace Message: This message is sent whenever an order on the book has been cancel-replaced.  All remaining shares from the original order are no longer accessible, and must be removed.  The new order details are provided for the replacement, along with a new order reference number which will be used henceforth.  Since the side, stock symbol and attribution (if any) cannot be changed by an Order Replace event, these fields are not included in the message.  Firms should retain the side, stock symbol and MPID from the original Add Order message.
/// </summary>

public partial class OrderReplaceMessage
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
    ///  The original reference number of the order being replaced.
    /// </summary>
    public ulong OriginalOrderReferenceNumber => Layout.OriginalOrderReferenceNumber.Value;

    /// <summary>
    ///  The new reference number for this order at time of replacement. Please note that the NASDAQ system will use this new order reference number for all subsequent updates.
    /// </summary>
    public ulong NewOrderReferenceNumber => Layout.NewOrderReferenceNumber.Value;

    /// <summary>
    ///  The total number of shares associated with the order being added to the book.
    /// </summary>
    public uint Shares => Layout.Shares.Value;

    /// <summary>
    ///  The display price of the new order.  Refer to Data Types for field processing notes.
    /// </summary>
    public uint Price => Layout.Price.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public OriginalOrderReferenceNumber OriginalOrderReferenceNumber;
        public NewOrderReferenceNumber NewOrderReferenceNumber;
        public Shares Shares;
        public Price Price;
    };
};
