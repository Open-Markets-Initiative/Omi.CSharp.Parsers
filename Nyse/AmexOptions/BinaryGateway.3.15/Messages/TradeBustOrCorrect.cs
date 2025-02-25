using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Trade Bust Or Correct
    /// </summary>

    public partial class TradeBustOrCorrect
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public OrderId OrderId;
            public ClOrdId ClOrdId;
            public Refseqmsgid Refseqmsgid;
            public DealId DealId;
            public LastPx LastPx;
            public LastQty LastQty;
            public ReasonCode ReasonCode;
            public UserData UserData;
            public BustCorrectIndicator BustCorrectIndicator;
        };
    };
}