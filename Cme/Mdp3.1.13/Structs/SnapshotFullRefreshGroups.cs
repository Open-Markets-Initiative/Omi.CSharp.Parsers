using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Full Refresh Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class SnapshotFullRefreshGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}