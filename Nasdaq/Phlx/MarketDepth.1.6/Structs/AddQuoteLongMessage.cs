using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Add Quote Long Message: An Add Quote Message indicates that a new quote has been accepted by the PHLX ® options system and was added to the displayable book. The message includes a unique Bid/Ask Reference Numbers used by the options system to track the quote.
    /// </summary>

    public partial class AddQuoteLongMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            BidReferenceNumberDelta BidReferenceNumberDelta;
            AskReferenceNumberDelta AskReferenceNumberDelta;
            OptionId OptionId;
            BidPrice BidPrice;
            BidSize BidSize;
            AskPrice AskPrice;
            AskSize AskSize;
        };
    };
}