using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Trade Report
    /// </summary>

    public partial class TradeReport
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            TransactTime TransactTime;
            LastQty LastQty;
            LastPx LastPx;
            TrdMatchId TrdMatchId;
            MatchType MatchType;
            MatchSubType MatchSubType;
            AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
            Pad1 Pad1;
            TradeCondition TradeCondition;
            Pad6 Pad6;
        };
    };
}