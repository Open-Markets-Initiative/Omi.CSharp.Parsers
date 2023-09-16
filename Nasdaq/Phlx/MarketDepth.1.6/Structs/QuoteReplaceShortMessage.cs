using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Quote Replace Short Message: This message is sent whenever a quote on the book is replaced. The replaced quote has new reference numbers on both sides.
    /// </summary>

    public partial class QuoteReplaceShortMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OriginalBidReferenceNumberDelta OriginalBidReferenceNumberDelta;
            BidReferenceNumberDelta BidReferenceNumberDelta;
            OriginalAskReferenceNumberDelta OriginalAskReferenceNumberDelta;
            AskReferenceNumberDelta AskReferenceNumberDelta;
            ShortBidPrice ShortBidPrice;
            ShortBidSize ShortBidSize;
            ShortAskPrice ShortAskPrice;
            ShortAskSize ShortAskSize;
        };
    };
}