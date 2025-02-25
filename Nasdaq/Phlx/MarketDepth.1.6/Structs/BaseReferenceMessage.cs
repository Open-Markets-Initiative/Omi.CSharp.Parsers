using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Base Reference Message: This message indicates the base reference number to which all the order/quote/trade reference number deltas must be added to obtain the absolute order/quote PHLX reference number.
/// </summary>

public partial class BaseReferenceMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  The base reference number
    /// </summary>
    public ulong BaseReferenceNumber => Layout.BaseReferenceNumber.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public BaseReferenceNumber BaseReferenceNumber;
    };
};
