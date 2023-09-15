using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Instrument Definition Spread: MDInstrumentDefinitionSpread
    /// </summary>

    public partial class MdInstrumentDefinitionSpread
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
            UnderlyingProductOptional UnderlyingProductOptional;
            SecurityExchange SecurityExchange;
            SecurityGroup SecurityGroup;
            Asset Asset;
            Symbol Symbol;
            SecurityId SecurityId;
            SecurityType SecurityType;
            CfiCode CfiCode;
            MaturityMonthYear MaturityMonthYear;
            Currency Currency;
            SecuritySubType SecuritySubType;
            UserDefinedInstrument UserDefinedInstrument;
            MatchAlgorithm MatchAlgorithm;
            MinTradeVol MinTradeVol;
            MaxTradeVol MaxTradeVol;
            MinPriceIncrementOptional MinPriceIncrementOptional;
            DisplayFactor DisplayFactor;
            PriceDisplayFormat PriceDisplayFormat;
            PriceRatio PriceRatio;
            TickRule TickRule;
            UnitOfMeasure UnitOfMeasure;
            TradingReferencePrice TradingReferencePrice;
            SettlPriceType SettlPriceType;
            OpenInterestQty OpenInterestQty;
            ClearedVolume ClearedVolume;
            HighLimitPrice HighLimitPrice;
            LowLimitPrice LowLimitPrice;
            MaxPriceVariation MaxPriceVariation;
            MainFraction MainFraction;
            SubFraction SubFraction;
            TradingReferenceDate TradingReferenceDate;
            PriceQuoteMethod PriceQuoteMethod;
            RiskSet RiskSet;
            MarketSet MarketSet;
            InstrumentGuid InstrumentGuid;
            FinancialInstrumentFullName FinancialInstrumentFullName;
        };
    };
}