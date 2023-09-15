using System.Runtime.InteropServices;

namespace Eurex.T7
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
            LastFragment LastFragment;
            Pad1 Pad1;
            LegRatioMultiplier LegRatioMultiplier;
            NoLegs NoLegs;
            Pad3 Pad3;
        };
    };
}