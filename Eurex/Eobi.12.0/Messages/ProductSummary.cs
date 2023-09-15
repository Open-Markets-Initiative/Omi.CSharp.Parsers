using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Product Summary
    /// </summary>

    public partial class ProductSummary
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
            TradingSessionId TradingSessionId;
            TradingSessionSubId TradingSessionSubId;
            TradSesStatus TradSesStatus;
            MarketCondition MarketCondition;
            FastMarketIndicator FastMarketIndicator;
            TesTradSesStatus TesTradSesStatus;
            Pad6 Pad6;
        };
    };
}