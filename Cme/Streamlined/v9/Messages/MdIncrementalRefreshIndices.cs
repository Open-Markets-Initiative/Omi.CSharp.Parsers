using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Incremental Refresh Indices: MDIncrementalRefreshIndices
/// </summary>

public partial class MdIncrementalRefreshIndices
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MdFeedType MdFeedType;
        public MatchEventIndicator MatchEventIndicator;
        public BatchTotalMessagesOptional BatchTotalMessagesOptional;
    };
};
