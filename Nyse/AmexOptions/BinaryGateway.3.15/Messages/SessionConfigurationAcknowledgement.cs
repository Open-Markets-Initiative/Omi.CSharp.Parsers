using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Session Configuration Acknowledgement
    /// </summary>

    public partial class SessionConfigurationAcknowledgement
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public UserSessionType UserSessionType;
            public UserSessionStatus UserSessionStatus;
            public Username Username;
            public Mic Mic;
            public CancelOnDisconnect CancelOnDisconnect;
            public ThrottlePreference ThrottlePreference;
            public ThrottleWindow ThrottleWindow;
            public ThrottleThreshold ThrottleThreshold;
            public SymbolEligibility SymbolEligibility;
            public MaxOrderQuantity MaxOrderQuantity;
            public SelfTradePrevention SelfTradePrevention;
            public OrderPriorityUpdateAckSubscription OrderPriorityUpdateAckSubscription;
            public AckStatus AckStatus;
            public BoldDesignation BoldDesignation;
            public Reserved49 Reserved49;
        };
    };
}