using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  End Of Day Market Summary Message: The message is streamed to client when market is closed and settlement price is available for the current trading day.
/// </summary>

public partial class EndOfDayMarketSummaryMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public Volume Volume;
        public BlockVolume BlockVolume;
        public EfsVolume EfsVolume;
        public EfpVolume EfpVolume;
        public OpeningPrice OpeningPrice;
        public High High;
        public Low Low;
        public Vwap Vwap;
        public SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
        public OpenInterest OpenInterest;
        public MessageDateTime MessageDateTime;
        public SettlementPrice SettlementPrice;
    };
};
