using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Events Groups: Number of repeating EventType entries Block
    /// </summary>

    public partial class EventsGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}