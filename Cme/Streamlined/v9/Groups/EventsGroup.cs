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
            public EventTypeIndices EventTypeIndices;
            public EventTime EventTime;
        };
    };
}