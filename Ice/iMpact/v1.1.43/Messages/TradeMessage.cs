using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Trade Message
    /// </summary>

    public partial class TradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            TradeId TradeId;
            IsSystemPricedLeg IsSystemPricedLeg;
            Price Price;
            Quantity Quantity;
            OldOffMarketTradeType OldOffMarketTradeType;
            TransactDateTime TransactDateTime;
            SystemPricedLegType SystemPricedLegType;
            IsImpliedSpreadAtMarketOpen IsImpliedSpreadAtMarketOpen;
            IsAdjustedTrade IsAdjustedTrade;
            AggressorSide AggressorSide;
            TradeFlags TradeFlags;
            OffMarketTradeType OffMarketTradeType;
            SequenceWithinMillis SequenceWithinMillis;
            RequestTradingEngineReceivedTimestamp RequestTradingEngineReceivedTimestamp;
        };
    };
}