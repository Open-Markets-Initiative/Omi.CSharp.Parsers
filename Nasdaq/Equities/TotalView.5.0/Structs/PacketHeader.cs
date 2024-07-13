using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Packet Header
    /// </summary>

    public partial class PacketHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Session Session;
            Sequence Sequence;
            Count Count;
        };
    };
}