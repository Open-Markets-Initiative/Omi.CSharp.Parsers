using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Snapshot Order
    /// </summary>

    public partial class SnapshotOrder
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public OrderDetailsComp OrderDetailsComp;
        };
    };
}