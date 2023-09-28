using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Extra Leg Definition: Extra Leg Definition
    /// </summary>

    public partial class ExtraLegDefinition
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LegBodyLength LegBodyLength;
            LegMarketId LegMarketId;
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