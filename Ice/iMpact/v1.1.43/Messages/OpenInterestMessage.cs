using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Open Interest Message: Open Interest Message
    /// </summary>

    public partial class OpenInterestMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public OpenInterest OpenInterest;
            public OpenInterestChange OpenInterestChange;
            public MessageDateTime MessageDateTime;
            public OpenInterestDate OpenInterestDate;
        };
    };
}