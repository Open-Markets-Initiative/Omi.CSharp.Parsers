using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Security Alt Id Groups: Number of entries in AltID group. Block
/// </summary>

public partial class SecurityAltIdGroups
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
