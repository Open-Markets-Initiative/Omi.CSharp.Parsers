using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Msg Header
/// </summary>

public partial class MsgHeader
{
    /// <summary>
    ///  Pillar stream message type
    /// </summary>
    public MsgType MsgType => Layout.MsgType.Value;

    /// <summary>
    ///  Total message length, including this header
    /// </summary>
    public ushort MsgLength => Layout.MsgLength.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgType MsgType;
        public MsgLength MsgLength;
    };
};
