using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Message Header
/// </summary>

public partial class MessageHeader
{
    /// <summary>
    ///  Length of the message
    /// </summary>
    public ushort MessageLength => Layout.MessageLength.Value;

    /// <summary>
    ///  Code identifying this message type
    /// </summary>
    public MessageType MessageType => Layout.MessageType.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageLength MessageLength;
        public MessageType MessageType;
    };
};
