using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  New Options Market Definition Message: New Options Market Definition messages will be sent out when new options markets are created.
/// </summary>

public partial class NewOptionsMarketDefinitionMessage
{
    /// <summary>
    ///  Market Id
    /// </summary>
    public int MarketId => Fields.MarketId.Value;

    /// <summary>
    ///  Unique identifier of the underlying market
    /// </summary>
    public int UnderlyingMarketId => Fields.UnderlyingMarketId.Value;

    /// <summary>
    ///  Futures Contract Symbol
    /// </summary>
    public string FuturesContractSymbol => Fields.FuturesContractSymbol.Value;

    /// <summary>
    ///  See Appendix A on the trading status codes
    /// </summary>
    public TradingStatus TradingStatus => Fields.TradingStatus.Value;

    /// <summary>
    ///  Denominator for the order price fields in this market.
    /// </summary>
    public char OrderPriceDenominator => Fields.OrderPriceDenominator.Value;

    /// <summary>
    ///  Minimum increment quantity for this market
    /// </summary>
    public int IncrementQty => Fields.IncrementQty.Value;

    /// <summary>
    ///  The lot size is minimum size of contracts in lots. It is multiplier to determine the total lots.
    /// </summary>
    public int LotSize => Fields.LotSize.Value;

    /// <summary>
    ///  Description of the market
    /// </summary>
    public string MarketDesc => Fields.MarketDesc.Value;

    /// <summary>
    ///  “C” – Call, “P” – Put
    /// </summary>
    public OptionType OptionType => Fields.OptionType.Value;

    /// <summary>
    ///  Strike Price of the option. Used in conjunction with the NumDecimalsStrikePrice. This is often different from the premium price decimals.
    /// </summary>
    public long StrikePrice => Fields.StrikePrice.Value;

    /// <summary>
    ///  Denominator for the deal price fields in the market. For most markets, this is the same as OrderPriceDenominator. However, it could be different for some crack or spread markets.
    /// </summary>
    public char DealPriceDenominator => Fields.DealPriceDenominator.Value;

    /// <summary>
    ///  Minimum quantity for this market
    /// </summary>
    public int MinQty => Fields.MinQty.Value;

    /// <summary>
    ///  The currency that the market is traded on.
    /// </summary>
    public string Currency => Fields.Currency.Value;

    /// <summary>
    ///  Denominator for the strike price field.
    /// </summary>
    public char NumDecimalsStrikePrice => Fields.NumDecimalsStrikePrice.Value;

    /// <summary>
    ///  Minimum premium price for the option.
    /// </summary>
    public long MinOptionsPrice => Fields.MinOptionsPrice.Value;

    /// <summary>
    ///  Maximum premium price for the option.
    /// </summary>
    public long MaxOptionsPrice => Fields.MaxOptionsPrice.Value;

    /// <summary>
    ///  Price increment for the option market.
    /// </summary>
    public int IncrementPremiumPrice => Fields.IncrementPremiumPrice.Value;

    /// <summary>
    ///  4 digit year
    /// </summary>
    public short OptionsExpirationYear => Fields.OptionsExpirationYear.Value;

    /// <summary>
    ///  Month Range
    /// </summary>
    public short OptionsExpirationMonth => Fields.OptionsExpirationMonth.Value;

    /// <summary>
    ///  Day of the month
    /// </summary>
    public short OptionsExpirationDay => Fields.OptionsExpirationDay.Value;

    /// <summary>
    ///  OptionsStyle: ‘A’ – American, ‘E’ – European, ‘0’ – None, ‘3’ – Asian, ‘4’ – One Time
    /// </summary>
    public OptionsStyle OptionsStyle => Fields.OptionsStyle.Value;

    /// <summary>
    ///  Options expiration type: ‘M’ – Monthly ‘D’ – Daily
    /// </summary>
    public OptionsExpirationType OptionsExpirationType => Fields.OptionsExpirationType.Value;

    /// <summary>
    ///  Market ID for the corresponding hedge market.
    /// </summary>
    public int HedgeMarketId => Fields.HedgeMarketId.Value;

    /// <summary>
    ///  Denominator for the settlement price fields in the market. For most markets, this is the same as DealPriceDenominator.
    /// </summary>
    public char SettlePriceDenominator => Fields.SettlePriceDenominator.Value;

    /// <summary>
    ///  Denominator for UnitQuantity. This field will be ‘0’ for most of the markets.
    /// </summary>
    public char UnitQtyDenominator => Fields.UnitQtyDenominator.Value;

    /// <summary>
    ///  OrderPriceDenominator should be applied to get the real value.
    /// </summary>
    public long TickValue => Fields.TickValue.Value;

    /// <summary>
    ///  Indicates if flexible strikes can be created for the option market. ‘Y’ or ‘N’
    /// </summary>
    public FlexAllowed FlexAllowed => Fields.FlexAllowed.Value;

    /// <summary>
    ///  Settlement Type: ‘0’ - financial, ‘1’ - physical
    /// </summary>
    public SettlementType SettlementType => Fields.SettlementType.Value;

    /// <summary>
    ///  Indicates if Market is only tradable via ICE Block Trade. This also means the screen trading is not allowed for the market. ‘Y’ or ‘N’
    /// </summary>
    public IsBlockOnly IsBlockOnly => Fields.IsBlockOnly.Value;

    /// <summary>
    ///  Indicates if GTC is allowed in the market. ‘Y’ or ‘N’
    /// </summary>
    public GtAllowed GtAllowed => Fields.GtAllowed.Value;

    /// <summary>
    ///  Indicates if Cross Order is supported in the market. ‘Y’ or ‘N’
    /// </summary>
    public CrossOrderSupported CrossOrderSupported => Fields.CrossOrderSupported.Value;

    /// <summary>
    ///  Indicates if Guarantee Cross is supported in the market. ‘Y’ or ‘N’
    /// </summary>
    public GuaranteedCrossSupported GuaranteedCrossSupported => Fields.GuaranteedCrossSupported.Value;

    /// <summary>
    ///  Unit Of Measure
    /// </summary>
    public string UnitOfMeasure => Fields.UnitOfMeasure.Value;

    /// <summary>
    ///  Indicates MIFID-II market. ‘Y’ or ‘N’
    /// </summary>
    public MifidRegulatedMarket MifidRegulatedMarket => Fields.MifidRegulatedMarket.Value;

    /// <summary>
    ///  Screen last trade year, 4 digits
    /// </summary>
    public short ScreenLastTradeYear => Fields.ScreenLastTradeYear.Value;

    /// <summary>
    ///  Screen last trade month, range 1-12
    /// </summary>
    public short ScreenLastTradeMonth => Fields.ScreenLastTradeMonth.Value;

    /// <summary>
    ///  Screen last trade day of the month
    /// </summary>
    public short ScreenLastTradeDay => Fields.ScreenLastTradeDay.Value;

    /// <summary>
    ///  Indicate if the contract is tradable. ‘Y’ or ‘N’.
    /// </summary>
    public IsTradable IsTradable => Fields.IsTradable.Value;

    /// <summary>
    ///  Number of cycles for a contract.
    /// </summary>
    public short OldNumOfCycles => Fields.OldNumOfCycles.Value;

    /// <summary>
    ///  Number of cycles for a contract.
    /// </summary>
    public MarketTypeId MarketTypeId => Fields.MarketTypeId.Value;

    /// <summary>
    ///  Numeric Number of cycles for a contract
    /// </summary>
    public int NumOfCycles => Fields.NumOfCycles.Value;

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

    protected Layout Fields;
};
