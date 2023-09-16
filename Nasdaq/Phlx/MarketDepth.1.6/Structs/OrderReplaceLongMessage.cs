using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Order Replace Long Message: This message is sent whenever an order on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
    /// </summary>

    public partial class OrderReplaceLongMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OriginalReferenceNumberDelta OriginalReferenceNumberDelta;
            NewReferenceNumberDelta NewReferenceNumberDelta;
            Price Price;
            Volume Volume;
            OrderId OrderId;
        };
    };
}