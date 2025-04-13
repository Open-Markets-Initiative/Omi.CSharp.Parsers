using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Trading Action Message: The options system uses this administrative message to indicate the current trading status of an index or equity option within the PHLX Options Market.
/// </summary>

public partial class TradingActionMessage
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
    ///  Reflects the current trading state for the options security in the Options Market.
    /// </summary>
    public CurrentTradingState CurrentTradingState => Fields.CurrentTradingState.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public OptionId OptionId;
        public CurrentTradingState CurrentTradingState;
    };

    protected Layout Fields;
};
