using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Top Of Book
    /// </summary>

    public partial class TopOfBook
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTime TransactTime;
            public SecurityId SecurityId;
            public BidPx BidPx;
            public OfferPx OfferPx;
            public BidSize BidSize;
            public OfferSize OfferSize;
            public NumberOfBuyOrders NumberOfBuyOrders;
            public NumberOfSellOrders NumberOfSellOrders;
            public Pad4 Pad4;
        };
    };
}