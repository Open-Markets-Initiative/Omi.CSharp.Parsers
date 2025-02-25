using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Modify Request
    /// </summary>

    public partial class OrderModifyRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public ClOrdId ClOrdId;
            public OrigClOrdId OrigClOrdId;
            public OrderQty OrderQty;
            public SideU81 SideU81;
            public LocateReqd LocateReqd;
        };
    };
}