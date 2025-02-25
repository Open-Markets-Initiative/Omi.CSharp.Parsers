using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Mwcb Decline Level Message: Informs data recipients what the daily MWCB breach points are set to for the current trading day.
/// </summary>

public partial class MwcbDeclineLevelMessage
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
    ///  Denotes the MWCB Level 1 Value.
    /// </summary>
    public ulong Level1 => Layout.Level1.Value;

    /// <summary>
    ///  Denotes the MWCB Level 2 Value.
    /// </summary>
    public ulong Level2 => Layout.Level2.Value;

    /// <summary>
    ///  Denotes the MWCB Level 3 Value.
    /// </summary>
    public ulong Level3 => Layout.Level3.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Level1 Level1;
        public Level2 Level2;
        public Level3 Level3;
    };
};
