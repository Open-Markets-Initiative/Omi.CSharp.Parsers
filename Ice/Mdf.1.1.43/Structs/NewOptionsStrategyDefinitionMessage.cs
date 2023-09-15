using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  New Options Strategy Definition Message
    /// </summary>

    public partial class NewOptionsStrategyDefinitionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            UnderlyingMarketId UnderlyingMarketId;
            ContractSymbol ContractSymbol;
            TradingStatus TradingStatus;
            OrderPriceDenominator OrderPriceDenominator;
            IncrementPrice IncrementPrice;
            IncrementQty IncrementQty;
            MinQty MinQty;
            NumberOfStrategyLegDefinitions NumberOfStrategyLegDefinitions;
            NumberOfHedgeDefinitions NumberOfHedgeDefinitions;
            SecuritySubType SecuritySubType;
            IsBlockOnly IsBlockOnly;
            StrategySymbol StrategySymbol;
            GtAllowed GtAllowed;
            MifidRegulatedMarket MifidRegulatedMarket;
            DealPriceDenominator DealPriceDenominator;
            SettlePriceDenominator SettlePriceDenominator;
            UnitQtyDenominator UnitQtyDenominator;
            TestMarketIndicator TestMarketIndicator;
            ContractSymbolExtra ContractSymbolExtra;
            LegDealSuppressed LegDealSuppressed;
            IsTradable IsTradable;
            OldNumOfCycles OldNumOfCycles;
            OptionsExpirationYear OptionsExpirationYear;
            OptionsExpirationMonth OptionsExpirationMonth;
            OptionsExpirationDay OptionsExpirationDay;
            MarketTypeId MarketTypeId;
            OverrideBlockMin OverrideBlockMin;
            NumberOfExtraStrategyLegDefinitions NumberOfExtraStrategyLegDefinitions;
            NumOfCycles NumOfCycles;
        };
    };
}