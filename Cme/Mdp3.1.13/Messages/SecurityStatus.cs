using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Security Status: SecurityStatus
    /// </summary>

    public partial class SecurityStatus
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            SecurityGroup SecurityGroup;
            Asset Asset;
            SecurityIdOptional SecurityIdOptional;
            TradeDate TradeDate;
            MatchEventIndicator MatchEventIndicator;
            SecurityTradingStatus SecurityTradingStatus;
            HaltReason HaltReason;
            SecurityTradingEvent SecurityTradingEvent;
        };
    };
}