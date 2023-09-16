using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Options Cross Trade Message: Options Auction Trade message is sent for every option when an auction in that option is completed. The message indicates the bulk volume associated with the auction event.
    /// </summary>

    public partial class OptionsCrossTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OptionId OptionId;
            CrossNumber CrossNumber;
            MatchNumber MatchNumber;
            CrossType CrossType;
            Price Price;
            Volume Volume;
        };
    };
}