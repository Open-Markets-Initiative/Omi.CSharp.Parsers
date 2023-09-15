using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Heartbeat
    /// </summary>

    public partial class Heartbeat
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
            Pad4 Pad4;
        };
    };
}