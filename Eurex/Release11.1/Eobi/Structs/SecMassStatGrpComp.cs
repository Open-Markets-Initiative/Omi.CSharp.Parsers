using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Sec Mass Stat Grp Comp
    /// </summary>

    public partial class SecMassStatGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            HighPx HighPx;
            LowPx LowPx;
            SecurityStatus SecurityStatus;
            SecurityTradingStatus SecurityTradingStatus;
            MarketCondition MarketCondition;
            SecurityTradingEvent SecurityTradingEvent;
            SoldOutIndicator SoldOutIndicator;
            TesSecurityStatus TesSecurityStatus;
            Pad2 Pad2;
        };
    };
}