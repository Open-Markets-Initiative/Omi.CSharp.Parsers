using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Full Order Execution
/// </summary>

public partial class FullOrderExecution
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
