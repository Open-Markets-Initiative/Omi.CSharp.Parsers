using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Message
/// </summary>

public partial class Message
{
    /// <summary>
    ///  Message Size
    /// </summary>
    public ushort MessageSize => Layout.MessageSize.Value;

    /// <summary>
    ///  Template ID and length of message root
    /// </summary>
    public string MessageHeader => Layout.MessageHeader.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageSize MessageSize;
        public MessageHeader MessageHeader;
    };
};
