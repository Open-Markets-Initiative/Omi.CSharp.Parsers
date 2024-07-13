using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Stock Directory Message: Market data redistributors should process this message to populate the Financial Status Indicator (required display field) and the Market Category (recommended display field) for NASDAQ-listed issues.
    /// </summary>

    public partial class StockDirectoryMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Stock Stock;
            MarketCategory MarketCategory;
            FinancialStatusIndicator FinancialStatusIndicator;
            RoundLotSize RoundLotSize;
            RoundLotsOnly RoundLotsOnly;
            IssueClassification IssueClassification;
            IssueSubType IssueSubType;
            Authenticity Authenticity;
            ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
            IpoFlag IpoFlag;
            LuldReferencePriceTier LuldReferencePriceTier;
            EtpFlag EtpFlag;
            EtpLeverageFactor EtpLeverageFactor;
            InverseIndicator InverseIndicator;
        };
    };
}