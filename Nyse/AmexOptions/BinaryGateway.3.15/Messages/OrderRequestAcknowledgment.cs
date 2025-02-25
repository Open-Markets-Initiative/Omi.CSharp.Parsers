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
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public OrderId OrderId;
            public RefClOrdId RefClOrdId;
            public OrigClOrdId OrigClOrdId;
            public PricePrice8 PricePrice8;
            public OrderQty OrderQty;
            public LeavesQty LeavesQty;
            public SideU81 SideU81;
            public LocateReqd LocateReqd;
            public ReasonCode ReasonCode;
            public AckType AckType;
            public FlowIndicator FlowIndicator;
            public UserData UserData;
            public GroupId GroupId;
            public MarketMaker MarketMaker;
            public TargetCancelUsername TargetCancelUsername;
            public TargetCancelMpid TargetCancelMpid;
            public BulkAction BulkAction;
            public CancelScope CancelScope;
        };
    };
}