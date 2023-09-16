using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Base Reference Message: This message indicates the base reference number to which all the order/quote/trade reference number deltas must be added to obtain the absolute order/quote PHLX reference number.
    /// </summary>

    public partial class BaseReferenceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            BaseReferenceNumber BaseReferenceNumber;
        };
    };
}