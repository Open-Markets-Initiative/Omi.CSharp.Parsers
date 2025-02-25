using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Order Replace Long Message: This message is sent whenever an order on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
/// </summary>

public partial class OrderReplaceLongMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  The original reference number delta associated with the order being replaced.
    /// </summary>
    public uint OriginalReferenceNumberDelta => Layout.OriginalReferenceNumberDelta.Value;

    /// <summary>
    ///  The new reference number delta associated with the new order.
    /// </summary>
    public uint NewReferenceNumberDelta => Layout.NewReferenceNumberDelta.Value;

    /// <summary>
    ///  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits. The display price of the new order being added to the book.
    /// </summary>
    public int Price => Layout.Price.Value;

    /// <summary>
    ///  The total number of contracts of the new order being added to the book.
    /// </summary>
    public uint Volume => Layout.Volume.Value;

    /// <summary>
    ///  PHLX assigned order ID.
    /// </summary>
    public uint OrderId => Layout.OrderId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public OriginalReferenceNumberDelta OriginalReferenceNumberDelta;
        public NewReferenceNumberDelta NewReferenceNumberDelta;
        public Price Price;
        public Volume Volume;
        public OrderId OrderId;
    };
};
