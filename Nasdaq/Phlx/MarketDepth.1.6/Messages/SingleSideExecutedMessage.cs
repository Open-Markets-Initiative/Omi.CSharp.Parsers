using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Single Side Executed Message: This message is sent whenever a Side order is executed in whole or in part. It is possible to receive several Single Side Executed Messages for the same Side order if that Side order is executed in several parts. The multiple Single Side Executed Messages on the same order are cumulative. By combining the executions received separately via two types of Single Side Executed Messages and Trade Messages, it is possible to build a complete view of all non-auction executions that happen on PHLX ®. Auction execution information is available in one bulk print via the Auction Trade Message.
/// </summary>

public partial class SingleSideExecutedMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The order/quote reference number delta associated with the executed order.
    /// </summary>
    public uint ReferenceNumberDelta => Fields.ReferenceNumberDelta.Value;

    /// <summary>
    ///  The number of contracts executed.
    /// </summary>
    public uint ExecutedContracts => Fields.ExecutedContracts.Value;

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
        public ReferenceNumberDelta ReferenceNumberDelta;
        public ExecutedContracts ExecutedContracts;
        public CrossNumber CrossNumber;
        public MatchNumber MatchNumber;
    };

    protected Layout Fields;
};
