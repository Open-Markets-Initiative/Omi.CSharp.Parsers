using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Message Bundle Marker: This message indicates where a bundle of messages starts or ends.
    /// </summary>

    public partial class MessageBundleMarker
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StartOrEnd StartOrEnd;
            TradeTransactionId TradeTransactionId;
            IsTransactionEnd IsTransactionEnd;
        };
    };
}