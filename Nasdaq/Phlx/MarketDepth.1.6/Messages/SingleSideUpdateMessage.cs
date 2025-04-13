using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Single Side Update Message: This message is sent whenever an order or a side of a quote is being updated for price and (or) contracts. The reference number associated with the order quote is unchanged.
/// </summary>

public partial class SingleSideUpdateMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The order/quote reference number delta associated with the executed order.
    /// </summary>
    public uint ReferenceNumberDelta => Fields.ReferenceNumberDelta.Value;

    /// <summary>
    ///  Change Reason
    /// </summary>
    public ChangeReason ChangeReason => Fields.ChangeReason.Value;

    /// <summary>
    ///  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits. The display price of the new order being added to the book.
    /// </summary>
    public int Price => Fields.Price.Value;

    /// <summary>
    ///  The total number of contracts of the new order being added to the book.
    /// </summary>
    public uint Volume => Fields.Volume.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public ReferenceNumberDelta ReferenceNumberDelta;
        public ChangeReason ChangeReason;
        public Price Price;
        public Volume Volume;
    };

    protected Layout Fields;
};
