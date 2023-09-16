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
            TransactTime TransactTime;
            MdEntryPxOptional MdEntryPxOptional;
            SecurityId SecurityId;
            MatchEventIndicator MatchEventIndicator;
            TradeDate TradeDate;
            TradeLinkId TradeLinkId;
            WorkupTradingStatus WorkupTradingStatus;
            HaltReason HaltReason;
            SecurityTradingEvent SecurityTradingEvent;
        };
    };
}