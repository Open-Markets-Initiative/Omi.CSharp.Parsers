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
            MarketId MarketId;
            SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
            MessageDateTime MessageDateTime;
            IsOfficial IsOfficial;
            ValuationDateTime ValuationDateTime;
            Volatility Volatility;
            SettlementPrice SettlementPrice;
            Delta Delta;
        };
    };
}