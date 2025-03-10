using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Instrument State Change
/// </summary>

public partial class InstrumentStateChange
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public SecurityStatus SecurityStatus;
        public SecurityTradingStatus SecurityTradingStatus;
        public MarketCondition MarketCondition;
        public FastMarketIndicator FastMarketIndicator;
        public SecurityTradingEvent SecurityTradingEvent;
        public SoldOutIndicator SoldOutIndicator;
        public Pad2 Pad2;
        public HighPx HighPx;
        public LowPx LowPx;
        public TransactTime TransactTime;
        public TesSecurityStatus TesSecurityStatus;
        public Pad7 Pad7;
    };
};
