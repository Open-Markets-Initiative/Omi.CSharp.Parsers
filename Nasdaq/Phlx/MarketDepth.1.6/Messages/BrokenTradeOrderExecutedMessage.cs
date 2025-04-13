using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Broken Trade Order Executed Message: The Broken Trade Message is sent whenever an execution on PHLX ® is broken. An execution may be broken if it is found to be “clearly erroneous” pursuant to PHLX ® Clearly Erroneous Policy. A trade break is final; once a trade is broken, it cannot be reinstated.
/// </summary>

public partial class BrokenTradeOrderExecutedMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Trade Group Id. Ties together all trades of a given atomic transaction in the matching engine.
    /// </summary>
    public uint CrossNumber => Fields.CrossNumber.Value;

    /// <summary>
    ///  Execution Id. Identifies the component of an execution. Unique for a given day.  The match number is also referenced in the Trade Break Message.
    /// </summary>
    public uint MatchNumber => Fields.MatchNumber.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public CrossNumber CrossNumber;
        public MatchNumber MatchNumber;
    };

    protected Layout Fields;
};
