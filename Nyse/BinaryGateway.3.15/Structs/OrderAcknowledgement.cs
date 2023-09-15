using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Order Acknowledgement
    /// </summary>

    public partial class OrderAcknowledgement
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            SymbolId SymbolId;
            Mpid Mpid;
            MarketMaker MarketMaker;
            MpSubId MpSubId;
            ClOrdId ClOrdId;
            OrigClOrdId OrigClOrdId;
            OrderInstructions OrderInstructions;
            PricePrice8 PricePrice8;
            OrderQty OrderQty;
            MinQty MinQty;
            UserData UserData;
            TransactTime TransactTime;
            OrderId OrderId;
            LeavesQty LeavesQty;
            WorkingPrice WorkingPrice;
            WorkingAwayFromDisplay WorkingAwayFromDisplay;
            PreLiquidityIndicator PreLiquidityIndicator;
            ReasonCode ReasonCode;
            AckType AckType;
            FlowIndicator FlowIndicator;
            LegOpenClose LegOpenClose;
            AuctionId AuctionId;
        };
    };
}