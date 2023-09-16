using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Book Order Groups: Number of OrderID entries Block
    /// </summary>

    public partial class MDIncrementalRefreshBookOrderGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize8Byte GroupSize8Byte;
        };
    };
}