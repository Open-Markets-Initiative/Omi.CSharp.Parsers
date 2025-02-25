using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Bulk Quote Acknowledgment
    /// </summary>

    public partial class BulkQuoteAcknowledgment
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public Mpid Mpid;
            public MarketMaker MarketMaker;
            public SubId SubId;
            public ClOrdId ClOrdId;
            public FlowIndicator FlowIndicator;
            public SelfTradeType SelfTradeType;
            public GroupId GroupId;
            public RepeatingGroups RepeatingGroups;
        };
    };
}