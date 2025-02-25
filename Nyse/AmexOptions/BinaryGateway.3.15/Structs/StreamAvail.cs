using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Stream Avail
/// </summary>

public partial class StreamAvail
{
    /// <summary>
    ///  Msg Header
    /// </summary>
    public string MsgHeader => Layout.MsgHeader.Value;

    /// <summary>
    ///  Stream Id
    /// </summary>
    public string StreamId => Layout.StreamId.Value;

    /// <summary>
    ///  Next sequence number
    /// </summary>
    public ulong NextSeq => Layout.NextSeq.Value;

    /// <summary>
    ///  Available access on the stream
    /// </summary>
    public byte Access => Layout.Access.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public StreamId StreamId;
        public NextSeq NextSeq;
        public Access Access;
    };
};
