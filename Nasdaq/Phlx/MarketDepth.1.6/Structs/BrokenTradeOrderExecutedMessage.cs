using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Broken Trade Order Executed Message: The Broken Trade Message is sent whenever an execution on PHLX ® is broken. An execution may be broken if it is found to be “clearly erroneous” pursuant to PHLX ® Clearly Erroneous Policy. A trade break is final; once a trade is broken, it cannot be reinstated.
    /// </summary>

    public partial class BrokenTradeOrderExecutedMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            CrossNumber CrossNumber;
            MatchNumber MatchNumber;
        };
    };
}