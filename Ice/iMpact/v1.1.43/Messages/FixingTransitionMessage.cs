using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fixing Transition Message
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