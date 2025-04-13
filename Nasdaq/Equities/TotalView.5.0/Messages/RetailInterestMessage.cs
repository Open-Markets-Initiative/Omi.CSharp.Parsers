using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Retail Interest Message: Identifies a retail interest indication of the Bid, Ask or both the Bid and Ask for NASDAQ-listed securities.
/// </summary>

public partial class RetailInterestMessage
{
    /// <summary>
    ///  Always 0
    /// </summary>
    public ushort StockLocate => Fields.StockLocate.Value;

    /// <summary>
    ///  NASDAQ OMX internal tracking number
    /// </summary>
    public ushort TrackingNumber => Fields.TrackingNumber.Value;

    /// <summary>
    ///  Nanoseconds since midnight.
    /// </summary>
    public string Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Fields.Stock.Value;

    /// <summary>
    ///  Interest Flag
    /// </summary>
    public InterestFlag InterestFlag => Fields.InterestFlag.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Stock Stock;
        public InterestFlag InterestFlag;
    };

    protected Layout Fields;
};
