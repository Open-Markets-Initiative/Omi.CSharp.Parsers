using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Related Sym Groups: Specifies the number of repeating symbols specified. Block
/// </summary>

public partial class RelatedSymGroups
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
