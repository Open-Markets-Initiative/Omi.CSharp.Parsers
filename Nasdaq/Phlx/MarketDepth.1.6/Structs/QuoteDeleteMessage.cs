using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Quote Delete Message: The message is sent when a single quote is being cancelled. All remaining contracts are no longer accessible so the quote should be removed from the book.
    /// </summary>

    public partial class QuoteDeleteMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            BidReferenceNumberDelta BidReferenceNumberDelta;
            AskReferenceNumberDelta AskReferenceNumberDelta;
        };
    };
}