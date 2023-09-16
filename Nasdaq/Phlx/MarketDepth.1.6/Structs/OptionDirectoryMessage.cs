using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Option Directory Message: At the start of each trading day, the options system disseminates option symbol directory messages for all active option symbols in the PHLX ® options system.
    /// </summary>

    public partial class OptionDirectoryMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OptionId OptionId;
            SecuritySymbol SecuritySymbol;
            ExpirationYear ExpirationYear;
            ExpirationMonth ExpirationMonth;
            ExpirationDate ExpirationDate;
            ExplicitStrikePrice ExplicitStrikePrice;
            OptionType OptionType;
            Source Source;
            UnderlyingSymbol UnderlyingSymbol;
            OptionsClosingType OptionsClosingType;
            Tradable Tradable;
            Mpv Mpv;
        };
    };
}