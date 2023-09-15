using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Product State Change
    /// </summary>

    public partial class ProductStateChange
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TradingSessionId TradingSessionId;
            TradingSessionSubId TradingSessionSubId;
            TradSesStatus TradSesStatus;
            MarketCondition MarketCondition;
            FastMarketIndicator FastMarketIndicator;
            TesTradSesStatus TesTradSesStatus;
            Pad2 Pad2;
            TransactTime TransactTime;
        };
    };
}