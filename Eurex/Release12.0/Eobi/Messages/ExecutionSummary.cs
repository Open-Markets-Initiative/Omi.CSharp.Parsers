using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Execution Summary
    /// </summary>

    public partial class ExecutionSummary
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SecurityId SecurityId;
            public RequestTime RequestTime;
            public ExecId ExecId;
            public LastQty LastQty;
            public AggressorSide AggressorSide;
            public Pad1 Pad1;
            public TradeCondition TradeCondition;
            public TradingHhiIndicator TradingHhiIndicator;
            public Pad3 Pad3;
            public LastPx LastPx;
            public RemainingOrderDetailsComp RemainingOrderDetailsComp;
            public RestingHiddenQty RestingHiddenQty;
            public RestingCxlQty RestingCxlQty;
            public AggressorTime AggressorTime;
        };
    };
}