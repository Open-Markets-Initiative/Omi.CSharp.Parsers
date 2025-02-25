using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Control Message
/// </summary>

public partial class ControlMessage
{
    /// <summary>
    ///  Control Message Type
    /// </summary>
    public ControlMessageType ControlMessageType => Layout.ControlMessageType.Value;

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

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ControlMessageType ControlMessageType;
        public MessageIndicator MessageIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
    };
};
