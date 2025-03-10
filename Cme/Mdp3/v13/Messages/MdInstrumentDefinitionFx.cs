using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Instrument Definition Fx: MDInstrumentDefinitionFX
/// </summary>

public partial class MdInstrumentDefinitionFx
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MatchEventIndicator MatchEventIndicator;
        public TotNumReportsOptional TotNumReportsOptional;
        public SecurityUpdateAction SecurityUpdateAction;
        public LastUpdateTime LastUpdateTime;
        public MdSecurityTradingStatus MdSecurityTradingStatus;
        public ApplId ApplId;
        public MarketSegmentId MarketSegmentId;
        public UnderlyingProduct UnderlyingProduct;
        public SecurityExchange SecurityExchange;
        public SecurityGroup SecurityGroup;
        public Asset Asset;
        public Symbol Symbol;
        public SecurityId SecurityId;
        public SecurityType SecurityType;
        public CfiCode CfiCode;
        public Currency Currency;
        public SettlCurrency SettlCurrency;
        public PriceQuoteCurrency PriceQuoteCurrency;
        public MatchAlgorithm MatchAlgorithm;
        public MinTradeVol MinTradeVol;
        public MaxTradeVol MaxTradeVol;
        public MinPriceIncrement MinPriceIncrement;
        public DisplayFactor DisplayFactor;
        public PricePrecision PricePrecision;
        public UnitOfMeasure UnitOfMeasure;
        public UnitOfMeasureQty UnitOfMeasureQty;
        public HighLimitPrice HighLimitPrice;
        public LowLimitPrice LowLimitPrice;
        public MaxPriceVariation MaxPriceVariation;
        public UserDefinedInstrument UserDefinedInstrument;
        public FinancialInstrumentFullName FinancialInstrumentFullName;
        public FxCurrencySymbol FxCurrencySymbol;
        public SettlType SettlType;
        public InterveningDays InterveningDays;
        public FxBenchmarkRateFix FxBenchmarkRateFix;
        public RateSource RateSource;
        public FixRateLocalTime FixRateLocalTime;
        public FixRateLocalTimeZone FixRateLocalTimeZone;
        public MinQuoteLife MinQuoteLife;
        public MaxPriceDiscretionOffset MaxPriceDiscretionOffset;
        public InstrumentGuid InstrumentGuid;
        public MaturityMonthYear MaturityMonthYear;
        public SettlementLocale SettlementLocale;
        public AltMinPriceIncrement AltMinPriceIncrement;
        public AltMinQuoteLife AltMinQuoteLife;
        public AltPriceIncrementConstraint AltPriceIncrementConstraint;
        public MaxBidAskConstraint MaxBidAskConstraint;
    };
};
