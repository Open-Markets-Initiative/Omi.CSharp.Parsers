using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fixing Lockdown Message: This message supports ICE Benchmark Administration’s (IBA) electronic Gold Auction and it is disseminated when there is a transition of the fixing market.
    /// </summary>

    public partial class FixingLockdownMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public AuctionDate AuctionDate;
            public Time Time;
            public Description Description;
            public Round Round;
            public AggBidQty AggBidQty;
            public AggOfferQty AggOfferQty;
            public UsdPrice UsdPrice;
            public IsBalanced IsBalanced;
            public IsFinal IsFinal;
            public GbpPrice GbpPrice;
            public EurPrice EurPrice;
        };
    };
}