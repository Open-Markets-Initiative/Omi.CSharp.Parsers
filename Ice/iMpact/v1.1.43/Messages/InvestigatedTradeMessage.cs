using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Investigated Trade Message
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