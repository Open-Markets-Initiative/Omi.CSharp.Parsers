using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Security Status Workup: SecurityStatusWorkup
    /// </summary>

    public partial class SecurityStatusWorkup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTime TransactTime;
            public MdEntryPxOptional MdEntryPxOptional;
            public SecurityId SecurityId;
            public MatchEventIndicator MatchEventIndicator;
            public TradeDate TradeDate;
            public TradeLinkId TradeLinkId;
            public WorkupTradingStatus WorkupTradingStatus;
            public HaltReason HaltReason;
            public SecurityTradingEvent SecurityTradingEvent;
        };
    };
}