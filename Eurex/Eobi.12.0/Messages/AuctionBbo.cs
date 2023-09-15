using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Auction Bbo
    /// </summary>

    public partial class AuctionBbo
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            SecurityId SecurityId;
            BidPx BidPx;
            OfferPx OfferPx;
            BidSize BidSize;
            OfferSize OfferSize;
            PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
            BidOrdType BidOrdType;
            OfferOrdType OfferOrdType;
            Pad5 Pad5;
        };
    };
}