using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Product Summary
/// </summary>

public partial class ProductSummary
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
        public TradingSessionId TradingSessionId;
        public TradingSessionSubId TradingSessionSubId;
        public TradSesStatus TradSesStatus;
        public MarketCondition MarketCondition;
        public FastMarketIndicator FastMarketIndicator;
        public TesTradSesStatus TesTradSesStatus;
        public Pad6 Pad6;
    };
};
