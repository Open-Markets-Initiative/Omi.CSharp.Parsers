using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Sec Mass Stat Grp Comp
/// </summary>

public partial class SecMassStatGrpComp
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public HighPx HighPx;
        public LowPx LowPx;
        public SecurityStatus SecurityStatus;
        public SecurityTradingStatus SecurityTradingStatus;
        public MarketCondition MarketCondition;
        public SecurityTradingEvent SecurityTradingEvent;
        public SoldOutIndicator SoldOutIndicator;
        public TesSecurityStatus TesSecurityStatus;
        public Pad2 Pad2;
    };
};
