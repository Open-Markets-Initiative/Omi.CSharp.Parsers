using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Lines Of Text Groups: Identifies number of lines of text body. Block
/// </summary>

public partial class LinesOfTextGroups
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
