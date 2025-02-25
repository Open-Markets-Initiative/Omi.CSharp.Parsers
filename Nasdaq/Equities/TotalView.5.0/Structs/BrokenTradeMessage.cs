using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Broken Trade Message: Firms that use the ITCH feed to create time-and-sales displays or calculate market statistics should be prepared to process the broken trade message.   If a firm is only using the ITCH feed to build a book, however, it may ignore these messages as they have no impact on the current book.
/// </summary>

public partial class BrokenTradeMessage
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
    ///  The NASDAQ generated day-unique Match Number of this execution. The match number is also referenced in the Trade Break Message.
    /// </summary>
    public ulong MatchNumber => Layout.MatchNumber.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public MatchNumber MatchNumber;
    };
};
