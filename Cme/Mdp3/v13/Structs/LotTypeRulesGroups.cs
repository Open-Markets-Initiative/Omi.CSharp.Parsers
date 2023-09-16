using System.Runtime.InteropServices;

namespace Cme.Mdp3
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