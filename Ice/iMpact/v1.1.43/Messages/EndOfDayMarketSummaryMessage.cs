using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  End Of Day Market Summary Message: The message is streamed to client when market is closed and settlement price is available for the current trading day.
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