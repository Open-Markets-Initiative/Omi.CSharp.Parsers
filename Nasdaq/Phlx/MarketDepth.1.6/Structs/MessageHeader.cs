using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Message Header
/// </summary>

public partial class MessageHeader
{
    /// <summary>
    ///  Length of data message not including this field
    /// </summary>
    public ushort Length => Layout.Length.Value;

    /// <summary>
    ///  Code identifying this message type
    /// </summary>
    public MessageType MessageType => Layout.MessageType.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Length Length;
        public MessageType MessageType;
    };
};
