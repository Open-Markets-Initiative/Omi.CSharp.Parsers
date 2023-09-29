using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Investigated Trade Message: This message is sent when a trade is put under investigation or the investigation is completed. Client can use the market ID and order ID to find and flag the original trade if needed.
    /// </summary>

    public partial class InvestigatedTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            TradeId TradeId;
            Price Price;
            Quantity Quantity;
            FfMarketTradeIndicator FfMarketTradeIndicator;
            MessageDateTime MessageDateTime;
            InvestigationStatus InvestigationStatus;
            OffMarketTradeType OffMarketTradeType;
        };
    };
}