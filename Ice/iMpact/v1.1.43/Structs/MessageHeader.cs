using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Message Header
/// </summary>

public partial class MessageHeader
{
    /// <summary>
    ///  Code identifying this message type
    /// </summary>
    public MessageType MessageType => Fields.MessageType.Value;

    /// <summary>
    ///  Length of message
    /// </summary>
    public ushort Length => Fields.Length.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageType MessageType;
        public Length Length;
    };

    protected Layout Fields;
};
