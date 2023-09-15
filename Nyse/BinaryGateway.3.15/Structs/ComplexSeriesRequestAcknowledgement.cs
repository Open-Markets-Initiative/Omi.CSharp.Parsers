using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Complex Series Request Acknowledgement
    /// </summary>

    public partial class ComplexSeriesRequestAcknowledgement
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            ClOrdId ClOrdId;
            ReasonCode ReasonCode;
            SymbolId SymbolId;
            SideU81 SideU81;
            RepeatingGroups RepeatingGroups;
            ComplexAck ComplexAck;
        };
    };
}