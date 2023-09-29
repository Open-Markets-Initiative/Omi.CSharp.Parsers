using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Add Price Level Message: Upon receipt of this message, client should add/insert a price level at the specified position in the book for the given market, and push down the price levels that were previously at or below that position.
    /// </summary>

    public partial class AddPriceLevelMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            Side Side;
            PriceLevelPosition PriceLevelPosition;
            Price Price;
            Quantity Quantity;
            OrderCount OrderCount;
            ImpliedQuantity ImpliedQuantity;
            ImpliedOrderCount ImpliedOrderCount;
            Timestamp Timestamp;
        };
    };
}