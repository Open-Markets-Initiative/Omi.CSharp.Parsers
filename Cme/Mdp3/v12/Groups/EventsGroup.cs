using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Events Group: Number of repeating EventType entries
/// </summary>

public partial class EventsGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public EventType EventType;
        public EventTime EventTime;
    };
};
