using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fixing Transition Message: This message supports ICE Benchmark Administration’s (IBA) electronic Gold Auction and it is disseminated when there is a transition of the fixing market.
    /// </summary>

    public partial class FixingTransitionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            FixingStatus FixingStatus;
            AuctionEndTime AuctionEndTime;
            ThresholdImbalanceQty ThresholdImbalanceQty;
            MessageDateTime MessageDateTime;
        };
    };
}