using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Incremental Refresh Indices: MDIncrementalRefreshIndices
/// </summary>

public partial class MdIncrementalRefreshIndices
{
    /// <summary>
    ///  Start of event processing time in number of nanoseconds since Unix epoch
    /// </summary>
    public ulong TransactTime => Fields.TransactTime.Value;

    /// <summary>
    ///  Describes a class of service for a given data feed.
    /// </summary>
    public string MdFeedType => Fields.MdFeedType.Value;

    /// <summary>
    ///  MatchEventIndicator bit set
    /// </summary>
    public string MatchEventIndicator => Fields.MatchEventIndicator.Value;

    /// <summary>
    ///  Total number of messages contained within batch which is defined by match event indicator (5799)
    /// </summary>
    public ushort BatchTotalMessagesOptional => Fields.BatchTotalMessagesOptional.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MdFeedType MdFeedType;
        public MatchEventIndicator MatchEventIndicator;
        public BatchTotalMessagesOptional BatchTotalMessagesOptional;
    };

    protected Layout Fields;
};
