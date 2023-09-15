using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Bulk Cancel Request
    /// </summary>

    public partial class BulkCancelRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            SymbolId SymbolId;
            Mpid Mpid;
            MarketMaker MarketMaker;
            ClOrdId ClOrdId;
            MmSentTime MmSentTime;
            SideU81 SideU81;
            GroupId GroupId;
            TargetCancelUsername TargetCancelUsername;
            BulkAction BulkAction;
            CancelScope CancelScope;
            TargetCancelMpid TargetCancelMpid;
        };
    };
}