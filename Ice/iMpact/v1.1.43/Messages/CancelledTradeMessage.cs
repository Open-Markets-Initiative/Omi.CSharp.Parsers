using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Cancelled Trade Message: This message is sent when a trade is cancelled.
/// </summary>

public partial class CancelledTradeMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public TradeId TradeId;
        public Price Price;
        public Quantity Quantity;
        public OldOffMarketTradeType OldOffMarketTradeType;
        public MessageDateTime MessageDateTime;
        public OffMarketTradeType OffMarketTradeType;
    };
};
