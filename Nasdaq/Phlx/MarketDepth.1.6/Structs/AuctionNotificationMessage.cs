using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Auction Notification Message: This message is also sent as notification that there is an exposed buy (sell) order available for execution at the National Best Offer (Bid).
    /// </summary>

    public partial class AuctionNotificationMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            AuctionId AuctionId;
            AuctionType AuctionType;
            PairedContracts PairedContracts;
            ImbalanceDirection ImbalanceDirection;
            OptionId OptionId;
            ImbalancePrice ImbalancePrice;
            ImbalanceVolume ImbalanceVolume;
            CustomerIndicator CustomerIndicator;
            Reserved Reserved;
        };
    };
}