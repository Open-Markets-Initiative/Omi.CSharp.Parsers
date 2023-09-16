using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Eris Reference Data And Daily Statistics: MDIncrementalRefreshErisReferenceDataAndDailyStatistics
    /// </summary>

    public partial class MdIncrementalRefreshErisReferenceDataAndDailyStatistics
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            BatchTotalMessagesOptional BatchTotalMessagesOptional;
        };
    };
}