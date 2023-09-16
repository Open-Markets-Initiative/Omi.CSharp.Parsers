using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  New Futures Strategy Definition Message
    /// </summary>

    public partial class NewFuturesStrategyDefinitionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            FuturesContractSymbol FuturesContractSymbol;
            TradingStatus TradingStatus;
            OrderPriceDenominator OrderPriceDenominator;
            IncrementPrice IncrementPrice;
            IncrementQty IncrementQty;
            MinQty MinQty;
            NumberOfLegDefinitions NumberOfLegDefinitions;
            SecuritySubType SecuritySubType;
            IsBlockOnly IsBlockOnly;
            StrategySymbol StrategySymbol;
            GtAllowed GtAllowed;
            ReservedBytes4 ReservedBytes4;
            MifidRegulatedMarket MifidRegulatedMarket;
            MarketDesc MarketDesc;
            MaturityYear MaturityYear;
            MaturityMonth MaturityMonth;
            MaturityDay MaturityDay;
            DealPriceDenominator DealPriceDenominator;
            UnitQuantity UnitQuantity;
            NumDecimalsOptionsPrice NumDecimalsOptionsPrice;
            AllowOptions AllowOptions;
            ClearedAlias ClearedAlias;
            AllowsImplied AllowsImplied;
            MinPrice MinPrice;
            MaxPrice MaxPrice;
            ProductName ProductName;
            HubAlias HubAlias;
            StripName StripName;
            IsTradable IsTradable;
            SettlePriceDenominator SettlePriceDenominator;
            MicCode MicCode;
            UnitQtyDenominator UnitQtyDenominator;
            HedgeOnly HedgeOnly;
            ExchangeSilo ExchangeSilo;
            OffExchangeIncrementQtyDenominator OffExchangeIncrementQtyDenominator;
            OffExchangeIncrementQty OffExchangeIncrementQty;
            OffExchangeIncrementPrice OffExchangeIncrementPrice;
            OffExchangeIncrementOptionPrice OffExchangeIncrementOptionPrice;
            ProductId ProductId;
            HubId HubId;
            StripId StripId;
            UnderlyingIsin UnderlyingIsin;
            TestMarketIndicator TestMarketIndicator;
            LegDealSuppressed LegDealSuppressed;
            OldNumOfCycles OldNumOfCycles;
            MarketTypeId MarketTypeId;
            OverrideBlockMin OverrideBlockMin;
            NumberOfExtraLegDefinitions NumberOfExtraLegDefinitions;
            NumOfCycles NumOfCycles;
        };
    };
}