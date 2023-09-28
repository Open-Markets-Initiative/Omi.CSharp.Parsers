using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Extra Strategy Leg Definition: Extra Strategy Leg Definition
    /// </summary>

    public partial class ExtraStrategyLegDefinition
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LegBodyLength LegBodyLength;
            LegMarketId LegMarketId;
            LegUnderlyingMarketId LegUnderlyingMarketId;
            Reserved2Bytes Reserved2Bytes;
            LegSide LegSide;
            LegStrategyCode LegStrategyCode;
            LegRatioQtyNumerator LegRatioQtyNumerator;
            LegRatioQtyDenominator LegRatioQtyDenominator;
            LegRatioPriceNumerator LegRatioPriceNumerator;
            LegRatioPriceDenominator LegRatioPriceDenominator;
        };
    };
}