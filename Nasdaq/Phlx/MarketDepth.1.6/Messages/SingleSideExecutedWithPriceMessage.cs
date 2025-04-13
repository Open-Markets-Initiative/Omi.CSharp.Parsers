using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Single Side Executed With Price Message: This message is sent whenever an incoming Side order is executed against the book in whole or in part at a price different from the initial display price. Since the execution price is different than the display price of the original Add/Replace, the options system includes a price field within this execution message. It is possible to receive multiple Single Side Executed and Single Side Executed with Price messages for the same Side order if that Side order is executed in several parts. The multiple Single Side Executed messages on the same Side order are cumulative.
/// </summary>

public partial class SingleSideExecutedWithPriceMessage
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
    ///  Trade Group Id. Ties together all trades of a given atomic transaction in the matching engine.
    /// </summary>
    public uint CrossNumber => Fields.CrossNumber.Value;

    /// <summary>
    ///  Execution Id. Identifies the component of an execution. Unique for a given day.  The match number is also referenced in the Trade Break Message.
    /// </summary>
    public uint MatchNumber => Fields.MatchNumber.Value;

    /// <summary>
    ///  Indicates if the execution should be reflected on time and sale displays and volume calculations.
    /// </summary>
    public Printable Printable => Fields.Printable.Value;

    /// <summary>
    ///  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits. The display price of the new order being added to the book.
    /// </summary>
    public int Price => Fields.Price.Value;

    /// <summary>
    ///  The total number of contracts of the new order being added to the book.
    /// </summary>
    public uint Volume => Fields.Volume.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public ReferenceNumberDelta ReferenceNumberDelta;
        public CrossNumber CrossNumber;
        public MatchNumber MatchNumber;
        public Printable Printable;
        public Price Price;
        public Volume Volume;
    };

    protected Layout Fields;
};
