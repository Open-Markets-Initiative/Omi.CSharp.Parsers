using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Cancelled Trade Message
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
            DateTime DateTime;
            OffMarketTradeType OffMarketTradeType;
        };
    };
}