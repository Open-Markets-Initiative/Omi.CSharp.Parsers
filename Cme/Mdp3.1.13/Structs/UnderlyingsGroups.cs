using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Underlyings Groups: Number of underlying instruments Block
    /// </summary>

    public partial class UnderlyingsGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}