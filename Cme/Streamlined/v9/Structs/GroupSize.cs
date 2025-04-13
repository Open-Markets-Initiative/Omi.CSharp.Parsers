using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Group Size: Repeating group dimensions
/// </summary>

public partial class GroupSize
{
    /// <summary>
    ///  Block Length
    /// </summary>
    public ushort BlockLength => Fields.BlockLength.Value;

    /// <summary>
    ///  Num In Group uint 8
    /// </summary>
    public byte NumInGroupUint8 => Fields.NumInGroupUint8.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BlockLength BlockLength;
        public NumInGroupUint8 NumInGroupUint8;
    };

    protected Layout Fields;
};
