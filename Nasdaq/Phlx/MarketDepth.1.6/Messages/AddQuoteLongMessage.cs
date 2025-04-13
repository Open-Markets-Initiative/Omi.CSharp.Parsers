using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Add Quote Long Message: An Add Quote Message indicates that a new quote has been accepted by the PHLX ® options system and was added to the displayable book. The message includes a unique Bid/Ask Reference Numbers used by the options system to track the quote.
/// </summary>

public partial class AddQuoteLongMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The bid reference number delta associated with the new quote.
    /// </summary>
    public uint BidReferenceNumberDelta => Fields.BidReferenceNumberDelta.Value;

    /// <summary>
    ///  The ask reference number delta associated with the new quote
    /// </summary>
    public uint AskReferenceNumberDelta => Fields.AskReferenceNumberDelta.Value;

    /// <summary>
    ///  Option ID assigned daily, valid for trading day.
    /// </summary>
    public uint OptionId => Fields.OptionId.Value;

    /// <summary>
    ///  The display bid price of the new quote.  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits.
    /// </summary>
    public int BidPrice => Fields.BidPrice.Value;

    /// <summary>
    ///  The bid contracts of the new quote.
    /// </summary>
    public uint BidSize => Fields.BidSize.Value;

    /// <summary>
    ///  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits. The display ask price of the new quote.
    /// </summary>
    public int AskPrice => Fields.AskPrice.Value;

    /// <summary>
    ///  The ask contracts of the new quote.
    /// </summary>
    public uint AskSize => Fields.AskSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public BidReferenceNumberDelta BidReferenceNumberDelta;
        public AskReferenceNumberDelta AskReferenceNumberDelta;
        public OptionId OptionId;
        public BidPrice BidPrice;
        public BidSize BidSize;
        public AskPrice AskPrice;
        public AskSize AskSize;
    };

    protected Layout Fields;
};
