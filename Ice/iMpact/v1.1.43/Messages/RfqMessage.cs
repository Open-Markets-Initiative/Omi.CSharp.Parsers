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
            MarketId MarketId;
            MessageTimestamp MessageTimestamp;
            RfqSystemId RfqSystemId;
            MarketTypeId MarketTypeId;
            UnderlyingMarketId UnderlyingMarketId;
            Quantity Quantity;
            Side Side;
        };
    };
}