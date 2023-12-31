using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Inst Attrib Groups: Number of repeating InstrAttribType entries. Block
    /// </summary>

    public partial class InstAttribGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSizeEncoding GroupSizeEncoding;
        };
    };
}