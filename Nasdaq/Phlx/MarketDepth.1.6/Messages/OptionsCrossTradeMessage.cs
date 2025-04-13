using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Options Cross Trade Message: Options Auction Trade message is sent for every option when an auction in that option is completed. The message indicates the bulk volume associated with the auction event.
/// </summary>

public partial class OptionsCrossTradeMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Option ID assigned daily, valid for trading day.
    /// </summary>
    public uint OptionId => Fields.OptionId.Value;

    /// <summary>
    ///  Trade Group Id. Ties together all trades of a given atomic transaction in the matching engine.
    /// </summary>
    public uint CrossNumber => Fields.CrossNumber.Value;

    /// <summary>
    ///  Execution Id. Identifies the component of an execution. Unique for a given day.  The match number is also referenced in the Trade Break Message.
    /// </summary>
    public uint MatchNumber => Fields.MatchNumber.Value;

    /// <summary>
    ///  The PHLX® auction session for which the message is being generated.
    /// </summary>
    public CrossType CrossType => Fields.CrossType.Value;

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
        public OptionId OptionId;
        public CrossNumber CrossNumber;
        public MatchNumber MatchNumber;
        public CrossType CrossType;
        public Price Price;
        public Volume Volume;
    };

    protected Layout Fields;
};
