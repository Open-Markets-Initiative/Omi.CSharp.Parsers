using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  System Event Message: Reflects the number of seconds past midnight that the Timestamp message was generated.
/// </summary>

public partial class SystemEventMessage
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
    ///  System Event Codes
    /// </summary>
    public EventCode EventCode => Layout.EventCode.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public EventCode EventCode;
    };
};
