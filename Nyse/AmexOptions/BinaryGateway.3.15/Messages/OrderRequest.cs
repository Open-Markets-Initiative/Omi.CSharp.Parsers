using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Request
    /// </summary>

    public partial class OrderRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public MarketMaker MarketMaker;
            public MpSubId MpSubId;
            public ClOrdId ClOrdId;
            public OrigClOrdId OrigClOrdId;
            public OrderInstructions OrderInstructions;
            public PricePrice8 PricePrice8;
            public OrderQty OrderQty;
            public MinQty MinQty;
            public UserData UserData;
            public LegOpenClose LegOpenClose;
            public AuctionId AuctionId;
        };
    };
}