using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Market State Change Message: Market State Change Message
/// </summary>

public partial class MarketStateChangeMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public TradingStatus TradingStatus;
        public MessageDateTime MessageDateTime;
    };
};
