using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Packet Info
    /// </summary>

    public partial class PacketInfo
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            HeaderLength HeaderLength;
            PacketId PacketId;
            PacketSequenceNumber PacketSequenceNumber;
        };
    };
}