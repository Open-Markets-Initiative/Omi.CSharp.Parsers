using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  New Expiry Message: New Expiry message will be sent out when a new equity market is created during the day.
    /// </summary>

    public partial class NewExpiryMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            MarketTypeId MarketTypeId;
            OrderPriceDenominator OrderPriceDenominator;
            IncrementPrice IncrementPrice;
            IncrementQty IncrementQty;
            LotSize LotSize;
            MarketDesc MarketDesc;
            MaturityYear MaturityYear;
            MaturityMonth MaturityMonth;
            MaturityDay MaturityDay;
            DealPriceDenominator DealPriceDenominator;
            MinQty MinQty;
            UnitQuantity UnitQuantity;
            Currency Currency;
            ClearedAlias ClearedAlias;
            MinPrice MinPrice;
            MaxPrice MaxPrice;
            ProductId ProductId;
            ProductName ProductName;
            HubId HubId;
            HubAlias HubAlias;
            StripId StripId;
            StripName StripName;
            SettlePriceDenominator SettlePriceDenominator;
            MicCode MicCode;
            UnitQtyDenominator UnitQtyDenominator;
            OffExchangeIncrementQtyDenominator OffExchangeIncrementQtyDenominator;
            OffExchangeIncrementQty OffExchangeIncrementQty;
            OffExchangeIncrementPrice OffExchangeIncrementPrice;
            OffExchangeIncrementOptionPrice OffExchangeIncrementOptionPrice;
            ContractSymbol ContractSymbol;
            Isin Isin;
            NumDecimalsOptionsPrice NumDecimalsOptionsPrice;
            HedgeMarketId HedgeMarketId;
            SettlementType SettlementType;
            GtAllowed GtAllowed;
            CrossOrderSupported CrossOrderSupported;
            UnitOfMeasure UnitOfMeasure;
            MifidRegulatedMarket MifidRegulatedMarket;
            ScreenLastTradeYear ScreenLastTradeYear;
            ScreenLastTradeMonth ScreenLastTradeMonth;
            ScreenLastTradeDay ScreenLastTradeDay;
            OldNumOfCycles OldNumOfCycles;
            NumOfCycles NumOfCycles;
        };
    };
}