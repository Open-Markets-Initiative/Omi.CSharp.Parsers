using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Index Prices Message: The exchange sends out Marker/Index Prices when there is an update.
    /// </summary>

    public partial class IndexPricesMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public Price Price;
            public ShortName ShortName;
            public PublishedDateTime PublishedDateTime;
            public ValuationDate ValuationDate;
            public EndexStatus EndexStatus;
            public Reserved2Bytes Reserved2Bytes;
            public IndexPriceDenominator IndexPriceDenominator;
        };
    };
}