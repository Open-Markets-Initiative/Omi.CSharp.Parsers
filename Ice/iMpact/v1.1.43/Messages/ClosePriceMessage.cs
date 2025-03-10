using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Close Price Message: Close Price Message
/// </summary>

public partial class ClosePriceMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public ClosePrice ClosePrice;
        public MessageDateTime MessageDateTime;
    };
};
