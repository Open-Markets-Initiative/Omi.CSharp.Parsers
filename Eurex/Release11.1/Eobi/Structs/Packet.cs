using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Packet
    /// </summary>

    public partial class Packet
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            PacketHeader PacketHeader;
        };
    };
}