using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  New Expiry Message: New Expiry message will be sent out when a new equity market is created during the day.
/// </summary>

public partial class NewExpiryMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public MarketTypeId MarketTypeId;
        public OrderPriceDenominator OrderPriceDenominator;
        public IncrementPrice IncrementPrice;
        public IncrementQty IncrementQty;
        public LotSize LotSize;
        public MarketDesc MarketDesc;
        public MaturityYear MaturityYear;
        public MaturityMonth MaturityMonth;
        public MaturityDay MaturityDay;
        public DealPriceDenominator DealPriceDenominator;
        public MinQty MinQty;
        public UnitQuantity UnitQuantity;
        public Currency Currency;
        public ClearedAlias ClearedAlias;
        public MinPrice MinPrice;
        public MaxPrice MaxPrice;
        public ProductId ProductId;
        public ProductName ProductName;
        public HubId HubId;
        public HubAlias HubAlias;
        public StripId StripId;
        public StripName StripName;
        public SettlePriceDenominator SettlePriceDenominator;
        public MicCode MicCode;
        public UnitQtyDenominator UnitQtyDenominator;
        public OffExchangeIncrementQtyDenominator OffExchangeIncrementQtyDenominator;
        public OffExchangeIncrementQty OffExchangeIncrementQty;
        public OffExchangeIncrementPrice OffExchangeIncrementPrice;
        public OffExchangeIncrementOptionPrice OffExchangeIncrementOptionPrice;
        public ContractSymbol ContractSymbol;
        public Isin Isin;
        public NumDecimalsOptionsPrice NumDecimalsOptionsPrice;
        public HedgeMarketId HedgeMarketId;
        public SettlementType SettlementType;
        public GtAllowed GtAllowed;
        public CrossOrderSupported CrossOrderSupported;
        public UnitOfMeasure UnitOfMeasure;
        public MifidRegulatedMarket MifidRegulatedMarket;
        public ScreenLastTradeYear ScreenLastTradeYear;
        public ScreenLastTradeMonth ScreenLastTradeMonth;
        public ScreenLastTradeDay ScreenLastTradeDay;
        public OldNumOfCycles OldNumOfCycles;
        public NumOfCycles NumOfCycles;
    };
};
