using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Full Refresh Tc P Long Qty Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class SnapshotFullRefreshTcPLongQtyGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}