using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Close
/// </summary>

public partial class Close
{
    /// <summary>
    ///  Msg Header
    /// </summary>
    public string MsgHeader => Layout.MsgHeader.Value;

    /// <summary>
    ///  Stream Id
    /// </summary>
    public string StreamId => Layout.StreamId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public StreamId StreamId;
    };
};
