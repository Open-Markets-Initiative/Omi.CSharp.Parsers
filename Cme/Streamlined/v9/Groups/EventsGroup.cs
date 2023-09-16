using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Events Group: Number of repeating EventType entries.
    /// </summary>

    public partial class EventsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            EventTypeIndices EventTypeIndices;
            EventTime EventTime;
        };
    };
}