using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Net Order Imbalance Indicator Message: NASDAQ disseminates NOII data at 5-second intervals in the minutes leading up to the NASDAQ Opening Cross and NASDAQ Closing Cross
/// </summary>

public partial class NetOrderImbalanceIndicatorMessage
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
    ///  The total number of shares that are eligible to be matched at the Current Reference Price.
    /// </summary>
    public ulong PairedShares => Fields.PairedShares.Value;

    /// <summary>
    ///  The number of shares not paired at the Current Reference Price.
    /// </summary>
    public ulong ImbalanceShares => Fields.ImbalanceShares.Value;

    /// <summary>
    ///  The market side of the order imbalance.
    /// </summary>
    public ImbalanceDirection ImbalanceDirection => Fields.ImbalanceDirection.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Fields.Stock.Value;

    /// <summary>
    ///  A hypothetical auction-clearing price for cross orders only. Refer to Data Types for field processing notes.
    /// </summary>
    public uint FarPrice => Fields.FarPrice.Value;

    /// <summary>
    ///  A hypothetical auction-clearing price for cross orders as well as continuous orders. Refer to Data Types for field processing notes.
    /// </summary>
    public uint NearPrice => Fields.NearPrice.Value;

    /// <summary>
    ///  The price at which the NOII shares are being calculated.   Refer to Data Types for field processing notes.
    /// </summary>
    public uint CurrentReferencePrice => Fields.CurrentReferencePrice.Value;

    /// <summary>
    ///  The NASDAQ cross session for which the message is being generated.
    /// </summary>
    public CrossType CrossType => Fields.CrossType.Value;

    /// <summary>
    ///  This field indicates the absolute value of the percentage of deviation of the Near Indicative Clearing Price to the nearest Current Reference Price.
    /// </summary>
    public PriceVariationIndicator PriceVariationIndicator => Fields.PriceVariationIndicator.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public PairedShares PairedShares;
        public ImbalanceShares ImbalanceShares;
        public ImbalanceDirection ImbalanceDirection;
        public Stock Stock;
        public FarPrice FarPrice;
        public NearPrice NearPrice;
        public CurrentReferencePrice CurrentReferencePrice;
        public CrossType CrossType;
        public PriceVariationIndicator PriceVariationIndicator;
    };

    protected Layout Fields;
};
