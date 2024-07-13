using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Long Equity And Index Quote Message
    /// </summary>

    public partial class LongEquityAndIndexQuoteMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            QuoteMessageType QuoteMessageType;
            BboIndicator BboIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            SecuritySymbol SecuritySymbol;
            Reserved1 Reserved1;
            ExpirationBlock ExpirationBlock;
            StrikePriceDenominatorCode StrikePriceDenominatorCode;
            StrikePrice StrikePrice;
            PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
            BidPrice BidPrice;
            BidSize BidSize;
            OfferPrice OfferPrice;
            OfferSize OfferSize;
        };
    };
}