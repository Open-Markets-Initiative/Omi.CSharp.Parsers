using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Administrative Message
    /// </summary>

    public partial class AdministrativeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageType MessageType;
            MessageIndicator MessageIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            MessageDataLength MessageDataLength;
        };
    };
}