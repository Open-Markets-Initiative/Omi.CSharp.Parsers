using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Definition: Hedge Definition
    /// </summary>

    public partial class HedgeDefinition
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            HedgeBodyLength HedgeBodyLength;
            HedgeMarketId HedgeMarketId;
            HedgeSecurityType HedgeSecurityType;
            HedgeSide HedgeSide;
            HedgePrice HedgePrice;
            HedgePriceDenominator HedgePriceDenominator;
            HedgeDeltaObsolete HedgeDeltaObsolete;
            HedgeStrategyCode HedgeStrategyCode;
            HedgeDelta HedgeDelta;
        };
    };
}