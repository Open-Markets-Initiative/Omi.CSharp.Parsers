using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  New Bulk Quote
    /// </summary>

    public partial class NewBulkQuote
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            Mpid Mpid;
            MarketMaker MarketMaker;
            SubId SubId;
            ClOrdId ClOrdId;
            SelfTradeType SelfTradeType;
            GroupId GroupId;
            MmSentTime MmSentTime;
        };
    };
}