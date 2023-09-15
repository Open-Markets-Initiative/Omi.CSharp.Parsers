using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Snapshot Order
    /// </summary>

    public partial class SnapshotOrder
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            OrderDetailsComp OrderDetailsComp;
        };
    };
}