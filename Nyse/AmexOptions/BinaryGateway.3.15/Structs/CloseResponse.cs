using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Close Response
/// </summary>

public partial class CloseResponse
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

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public StreamId StreamId;
        public Status Status;
    };
};
