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
            public MarketId MarketId;
            public TradeId TradeId;
            public IsSystemPricedLeg IsSystemPricedLeg;
            public Price Price;
            public Quantity Quantity;
            public OldOffMarketTradeType OldOffMarketTradeType;
            public TransactDateTime TransactDateTime;
            public SystemPricedLegType SystemPricedLegType;
            public IsImpliedSpreadAtMarketOpen IsImpliedSpreadAtMarketOpen;
            public IsAdjustedTrade IsAdjustedTrade;
            public AggressorSide AggressorSide;
            public TradeFlags TradeFlags;
            public OffMarketTradeType OffMarketTradeType;
            public SequenceWithinMillis SequenceWithinMillis;
            public RequestTradingEngineReceivedTimestamp RequestTradingEngineReceivedTimestamp;
        };
    };
}