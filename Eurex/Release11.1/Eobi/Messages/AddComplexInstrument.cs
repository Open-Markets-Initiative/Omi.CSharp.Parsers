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
            public SecurityId SecurityId;
            public TransactTime TransactTime;
            public SecurityDesc SecurityDesc;
            public SecuritySubType SecuritySubType;
            public ProductComplex ProductComplex;
            public ImpliedMarketIndicator ImpliedMarketIndicator;
            public LastFragment LastFragment;
            public Pad1 Pad1;
            public LegRatioMultiplier LegRatioMultiplier;
            public NoLegs NoLegs;
            public Pad3 Pad3;
        };
    };
}