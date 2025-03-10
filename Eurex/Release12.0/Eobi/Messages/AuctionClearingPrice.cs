using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Auction Clearing Price
/// </summary>

public partial class AuctionClearingPrice
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public SecurityId SecurityId;
        public LastPx LastPx;
        public LastQty LastQty;
        public ImbalanceQty ImbalanceQty;
        public SecurityTradingStatus SecurityTradingStatus;
        public PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
        public Pad6 Pad6;
    };
};
