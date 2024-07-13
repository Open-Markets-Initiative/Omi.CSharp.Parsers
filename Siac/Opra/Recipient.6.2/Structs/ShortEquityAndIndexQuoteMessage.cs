using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Short Equity And Index Quote Message
    /// </summary>

    public partial class ShortEquityAndIndexQuoteMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            QuoteMessageType QuoteMessageType;
            BboIndicator BboIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            SecuritySymbolShort SecuritySymbolShort;
            ExpirationBlock ExpirationBlock;
            StrikePriceShort StrikePriceShort;
            BidPriceShort BidPriceShort;
            BidSizeShort BidSizeShort;
            OfferPriceShort OfferPriceShort;
            OfferSizeShort OfferSizeShort;
        };
    };
}