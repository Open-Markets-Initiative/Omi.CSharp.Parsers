using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Heartbeat
    /// </summary>

    public partial class Heartbeat
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgHeader MsgHeader;
        };
    };
}