using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Hedge Definition: Hedge Definition
/// </summary>

public partial class HedgeDefinition
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public HedgeBodyLength HedgeBodyLength;
        public HedgeMarketId HedgeMarketId;
        public HedgeSecurityType HedgeSecurityType;
        public HedgeSide HedgeSide;
        public HedgePrice HedgePrice;
        public HedgePriceDenominator HedgePriceDenominator;
        public HedgeDeltaObsolete HedgeDeltaObsolete;
        public HedgeStrategyCode HedgeStrategyCode;
        public HedgeDelta HedgeDelta;
    };
};
