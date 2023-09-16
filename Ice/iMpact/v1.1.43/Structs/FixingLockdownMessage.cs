using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fixing Lockdown Message
    /// </summary>

    public partial class FixingLockdownMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            AuctionDate AuctionDate;
            Time Time;
            Description Description;
            Round Round;
            AggBidQty AggBidQty;
            AggOfferQty AggOfferQty;
            UsdPrice UsdPrice;
            IsBalanced IsBalanced;
            IsFinal IsFinal;
            GbpPrice GbpPrice;
            EurPrice EurPrice;
        };
    };
}