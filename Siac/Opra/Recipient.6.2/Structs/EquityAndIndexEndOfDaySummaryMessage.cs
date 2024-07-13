using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Equity And Index End Of Day Summary Message
    /// </summary>

    public partial class EquityAndIndexEndOfDaySummaryMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageType MessageType;
            MessageIndicator MessageIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            SecuritySymbol SecuritySymbol;
            Reserved1 Reserved1;
            ExpirationBlock ExpirationBlock;
            StrikePriceDenominatorCode StrikePriceDenominatorCode;
            StrikePrice StrikePrice;
            Volume Volume;
            OpenInterestVolume OpenInterestVolume;
            PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
            OpenPrice OpenPrice;
            HighPrice HighPrice;
            LowPrice LowPrice;
            LastPrice LastPrice;
            NetChange NetChange;
            UnderlyingPriceDenominatorCode UnderlyingPriceDenominatorCode;
            UnderlyingPrice UnderlyingPrice;
            BidPrice BidPrice;
            OfferPrice OfferPrice;
        };
    };
}