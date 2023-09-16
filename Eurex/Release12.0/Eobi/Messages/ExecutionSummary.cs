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
            SecurityId SecurityId;
            RequestTime RequestTime;
            ExecId ExecId;
            LastQty LastQty;
            AggressorSide AggressorSide;
            Pad1 Pad1;
            TradeCondition TradeCondition;
            TradingHhiIndicator TradingHhiIndicator;
            Pad3 Pad3;
            LastPx LastPx;
            RemainingOrderDetailsComp RemainingOrderDetailsComp;
            RestingHiddenQty RestingHiddenQty;
            RestingCxlQty RestingCxlQty;
            AggressorTime AggressorTime;
        };
    };
}