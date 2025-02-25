using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Security Status: SecurityStatus
    /// </summary>

    public partial class SecurityStatus
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTime TransactTime;
            public SecurityGroup SecurityGroup;
            public Asset Asset;
            public SecurityIdOptional SecurityIdOptional;
            public TradeDate TradeDate;
            public MatchEventIndicator MatchEventIndicator;
            public SecurityTradingStatus SecurityTradingStatus;
            public HaltReason HaltReason;
            public SecurityTradingEvent SecurityTradingEvent;
        };
    };
}