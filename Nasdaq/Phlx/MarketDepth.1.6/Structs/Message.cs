using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Message
/// </summary>

public partial class Message
{
    /// <summary>
    ///  Message Header
    /// </summary>
    public string MessageHeader => Layout.MessageHeader.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageHeader MessageHeader;
    };
};
