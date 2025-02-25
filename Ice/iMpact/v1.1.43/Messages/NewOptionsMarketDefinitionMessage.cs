using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  New Options Market Definition Message: New Options Market Definition messages will be sent out when new options markets are created.
    /// </summary>

    public partial class NewOptionsMarketDefinitionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public UnderlyingMarketId UnderlyingMarketId;
            public FuturesContractSymbol FuturesContractSymbol;
            public TradingStatus TradingStatus;
            public OrderPriceDenominator OrderPriceDenominator;
            public IncrementQty IncrementQty;
            public LotSize LotSize;
            public MarketDesc MarketDesc;
            public OptionType OptionType;
            public StrikePrice StrikePrice;
            public DealPriceDenominator DealPriceDenominator;
            public MinQty MinQty;
            public Currency Currency;
            public NumDecimalsStrikePrice NumDecimalsStrikePrice;
            public MinOptionsPrice MinOptionsPrice;
            public MaxOptionsPrice MaxOptionsPrice;
            public IncrementPremiumPrice IncrementPremiumPrice;
            public OptionsExpirationYear OptionsExpirationYear;
            public OptionsExpirationMonth OptionsExpirationMonth;
            public OptionsExpirationDay OptionsExpirationDay;
            public OptionsStyle OptionsStyle;
            public OptionsExpirationType OptionsExpirationType;
            public HedgeMarketId HedgeMarketId;
            public SettlePriceDenominator SettlePriceDenominator;
            public UnitQtyDenominator UnitQtyDenominator;
            public TickValue TickValue;
            public FlexAllowed FlexAllowed;
            public SettlementType SettlementType;
            public IsBlockOnly IsBlockOnly;
            public GtAllowed GtAllowed;
            public CrossOrderSupported CrossOrderSupported;
            public GuaranteedCrossSupported GuaranteedCrossSupported;
            public UnitOfMeasure UnitOfMeasure;
            public MifidRegulatedMarket MifidRegulatedMarket;
            public ScreenLastTradeYear ScreenLastTradeYear;
            public ScreenLastTradeMonth ScreenLastTradeMonth;
            public ScreenLastTradeDay ScreenLastTradeDay;
            public IsTradable IsTradable;
            public OldNumOfCycles OldNumOfCycles;
            public MarketTypeId MarketTypeId;
            public NumOfCycles NumOfCycles;
        };
    };
}