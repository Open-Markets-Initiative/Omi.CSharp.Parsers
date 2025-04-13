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
    public char MessageType => Fields.MessageType.Value;

    /// <summary>
    ///  Message Identifier
    /// </summary>
    public char MessageIndicator => Fields.MessageIndicator.Value;

    /// <summary>
    ///  Reserved For Internal Use Only
    /// </summary>
    public uint TransactionId => Fields.TransactionId.Value;

    /// <summary>
    ///  The Prn Is For Optional Use By The Participant
    /// </summary>
    public uint ParticipantReferenceNumber => Fields.ParticipantReferenceNumber.Value;

    /// <summary>
    ///  Represents The Length Of The Message Data Field
    /// </summary>
    public ushort MessageDataLength => Fields.MessageDataLength.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageType MessageType;
        public MessageIndicator MessageIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public MessageDataLength MessageDataLength;
    };

    protected Layout Fields;
};
