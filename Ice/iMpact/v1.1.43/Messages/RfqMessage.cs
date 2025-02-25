using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Rfq Message: Request for Quote Message.
    /// </summary>

    public partial class RfqMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public MessageTimestamp MessageTimestamp;
            public RfqSystemId RfqSystemId;
            public MarketTypeId MarketTypeId;
            public UnderlyingMarketId UnderlyingMarketId;
            public Quantity Quantity;
            public Side Side;
        };
    };
}