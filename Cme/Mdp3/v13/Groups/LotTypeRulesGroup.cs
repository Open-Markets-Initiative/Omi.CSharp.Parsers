using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Lot Type Rules Group: Number of entries
    /// </summary>

    public partial class LotTypeRulesGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public LotType LotType;
            public MinLotSizeDecimalQty MinLotSizeDecimalQty;
        };
    };
}