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
            public SecurityId SecurityId;
            public LastUpdateTime LastUpdateTime;
            public TrdRegTsExecutionTime TrdRegTsExecutionTime;
            public TotNoOrders TotNoOrders;
            public SecurityStatus SecurityStatus;
            public SecurityTradingStatus SecurityTradingStatus;
            public MarketCondition MarketCondition;
            public FastMarketIndicator FastMarketIndicator;
            public SecurityTradingEvent SecurityTradingEvent;
            public SoldOutIndicator SoldOutIndicator;
            public HighPx HighPx;
            public LowPx LowPx;
            public ProductComplex ProductComplex;
            public NoMdEntries NoMdEntries;
            public TesSecurityStatus TesSecurityStatus;
            public Pad5 Pad5;
        };
    };
}