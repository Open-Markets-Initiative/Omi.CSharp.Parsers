using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Trade Reversal
/// </summary>

public partial class TradeReversal
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public TransactTime TransactTime;
        public LastQty LastQty;
        public LastPx LastPx;
        public TrdRegTsExecutionTime TrdRegTsExecutionTime;
        public TrdMatchId TrdMatchId;
        public TradeCondition TradeCondition;
        public MdOriginType MdOriginType;
        public NoMdEntries NoMdEntries;
    };
};
