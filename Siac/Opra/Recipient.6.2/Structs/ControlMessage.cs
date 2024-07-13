using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Control Message
    /// </summary>

    public partial class ControlMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            ControlMessageType ControlMessageType;
            MessageIndicator MessageIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
        };
    };
}