using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Incremental Refresh Trade Blocks Short: MDIncrementalRefreshTradeBlocks
/// </summary>

public partial class MdIncrementalRefreshTradeBlocksShort
{
    /// <summary>
    ///  Start of event processing time in number of nanoseconds since Unix epoch. Not present for EFP (828=2) and EFR (828=11) transactions
    /// </summary>
    public ulong TransactTimeOptional => Fields.TransactTimeOptional.Value;

    /// <summary>
    ///  MatchEventIndicator bit set
    /// </summary>
    public string MatchEventIndicator => Fields.MatchEventIndicator.Value;

    /// <summary>
    ///  Total number of messages contained within batch which is defined by match event indicator (5799)
    /// </summary>
    public ushort BatchTotalMessages => Fields.BatchTotalMessages.Value;

    /// <summary>
    ///  Indicates date of trade referenced in this message in YYYYMMDD format (expressed in local time at place of trade). Returned only in trade and trade cancel execution reports.
    /// </summary>
    public ushort TradeDate => Fields.TradeDate.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTimeOptional TransactTimeOptional;
        public MatchEventIndicator MatchEventIndicator;
        public BatchTotalMessages BatchTotalMessages;
        public TradeDate TradeDate;
    };

    protected Layout Fields;
};
