using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Stock Trading Action Message: NASDAQ uses this administrative message to indicate the current trading status of a security to the trading community.
    /// </summary>

    public partial class StockTradingActionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Stock Stock;
            TradingState TradingState;
            Reserved Reserved;
            Reason Reason;
        };
    };
}