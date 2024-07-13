using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Best Bid And Offer Appendage
    /// </summary>

    public partial class BestBidAndOfferAppendage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BestBidParticipantId BestBidParticipantId;
            BestBidDenominatorCode BestBidDenominatorCode;
            BestBidPrice BestBidPrice;
            BestBidSize BestBidSize;
            BestOfferParticipantId BestOfferParticipantId;
            BestOfferDenominatorCode BestOfferDenominatorCode;
            BestOfferPrice BestOfferPrice;
            BestOfferSize BestOfferSize;
        };
    };
}