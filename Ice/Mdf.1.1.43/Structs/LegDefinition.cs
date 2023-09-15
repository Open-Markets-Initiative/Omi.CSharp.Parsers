using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Definition: Leg Definition
    /// </summary>

    public partial class LegDefinition
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LegBodyLength LegBodyLength;
            LegMarketId LegMarketId;
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