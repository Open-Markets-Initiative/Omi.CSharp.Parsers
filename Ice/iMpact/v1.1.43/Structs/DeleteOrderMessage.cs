using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Delete Order Message
    /// </summary>

    public partial class DeleteOrderMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            OrderId OrderId;
            DateTime DateTime;
            SequenceWithinMillis SequenceWithinMillis;
            RequestTradingEngineReceivedTimestamp RequestTradingEngineReceivedTimestamp;
        };
    };
}