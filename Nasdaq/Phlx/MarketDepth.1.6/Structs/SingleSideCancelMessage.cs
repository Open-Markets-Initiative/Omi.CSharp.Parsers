using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Single Side Cancel Message: This message is sent whenever an order or a side of a quote on the book is modified as a result of a partial cancellation.
    /// </summary>

    public partial class SingleSideCancelMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            ReferenceNumberDelta ReferenceNumberDelta;
            CancelledContracts CancelledContracts;
        };
    };
}