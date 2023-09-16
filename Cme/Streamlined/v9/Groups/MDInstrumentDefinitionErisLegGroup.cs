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
            LegBenchmarkCurveName LegBenchmarkCurveName;
            RateDescriptor RateDescriptor;
            PreviousFixingDate PreviousFixingDate;
            LegPayFrequencey LegPayFrequencey;
            PreviousFixingRate PreviousFixingRate;
            LegSymbol LegSymbol;
            LegRatioQty LegRatioQty;
            LegSide LegSide;
            LegCurrency LegCurrency;
            LegSecurityType LegSecurityType;
            LegSecurityGroup LegSecurityGroup;
            LegDateOffset LegDateOffset;
            InterpolationFactor InterpolationFactor;
        };
    };
}