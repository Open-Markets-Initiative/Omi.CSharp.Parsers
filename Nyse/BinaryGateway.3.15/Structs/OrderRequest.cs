using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Order Request
    /// </summary>

    public partial class OrderRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            SymbolId SymbolId;
            Mpid Mpid;
            MarketMaker MarketMaker;
            MpSubId MpSubId;
            ClOrdId ClOrdId;
            OrigClOrdId OrigClOrdId;
            OrderInstructions OrderInstructions;
            PricePrice8 PricePrice8;
            OrderQty OrderQty;
            MinQty MinQty;
            UserData UserData;
            LegOpenClose LegOpenClose;
            AuctionId AuctionId;
        };
    };
}