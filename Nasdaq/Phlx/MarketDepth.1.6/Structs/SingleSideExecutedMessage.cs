using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Single Side Executed Message: This message is sent whenever a Side order is executed in whole or in part. It is possible to receive several Single Side Executed Messages for the same Side order if that Side order is executed in several parts. The multiple Single Side Executed Messages on the same order are cumulative. By combining the executions received separately via two types of Single Side Executed Messages and Trade Messages, it is possible to build a complete view of all non-auction executions that happen on PHLX ®. Auction execution information is available in one bulk print via the Auction Trade Message.
    /// </summary>

    public partial class SingleSideExecutedMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            ReferenceNumberDelta ReferenceNumberDelta;
            ExecutedContracts ExecutedContracts;
            CrossNumber CrossNumber;
            MatchNumber MatchNumber;
        };
    };
}