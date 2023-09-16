using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Instructions
    /// </summary>

    public partial class OrderInstructions
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            ReservedBits34 ReservedBits34;
            SecurityType SecurityType;
            Capacity Capacity;
            OpenClose OpenClose;
            SubIdIndicator SubIdIndicator;
            SpecialOrdType SpecialOrdType;
            LocateReqd LocateReqd;
            RetailIndicator RetailIndicator;
            AttributedQuote AttributedQuote;
            OrderCapacity OrderCapacity;
            InterestType InterestType;
            TradingSessionId TradingSessionId;
            TimeInForce TimeInForce;
            ProactiveIfLocked ProactiveIfLocked;
            SelfTradeType SelfTradeType;
            CancelInsteadOfReprice CancelInsteadOfReprice;
            RoutingInst RoutingInst;
            ExtendedExecInst ExtendedExecInst;
            ExecInst ExecInst;
            OrdType OrdType;
            SideBit5 SideBit5;
        };
    };
}