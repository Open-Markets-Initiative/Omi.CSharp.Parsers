using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Packet Header
    /// </summary>

    public partial class PacketHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            PacketInfo PacketInfo;
            ApplSeqNum ApplSeqNum;
            MarketSegmentId MarketSegmentId;
            PartitionId PartitionId;
            CompletionIndicator CompletionIndicator;
            ApplSeqResetIndicator ApplSeqResetIndicator;
            Pad5 Pad5;
            TransactTime TransactTime;
        };
    };
}