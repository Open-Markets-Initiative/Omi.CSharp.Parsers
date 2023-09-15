using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Full Refresh Order Book: SnapshotFullRefreshOrderBook
    /// </summary>

    public partial class SnapshotFullRefreshOrderBook
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
            TotNumReports TotNumReports;
            SecurityId SecurityId;
            NoChunks NoChunks;
            CurrentChunk CurrentChunk;
            TransactTime TransactTime;
        };
    };
}