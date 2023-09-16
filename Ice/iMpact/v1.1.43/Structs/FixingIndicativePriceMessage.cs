using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fixing Indicative Price Message
    /// </summary>

    public partial class FixingIndicativePriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            IbaCurrency IbaCurrency;
            Price Price;
            PriceInGram PriceInGram;
            NumDecimalsPrice NumDecimalsPrice;
            NumDecimalsPriceInGram NumDecimalsPriceInGram;
        };
    };
}