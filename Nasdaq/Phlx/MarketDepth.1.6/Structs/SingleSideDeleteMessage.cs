using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Single Side Delete Message: The message is sent when an order or a side of a quote is being cancelled. All remaining contracts are no longer accessible so the side should be removed from the book.
    /// </summary>

    public partial class SingleSideDeleteMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            ReferenceNumberDelta ReferenceNumberDelta;
        };
    };
}