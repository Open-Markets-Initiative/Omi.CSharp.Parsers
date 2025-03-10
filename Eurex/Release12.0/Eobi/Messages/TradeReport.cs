using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Trade Report
/// </summary>

public partial class TradeReport
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public TransactTime TransactTime;
        public LastQty LastQty;
        public LastPx LastPx;
        public TrdMatchId TrdMatchId;
        public MatchType MatchType;
        public MatchSubType MatchSubType;
        public AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
        public Pad1 Pad1;
        public TradeCondition TradeCondition;
        public Pad6 Pad6;
    };
};
