using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Otc: MDIncrementalRefreshOTC
    /// </summary>

    public partial class MdIncrementalRefreshOtc
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            TradeDate TradeDate;
            MatchEventIndicator MatchEventIndicator;
            BatchTotalMessagesOptional BatchTotalMessagesOptional;
        };
    };
}