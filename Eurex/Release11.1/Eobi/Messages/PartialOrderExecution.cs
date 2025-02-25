using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Partial Order Execution
    /// </summary>

    public partial class PartialOrderExecution
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public Side Side;
            public OrdType OrdType;
            public AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
            public HhiIndicator HhiIndicator;
            public TrdMatchId TrdMatchId;
            public Price Price;
            public TrdRegTsTimePriority TrdRegTsTimePriority;
            public SecurityId SecurityId;
            public LastQty LastQty;
            public LastPx LastPx;
        };
    };
}