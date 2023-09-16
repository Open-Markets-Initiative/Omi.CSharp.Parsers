using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Single Side Executed With Price Message: This message is sent whenever an incoming Side order is executed against the book in whole or in part at a price different from the initial display price. Since the execution price is different than the display price of the original Add/Replace, the options system includes a price field within this execution message. It is possible to receive multiple Single Side Executed and Single Side Executed with Price messages for the same Side order if that Side order is executed in several parts. The multiple Single Side Executed messages on the same Side order are cumulative.
    /// </summary>

    public partial class SingleSideExecutedWithPriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            ReferenceNumberDelta ReferenceNumberDelta;
            CrossNumber CrossNumber;
            MatchNumber MatchNumber;
            Printable Printable;
            Price Price;
            Volume Volume;
        };
    };
}