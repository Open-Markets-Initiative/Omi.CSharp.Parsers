using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Events Groups: Number of repeating EventType entries. Block
/// </summary>

public partial class EventsGroups
{
    /// <summary>
    ///  Repeating group dimensions
    /// </summary>
    public string GroupSizeEncoding => Layout.GroupSizeEncoding.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSizeEncoding GroupSizeEncoding;
    };
};
