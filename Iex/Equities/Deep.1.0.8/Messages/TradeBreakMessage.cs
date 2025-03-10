using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Trade Break Message: Trade Break Messages are sent when an execution on IEX is broken on that same trading day
/// </summary>

public partial class TradeBreakMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SaleConditionFlags SaleConditionFlags;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public Size Size;
        public Price Price;
        public TradeId TradeId;
    };
};
