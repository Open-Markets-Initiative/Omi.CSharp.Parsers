using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Block Delete Message: This message contains a block of Single Side Deletes. Each reference number inside the block represents an order or a side of a quote that is being cancelled. All remaining contracts are no longer accessible so the side should be removed from the book.
    /// </summary>

    public partial class BlockDeleteMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            NumberOfReferenceNumberDeltas NumberOfReferenceNumberDeltas;
            ReferenceNumberDelta ReferenceNumberDelta;
        };
    };
}