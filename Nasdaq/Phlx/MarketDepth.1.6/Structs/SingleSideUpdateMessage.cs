using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Single Side Update Message: This message is sent whenever an order or a side of a quote is being updated for price and (or) contracts. The reference number associated with the order quote is unchanged.
    /// </summary>

    public partial class SingleSideUpdateMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            ReferenceNumberDelta ReferenceNumberDelta;
            ChangeReason ChangeReason;
            Price Price;
            Volume Volume;
        };
    };
}