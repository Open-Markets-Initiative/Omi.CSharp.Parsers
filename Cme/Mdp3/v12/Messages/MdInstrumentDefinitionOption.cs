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
            public PutOrCall PutOrCall;
            public MaturityMonthYear MaturityMonthYear;
            public Currency Currency;
            public StrikePrice StrikePrice;
            public StrikeCurrency StrikeCurrency;
            public SettlCurrency SettlCurrency;
            public MinCabPrice MinCabPrice;
            public MatchAlgorithm MatchAlgorithm;
            public MinTradeVol MinTradeVol;
            public MaxTradeVol MaxTradeVol;
            public MinPriceIncrementOptional MinPriceIncrementOptional;
            public MinPriceIncrementAmount MinPriceIncrementAmount;
            public DisplayFactor DisplayFactor;
            public TickRule TickRule;
            public MainFraction MainFraction;
            public SubFraction SubFraction;
            public PriceDisplayFormat PriceDisplayFormat;
            public UnitOfMeasure UnitOfMeasure;
            public UnitOfMeasureQty UnitOfMeasureQty;
            public TradingReferencePrice TradingReferencePrice;
            public SettlPriceType SettlPriceType;
            public ClearedVolume ClearedVolume;
            public OpenInterestQty OpenInterestQty;
            public LowLimitPrice LowLimitPrice;
            public HighLimitPrice HighLimitPrice;
            public UserDefinedInstrument UserDefinedInstrument;
            public TradingReferenceDate TradingReferenceDate;
            public InstrumentGuid InstrumentGuid;
        };
    };
}