using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Instrument Definition Spread Leg Group: Number of Leg entries
/// </summary>

public partial class MDInstrumentDefinitionSpreadLegGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public LegSecurityId LegSecurityId;
        public LegSide LegSide;
        public LegRatioQty LegRatioQty;
        public LegPrice LegPrice;
        public LegOptionDelta LegOptionDelta;
    };
};
