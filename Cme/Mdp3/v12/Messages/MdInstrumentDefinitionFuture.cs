using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Instrument Definition Future: MDInstrumentDefinitionFuture
/// </summary>

public partial class MdInstrumentDefinitionFuture
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
        public MaturityMonthYear MaturityMonthYear;
        public Currency Currency;
        public SettlCurrency SettlCurrency;
        public MatchAlgorithm MatchAlgorithm;
        public MinTradeVol MinTradeVol;
        public MaxTradeVol MaxTradeVol;
        public MinPriceIncrement MinPriceIncrement;
        public DisplayFactor DisplayFactor;
        public MainFraction MainFraction;
        public SubFraction SubFraction;
        public PriceDisplayFormat PriceDisplayFormat;
        public UnitOfMeasure UnitOfMeasure;
        public UnitOfMeasureQty UnitOfMeasureQty;
        public TradingReferencePrice TradingReferencePrice;
        public SettlPriceType SettlPriceType;
        public OpenInterestQty OpenInterestQty;
        public ClearedVolume ClearedVolume;
        public HighLimitPrice HighLimitPrice;
        public LowLimitPrice LowLimitPrice;
        public MaxPriceVariation MaxPriceVariation;
        public DecayQuantity DecayQuantity;
        public DecayStartDate DecayStartDate;
        public OriginalContractSize OriginalContractSize;
        public ContractMultiplier ContractMultiplier;
        public ContractMultiplierUnit ContractMultiplierUnit;
        public FlowScheduleType FlowScheduleType;
        public MinPriceIncrementAmount MinPriceIncrementAmount;
        public UserDefinedInstrument UserDefinedInstrument;
        public TradingReferenceDate TradingReferenceDate;
        public InstrumentGuid InstrumentGuid;
    };
};
