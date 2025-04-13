using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Block Delete Message: This message contains a block of Single Side Deletes. Each reference number inside the block represents an order or a side of a quote that is being cancelled. All remaining contracts are no longer accessible so the side should be removed from the book.
/// </summary>

public partial class BlockDeleteMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  The number of single side deletes in this block. Max possible value = 360
    /// </summary>
    public ushort NumberOfReferenceNumberDeltas => Fields.NumberOfReferenceNumberDeltas.Value;

    /// <summary>
    ///  The order/quote reference number delta associated with the executed order.
    /// </summary>
    public uint ReferenceNumberDelta => Fields.ReferenceNumberDelta.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public NumberOfReferenceNumberDeltas NumberOfReferenceNumberDeltas;
        public ReferenceNumberDelta ReferenceNumberDelta;
    };

    protected Layout Fields;
};
