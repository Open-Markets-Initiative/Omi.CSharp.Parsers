using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market State Change Message: Market State Change Message
    /// </summary>

    public partial class MarketStateChangeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            TradingStatus TradingStatus;
            MessageDateTime MessageDateTime;
        };
    };
}