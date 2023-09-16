using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Full Order Execution
    /// </summary>

    public partial class FullOrderExecution
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