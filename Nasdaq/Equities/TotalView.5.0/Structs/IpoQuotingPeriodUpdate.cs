using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Ipo Quoting Period Update: Indicates the anticipated IPO quotation release time of a security.
    /// </summary>

    public partial class IpoQuotingPeriodUpdate
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Stock Stock;
            IpoQuotationReleaseTime IpoQuotationReleaseTime;
            IpoQuotationReleaseQualifier IpoQuotationReleaseQualifier;
            IpoPrice IpoPrice;
        };
    };
}