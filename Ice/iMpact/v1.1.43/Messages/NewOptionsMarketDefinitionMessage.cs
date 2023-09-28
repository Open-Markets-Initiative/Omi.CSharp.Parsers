using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  New Options Market Definition Message
    /// </summary>

    public partial class NewOptionsMarketDefinitionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            UnderlyingMarketId UnderlyingMarketId;
            FuturesContractSymbol FuturesContractSymbol;
            TradingStatus TradingStatus;
            OrderPriceDenominator OrderPriceDenominator;
            IncrementQty IncrementQty;
            LotSize LotSize;
            MarketDesc MarketDesc;
            OptionType OptionType;
            StrikePrice StrikePrice;
            DealPriceDenominator DealPriceDenominator;
            MinQty MinQty;
            Currency Currency;
            NumDecimalsStrikePrice NumDecimalsStrikePrice;
            MinOptionsPrice MinOptionsPrice;
            MaxOptionsPrice MaxOptionsPrice;
            IncrementPremiumPrice IncrementPremiumPrice;
            OptionsExpirationYear OptionsExpirationYear;
            OptionsExpirationMonth OptionsExpirationMonth;
            OptionsExpirationDay OptionsExpirationDay;
            OptionsStyle OptionsStyle;
            OptionsExpirationType OptionsExpirationType;
            HedgeMarketId HedgeMarketId;
            SettlePriceDenominator SettlePriceDenominator;
            UnitQtyDenominator UnitQtyDenominator;
            TickValue TickValue;
            FlexAllowed FlexAllowed;
            SettlementType SettlementType;
            IsBlockOnly IsBlockOnly;
            GtAllowed GtAllowed;
            CrossOrderSupported CrossOrderSupported;
            GuaranteedCrossSupported GuaranteedCrossSupported;
            UnitOfMeasure UnitOfMeasure;
            MifidRegulatedMarket MifidRegulatedMarket;
            ScreenLastTradeYear ScreenLastTradeYear;
            ScreenLastTradeMonth ScreenLastTradeMonth;
            ScreenLastTradeDay ScreenLastTradeDay;
            IsTradable IsTradable;
            OldNumOfCycles OldNumOfCycles;
            MarketTypeId MarketTypeId;
            NumOfCycles NumOfCycles;
        };
    };
}