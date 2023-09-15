using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Instrument Definition Fx: MDInstrumentDefinitionFX
    /// </summary>

    public partial class MdInstrumentDefinitionFx
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
            Currency Currency;
            SettlCurrency SettlCurrency;
            PriceQuoteCurrency PriceQuoteCurrency;
            MatchAlgorithm MatchAlgorithm;
            MinTradeVol MinTradeVol;
            MaxTradeVol MaxTradeVol;
            MinPriceIncrement MinPriceIncrement;
            DisplayFactor DisplayFactor;
            PricePrecision PricePrecision;
            UnitOfMeasure UnitOfMeasure;
            UnitOfMeasureQty UnitOfMeasureQty;
            HighLimitPrice HighLimitPrice;
            LowLimitPrice LowLimitPrice;
            MaxPriceVariation MaxPriceVariation;
            UserDefinedInstrument UserDefinedInstrument;
            FinancialInstrumentFullName FinancialInstrumentFullName;
            FxCurrencySymbol FxCurrencySymbol;
            SettlType SettlType;
            InterveningDays InterveningDays;
            FxBenchmarkRateFix FxBenchmarkRateFix;
            RateSource RateSource;
            FixRateLocalTime FixRateLocalTime;
            FixRateLocalTimeZone FixRateLocalTimeZone;
            MinQuoteLife MinQuoteLife;
            MaxPriceDiscretionOffset MaxPriceDiscretionOffset;
            InstrumentGuid InstrumentGuid;
            MaturityMonthYear MaturityMonthYear;
            SettlementLocale SettlementLocale;
            AltMinPriceIncrement AltMinPriceIncrement;
            AltMinQuoteLife AltMinQuoteLife;
            AltPriceIncrementConstraint AltPriceIncrementConstraint;
            MaxBidAskConstraint MaxBidAskConstraint;
        };
    };
}