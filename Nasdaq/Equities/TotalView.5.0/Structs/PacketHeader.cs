using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Packet Header
/// </summary>

public partial class PacketHeader
{
    /// <summary>
    ///  Identity of the multicast session
    /// </summary>
    public string Session => Fields.Session.Value;

    /// <summary>
    ///  Sequence number of the first message to follow this header
    /// </summary>
    public ulong Sequence => Fields.Sequence.Value;

    /// <summary>
    ///  Number of messages to follow this header
    /// </summary>
    public ushort Count => Fields.Count.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Session Session;
        public Sequence Sequence;
        public Count Count;
    };

    protected Layout Fields;
};
