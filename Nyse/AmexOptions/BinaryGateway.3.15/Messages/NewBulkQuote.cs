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
            public SeqMsgHeader SeqMsgHeader;
            public Mpid Mpid;
            public MarketMaker MarketMaker;
            public SubId SubId;
            public ClOrdId ClOrdId;
            public SelfTradeType SelfTradeType;
            public GroupId GroupId;
            public MmSentTime MmSentTime;
        };
    };
}