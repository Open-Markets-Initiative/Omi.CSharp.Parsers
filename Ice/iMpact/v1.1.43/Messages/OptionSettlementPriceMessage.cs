using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Option Settlement Price Message: Option settlement prices could be official or unofficial. For a given market, the exchange usually sends out unofficial price before the official one.
    /// </summary>

    public partial class OptionSettlementPriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
            public MessageDateTime MessageDateTime;
            public IsOfficial IsOfficial;
            public ValuationDateTime ValuationDateTime;
            public Volatility Volatility;
            public SettlementPrice SettlementPrice;
            public Delta Delta;
        };
    };
}