using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Option Open Interest Message: Option Open Interest Message
/// </summary>

public partial class OptionOpenInterestMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public OpenInterest OpenInterest;
        public MessageDateTime MessageDateTime;
        public OpenInterestDate OpenInterestDate;
    };
};
