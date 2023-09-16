using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  System Event Message: The system event message type is used to signal a market or data feed handler event.
    /// </summary>

    public partial class SystemEventMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            EventCode EventCode;
        };
    };
}