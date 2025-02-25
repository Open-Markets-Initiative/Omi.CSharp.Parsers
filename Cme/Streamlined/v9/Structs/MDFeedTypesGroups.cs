using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  M D Feed Types Groups: Number of feed type repeating group entries. Block
/// </summary>

public partial class MDFeedTypesGroups
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
