using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Request Acknowledgment
    /// </summary>

    public partial class OrderRequestAcknowledgment
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            SymbolId SymbolId;
            Mpid Mpid;
            OrderId OrderId;
            RefClOrdId RefClOrdId;
            OrigClOrdId OrigClOrdId;
            PricePrice8 PricePrice8;
            OrderQty OrderQty;
            LeavesQty LeavesQty;
            SideU81 SideU81;
            LocateReqd LocateReqd;
            ReasonCode ReasonCode;
            AckType AckType;
            FlowIndicator FlowIndicator;
            UserData UserData;
            GroupId GroupId;
            MarketMaker MarketMaker;
            TargetCancelUsername TargetCancelUsername;
            TargetCancelMpid TargetCancelMpid;
            BulkAction BulkAction;
            CancelScope CancelScope;
        };
    };
}