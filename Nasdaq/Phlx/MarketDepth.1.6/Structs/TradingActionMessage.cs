using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Trading Action Message: The options system uses this administrative message to indicate the current trading status of an index or equity option within the PHLX Options Market.
    /// </summary>

    public partial class TradingActionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OptionId OptionId;
            CurrentTradingState CurrentTradingState;
        };
    };
}