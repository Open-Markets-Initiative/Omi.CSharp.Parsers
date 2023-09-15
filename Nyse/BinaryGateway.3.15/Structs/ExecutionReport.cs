using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Execution Report
    /// </summary>

    public partial class ExecutionReport
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            SymbolId SymbolId;
            Mpid Mpid;
            OrderId OrderId;
            ClOrdId ClOrdId;
            DealId DealId;
            LastPx LastPx;
            LeavesQty LeavesQty;
            CumQty CumQty;
            LastQty LastQty;
            LiquidityIndicator LiquidityIndicator;
            MultilegReportingType MultilegReportingType;
            Reserved1 Reserved1;
            Reserved2 Reserved2;
            LocateReqd LocateReqd;
            ParticipantType ParticipantType;
            ReasonCode ReasonCode;
            UserData UserData;
            SideU81 SideU81;
            MarketMaker MarketMaker;
            ContraMarketMaker ContraMarketMaker;
            ContraClearingFirm ContraClearingFirm;
            ContraMpid ContraMpid;
            ContraOpenClose ContraOpenClose;
            ContraCustomerOrFirm ContraCustomerOrFirm;
            ContraClearingAccount ContraClearingAccount;
            ContraCrossType ContraCrossType;
            ContraCoveredOrUncovered ContraCoveredOrUncovered;
            CoveredOrUncovered CoveredOrUncovered;
            CrossId CrossId;
            OpenClose OpenClose;
        };
    };
}