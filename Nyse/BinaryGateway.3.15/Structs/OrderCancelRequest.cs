using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Order Cancel Request
    /// </summary>

    public partial class OrderCancelRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            SymbolId SymbolId;
            Mpid Mpid;
            ClOrdId ClOrdId;
            OrigClOrdId OrigClOrdId;
        };
    };
}