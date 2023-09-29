using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Trade Message: A trade with IsSystemPricedLeg equal to ‘Y’ should not be used for the last price, High, Low and Open. Also please refer to Appendix B on how to handle market stats for given OffTradeMarketType. This message will not be sent for trades in Endex Spot markets.
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