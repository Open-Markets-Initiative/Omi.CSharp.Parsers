using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Underlying Value Bid And Offer Message
    /// </summary>

    public partial class UnderlyingValueBidAndOfferMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageIndicator MessageIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            SecuritySymbol SecuritySymbol;
            Reserved1 Reserved1;
            IndexValueDenominatorCode IndexValueDenominatorCode;
            BidIndexValue BidIndexValue;
            OfferIndexValue OfferIndexValue;
        };
    };
}