using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Packet Info
/// </summary>

public partial class PacketInfo
{
    /// <summary>
    ///  Packet header Length in Bytes
    /// </summary>
    public ushort HeaderLength => Layout.HeaderLength.Value;

    /// <summary>
    ///  Packet Identifier
    /// </summary>
    public ushort PacketId => Layout.PacketId.Value;

    /// <summary>
    ///  Packet Sequence Number
    /// </summary>
    public uint PacketSequenceNumber => Layout.PacketSequenceNumber.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public HeaderLength HeaderLength;
        public PacketId PacketId;
        public PacketSequenceNumber PacketSequenceNumber;
    };
};
