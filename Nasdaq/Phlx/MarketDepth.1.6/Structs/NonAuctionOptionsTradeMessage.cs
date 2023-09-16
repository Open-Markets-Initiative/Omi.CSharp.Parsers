using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Non Auction Options Trade Message: This Options Trade Message is designed to provide execution details for match events involving non-displayable order types and Complex orders. (Note: There is a separate message for Option auction events.)
    /// </summary>

    public partial class NonAuctionOptionsTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            TradeIndicator TradeIndicator;
            OptionId OptionId;
            CrossNumber CrossNumber;
            MatchNumber MatchNumber;
            Price Price;
            Volume Volume;
        };
    };
}