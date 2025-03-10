using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Price Level Sell Update Message: Deep broadcasts a real-time Price Level Update Message each time a displayed price level on IEX is updated during the trading day
/// </summary>

public partial class PriceLevelSellUpdateMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public EventFlags EventFlags;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public Size Size;
        public Price Price;
    };
};
