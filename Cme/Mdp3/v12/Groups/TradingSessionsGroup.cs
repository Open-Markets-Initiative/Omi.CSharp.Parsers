using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Trading Sessions Group: Number of scheduled Trading Dates
/// </summary>

public partial class TradingSessionsGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TradeDate TradeDate;
        public SettlDate SettlDate;
        public MaturityDate MaturityDate;
        public SecurityAltId SecurityAltId;
    };
};
