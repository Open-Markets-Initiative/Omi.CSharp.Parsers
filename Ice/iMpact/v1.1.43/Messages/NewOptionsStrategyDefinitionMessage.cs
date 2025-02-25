using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  New Options Strategy Definition Message: New Options Strategy Definition messages will be sent out when new UDS markets for options are created.
    /// </summary>

    public partial class NewOptionsStrategyDefinitionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public UnderlyingMarketId UnderlyingMarketId;
            public ContractSymbol ContractSymbol;
            public TradingStatus TradingStatus;
            public OrderPriceDenominator OrderPriceDenominator;
            public IncrementPrice IncrementPrice;
            public IncrementQty IncrementQty;
            public MinQty MinQty;
            public NumberOfStrategyLegDefinitions NumberOfStrategyLegDefinitions;
            public NumberOfHedgeDefinitions NumberOfHedgeDefinitions;
            public SecuritySubType SecuritySubType;
            public IsBlockOnly IsBlockOnly;
            public StrategySymbol StrategySymbol;
            public GtAllowed GtAllowed;
            public MifidRegulatedMarket MifidRegulatedMarket;
            public DealPriceDenominator DealPriceDenominator;
            public SettlePriceDenominator SettlePriceDenominator;
            public UnitQtyDenominator UnitQtyDenominator;
            public TestMarketIndicator TestMarketIndicator;
            public ContractSymbolExtra ContractSymbolExtra;
            public LegDealSuppressed LegDealSuppressed;
            public IsTradable IsTradable;
            public OldNumOfCycles OldNumOfCycles;
            public OptionsExpirationYear OptionsExpirationYear;
            public OptionsExpirationMonth OptionsExpirationMonth;
            public OptionsExpirationDay OptionsExpirationDay;
            public MarketTypeId MarketTypeId;
            public OverrideBlockMin OverrideBlockMin;
            public NumberOfExtraStrategyLegDefinitions NumberOfExtraStrategyLegDefinitions;
            public NumOfCycles NumOfCycles;
        };
    };
}