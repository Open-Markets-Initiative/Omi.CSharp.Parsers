using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Group Size 8 Byte: 8 Byte aligned repeating group dimensions
    /// </summary>

    public partial class GroupSize8Byte
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BlockLength BlockLength;
            Padding5 Padding5;
            NumInGroup NumInGroup;
        };
    };
}