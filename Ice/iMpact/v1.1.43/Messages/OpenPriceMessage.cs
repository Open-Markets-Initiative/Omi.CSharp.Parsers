using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Open Price Message: Open Price Message
/// </summary>

public partial class OpenPriceMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public OpenPrice OpenPrice;
        public MessageDateTime MessageDateTime;
    };
};
