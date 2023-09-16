using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Trade Blocks No Date: MDIncrementalRefreshTradeBlocks
    /// </summary>

    public partial class MdIncrementalRefreshTradeBlocksNoDate
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            BatchTotalMessages BatchTotalMessages;
        };
    };
}