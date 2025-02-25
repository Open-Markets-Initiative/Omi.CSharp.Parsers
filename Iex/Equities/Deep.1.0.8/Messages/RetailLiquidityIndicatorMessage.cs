using System.Runtime.InteropServices;

namespace Iex.Deep
{
    /// <summary>
    ///  Retail Liquidity Indicator Message: broadcasts a real-time Retail Liquidity Indicator Message each time there is an update to IEX's eligible retail liquidity interest during the trading day
    /// </summary>

    public partial class RetailLiquidityIndicatorMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public RetailLiquidityIndicator RetailLiquidityIndicator;
            public Timestamp Timestamp;
            public Symbol Symbol;
        };
    };
}