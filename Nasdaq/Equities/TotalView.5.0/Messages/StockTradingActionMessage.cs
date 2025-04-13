using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Stock Trading Action Message: NASDAQ uses this administrative message to indicate the current trading status of a security to the trading community.
/// </summary>

public partial class StockTradingActionMessage
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
    ///  Indicates the current trading state for the stock.  Allowable values:
    /// </summary>
    public TradingState TradingState => Fields.TradingState.Value;

    /// <summary>
    ///  Reserved
    /// </summary>
    public char Reserved => Fields.Reserved.Value;

    /// <summary>
    ///  Trading Action reason
    /// </summary>
    public string Reason => Fields.Reason.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Stock Stock;
        public TradingState TradingState;
        public Reserved Reserved;
        public Reason Reason;
    };

    protected Layout Fields;
};
