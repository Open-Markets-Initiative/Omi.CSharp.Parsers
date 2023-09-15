using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Refresh Top Orders Groups: Number of data blocks following Block
    /// </summary>

    public partial class SnapshotRefreshTopOrdersGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}