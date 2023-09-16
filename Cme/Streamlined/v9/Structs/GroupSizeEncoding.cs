using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Group Size Encoding: Repeating group dimensions
    /// </summary>

    public partial class GroupSizeEncoding
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BlockLength BlockLength;
            NumInGroup16 NumInGroup16;
        };
    };
}