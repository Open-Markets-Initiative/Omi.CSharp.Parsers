using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Inst Attrib Groups: Number of repeating InstrAttribType entries. Block
/// </summary>

public partial class InstAttribGroups
{
    /// <summary>
    ///  Repeating group dimensions
    /// </summary>
    public string GroupSizeEncoding => Fields.GroupSizeEncoding.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSizeEncoding GroupSizeEncoding;
    };

    protected Layout Fields;
};
