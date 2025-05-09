using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Quote Replace Long Message: This message is sent whenever a quote on the book is replaced. The replaced quote has new reference numbers on both sides.
/// </summary>

public partial class QuoteReplaceLongMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The original bid reference number delta associated with the order being replaced.
    /// </summary>
    public uint OriginalBidReferenceNumberDelta => Fields.OriginalBidReferenceNumberDelta.Value;

    /// <summary>
    ///  The bid reference number delta associated with the new quote.
    /// </summary>
    public uint BidReferenceNumberDelta => Fields.BidReferenceNumberDelta.Value;

    /// <summary>
    ///  The original ask reference number delta associated with the order being replaced.
    /// </summary>
    public uint OriginalAskReferenceNumberDelta => Fields.OriginalAskReferenceNumberDelta.Value;

    /// <summary>
    ///  The ask reference number delta associated with the new quote
    /// </summary>
    public uint AskReferenceNumberDelta => Fields.AskReferenceNumberDelta.Value;

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
        public OriginalBidReferenceNumberDelta OriginalBidReferenceNumberDelta;
        public BidReferenceNumberDelta BidReferenceNumberDelta;
        public OriginalAskReferenceNumberDelta OriginalAskReferenceNumberDelta;
        public AskReferenceNumberDelta AskReferenceNumberDelta;
        public BidPrice BidPrice;
        public BidSize BidSize;
        public AskPrice AskPrice;
        public AskSize AskSize;
    };

    protected Layout Fields;
};
