using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Instrument Definition Option: MDInstrumentDefinitionOption
    /// </summary>

    public partial class MdInstrumentDefinitionOption
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MatchEventIndicator MatchEventIndicator;
            TotNumReportsOptional TotNumReportsOptional;
            SecurityUpdateAction SecurityUpdateAction;
            LastUpdateTime LastUpdateTime;
            MdSecurityTradingStatus MdSecurityTradingStatus;
            ApplId ApplId;
            MarketSegmentId MarketSegmentId;
            UnderlyingProduct UnderlyingProduct;
            SecurityExchange SecurityExchange;
            SecurityGroup SecurityGroup;
            Asset Asset;
            Symbol Symbol;
            SecurityId SecurityId;
            SecurityType SecurityType;
            CfiCode CfiCode;
            PutOrCall PutOrCall;
            MaturityMonthYear MaturityMonthYear;
            Currency Currency;
            StrikePrice StrikePrice;
            StrikeCurrency StrikeCurrency;
            SettlCurrency SettlCurrency;
            MinCabPrice MinCabPrice;
            MatchAlgorithm MatchAlgorithm;
            MinTradeVol MinTradeVol;
            MaxTradeVol MaxTradeVol;
            MinPriceIncrementOptional MinPriceIncrementOptional;
            MinPriceIncrementAmount MinPriceIncrementAmount;
            DisplayFactor DisplayFactor;
            TickRule TickRule;
            MainFraction MainFraction;
            SubFraction SubFraction;
            PriceDisplayFormat PriceDisplayFormat;
            UnitOfMeasure UnitOfMeasure;
            UnitOfMeasureQty UnitOfMeasureQty;
            TradingReferencePrice TradingReferencePrice;
            SettlPriceType SettlPriceType;
            ClearedVolume ClearedVolume;
            OpenInterestQty OpenInterestQty;
            LowLimitPrice LowLimitPrice;
            HighLimitPrice HighLimitPrice;
            UserDefinedInstrument UserDefinedInstrument;
            TradingReferenceDate TradingReferenceDate;
            InstrumentGuid InstrumentGuid;
        };
    };
}