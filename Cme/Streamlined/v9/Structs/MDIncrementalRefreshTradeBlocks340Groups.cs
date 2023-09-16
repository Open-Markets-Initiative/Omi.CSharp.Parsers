using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Trade Blocks 340 Groups: Number of entries in Market Data message. Block
    /// </summary>

    public partial class MDIncrementalRefreshTradeBlocks340Groups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}