using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Packet
    /// </summary>

    public partial class Packet
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BinaryPacketHeader BinaryPacketHeader;
        };
    };
}