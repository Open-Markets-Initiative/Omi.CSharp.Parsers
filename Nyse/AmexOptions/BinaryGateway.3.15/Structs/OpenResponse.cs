using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Open Response
/// </summary>

public partial class OpenResponse
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
    ///  Pillar Status Code
    /// </summary>
    public Status Status => Layout.Status.Value;

    /// <summary>
    ///  Available access on the stream
    /// </summary>
    public byte Access => Layout.Access.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public StreamId StreamId;
        public Status Status;
        public Access Access;
    };
};
