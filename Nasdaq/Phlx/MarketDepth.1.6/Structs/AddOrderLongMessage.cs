using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Add Order Long Message: An Add Order Message indicates that a new order has been accepted by the options system and was added to the displayable book. The message includes a day-unique Order Reference Number used by options system to track the order.
    /// </summary>

    public partial class AddOrderLongMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OrderReferenceNumberDelta OrderReferenceNumberDelta;
            MarketSide MarketSide;
            OptionId OptionId;
            Price Price;
            Volume Volume;
            OrderId OrderId;
        };
    };
}