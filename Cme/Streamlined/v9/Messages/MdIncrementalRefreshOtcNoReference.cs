using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Otc No Reference: MDIncrementalRefreshOTC
    /// </summary>

    public partial class MdIncrementalRefreshOtcNoReference
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTime TransactTime;
            public TradeDate TradeDate;
            public MatchEventIndicator MatchEventIndicator;
            public BatchTotalMessagesOptional BatchTotalMessagesOptional;
        };
    };
}