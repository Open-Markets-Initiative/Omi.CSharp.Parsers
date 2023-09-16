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
            TransactTime TransactTime;
            SecurityId SecurityId;
            BidPx BidPx;
            OfferPx OfferPx;
            BidSize BidSize;
            OfferSize OfferSize;
            NumberOfBuyOrders NumberOfBuyOrders;
            NumberOfSellOrders NumberOfSellOrders;
            Pad4 Pad4;
        };
    };
}