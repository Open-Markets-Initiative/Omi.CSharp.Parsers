using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Old Style Options Trade And Market Stats Message: Option settlement prices could be official or unofficial. For a given market, the exchange usually sends out unofficial price before the official one.
    /// </summary>

    public partial class OldStyleOptionsTradeAndMarketStatsMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public UnderlyingMarketId UnderlyingMarketId;
            public TradeId TradeId;
            public Price Price;
            public Quantity Quantity;
            public OldOffMarketTradeType OldOffMarketTradeType;
            public TransactDateTime TransactDateTime;
            public OptionType OptionType;
            public StrikePrice StrikePrice;
            public EventCode EventCode;
            public TotalVolume TotalVolume;
            public BlockVolume BlockVolume;
            public EfsVolume EfsVolume;
            public EfpVolume EfpVolume;
            public High High;
            public Low Low;
            public Vwap Vwap;
        };
    };
}