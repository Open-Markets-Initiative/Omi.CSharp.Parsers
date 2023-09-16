using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Order Replace Short Message: This message is sent whenever an order on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
    /// </summary>

    public partial class OrderReplaceShortMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OriginalReferenceNumberDelta OriginalReferenceNumberDelta;
            NewReferenceNumberDelta NewReferenceNumberDelta;
            ShortPrice ShortPrice;
            ShortVolume ShortVolume;
            OrderId OrderId;
        };
    };
}