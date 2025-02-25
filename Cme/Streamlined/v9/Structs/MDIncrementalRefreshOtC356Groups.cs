using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  M D Incremental Refresh Ot C 356 Groups: Number of entries in Market Data message. Block
/// </summary>

public partial class MDIncrementalRefreshOtC356Groups
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
