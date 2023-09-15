using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Partial Order Execution
    /// </summary>

    public partial class PartialOrderExecution
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Side Side;
            OrdType OrdType;
            AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
            HhiIndicator HhiIndicator;
            TrdMatchId TrdMatchId;
            Price Price;
            TrdRegTsTimePriority TrdRegTsTimePriority;
            SecurityId SecurityId;
            LastQty LastQty;
            LastPx LastPx;
        };
    };
}