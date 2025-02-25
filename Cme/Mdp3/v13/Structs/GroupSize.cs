using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Group Size: Repeating group dimensions
/// </summary>

public partial class GroupSize
{
    /// <summary>
    ///  Block Length
    /// </summary>
    public ushort BlockLength => Layout.BlockLength.Value;

    /// <summary>
    ///  Num In Group
    /// </summary>
    public byte NumInGroup => Layout.NumInGroup.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BlockLength BlockLength;
        public NumInGroup NumInGroup;
    };
};
