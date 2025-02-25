using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Seq Msg Header
/// </summary>

public partial class SeqMsgHeader
{
    /// <summary>
    ///  Code identifying this message type
    /// </summary>
    public SeqMsgType SeqMsgType => Layout.SeqMsgType.Value;

    /// <summary>
    ///  Length of sequenced data message including this field
    /// </summary>
    public ushort SeqMsgLength => Layout.SeqMsgLength.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SeqMsgType SeqMsgType;
        public SeqMsgLength SeqMsgLength;
    };
};
