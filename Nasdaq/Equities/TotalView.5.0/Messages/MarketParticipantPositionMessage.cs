using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Market Participant Position Message: Throughout the day, NASDAQ will send out this message only if NASDAQ Operations changes the status of a market participant firm in an issue.
/// </summary>

public partial class MarketParticipantPositionMessage
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
    ///  Denotes the market participant identifier for which the position message is being generated
    /// </summary>
    public string Mpid => Fields.Mpid.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Fields.Stock.Value;

    /// <summary>
    ///  Indicates if the market participant firm qualifies as a Primary Market Maker in accordance with NASDAQ marketplace rules
    /// </summary>
    public PrimaryMarketMaker PrimaryMarketMaker => Fields.PrimaryMarketMaker.Value;

    /// <summary>
    ///  Indicates the quoting participant’s registration status in relation to SEC Rules 101 and 104 of Regulation M
    /// </summary>
    public MarketMakerMode MarketMakerMode => Fields.MarketMakerMode.Value;

    /// <summary>
    ///  Indicates the market participant’s current registration status in the issue
    /// </summary>
    public MarketParticipantState MarketParticipantState => Fields.MarketParticipantState.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Mpid Mpid;
        public Stock Stock;
        public PrimaryMarketMaker PrimaryMarketMaker;
        public MarketMakerMode MarketMakerMode;
        public MarketParticipantState MarketParticipantState;
    };

    protected Layout Fields;
};
