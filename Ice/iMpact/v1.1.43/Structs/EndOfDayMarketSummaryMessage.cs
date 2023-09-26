using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  End Of Day Market Summary Message
    /// </summary>

    public partial class EndOfDayMarketSummaryMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            Volume Volume;
            BlockVolume BlockVolume;
            EfsVolume EfsVolume;
            EfpVolume EfpVolume;
            OpeningPrice OpeningPrice;
            High High;
            Low Low;
            Vwap Vwap;
            SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
            OpenInterest OpenInterest;
            MessageDateTime MessageDateTime;
            SettlementPrice SettlementPrice;
        };
    };
}