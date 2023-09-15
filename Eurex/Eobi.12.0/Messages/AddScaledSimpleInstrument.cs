using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Add Scaled Simple Instrument
    /// </summary>

    public partial class AddScaledSimpleInstrument
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            TransactTime TransactTime;
            SecurityDesc SecurityDesc;
            SecurityType SecurityType;
            Pad1 Pad1;
            QuantityScalingFactor QuantityScalingFactor;
            Pad4 Pad4;
            RelatedInstrumentGrpComp RelatedInstrumentGrpComp;
        };
    };
}