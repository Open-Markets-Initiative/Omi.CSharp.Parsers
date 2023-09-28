using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Index Prices Message
    /// </summary>

    public partial class IndexPricesMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            Price Price;
            ShortName ShortName;
            PublishedDateTime PublishedDateTime;
            ValuationDate ValuationDate;
            EndexStatus EndexStatus;
            Reserved2Bytes Reserved2Bytes;
            IndexPriceDenominator IndexPriceDenominator;
        };
    };
}