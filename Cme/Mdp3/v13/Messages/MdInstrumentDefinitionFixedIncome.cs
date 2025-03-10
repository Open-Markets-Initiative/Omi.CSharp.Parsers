using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Instrument Definition Fixed Income: MDInstrumentDefinitionFixedIncome
/// </summary>

public partial class MdInstrumentDefinitionFixedIncome
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
        public MatchAlgorithm MatchAlgorithm;
        public MinTradeVol MinTradeVol;
        public MaxTradeVol MaxTradeVol;
        public MinPriceIncrementOptional MinPriceIncrementOptional;
        public DisplayFactor DisplayFactor;
        public MainFraction MainFraction;
        public SubFraction SubFraction;
        public PriceDisplayFormat PriceDisplayFormat;
        public UnitOfMeasure UnitOfMeasure;
        public UnitOfMeasureQty UnitOfMeasureQty;
        public TradingReferencePrice TradingReferencePrice;
        public TradingReferenceDate TradingReferenceDate;
        public HighLimitPrice HighLimitPrice;
        public LowLimitPrice LowLimitPrice;
        public MaxPriceVariation MaxPriceVariation;
        public MinPriceIncrementAmount MinPriceIncrementAmount;
        public IssueDate IssueDate;
        public DatedDate DatedDate;
        public MaturityDate MaturityDate;
        public CouponRate CouponRate;
        public ParValue ParValue;
        public CouponFrequencyUnit CouponFrequencyUnit;
        public CouponFrequencyPeriod CouponFrequencyPeriod;
        public CouponDayCount CouponDayCount;
        public CountryOfIssue CountryOfIssue;
        public Issuer Issuer;
        public FinancialInstrumentFullName FinancialInstrumentFullName;
        public SecurityAltId SecurityAltId;
        public SecurityAltIdSource SecurityAltIdSource;
        public PriceQuoteMethod PriceQuoteMethod;
        public PartyRoleClearingOrg PartyRoleClearingOrg;
        public UserDefinedInstrument UserDefinedInstrument;
        public RiskSet RiskSet;
        public MarketSet MarketSet;
        public InstrumentGuid InstrumentGuid;
    };
};
