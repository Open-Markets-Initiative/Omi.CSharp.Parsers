using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Add Complex Instrument
    /// </summary>

    public partial class AddComplexInstrument
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            TransactTime TransactTime;
            SecurityDesc SecurityDesc;
            SecuritySubType SecuritySubType;
            ProductComplex ProductComplex;
            ImpliedMarketIndicator ImpliedMarketIndicator;
            QuantityScalingFactor QuantityScalingFactor;
            LegRatioMultiplier LegRatioMultiplier;
            NoLegs NoLegs;
            Pad2 Pad2;
            LastFragment LastFragment;
        };
    };
}