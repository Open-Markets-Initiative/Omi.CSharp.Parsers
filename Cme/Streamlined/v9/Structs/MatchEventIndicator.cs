using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Match Event Indicator: MatchEventIndicator bit set
    /// </summary>

    public partial class MatchEventIndicator
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            EndOfEvent EndOfEvent;
            Reserved Reserved;
            RecoveryMsg RecoveryMsg;
            LastImpliedMsg LastImpliedMsg;
            LastStatsMsg LastStatsMsg;
            LastQuoteMsg LastQuoteMsg;
            LastVolumeMsg LastVolumeMsg;
            LastTradeMsg LastTradeMsg;
        };
    };
}