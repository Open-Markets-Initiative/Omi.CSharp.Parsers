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
    public ParticipantId ParticipantId => Fields.ParticipantId.Value;

    /// <summary>
    ///  Message Identifier
    /// </summary>
    public MessageCategory MessageCategory => Fields.MessageCategory.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ParticipantId ParticipantId;
        public MessageCategory MessageCategory;
    };

    protected Layout Fields;
};
