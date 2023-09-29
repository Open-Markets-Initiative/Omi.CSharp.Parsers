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
            MarketId MarketId;
            TradeId TradeId;
            Price Price;
            Quantity Quantity;
            TransactDateTime TransactDateTime;
            ExtraFlags ExtraFlags;
            DeliveryBeginDateTime DeliveryBeginDateTime;
            DeliveryEndDateTime DeliveryEndDateTime;
            IsSystemPricedLeg IsSystemPricedLeg;
        };
    };
}