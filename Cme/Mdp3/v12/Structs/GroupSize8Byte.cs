using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Group Size 8 Byte: 8 Byte aligned repeating group dimensions
/// </summary>

public partial class GroupSize8Byte
{
    /// <summary>
    ///  Block Length
    /// </summary>
    public ushort BlockLength => Layout.BlockLength.Value;

    /// <summary>
    ///  5 bytes padding
    /// </summary>
    public string Padding5 => Layout.Padding5.Value;

    /// <summary>
    ///  Num In Group
    /// </summary>
    public byte NumInGroup => Layout.NumInGroup.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BlockLength BlockLength;
        public Padding5 Padding5;
        public NumInGroup NumInGroup;
    };
};
