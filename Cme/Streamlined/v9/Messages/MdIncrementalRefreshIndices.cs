using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Indices: MDIncrementalRefreshIndices
    /// </summary>

    public partial class MdIncrementalRefreshIndices
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MdFeedType MdFeedType;
            MatchEventIndicator MatchEventIndicator;
            BatchTotalMessagesOptional BatchTotalMessagesOptional;
        };
    };
}