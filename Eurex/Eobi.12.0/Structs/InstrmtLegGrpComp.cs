using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Instrmt Leg Grp Comp
    /// </summary>

    public partial class InstrmtLegGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LegSymbol LegSymbol;
            Pad4 Pad4;
            LegSecurityId LegSecurityId;
            LegPrice LegPrice;
            LegRatioQty LegRatioQty;
            LegSecurityType LegSecurityType;
            LegSide LegSide;
            Pad2 Pad2;
        };
    };
}