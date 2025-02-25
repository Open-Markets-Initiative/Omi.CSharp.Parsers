using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Product State Change
    /// </summary>

    public partial class ProductStateChange
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TradingSessionId TradingSessionId;
            public TradingSessionSubId TradingSessionSubId;
            public TradSesStatus TradSesStatus;
            public MarketCondition MarketCondition;
            public FastMarketIndicator FastMarketIndicator;
            public TesTradSesStatus TesTradSesStatus;
            public Pad2 Pad2;
            public TransactTime TransactTime;
        };
    };
}