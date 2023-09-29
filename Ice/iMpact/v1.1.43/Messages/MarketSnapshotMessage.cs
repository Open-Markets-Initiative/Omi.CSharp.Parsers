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
            MarketId MarketId;
            MarketType MarketType;
            TradingStatus TradingStatus;
            Volume Volume;
            BlockVolume BlockVolume;
            EfsVolume EfsVolume;
            EfpVolume EfpVolume;
            OpenInterest OpenInterest;
            OpeningPrice OpeningPrice;
            SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
            High High;
            Low Low;
            Vwap Vwap;
            NumOfBookEntries NumOfBookEntries;
            LastTradePrice LastTradePrice;
            LastTradeQuantity LastTradeQuantity;
            LastTradeDateTime LastTradeDateTime;
            SettlePriceDateTime SettlePriceDateTime;
            LastMessageSequenceId LastMessageSequenceId;
            Reserved2Bytes Reserved2Bytes;
            OpenInterestDate OpenInterestDate;
            IsSettlePriceOfficial IsSettlePriceOfficial;
            SettlementPrice SettlementPrice;
            HasPreviousDaySettlementPrice HasPreviousDaySettlementPrice;
            PreviousDaySettlementPrice PreviousDaySettlementPrice;
        };
    };
}