using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Session Configuration Request Message
    /// </summary>

    public partial class SessionConfigurationRequestMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public Username Username;
            public CancelOnDisconnect CancelOnDisconnect;
            public ThrottlePreference ThrottlePreference;
            public SelfTradePrevention SelfTradePrevention;
            public OrderPriorityUpdateAckSubscription OrderPriorityUpdateAckSubscription;
            public BoldDesignation BoldDesignation;
            public Reserved49 Reserved49;
        };
    };
}