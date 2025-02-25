using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Packet Header
/// </summary>

public partial class PacketHeader
{
    /// <summary>
    ///  TODO
    /// </summary>
    public ushort Session => Layout.Session.Value;

    /// <summary>
    ///  TODO
    /// </summary>
    public uint Sequence => Layout.Sequence.Value;

    /// <summary>
    ///  Field indicates the number of messages contained in the block.
    /// </summary>
    public ushort Count => Layout.Count.Value;

    /// <summary>
    ///  Timestamp of last update used to derive the price level message. The format is nanoseconds since
    /// </summary>
    public long Timestamp => Layout.Timestamp.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Session Session;
        public Sequence Sequence;
        public Count Count;
        public Timestamp Timestamp;
    };
};
