using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Add Scaled Simple Instrument
/// </summary>

public partial class AddScaledSimpleInstrument
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public TransactTime TransactTime;
        public SecurityDesc SecurityDesc;
        public SecurityType SecurityType;
        public Pad1 Pad1;
        public QuantityScalingFactor QuantityScalingFactor;
        public Pad4 Pad4;
        public RelatedInstrumentGrpComp RelatedInstrumentGrpComp;
    };
};
