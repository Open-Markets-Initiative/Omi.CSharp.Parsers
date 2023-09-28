using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Strip Info Message
    /// </summary>

    public partial class StripInfoMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            OldStripId OldStripId;
            StripType StripType;
            BeginYear BeginYear;
            BeginMonth BeginMonth;
            BeginDay BeginDay;
            EndYear EndYear;
            EndMonth EndMonth;
            EndDay EndDay;
            StripInfo StripInfo;
            StripId StripId;
        };
    };
}