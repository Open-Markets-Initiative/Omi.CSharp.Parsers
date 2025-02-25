using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Strip Info Message: This message will be sent out if there is strip date change during the trading session. If client does not care about strip date changes, client should ignore these messages.
    /// </summary>

    public partial class StripInfoMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public OldStripId OldStripId;
            public StripType StripType;
            public BeginYear BeginYear;
            public BeginMonth BeginMonth;
            public BeginDay BeginDay;
            public EndYear EndYear;
            public EndMonth EndMonth;
            public EndDay EndDay;
            public StripInfo StripInfo;
            public StripId StripId;
        };
    };
}