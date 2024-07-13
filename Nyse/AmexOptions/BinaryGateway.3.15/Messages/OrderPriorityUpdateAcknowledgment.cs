using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Priority Update Acknowledgment
    /// </summary>

    public partial class OrderPriorityUpdateAcknowledgment
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
            WorkingPrice WorkingPrice;
            OrderQty OrderQty;
            WorkingAwayFromDisplay WorkingAwayFromDisplay;
            PreLiquidityIndicator PreLiquidityIndicator;
            AckType AckType;
            UserData UserData;
        };
    };
}