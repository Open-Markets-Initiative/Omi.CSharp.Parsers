using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Application Layer Reject
    /// </summary>

    public partial class ApplicationLayerReject
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public ClOrdId ClOrdId;
            public ReasonCode ReasonCode;
            public RejectType RejectType;
            public UserData UserData;
            public Reserved4 Reserved4;
        };
    };
}