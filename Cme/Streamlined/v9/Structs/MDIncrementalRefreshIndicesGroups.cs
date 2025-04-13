using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  M D Incremental Refresh Indices Groups: Number of entries in Market Data message Block
/// </summary>

public partial class MDIncrementalRefreshIndicesGroups
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
