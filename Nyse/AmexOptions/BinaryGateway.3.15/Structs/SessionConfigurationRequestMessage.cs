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
            SeqMsgHeader SeqMsgHeader;
            Username Username;
            CancelOnDisconnect CancelOnDisconnect;
            ThrottlePreference ThrottlePreference;
            SelfTradePrevention SelfTradePrevention;
            OrderPriorityUpdateAckSubscription OrderPriorityUpdateAckSubscription;
            BoldDesignation BoldDesignation;
            Reserved49 Reserved49;
        };
    };
}