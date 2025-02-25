using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Message
/// </summary>

public partial class Message
{
    /// <summary>
    ///  Ascii Character That Identifies The Participant Or Processor That Initiated The Message
    /// </summary>
    public ParticipantId ParticipantId => Layout.ParticipantId.Value;

    /// <summary>
    ///  Message Identifier
    /// </summary>
    public MessageCategory MessageCategory => Layout.MessageCategory.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ParticipantId ParticipantId;
        public MessageCategory MessageCategory;
    };
};
