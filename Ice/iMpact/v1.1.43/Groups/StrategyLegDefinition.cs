using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Strategy Leg Definition: Strategy Leg Definition
    /// </summary>

    public partial class StrategyLegDefinition
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public LegBodyLength LegBodyLength;
            public LegMarketId LegMarketId;
            public LegUnderlyingMarketId LegUnderlyingMarketId;
            public LegRatioObsolete LegRatioObsolete;
            public LegSide LegSide;
            public LegStrategyCode LegStrategyCode;
            public LegRatioQtyNumerator LegRatioQtyNumerator;
            public LegRatioQtyDenominator LegRatioQtyDenominator;
            public LegRatioPriceNumerator LegRatioPriceNumerator;
            public LegRatioPriceDenominator LegRatioPriceDenominator;
        };
    };
}