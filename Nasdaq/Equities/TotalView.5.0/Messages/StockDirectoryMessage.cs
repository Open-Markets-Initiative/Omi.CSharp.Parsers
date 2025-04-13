using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Stock Directory Message: Market data redistributors should process this message to populate the Financial Status Indicator (required display field) and the Market Category (recommended display field) for NASDAQ-listed issues.
/// </summary>

public partial class StockDirectoryMessage
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
    ///  Indicates Listing market or listing market tier for the issue
    /// </summary>
    public MarketCategory MarketCategory => Fields.MarketCategory.Value;

    /// <summary>
    ///  For NASDAQ-listed issues, this field indicates when a firm is not in compliance with NASDAQ continued listing requirements.
    /// </summary>
    public FinancialStatusIndicator FinancialStatusIndicator => Fields.FinancialStatusIndicator.Value;

    /// <summary>
    ///  Denotes the number of shares that represent a round lot for the issue
    /// </summary>
    public uint RoundLotSize => Fields.RoundLotSize.Value;

    /// <summary>
    ///  Indicates if NASDAQ system limits order entry for issue
    /// </summary>
    public RoundLotsOnly RoundLotsOnly => Fields.RoundLotsOnly.Value;

    /// <summary>
    ///  Identifies the security class for the issue as assigned by NASDAQ. See Appendix for allowable values.
    /// </summary>
    public IssueClassification IssueClassification => Fields.IssueClassification.Value;

    /// <summary>
    ///  Identifies the security sub-type for the issue as assigned by NASDAQ. See Appendix for allowable values.
    /// </summary>
    public string IssueSubType => Fields.IssueSubType.Value;

    /// <summary>
    ///  Denotes if an issue or quoting participant record is set-up in NASDAQ systems in a live/production, test, or demo state. Please note that firms should only show live issues and quoting participants on public quotation displays.
    /// </summary>
    public Authenticity Authenticity => Fields.Authenticity.Value;

    /// <summary>
    ///  Indicates if a security is subject to mandatory close-out of short sales under SEC Rule 203(b)(3).
    /// </summary>
    public ShortSaleThresholdIndicator ShortSaleThresholdIndicator => Fields.ShortSaleThresholdIndicator.Value;

    /// <summary>
    ///  Indicates if the NASDAQ security is set up for IPO release.   This field is intended to help NASDAQ market participant firms comply with FINRA Rule 5131(b).
    /// </summary>
    public IpoFlag IpoFlag => Fields.IpoFlag.Value;

    /// <summary>
    ///  Indicates which Limit Up / Limit Down price band calculation parameter is to be used for the instrument.
    /// </summary>
    public LuldReferencePriceTier LuldReferencePriceTier => Fields.LuldReferencePriceTier.Value;

    /// <summary>
    ///  Indicates whether the security is an exchange traded product (ETP):
    /// </summary>
    public EtpFlag EtpFlag => Fields.EtpFlag.Value;

    /// <summary>
    ///  Tracks the integral relationship of the ETP to the underlying index.   Example: If the underlying Index increases by a value of 1 and the ETP’s Leverage factor is 3, indicates the ETF will increase/decrease (see Inverse) by 3. Note: Leverage Factor of 1 indicates the ETP is NOT leveraged. This field is used for LULD Tier I price band calculation purposes.
    /// </summary>
    public uint EtpLeverageFactor => Fields.EtpLeverageFactor.Value;

    /// <summary>
    ///  Indicates the directional relationship between the ETP and underlying index. Example: An ETP Leverage Factor of 3 and an Inverse value of ‘Y’ indicates the ETP will decrease by a value of 3.
    /// </summary>
    public InverseIndicator InverseIndicator => Fields.InverseIndicator.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Stock Stock;
        public MarketCategory MarketCategory;
        public FinancialStatusIndicator FinancialStatusIndicator;
        public RoundLotSize RoundLotSize;
        public RoundLotsOnly RoundLotsOnly;
        public IssueClassification IssueClassification;
        public IssueSubType IssueSubType;
        public Authenticity Authenticity;
        public ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
        public IpoFlag IpoFlag;
        public LuldReferencePriceTier LuldReferencePriceTier;
        public EtpFlag EtpFlag;
        public EtpLeverageFactor EtpLeverageFactor;
        public InverseIndicator InverseIndicator;
    };

    protected Layout Fields;
};
