using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Events Groups: Number of repeating EventType entries Block
/// </summary>

public partial class EventsGroups
{
    /// <summary>
    ///  Repeating group dimensions
    /// </summary>
    public string GroupSize => Layout.GroupSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSize GroupSize;
    };
};
