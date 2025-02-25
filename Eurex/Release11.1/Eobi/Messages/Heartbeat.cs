using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Heartbeat
    /// </summary>

    public partial class Heartbeat
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
            public Pad4 Pad4;
        };
    };
}