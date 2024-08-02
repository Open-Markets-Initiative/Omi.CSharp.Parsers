using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Packet Header
    /// </summary>

    public sealed partial class PacketHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public Session Session;
            public Sequence Sequence;
            public Count Count;
        };
    };
}