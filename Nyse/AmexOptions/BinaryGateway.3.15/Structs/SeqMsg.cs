using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Seq Msg
/// </summary>

public partial class SeqMsg
{
    /// <summary>
    ///  Msg Header
    /// </summary>
    public string MsgHeader => Layout.MsgHeader.Value;

    /// <summary>
    ///  Seqmsgid
    /// </summary>
    public string Seqmsgid => Layout.Seqmsgid.Value;

    /// <summary>
    ///  Bytes reserved for future use
    /// </summary>
    public string Reserved4 => Layout.Reserved4.Value;

    /// <summary>
    ///  Message timestamp
    /// </summary>
    public ulong Timestamp => Layout.Timestamp.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public Seqmsgid Seqmsgid;
        public Reserved4 Reserved4;
        public Timestamp Timestamp;
    };
};
