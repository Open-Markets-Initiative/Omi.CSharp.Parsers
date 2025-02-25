using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Add Quote Short Message: An Add Quote Message indicates that a new quote has been accepted by the PHLX ® options system and was added to the displayable book. The message includes a unique Bid/Ask Reference Numbers used by the options system to track the quote.
/// </summary>

public partial class AddQuoteShortMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  The bid reference number delta associated with the new quote.
    /// </summary>
    public uint BidReferenceNumberDelta => Layout.BidReferenceNumberDelta.Value;

    /// <summary>
    ///  The ask reference number delta associated with the new quote
    /// </summary>
    public uint AskReferenceNumberDelta => Layout.AskReferenceNumberDelta.Value;

    /// <summary>
    ///  Option ID assigned daily, valid for trading day.
    /// </summary>
    public uint OptionId => Layout.OptionId.Value;

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
        public BidReferenceNumberDelta BidReferenceNumberDelta;
        public AskReferenceNumberDelta AskReferenceNumberDelta;
        public OptionId OptionId;
        public ShortBidPrice ShortBidPrice;
        public ShortBidSize ShortBidSize;
        public ShortAskPrice ShortAskPrice;
        public ShortAskSize ShortAskSize;
    };
};
