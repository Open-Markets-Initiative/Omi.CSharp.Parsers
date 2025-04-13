using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Fixing Indicative Price Message: This message supports ICE Benchmark Administration’s (IBA) electronic Gold and Silver Auction and is disseminated at the end of the final auction when the final price is published
/// </summary>

public partial class FixingIndicativePriceMessage
{
    /// <summary>
    ///  Market Id
    /// </summary>
    public int MarketId => Fields.MarketId.Value;

    /// <summary>
    ///  Currency Code
    /// </summary>
    public string IbaCurrency => Fields.IbaCurrency.Value;

    /// <summary>
    ///  DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>
    public long Price => Fields.Price.Value;

    /// <summary>
    ///  Auctioneers price in gram for the round in specified currency
    /// </summary>
    public long PriceInGram => Fields.PriceInGram.Value;

    /// <summary>
    ///  Number of decimals to use for Prices
    /// </summary>
    public sbyte NumDecimalsPrice => Fields.NumDecimalsPrice.Value;

    /// <summary>
    ///  Number of decimals to use for PriceInGram
    /// </summary>
    public sbyte NumDecimalsPriceInGram => Fields.NumDecimalsPriceInGram.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public IbaCurrency IbaCurrency;
        public Price Price;
        public PriceInGram PriceInGram;
        public NumDecimalsPrice NumDecimalsPrice;
        public NumDecimalsPriceInGram NumDecimalsPriceInGram;
    };

    protected Layout Fields;
};
