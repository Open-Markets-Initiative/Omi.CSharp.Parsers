using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Instrument Summary
    /// </summary>

    public partial class InstrumentSummary
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            LastUpdateTime LastUpdateTime;
            TrdRegTsExecutionTime TrdRegTsExecutionTime;
            TotNoOrders TotNoOrders;
            SecurityStatus SecurityStatus;
            SecurityTradingStatus SecurityTradingStatus;
            MarketCondition MarketCondition;
            FastMarketIndicator FastMarketIndicator;
            SecurityTradingEvent SecurityTradingEvent;
            SoldOutIndicator SoldOutIndicator;
            HighPx HighPx;
            LowPx LowPx;
            ProductComplex ProductComplex;
            NoMdEntries NoMdEntries;
            TesSecurityStatus TesSecurityStatus;
            Pad5 Pad5;
        };
    };
}