using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Instrument State Change
    /// </summary>

    public partial class InstrumentStateChange
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            SecurityStatus SecurityStatus;
            SecurityTradingStatus SecurityTradingStatus;
            MarketCondition MarketCondition;
            FastMarketIndicator FastMarketIndicator;
            SecurityTradingEvent SecurityTradingEvent;
            SoldOutIndicator SoldOutIndicator;
            Pad2 Pad2;
            HighPx HighPx;
            LowPx LowPx;
            TransactTime TransactTime;
            TesSecurityStatus TesSecurityStatus;
            Pad7 Pad7;
        };
    };
}