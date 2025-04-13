using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  M D Incremental Refresh Eris 353 Groups: Number of entries in Market Data message. Block
/// </summary>

public partial class MDIncrementalRefreshEris353Groups
{
    /// <summary>
    ///  Repeating group dimensions
    /// </summary>
    public string GroupSize => Fields.GroupSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSize GroupSize;
    };

    protected Layout Fields;
};
