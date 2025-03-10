using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Market Event Message: End of Day Market Summary Message
/// </summary>

public partial class MarketEventMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public EventType EventType;
        public MessageDateTime MessageDateTime;
    };
};
