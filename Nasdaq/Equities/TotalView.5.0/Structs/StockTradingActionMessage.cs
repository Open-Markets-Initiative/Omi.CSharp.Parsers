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
    ///  Indicates the current trading state for the stock.  Allowable values:
    /// </summary>
    public TradingState TradingState => Layout.TradingState.Value;

    /// <summary>
    ///  Reserved
    /// </summary>
    public string Reserved => Layout.Reserved.Value;

    /// <summary>
    ///  Trading Action reason
    /// </summary>
    public string Reason => Layout.Reason.Value;

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
};
