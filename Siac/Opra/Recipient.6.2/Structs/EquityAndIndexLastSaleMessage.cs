using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Equity And Index Last Sale Message
    /// </summary>

    public partial class EquityAndIndexLastSaleMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TradeMessageType TradeMessageType;
            MessageIndicator MessageIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            SecuritySymbol SecuritySymbol;
            Reserved1 Reserved1;
            ExpirationBlock ExpirationBlock;
            StrikePriceDenominatorCode StrikePriceDenominatorCode;
            StrikePrice StrikePrice;
            Volume Volume;
            PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
            PremiumPrice PremiumPrice;
            TradeIdentifier TradeIdentifier;
            Reserved4 Reserved4;
        };
    };
}