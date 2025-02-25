using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Full Refresh Order Book: SnapshotFullRefreshOrderBook
    /// </summary>

    public partial class SnapshotFullRefreshOrderBook
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
            public TotNumReports TotNumReports;
            public SecurityId SecurityId;
            public NoChunks NoChunks;
            public CurrentChunk CurrentChunk;
            public TransactTime TransactTime;
        };
    };
}