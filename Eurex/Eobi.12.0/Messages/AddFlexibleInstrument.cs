using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Add Flexible Instrument
    /// </summary>

    public partial class AddFlexibleInstrument
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            TransactTime TransactTime;
            SecurityDesc SecurityDesc;
            SecurityType SecurityType;
            PutOrCall PutOrCall;
            ExerciseStyle ExerciseStyle;
            SettlMethod SettlMethod;
            MaturityDate MaturityDate;
            StrikePrice StrikePrice;
            OptAttribute OptAttribute;
            Pad4 Pad4;
        };
    };
}