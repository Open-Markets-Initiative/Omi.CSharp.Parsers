using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Open Price Message
    /// </summary>

    public partial class OpenPriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            OpenPrice OpenPrice;
            DateTime DateTime;
        };
    };
}