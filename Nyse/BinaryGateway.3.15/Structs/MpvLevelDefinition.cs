using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Mpv Level Definition
    /// </summary>

    public partial class MpvLevelDefinition
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MpvLevelName MpvLevelName;
            PriceUPrice8 PriceUPrice8;
            QuotingMpv QuotingMpv;
            TradingMpv TradingMpv;
            MpvClassId MpvClassId;
        };
    };
}