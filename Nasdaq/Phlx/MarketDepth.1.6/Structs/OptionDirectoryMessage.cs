using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Option Directory Message: At the start of each trading day, the options system disseminates option symbol directory messages for all active option symbols in the PHLX ® options system.
/// </summary>

public partial class OptionDirectoryMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  Option ID assigned daily, valid for trading day.
    /// </summary>
    public uint OptionId => Layout.OptionId.Value;

    /// <summary>
    ///  Denotes the security symbol.
    /// </summary>
    public string SecuritySymbol => Layout.SecuritySymbol.Value;

    /// <summary>
    ///  Last two digits of the year of the option expiration
    /// </summary>
    public byte ExpirationYear => Layout.ExpirationYear.Value;

    /// <summary>
    ///  Expiration Month (1-12)
    /// </summary>
    public byte ExpirationMonth => Layout.ExpirationMonth.Value;

    /// <summary>
    ///  Day of the Month of expiration (1- 31)
    /// </summary>
    public byte ExpirationDate => Layout.ExpirationDate.Value;

    /// <summary>
    ///  Explicit strike price. Refer to Data Types for field processing notes.
    /// </summary>
    public int ExplicitStrikePrice => Layout.ExplicitStrikePrice.Value;

    /// <summary>
    ///  Option Type value
    /// </summary>
    public OptionType OptionType => Layout.OptionType.Value;

    /// <summary>
    ///  Identifies the source of the Option, valid for the trading day
    /// </summary>
    public byte Source => Layout.Source.Value;

    /// <summary>
    ///  Denotes the unique symbol assigned to the underlying security within exchange.
    /// </summary>
    public string UnderlyingSymbol => Layout.UnderlyingSymbol.Value;

    /// <summary>
    ///  Denotes which System Event is used to trigger the option closing process.
    /// </summary>
    public OptionsClosingType OptionsClosingType => Layout.OptionsClosingType.Value;

    /// <summary>
    ///  Denotes whether or not this option is tradable at the exchange.
    /// </summary>
    public Tradable Tradable => Layout.Tradable.Value;

    /// <summary>
    ///  Minimum Price Variation for this option.
    /// </summary>
    public Mpv Mpv => Layout.Mpv.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public OptionId OptionId;
        public SecuritySymbol SecuritySymbol;
        public ExpirationYear ExpirationYear;
        public ExpirationMonth ExpirationMonth;
        public ExpirationDate ExpirationDate;
        public ExplicitStrikePrice ExplicitStrikePrice;
        public OptionType OptionType;
        public Source Source;
        public UnderlyingSymbol UnderlyingSymbol;
        public OptionsClosingType OptionsClosingType;
        public Tradable Tradable;
        public Mpv Mpv;
    };
};
