using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Quote Replace Short Message: This message is sent whenever a quote on the book is replaced. The replaced quote has new reference numbers on both sides.
/// </summary>

public partial class QuoteReplaceShortMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  The original bid reference number delta associated with the order being replaced.
    /// </summary>
    public uint OriginalBidReferenceNumberDelta => Layout.OriginalBidReferenceNumberDelta.Value;

    /// <summary>
    ///  The bid reference number delta associated with the new quote.
    /// </summary>
    public uint BidReferenceNumberDelta => Layout.BidReferenceNumberDelta.Value;

    /// <summary>
    ///  The original ask reference number delta associated with the order being replaced.
    /// </summary>
    public uint OriginalAskReferenceNumberDelta => Layout.OriginalAskReferenceNumberDelta.Value;

    /// <summary>
    ///  The ask reference number delta associated with the new quote
    /// </summary>
    public uint AskReferenceNumberDelta => Layout.AskReferenceNumberDelta.Value;

    /// <summary>
    ///  NOTE: When converted to a decimal format, this price is in fixed point format with 3 whole number places followed by 2 decimal digits. The display bid price of the new quote.
    /// </summary>
    public short ShortBidPrice => Layout.ShortBidPrice.Value;

    /// <summary>
    ///  The bid contracts of the new quote.
    /// </summary>
    public ushort ShortBidSize => Layout.ShortBidSize.Value;

    /// <summary>
    ///  The display ask price of the new quote.
    /// </summary>
    public short ShortAskPrice => Layout.ShortAskPrice.Value;

    /// <summary>
    ///  The ask contracts of the new quote.
    /// </summary>
    public ushort ShortAskSize => Layout.ShortAskSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public OriginalBidReferenceNumberDelta OriginalBidReferenceNumberDelta;
        public BidReferenceNumberDelta BidReferenceNumberDelta;
        public OriginalAskReferenceNumberDelta OriginalAskReferenceNumberDelta;
        public AskReferenceNumberDelta AskReferenceNumberDelta;
        public ShortBidPrice ShortBidPrice;
        public ShortBidSize ShortBidSize;
        public ShortAskPrice ShortAskPrice;
        public ShortAskSize ShortAskSize;
    };
};
