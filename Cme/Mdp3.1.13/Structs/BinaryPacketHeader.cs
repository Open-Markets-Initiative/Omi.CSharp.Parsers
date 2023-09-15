using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Binary Packet Header
    /// </summary>

    public partial class BinaryPacketHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageSequenceNumber MessageSequenceNumber;
            SendingTime SendingTime;
        };
    };
}