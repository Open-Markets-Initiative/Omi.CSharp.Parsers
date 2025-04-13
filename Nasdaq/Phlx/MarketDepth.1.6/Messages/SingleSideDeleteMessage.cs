using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Single Side Delete Message: The message is sent when an order or a side of a quote is being cancelled. All remaining contracts are no longer accessible so the side should be removed from the book.
/// </summary>

public partial class SingleSideDeleteMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The order/quote reference number delta associated with the executed order.
    /// </summary>
    public uint ReferenceNumberDelta => Fields.ReferenceNumberDelta.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public ReferenceNumberDelta ReferenceNumberDelta;
    };

    protected Layout Fields;
};
