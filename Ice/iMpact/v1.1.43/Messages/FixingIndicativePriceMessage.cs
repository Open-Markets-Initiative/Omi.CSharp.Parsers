using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fixing Indicative Price Message: This message supports ICE Benchmark Administration’s (IBA) electronic Gold and Silver Auction and is disseminated at the end of the final auction when the final price is published
    /// </summary>

    public partial class FixingIndicativePriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public IbaCurrency IbaCurrency;
            public Price Price;
            public PriceInGram PriceInGram;
            public NumDecimalsPrice NumDecimalsPrice;
            public NumDecimalsPriceInGram NumDecimalsPriceInGram;
        };
    };
}