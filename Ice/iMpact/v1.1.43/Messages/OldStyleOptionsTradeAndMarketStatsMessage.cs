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
            UnderlyingMarketId UnderlyingMarketId;
            TradeId TradeId;
            Price Price;
            Quantity Quantity;
            OldOffMarketTradeType OldOffMarketTradeType;
            TransactDateTime TransactDateTime;
            OptionType OptionType;
            StrikePrice StrikePrice;
            EventCode EventCode;
            TotalVolume TotalVolume;
            BlockVolume BlockVolume;
            EfsVolume EfsVolume;
            EfpVolume EfpVolume;
            High High;
            Low Low;
            Vwap Vwap;
        };
    };
}