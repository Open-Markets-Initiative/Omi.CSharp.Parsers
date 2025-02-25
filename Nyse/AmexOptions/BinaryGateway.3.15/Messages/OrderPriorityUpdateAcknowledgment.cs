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
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public OrderId OrderId;
            public ClOrdId ClOrdId;
            public WorkingPrice WorkingPrice;
            public OrderQty OrderQty;
            public WorkingAwayFromDisplay WorkingAwayFromDisplay;
            public PreLiquidityIndicator PreLiquidityIndicator;
            public AckType AckType;
            public UserData UserData;
        };
    };
}