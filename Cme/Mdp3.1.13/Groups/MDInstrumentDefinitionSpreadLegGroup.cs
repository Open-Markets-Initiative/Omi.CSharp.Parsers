using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Instrument Definition Spread Leg Group: Number of Leg entries
    /// </summary>

    public partial class MDInstrumentDefinitionSpreadLegGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LegSecurityId LegSecurityId;
            LegSide LegSide;
            LegRatioQty LegRatioQty;
            LegPrice LegPrice;
            LegOptionDelta LegOptionDelta;
        };
    };
}