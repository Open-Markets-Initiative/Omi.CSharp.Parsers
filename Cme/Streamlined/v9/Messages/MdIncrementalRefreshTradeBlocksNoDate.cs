using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Incremental Refresh Trade Blocks No Date: MDIncrementalRefreshTradeBlocks
/// </summary>

public partial class MdIncrementalRefreshTradeBlocksNoDate
{
    /// <summary>
    ///  Start of event processing time in number of nanoseconds since Unix epoch
    /// </summary>
    public ulong TransactTime => Fields.TransactTime.Value;

    /// <summary>
    ///  MatchEventIndicator bit set
    /// </summary>
    public string MatchEventIndicator => Fields.MatchEventIndicator.Value;

    /// <summary>
    ///  Total number of messages contained within batch which is defined by match event indicator (5799)
    /// </summary>
    public ushort BatchTotalMessages => Fields.BatchTotalMessages.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MatchEventIndicator MatchEventIndicator;
        public BatchTotalMessages BatchTotalMessages;
    };

    protected Layout Fields;
};
