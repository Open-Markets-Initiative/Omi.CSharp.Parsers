using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Incremental Refresh Otc: MDIncrementalRefreshOTC
/// </summary>

public partial class MdIncrementalRefreshOtc
{
    /// <summary>
    ///  Start of event processing time in number of nanoseconds since Unix epoch
    /// </summary>
    public ulong TransactTime => Fields.TransactTime.Value;

    /// <summary>
    ///  Indicates date of trade referenced in this message in YYYYMMDD format (expressed in local time at place of trade). Returned only in trade and trade cancel execution reports.
    /// </summary>
    public ushort TradeDate => Fields.TradeDate.Value;

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
        public TradeDate TradeDate;
        public MatchEventIndicator MatchEventIndicator;
        public BatchTotalMessagesOptional BatchTotalMessagesOptional;
    };

    protected Layout Fields;
};
