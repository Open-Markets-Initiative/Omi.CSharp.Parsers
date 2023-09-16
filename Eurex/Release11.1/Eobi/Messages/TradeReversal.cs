using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trade Reversal
    /// </summary>

    public partial class TradeReversal
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            TransactTime TransactTime;
            LastQty LastQty;
            LastPx LastPx;
            TrdRegTsExecutionTime TrdRegTsExecutionTime;
            TrdMatchId TrdMatchId;
            TradeCondition TradeCondition;
            MdOriginType MdOriginType;
            NoMdEntries NoMdEntries;
        };
    };
}