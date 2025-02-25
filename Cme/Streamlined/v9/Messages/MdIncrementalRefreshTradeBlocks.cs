using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Trade Blocks 365: MDIncrementalRefreshTradeBlocks
    /// </summary>

    public partial class MdIncrementalRefreshTradeBlocks365
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTimeOptional TransactTimeOptional;
            public MatchEventIndicator MatchEventIndicator;
            public BatchTotalMessages BatchTotalMessages;
            public TradeDate TradeDate;
        };
    };
}