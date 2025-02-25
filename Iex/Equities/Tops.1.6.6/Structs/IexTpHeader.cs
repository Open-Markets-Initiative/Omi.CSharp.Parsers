using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Iex Tp Header
/// </summary>

public partial class IexTpHeader
{
    /// <summary>
    ///  Version of Transport specification
    /// </summary>
    public byte Version => Layout.Version.Value;

    /// <summary>
    ///  Reserved byte
    /// </summary>
    public string Reserved => Layout.Reserved.Value;

    /// <summary>
    ///  Unique identifier of the higher-layer protocol
    /// </summary>
    public ushort MessageProtocolId => Layout.MessageProtocolId.Value;

    /// <summary>
    ///  Identifies the stream of bytes sequenced messages
    /// </summary>
    public uint ChannelId => Layout.ChannelId.Value;

    /// <summary>
    ///  Identifies the session
    /// </summary>
    public uint SessionId => Layout.SessionId.Value;

    /// <summary>
    ///  Byte length of the payload
    /// </summary>
    public ushort PayloadLength => Layout.PayloadLength.Value;

    /// <summary>
    ///  Number of messages in the payload
    /// </summary>
    public ushort MessageCount => Layout.MessageCount.Value;

    /// <summary>
    ///  Byte offset of the data stream
    /// </summary>
    public ulong StreamOffset => Layout.StreamOffset.Value;

    /// <summary>
    ///  Sequence of the first message in the segment
    /// </summary>
    public ulong FirstMessageSequenceNumber => Layout.FirstMessageSequenceNumber.Value;

    /// <summary>
    ///  Send time of segment
    /// </summary>
    public ulong SendTime => Layout.SendTime.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Version Version;
        public Reserved Reserved;
        public MessageProtocolId MessageProtocolId;
        public ChannelId ChannelId;
        public SessionId SessionId;
        public PayloadLength PayloadLength;
        public MessageCount MessageCount;
        public StreamOffset StreamOffset;
        public FirstMessageSequenceNumber FirstMessageSequenceNumber;
        public SendTime SendTime;
    };
};
