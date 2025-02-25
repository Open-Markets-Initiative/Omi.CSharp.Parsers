using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Cross Trade Message: Cross Trade message indicates that NASDAQ has completed its cross process for a specific security.  NASDAQ sends out a Cross Trade message for all active issues in the system following the Opening, Closing and EMC cross events.  Firms may use the Cross Trade message to determine when the cross for each security has been completed.  (Note:  For the halted / paused securities, firms should use the Trading Action message to determine when an issue has been released for trading.)
/// </summary>

public partial class CrossTradeMessage
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
    ///  The number of shares matched in the
    /// </summary>
    public ulong CrossShares => Layout.CrossShares.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Layout.Stock.Value;

    /// <summary>
    ///  The price at which the cross occurred.  Refer to Data Types for field processing notes.
    /// </summary>
    public uint CrossPrice => Layout.CrossPrice.Value;

    /// <summary>
    ///  The NASDAQ generated day-unique Match Number of this execution. The match number is also referenced in the Trade Break Message.
    /// </summary>
    public ulong MatchNumber => Layout.MatchNumber.Value;

    /// <summary>
    ///  The NASDAQ cross session for which the message is being generated.
    /// </summary>
    public CrossType CrossType => Layout.CrossType.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public CrossShares CrossShares;
        public Stock Stock;
        public CrossPrice CrossPrice;
        public MatchNumber MatchNumber;
        public CrossType CrossType;
    };
};
