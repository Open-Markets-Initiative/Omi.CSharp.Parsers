using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Heartbeat
/// </summary>

public partial class Heartbeat
{
    /// <summary>
    ///  Msg Header
    /// </summary>
    public string MsgHeader => Layout.MsgHeader.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
    };
};
