using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Add Complex Instrument
/// </summary>

public partial class AddComplexInstrument
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public TransactTime TransactTime;
        public SecurityDesc SecurityDesc;
        public SecuritySubType SecuritySubType;
        public ProductComplex ProductComplex;
        public ImpliedMarketIndicator ImpliedMarketIndicator;
        public QuantityScalingFactor QuantityScalingFactor;
        public LegRatioMultiplier LegRatioMultiplier;
        public NoLegs NoLegs;
        public Pad2 Pad2;
        public LastFragment LastFragment;
    };
};
