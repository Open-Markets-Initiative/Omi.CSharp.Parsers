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
            public LegBodyLength LegBodyLength;
            public LegMarketId LegMarketId;
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