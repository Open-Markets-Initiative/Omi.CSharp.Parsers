using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Execution Report
    /// </summary>

    public partial class ExecutionReport
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
            public DealId DealId;
            public LastPx LastPx;
            public LeavesQty LeavesQty;
            public CumQty CumQty;
            public LastQty LastQty;
            public LiquidityIndicator LiquidityIndicator;
            public MultilegReportingType MultilegReportingType;
            public Reserved1 Reserved1;
            public Reserved2 Reserved2;
            public LocateReqd LocateReqd;
            public ParticipantType ParticipantType;
            public ReasonCode ReasonCode;
            public UserData UserData;
            public SideU81 SideU81;
            public MarketMaker MarketMaker;
            public ContraMarketMaker ContraMarketMaker;
            public ContraClearingFirm ContraClearingFirm;
            public ContraMpid ContraMpid;
            public ContraOpenClose ContraOpenClose;
            public ContraCustomerOrFirm ContraCustomerOrFirm;
            public ContraClearingAccount ContraClearingAccount;
            public ContraCrossType ContraCrossType;
            public ContraCoveredOrUncovered ContraCoveredOrUncovered;
            public CoveredOrUncovered CoveredOrUncovered;
            public CrossId CrossId;
            public OpenClose OpenClose;
        };
    };
}