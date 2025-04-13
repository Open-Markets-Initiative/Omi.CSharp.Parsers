using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Packet: Opra Udp Packet
/// </summary>

public partial class Packet
{
    /// <summary>
    ///  Block Header
    /// </summary>
    public string BlockHeader => Fields.BlockHeader.Value;

    /// <summary>
    ///  Block Pad Byte
    /// </summary>
    public byte BlockPadByte => Fields.BlockPadByte.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BlockHeader BlockHeader;
        public BlockPadByte BlockPadByte;
    };

    protected Layout Fields;
};
