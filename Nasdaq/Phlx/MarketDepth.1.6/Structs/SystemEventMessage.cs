using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  System Event Message: The system event message type is used to signal a market or data feed handler event.
/// </summary>

public partial class SystemEventMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  System Event Code
    /// </summary>
    public EventCode EventCode => Layout.EventCode.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public EventCode EventCode;
    };
};
