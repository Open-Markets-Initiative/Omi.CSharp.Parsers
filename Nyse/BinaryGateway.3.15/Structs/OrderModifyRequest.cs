using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Order Modify Request
    /// </summary>

    public partial class OrderModifyRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            SymbolId SymbolId;
            Mpid Mpid;
            ClOrdId ClOrdId;
            OrigClOrdId OrigClOrdId;
            OrderQty OrderQty;
            SideU81 SideU81;
            LocateReqd LocateReqd;
        };
    };
}