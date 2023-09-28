using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Settlement Price Message
    /// </summary>

    public partial class SettlementPriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
            MessageDateTime MessageDateTime;
            IsOfficial IsOfficial;
            ValuationDateTime ValuationDateTime;
            SettlementPrice SettlementPrice;
        };
    };
}