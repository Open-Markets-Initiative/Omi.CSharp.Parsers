using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Inst Attrib Groups: Number of repeating InstrAttribType entries Block
    /// </summary>

    public partial class InstAttribGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}