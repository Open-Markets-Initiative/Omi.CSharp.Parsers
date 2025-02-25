using System.Runtime.InteropServices;

namespace Iex.Deep
{
    /// <summary>
    ///  Auction Information Message: Broadcasts an Auction Information Message every one second between the Lock-in Time and the auction match for Opening and Closing Auctions, and during the Display Only Period for IPO, Halt, and Volatility Auctions.
    /// </summary>

    public partial class AuctionInformationMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public AuctionType AuctionType;
            public Timestamp Timestamp;
            public Symbol Symbol;
            public PairedShares PairedShares;
            public ReferencePrice ReferencePrice;
            public IndicativeClearingPrice IndicativeClearingPrice;
            public ImbalanceShares ImbalanceShares;
            public ImbalanceSide ImbalanceSide;
            public ExtensionNumber ExtensionNumber;
            public ScheduledAuctionTime ScheduledAuctionTime;
            public AuctionBookClearingPrice AuctionBookClearingPrice;
            public CollarReferencePrice CollarReferencePrice;
            public LowerAuctionCollar LowerAuctionCollar;
            public UpperAuctionCollar UpperAuctionCollar;
        };
    };
}