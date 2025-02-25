using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Ipo Quoting Period Update: Indicates the anticipated IPO quotation release time of a security.
/// </summary>

public partial class IpoQuotingPeriodUpdate
{
    /// <summary>
    ///  Always 0
    /// </summary>
    public ushort StockLocate => Layout.StockLocate.Value;

    /// <summary>
    ///  NASDAQ OMX internal tracking number
    /// </summary>
    public ushort TrackingNumber => Layout.TrackingNumber.Value;

    /// <summary>
    ///  Nanoseconds since midnight.
    /// </summary>
    public string Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Layout.Stock.Value;

    /// <summary>
    ///  Denotes the IPO release time, in seconds since midnight, for quotation to the nearest second.
    /// </summary>
    public uint IpoQuotationReleaseTime => Layout.IpoQuotationReleaseTime.Value;

    /// <summary>
    ///  Anticipated quotation release time. This value would be used when NASDAQ Market Operations initially enters the IPO instrument for release.IPO release canceled/postponed.This value would be used when NASDAQ Market Operations cancels or postpones the release of the IPO instrument.
    /// </summary>
    public IpoQuotationReleaseQualifier IpoQuotationReleaseQualifier => Layout.IpoQuotationReleaseQualifier.Value;

    /// <summary>
    ///  Denotes the IPO price to be used for intraday net change calculations. Prices are given in decimal format with 6 whole number places followed by 4 decimal digits.
    /// </summary>
    public uint IpoPrice => Layout.IpoPrice.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Stock Stock;
        public IpoQuotationReleaseTime IpoQuotationReleaseTime;
        public IpoQuotationReleaseQualifier IpoQuotationReleaseQualifier;
        public IpoPrice IpoPrice;
    };
};
