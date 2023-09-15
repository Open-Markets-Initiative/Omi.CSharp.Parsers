using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Open Interest Message
    /// </summary>

    public partial class OpenInterestMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            OpenInterest OpenInterest;
            OpenInterestChange OpenInterestChange;
            DateTime DateTime;
            OpenInterestDate OpenInterestDate;
        };
    };
}