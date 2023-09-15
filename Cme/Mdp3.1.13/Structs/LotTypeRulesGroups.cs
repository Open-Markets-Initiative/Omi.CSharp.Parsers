using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Lot Type Rules Groups: Number of entries Block
    /// </summary>

    public partial class LotTypeRulesGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}