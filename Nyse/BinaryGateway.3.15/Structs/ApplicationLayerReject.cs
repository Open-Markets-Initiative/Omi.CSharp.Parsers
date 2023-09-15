using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Application Layer Reject
    /// </summary>

    public partial class ApplicationLayerReject
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            SymbolId SymbolId;
            Mpid Mpid;
            ClOrdId ClOrdId;
            ReasonCode ReasonCode;
            RejectType RejectType;
            UserData UserData;
            Reserved4 Reserved4;
        };
    };
}