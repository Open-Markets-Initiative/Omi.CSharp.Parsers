using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Administrative Message
/// </summary>

public partial class AdministrativeMessage
{
    /// <summary>
    ///  Message Type
    /// </summary>
    public string MessageType => Layout.MessageType.Value;

    /// <summary>
    ///  Message Identifier
    /// </summary>
    public string MessageIndicator => Layout.MessageIndicator.Value;

    /// <summary>
    ///  Reserved For Internal Use Only
    /// </summary>
    public uint TransactionId => Layout.TransactionId.Value;

    /// <summary>
    ///  The Prn Is For Optional Use By The Participant
    /// </summary>
    public uint ParticipantReferenceNumber => Layout.ParticipantReferenceNumber.Value;

    /// <summary>
    ///  Represents The Length Of The Message Data Field
    /// </summary>
    public ushort MessageDataLength => Layout.MessageDataLength.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageType MessageType;
        public MessageIndicator MessageIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public MessageDataLength MessageDataLength;
    };
};
