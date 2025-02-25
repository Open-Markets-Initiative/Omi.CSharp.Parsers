using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Quote Delete Message: The message is sent when a single quote is being cancelled. All remaining contracts are no longer accessible so the quote should be removed from the book.
/// </summary>

public partial class QuoteDeleteMessage
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

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public BidReferenceNumberDelta BidReferenceNumberDelta;
        public AskReferenceNumberDelta AskReferenceNumberDelta;
    };
};
