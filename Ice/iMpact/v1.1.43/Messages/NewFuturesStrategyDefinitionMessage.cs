using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  New Futures Strategy Definition Message: New Futures Strategy Definition messages will be sent out when new UDS markets for futures are created.
    /// </summary>

    public partial class NewFuturesStrategyDefinitionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public FuturesContractSymbol FuturesContractSymbol;
            public TradingStatus TradingStatus;
            public OrderPriceDenominator OrderPriceDenominator;
            public IncrementPrice IncrementPrice;
            public IncrementQty IncrementQty;
            public MinQty MinQty;
            public NumberOfLegDefinitions NumberOfLegDefinitions;
            public SecuritySubType SecuritySubType;
            public IsBlockOnly IsBlockOnly;
            public StrategySymbol StrategySymbol;
            public GtAllowed GtAllowed;
            public ReservedBytes4 ReservedBytes4;
            public MifidRegulatedMarket MifidRegulatedMarket;
            public MarketDesc MarketDesc;
            public MaturityYear MaturityYear;
            public MaturityMonth MaturityMonth;
            public MaturityDay MaturityDay;
            public DealPriceDenominator DealPriceDenominator;
            public UnitQuantity UnitQuantity;
            public NumDecimalsOptionsPrice NumDecimalsOptionsPrice;
            public AllowOptions AllowOptions;
            public ClearedAlias ClearedAlias;
            public AllowsImplied AllowsImplied;
            public MinPrice MinPrice;
            public MaxPrice MaxPrice;
            public ProductName ProductName;
            public HubAlias HubAlias;
            public StripName StripName;
            public IsTradable IsTradable;
            public SettlePriceDenominator SettlePriceDenominator;
            public MicCode MicCode;
            public UnitQtyDenominator UnitQtyDenominator;
            public HedgeOnly HedgeOnly;
            public ExchangeSilo ExchangeSilo;
            public OffExchangeIncrementQtyDenominator OffExchangeIncrementQtyDenominator;
            public OffExchangeIncrementQty OffExchangeIncrementQty;
            public OffExchangeIncrementPrice OffExchangeIncrementPrice;
            public OffExchangeIncrementOptionPrice OffExchangeIncrementOptionPrice;
            public ProductId ProductId;
            public HubId HubId;
            public StripId StripId;
            public UnderlyingIsin UnderlyingIsin;
            public TestMarketIndicator TestMarketIndicator;
            public LegDealSuppressed LegDealSuppressed;
            public OldNumOfCycles OldNumOfCycles;
            public MarketTypeId MarketTypeId;
            public OverrideBlockMin OverrideBlockMin;
            public NumberOfExtraLegDefinitions NumberOfExtraLegDefinitions;
            public NumOfCycles NumOfCycles;
        };
    };
}