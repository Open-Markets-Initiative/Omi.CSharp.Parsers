using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Events Groups: Number of repeating EventType entries. Block
    /// </summary>

    public partial class EventsGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSizeEncoding GroupSizeEncoding;
        };
    };
}