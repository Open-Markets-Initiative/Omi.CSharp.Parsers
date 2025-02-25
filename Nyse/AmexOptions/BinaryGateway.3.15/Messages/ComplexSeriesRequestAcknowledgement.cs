using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Complex Series Request Acknowledgement
    /// </summary>

    public partial class ComplexSeriesRequestAcknowledgement
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public ClOrdId ClOrdId;
            public ReasonCode ReasonCode;
            public SymbolId SymbolId;
            public SideU81 SideU81;
            public RepeatingGroups RepeatingGroups;
            public ComplexAck ComplexAck;
        };
    };
}