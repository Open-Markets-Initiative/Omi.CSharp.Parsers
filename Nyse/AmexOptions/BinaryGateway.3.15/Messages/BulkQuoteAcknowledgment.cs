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
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            Mpid Mpid;
            MarketMaker MarketMaker;
            SubId SubId;
            ClOrdId ClOrdId;
            FlowIndicator FlowIndicator;
            SelfTradeType SelfTradeType;
            GroupId GroupId;
            RepeatingGroups RepeatingGroups;
        };
    };
}