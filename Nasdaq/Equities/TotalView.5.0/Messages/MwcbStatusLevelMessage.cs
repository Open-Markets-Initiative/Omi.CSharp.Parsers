using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Mwcb Status Level Message: Informs data recipients when a MWCB has breached one of the established levels
/// </summary>

public partial class MwcbStatusLevelMessage
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
    ///  Denotes the MWCB Level that was breached.
    /// </summary>
    public BreachedLevel BreachedLevel => Fields.BreachedLevel.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public BreachedLevel BreachedLevel;
    };

    protected Layout Fields;
};
