using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Bulk Cancel Request
    /// </summary>

    public partial class BulkCancelRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public MarketMaker MarketMaker;
            public ClOrdId ClOrdId;
            public MmSentTime MmSentTime;
            public SideU81 SideU81;
            public GroupId GroupId;
            public TargetCancelUsername TargetCancelUsername;
            public BulkAction BulkAction;
            public CancelScope CancelScope;
            public TargetCancelMpid TargetCancelMpid;
        };
    };
}