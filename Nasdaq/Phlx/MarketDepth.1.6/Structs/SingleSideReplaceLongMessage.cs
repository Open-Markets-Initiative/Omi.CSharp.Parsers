using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Single Side Replace Long Message: This message is sent whenever one side of a quote on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
    /// </summary>

    public partial class SingleSideReplaceLongMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OriginalReferenceNumberDelta OriginalReferenceNumberDelta;
            NewReferenceNumberDelta NewReferenceNumberDelta;
            Price Price;
            Volume Volume;
        };
    };
}