using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Instrument Definition Eris Leg Group: Number of legs (repeating groups)
    /// </summary>

    public partial class MDInstrumentDefinitionErisLegGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public LegBenchmarkCurveName LegBenchmarkCurveName;
            public RateDescriptor RateDescriptor;
            public PreviousFixingDate PreviousFixingDate;
            public LegPayFrequencey LegPayFrequencey;
            public PreviousFixingRate PreviousFixingRate;
            public LegSymbol LegSymbol;
            public LegRatioQty LegRatioQty;
            public LegSide LegSide;
            public LegCurrency LegCurrency;
            public LegSecurityType LegSecurityType;
            public LegSecurityGroup LegSecurityGroup;
            public LegDateOffset LegDateOffset;
            public InterpolationFactor InterpolationFactor;
        };
    };
}