using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Acknowledgement
    /// </summary>

    public partial class OrderAcknowledgement
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public MarketMaker MarketMaker;
            public MpSubId MpSubId;
            public ClOrdId ClOrdId;
            public OrigClOrdId OrigClOrdId;
            public OrderInstructions OrderInstructions;
            public PricePrice8 PricePrice8;
            public OrderQty OrderQty;
            public MinQty MinQty;
            public UserData UserData;
            public TransactTime TransactTime;
            public OrderId OrderId;
            public LeavesQty LeavesQty;
            public WorkingPrice WorkingPrice;
            public WorkingAwayFromDisplay WorkingAwayFromDisplay;
            public PreLiquidityIndicator PreLiquidityIndicator;
            public ReasonCode ReasonCode;
            public AckType AckType;
            public FlowIndicator FlowIndicator;
            public LegOpenClose LegOpenClose;
            public AuctionId AuctionId;
        };
    };
}