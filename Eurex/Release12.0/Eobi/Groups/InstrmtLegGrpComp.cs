using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Instrmt Leg Grp Comp
    /// </summary>

    public partial class InstrmtLegGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public LegSymbol LegSymbol;
            public Pad4 Pad4;
            public LegSecurityId LegSecurityId;
            public LegPrice LegPrice;
            public LegRatioQty LegRatioQty;
            public LegSecurityType LegSecurityType;
            public LegSide LegSide;
            public Pad2 Pad2;
        };
    };
}