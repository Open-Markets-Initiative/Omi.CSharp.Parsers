using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Luld Auction Collar Message: Indicates the auction collar thresholds within which a paused security can reopen following a LULD Trading Pause
    /// </summary>

    public partial class LuldAuctionCollarMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Stock Stock;
            AuctionCollarReferencePrice AuctionCollarReferencePrice;
            UpperAuctionCollarPrice UpperAuctionCollarPrice;
            LowerAuctionCollarPrice LowerAuctionCollarPrice;
            AuctionCollarExtension AuctionCollarExtension;
        };
    };
}