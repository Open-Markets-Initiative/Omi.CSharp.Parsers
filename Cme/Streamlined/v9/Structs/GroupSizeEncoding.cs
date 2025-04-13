using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Group Size Encoding: Repeating group dimensions
/// </summary>

public partial class GroupSizeEncoding
{
    /// <summary>
    ///  Block Length
    /// </summary>
    public ushort BlockLength => Fields.BlockLength.Value;

    /// <summary>
    ///  Num In Group 16
    /// </summary>
    public ushort NumInGroup16 => Fields.NumInGroup16.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BlockLength BlockLength;
        public NumInGroup16 NumInGroup16;
    };

    protected Layout Fields;
};
