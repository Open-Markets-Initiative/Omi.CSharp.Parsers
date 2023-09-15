using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Lot Type Rules Group: Number of entries
    /// </summary>

    public partial class LotTypeRulesGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LotType LotType;
            MinLotSizeDecimalQty MinLotSizeDecimalQty;
        };
    };
}