using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Auction Bbo
/// </summary>

public partial class AuctionBbo
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public SecurityId SecurityId;
        public BidPx BidPx;
        public OfferPx OfferPx;
        public BidSize BidSize;
        public OfferSize OfferSize;
        public PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
        public BidOrdType BidOrdType;
        public OfferOrdType OfferOrdType;
        public Pad5 Pad5;
    };
};
