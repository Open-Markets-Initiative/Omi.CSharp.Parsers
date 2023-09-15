using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Full Refresh Tcp Groups: Number of data blocks listed in the Incremental message Block
    /// </summary>

    public partial class SnapshotFullRefreshTcpGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}