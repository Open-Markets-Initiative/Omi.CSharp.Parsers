using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Trading Sessions Group: Number of scheduled Trading Dates
    /// </summary>

    public partial class TradingSessionsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TradeDate TradeDate;
            SettlDate SettlDate;
            MaturityDate MaturityDate;
            SecurityAltId SecurityAltId;
        };
    };
}