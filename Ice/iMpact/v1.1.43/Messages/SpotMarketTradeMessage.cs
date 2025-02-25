using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Spot Market Trade Message: This message will be sent only upon trade in spot markets and it will be rendered on spot market channels.
    /// </summary>

    public partial class SpotMarketTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public TradeId TradeId;
            public Price Price;
            public Quantity Quantity;
            public TransactDateTime TransactDateTime;
            public ExtraFlags ExtraFlags;
            public DeliveryBeginDateTime DeliveryBeginDateTime;
            public DeliveryEndDateTime DeliveryEndDateTime;
            public IsSystemPricedLeg IsSystemPricedLeg;
        };
    };
}