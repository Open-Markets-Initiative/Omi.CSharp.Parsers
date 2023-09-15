using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Covered
    /// </summary>

    public partial class Covered
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SubMsgHeader SubMsgHeader;
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