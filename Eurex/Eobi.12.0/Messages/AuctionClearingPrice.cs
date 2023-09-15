using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Auction Clearing Price
    /// </summary>

    public partial class AuctionClearingPrice
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            SecurityId SecurityId;
            LastPx LastPx;
            LastQty LastQty;
            ImbalanceQty ImbalanceQty;
            SecurityTradingStatus SecurityTradingStatus;
            PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
            Pad6 Pad6;
        };
    };
}