using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Incremental Refresh Session Statistics Long Qty: MDIncrementalRefreshSessionStatisticsLongQty
/// </summary>

public partial class MdIncrementalRefreshSessionStatisticsLongQty
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
    ///  2 bytes padding
    /// </summary>
    public string Padding2 => Fields.Padding2.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MatchEventIndicator MatchEventIndicator;
        public Padding2 Padding2;
    };

    protected Layout Fields;
};
