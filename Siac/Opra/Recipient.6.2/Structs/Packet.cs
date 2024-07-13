using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Packet: Opra Udp Packet
    /// </summary>

    public partial class Packet
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BlockHeader BlockHeader;
            BlockPadByte BlockPadByte;
        };
    };
}