using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  New Options Strategy Definition Message: New Options Strategy Definition messages will be sent out when new UDS markets for options are created.
/// </summary>

public partial class NewOptionsStrategyDefinitionMessage
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
    ///  Contract Symbol
    /// </summary>
    public string ContractSymbol => Fields.ContractSymbol.Value;

    /// <summary>
    ///  See Appendix A on the trading status codes
    /// </summary>
    public TradingStatus TradingStatus => Fields.TradingStatus.Value;

    /// <summary>
    ///  Denominator for the order price fields in this market.
    /// </summary>
    public char OrderPriceDenominator => Fields.OrderPriceDenominator.Value;

    /// <summary>
    ///  Minimum increment premium price for this market. OrderPriceDenominator should be applied to this field.
    /// </summary>
    public int IncrementPrice => Fields.IncrementPrice.Value;

    /// <summary>
    ///  Minimum increment quantity for this market
    /// </summary>
    public int IncrementQty => Fields.IncrementQty.Value;

    /// <summary>
    ///  Minimum quantity for this market
    /// </summary>
    public int MinQty => Fields.MinQty.Value;

    /// <summary>
    ///  Number of strategy leg definitions. The leg info are in repeating group followed
    /// </summary>
    public sbyte NumberOfStrategyLegDefinitions => Fields.NumberOfStrategyLegDefinitions.Value;

    /// <summary>
    ///  Number of hedge definitions
    /// </summary>
    public sbyte NumberOfHedgeDefinitions => Fields.NumberOfHedgeDefinitions.Value;

    /// <summary>
    ///  Contains the Strategy Code for defined market where applicable. See Appendix E for list of codes.
    /// </summary>
    public SecuritySubType SecuritySubType => Fields.SecuritySubType.Value;

    /// <summary>
    ///  Indicates if Market is only tradable via ICE Block Trade. This also means the screen trading is not allowed for the market. ‘Y’ or ‘N’
    /// </summary>
    public IsBlockOnly IsBlockOnly => Fields.IsBlockOnly.Value;

    /// <summary>
    ///  Strategy Symbol
    /// </summary>
    public string StrategySymbol => Fields.StrategySymbol.Value;

    /// <summary>
    ///  Indicates if GTC is allowed in the market. ‘Y’ or ‘N’
    /// </summary>
    public GtAllowed GtAllowed => Fields.GtAllowed.Value;

    /// <summary>
    ///  Indicates MIFID-II market. ‘Y’ or ‘N’
    /// </summary>
    public MifidRegulatedMarket MifidRegulatedMarket => Fields.MifidRegulatedMarket.Value;

    /// <summary>
    ///  Denominator for the deal price fields in the market. For most markets, this is the same as OrderPriceDenominator. However, it could be different for some crack or spread markets.
    /// </summary>
    public char DealPriceDenominator => Fields.DealPriceDenominator.Value;

    /// <summary>
    ///  Denominator for the settlement price fields in the market. For most markets, this is the same as DealPriceDenominator.
    /// </summary>
    public char SettlePriceDenominator => Fields.SettlePriceDenominator.Value;

    /// <summary>
    ///  Denominator for UnitQuantity. This field will be ‘0’ for most of the markets.
    /// </summary>
    public char UnitQtyDenominator => Fields.UnitQtyDenominator.Value;

    /// <summary>
    ///  Indicates Test Market. ‘Y’ or ‘N’
    /// </summary>
    public TestMarketIndicator TestMarketIndicator => Fields.TestMarketIndicator.Value;

    /// <summary>
    ///  Extra contract symbol. Some contract symbols might contain more than 35 characters. Clients should append this field to ContractSymbol (Offset 11) to get the complete contract symbol.
    /// </summary>
    public string ContractSymbolExtra => Fields.ContractSymbolExtra.Value;

    /// <summary>
    ///  Indicates whether leg deals are suppressed. ‘Y’ or ‘N’
    /// </summary>
    public LegDealSuppressed LegDealSuppressed => Fields.LegDealSuppressed.Value;

    /// <summary>
    ///  Indicate if the contract is tradable. ‘Y’ or ‘N’.
    /// </summary>
    public IsTradable IsTradable => Fields.IsTradable.Value;

    /// <summary>
    ///  Number of cycles for a contract.
    /// </summary>
    public short OldNumOfCycles => Fields.OldNumOfCycles.Value;

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
    ///  Number of cycles for a contract.
    /// </summary>
    public MarketTypeId MarketTypeId => Fields.MarketTypeId.Value;

    /// <summary>
    ///  Override Block Minimum
    /// </summary>
    public char OverrideBlockMin => Fields.OverrideBlockMin.Value;

    /// <summary>
    ///  Number of strategy leg definitions. The leg info are in repeating group followed
    /// </summary>
    public sbyte NumberOfExtraStrategyLegDefinitions => Fields.NumberOfExtraStrategyLegDefinitions.Value;

    /// <summary>
    ///  Numeric Number of cycles for a contract
    /// </summary>
    public int NumOfCycles => Fields.NumOfCycles.Value;

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

    protected Layout Fields;
};
