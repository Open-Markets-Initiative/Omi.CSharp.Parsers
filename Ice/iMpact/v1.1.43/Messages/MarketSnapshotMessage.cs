using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market Snapshot Message: The market snapshot message is the same for full order depth and price level snapshot channel.
    /// </summary>

    public partial class MarketSnapshotMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public MarketType MarketType;
            public TradingStatus TradingStatus;
            public Volume Volume;
            public BlockVolume BlockVolume;
            public EfsVolume EfsVolume;
            public EfpVolume EfpVolume;
            public OpenInterest OpenInterest;
            public OpeningPrice OpeningPrice;
            public SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
            public High High;
            public Low Low;
            public Vwap Vwap;
            public NumOfBookEntries NumOfBookEntries;
            public LastTradePrice LastTradePrice;
            public LastTradeQuantity LastTradeQuantity;
            public LastTradeDateTime LastTradeDateTime;
            public SettlePriceDateTime SettlePriceDateTime;
            public LastMessageSequenceId LastMessageSequenceId;
            public Reserved2Bytes Reserved2Bytes;
            public OpenInterestDate OpenInterestDate;
            public IsSettlePriceOfficial IsSettlePriceOfficial;
            public SettlementPrice SettlementPrice;
            public HasPreviousDaySettlementPrice HasPreviousDaySettlementPrice;
            public PreviousDaySettlementPrice PreviousDaySettlementPrice;
        };
    };
}