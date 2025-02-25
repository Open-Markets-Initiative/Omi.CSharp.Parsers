using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Add Flexible Instrument
    /// </summary>

    public partial class AddFlexibleInstrument
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SecurityId SecurityId;
            public TransactTime TransactTime;
            public SecurityDesc SecurityDesc;
            public SecurityType SecurityType;
            public PutOrCall PutOrCall;
            public ExerciseStyle ExerciseStyle;
            public SettlMethod SettlMethod;
            public MaturityDate MaturityDate;
            public StrikePrice StrikePrice;
            public OptAttribute OptAttribute;
            public Pad4 Pad4;
        };
    };
}