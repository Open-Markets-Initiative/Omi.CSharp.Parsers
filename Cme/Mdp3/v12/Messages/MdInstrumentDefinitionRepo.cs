using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Instrument Definition Repo: MDInstrumentDefinitionRepo
    /// </summary>

    public partial class MdInstrumentDefinitionRepo
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
            public MinPriceIncrement MinPriceIncrement;
            public DisplayFactor DisplayFactor;
            public UnitOfMeasure UnitOfMeasure;
            public UnitOfMeasureQty UnitOfMeasureQty;
            public TradingReferencePrice TradingReferencePrice;
            public TradingReferenceDate TradingReferenceDate;
            public HighLimitPrice HighLimitPrice;
            public LowLimitPrice LowLimitPrice;
            public MaxPriceVariation MaxPriceVariation;
            public FinancialInstrumentFullName FinancialInstrumentFullName;
            public PartyRoleClearingOrg PartyRoleClearingOrg;
            public StartDate StartDate;
            public EndDate EndDate;
            public TerminationType TerminationType;
            public RepoSubType RepoSubType;
            public MoneyOrPar MoneyOrPar;
            public MaxNoOfSubstitutions MaxNoOfSubstitutions;
            public PriceQuoteMethod PriceQuoteMethod;
            public UserDefinedInstrument UserDefinedInstrument;
            public RiskSet RiskSet;
            public MarketSet MarketSet;
            public InstrumentGuid InstrumentGuid;
            public TermCode TermCode;
        };
    };
}