using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Group Size: Repeating group dimensions
    /// </summary>

    public partial class GroupSize
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BlockLength BlockLength;
            NumInGroup NumInGroup;
        };
    };
}