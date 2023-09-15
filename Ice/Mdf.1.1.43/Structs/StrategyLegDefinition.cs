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
            LegBodyLength LegBodyLength;
            LegMarketId LegMarketId;
            LegUnderlyingMarketId LegUnderlyingMarketId;
            LegRatioObsolete LegRatioObsolete;
            LegSide LegSide;
            LegStrategyCode LegStrategyCode;
            LegRatioQtyNumerator LegRatioQtyNumerator;
            LegRatioQtyDenominator LegRatioQtyDenominator;
            LegRatioPriceNumerator LegRatioPriceNumerator;
            LegRatioPriceDenominator LegRatioPriceDenominator;
        };
    };
}