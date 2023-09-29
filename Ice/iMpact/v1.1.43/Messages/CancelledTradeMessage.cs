using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Cancelled Trade Message: This message is sent when a trade is cancelled.
    /// </summary>

    public partial class CancelledTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            TradeId TradeId;
            Price Price;
            Quantity Quantity;
            OldOffMarketTradeType OldOffMarketTradeType;
            MessageDateTime MessageDateTime;
            OffMarketTradeType OffMarketTradeType;
        };
    };
}