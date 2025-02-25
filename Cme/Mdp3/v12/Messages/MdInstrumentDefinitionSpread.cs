using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Instrument Definition Spread: MDInstrumentDefinitionSpread
    /// </summary>

    public partial class MdInstrumentDefinitionSpread
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
            public UnderlyingProductOptional UnderlyingProductOptional;
            public SecurityExchange SecurityExchange;
            public SecurityGroup SecurityGroup;
            public Asset Asset;
            public Symbol Symbol;
            public SecurityId SecurityId;
            public SecurityType SecurityType;
            public CfiCode CfiCode;
            public MaturityMonthYear MaturityMonthYear;
            public Currency Currency;
            public SecuritySubType SecuritySubType;
            public UserDefinedInstrument UserDefinedInstrument;
            public MatchAlgorithm MatchAlgorithm;
            public MinTradeVol MinTradeVol;
            public MaxTradeVol MaxTradeVol;
            public MinPriceIncrementOptional MinPriceIncrementOptional;
            public DisplayFactor DisplayFactor;
            public PriceDisplayFormat PriceDisplayFormat;
            public PriceRatio PriceRatio;
            public TickRule TickRule;
            public UnitOfMeasure UnitOfMeasure;
            public TradingReferencePrice TradingReferencePrice;
            public SettlPriceType SettlPriceType;
            public OpenInterestQty OpenInterestQty;
            public ClearedVolume ClearedVolume;
            public HighLimitPrice HighLimitPrice;
            public LowLimitPrice LowLimitPrice;
            public MaxPriceVariation MaxPriceVariation;
            public MainFraction MainFraction;
            public SubFraction SubFraction;
            public TradingReferenceDate TradingReferenceDate;
            public PriceQuoteMethod PriceQuoteMethod;
            public RiskSet RiskSet;
            public MarketSet MarketSet;
            public InstrumentGuid InstrumentGuid;
            public FinancialInstrumentFullName FinancialInstrumentFullName;
        };
    };
}