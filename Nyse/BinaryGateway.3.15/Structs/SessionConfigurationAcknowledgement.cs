using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Session Configuration Acknowledgement
    /// </summary>

    public partial class SessionConfigurationAcknowledgement
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            UserSessionType UserSessionType;
            UserSessionStatus UserSessionStatus;
            Username Username;
            Mic Mic;
            CancelOnDisconnect CancelOnDisconnect;
            ThrottlePreference ThrottlePreference;
            ThrottleWindow ThrottleWindow;
            ThrottleThreshold ThrottleThreshold;
            SymbolEligibility SymbolEligibility;
            MaxOrderQuantity MaxOrderQuantity;
            SelfTradePrevention SelfTradePrevention;
            OrderPriorityUpdateAckSubscription OrderPriorityUpdateAckSubscription;
            AckStatus AckStatus;
            BoldDesignation BoldDesignation;
            Reserved49 Reserved49;
        };
    };
}