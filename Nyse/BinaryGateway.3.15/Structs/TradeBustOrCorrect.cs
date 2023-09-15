using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Trade Bust Or Correct
    /// </summary>

    public partial class TradeBustOrCorrect
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            SymbolId SymbolId;
            Mpid Mpid;
            OrderId OrderId;
            ClOrdId ClOrdId;
            Refseqmsgid Refseqmsgid;
            DealId DealId;
            LastPx LastPx;
            LastQty LastQty;
            ReasonCode ReasonCode;
            UserData UserData;
            BustCorrectIndicator BustCorrectIndicator;
        };
    };
}