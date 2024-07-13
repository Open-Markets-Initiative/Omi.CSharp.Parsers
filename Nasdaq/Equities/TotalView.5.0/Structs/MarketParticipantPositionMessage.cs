using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Market Participant Position Message: Throughout the day, NASDAQ will send out this message only if NASDAQ Operations changes the status of a market participant firm in an issue.
    /// </summary>

    public partial class MarketParticipantPositionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Mpid Mpid;
            Stock Stock;
            PrimaryMarketMaker PrimaryMarketMaker;
            MarketMakerMode MarketMakerMode;
            MarketParticipantState MarketParticipantState;
        };
    };
}