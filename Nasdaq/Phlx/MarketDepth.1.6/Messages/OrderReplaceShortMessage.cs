using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Order Replace Short Message: This message is sent whenever an order on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
/// </summary>

public partial class OrderReplaceShortMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The original reference number delta associated with the order being replaced.
    /// </summary>
    public uint OriginalReferenceNumberDelta => Fields.OriginalReferenceNumberDelta.Value;

    /// <summary>
    ///  The new reference number delta associated with the new order.
    /// </summary>
    public uint NewReferenceNumberDelta => Fields.NewReferenceNumberDelta.Value;

    /// <summary>
    ///  The display price of the new order being added to the book. NOTE: When converted to a decimal format, this price is in fixed point format with 3 whole number places followed by 2 decimal digits.
    /// </summary>
    public short ShortPrice => Fields.ShortPrice.Value;

    /// <summary>
    ///  The total number of contracts of the new order being added to the book.
    /// </summary>
    public ushort ShortVolume => Fields.ShortVolume.Value;

    /// <summary>
    ///  PHLX assigned order ID.
    /// </summary>
    public uint OrderId => Fields.OrderId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public OriginalReferenceNumberDelta OriginalReferenceNumberDelta;
        public NewReferenceNumberDelta NewReferenceNumberDelta;
        public ShortPrice ShortPrice;
        public ShortVolume ShortVolume;
        public OrderId OrderId;
    };

    protected Layout Fields;
};
