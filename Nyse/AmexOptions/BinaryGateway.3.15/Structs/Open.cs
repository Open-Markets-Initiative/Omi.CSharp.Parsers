using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Open
/// </summary>

public partial class Open
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
    ///  Start sequence number
    /// </summary>
    public ulong StartSeq => Layout.StartSeq.Value;

    /// <summary>
    ///  End sequence (ignored for write request)
    /// </summary>
    public ulong EndSeq => Layout.EndSeq.Value;

    /// <summary>
    ///  Available access on the stream
    /// </summary>
    public byte Access => Layout.Access.Value;

    /// <summary>
    ///  Mode requested
    /// </summary>
    public byte Mode => Layout.Mode.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public StreamId StreamId;
        public StartSeq StartSeq;
        public EndSeq EndSeq;
        public Access Access;
        public Mode Mode;
    };
};
