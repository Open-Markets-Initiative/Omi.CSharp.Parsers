using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Single Side Cancel Message: This message is sent whenever an order or a side of a quote on the book is modified as a result of a partial cancellation.
/// </summary>

public partial class SingleSideCancelMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The order/quote reference number delta associated with the executed order.
    /// </summary>
    public uint ReferenceNumberDelta => Fields.ReferenceNumberDelta.Value;

    /// <summary>
    ///  The number of contracts to be removed from the display size of the order/quote as the result of a cancellation.
    /// </summary>
    public uint CancelledContracts => Fields.CancelledContracts.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public ReferenceNumberDelta ReferenceNumberDelta;
        public CancelledContracts CancelledContracts;
    };

    protected Layout Fields;
};
