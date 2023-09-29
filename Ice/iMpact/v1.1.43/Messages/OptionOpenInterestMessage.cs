using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Option Open Interest Message: Option Open Interest Message
    /// </summary>

    public partial class OptionOpenInterestMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            OpenInterest OpenInterest;
            MessageDateTime MessageDateTime;
            OpenInterestDate OpenInterestDate;
        };
    };
}