using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Close Price Message
    /// </summary>

    public partial class ClosePriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            ClosePrice ClosePrice;
            MessageDateTime MessageDateTime;
        };
    };
}