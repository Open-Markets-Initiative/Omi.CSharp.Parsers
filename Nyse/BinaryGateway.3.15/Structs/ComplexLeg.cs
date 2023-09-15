using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Complex Leg
    /// </summary>

    public partial class ComplexLeg
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LegSymbolId LegSymbolId;
            LegRatioQty LegRatioQty;
            LegSide LegSide;
        };
    };
}