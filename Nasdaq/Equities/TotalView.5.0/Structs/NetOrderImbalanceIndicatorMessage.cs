using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Net Order Imbalance Indicator Message: NASDAQ disseminates NOII data at 5-second intervals in the minutes leading up to the NASDAQ Opening Cross and NASDAQ Closing Cross
    /// </summary>

    public partial class NetOrderImbalanceIndicatorMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            PairedShares PairedShares;
            ImbalanceShares ImbalanceShares;
            ImbalanceDirection ImbalanceDirection;
            Stock Stock;
            FarPrice FarPrice;
            NearPrice NearPrice;
            CurrentReferencePrice CurrentReferencePrice;
            CrossType CrossType;
            PriceVariationIndicator PriceVariationIndicator;
        };
    };
}