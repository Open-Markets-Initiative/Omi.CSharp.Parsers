using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Change Price Level Message: Upon receipt of this message, client should update the price level at the specified position in its book for the given market.
    /// </summary>

    public partial class ChangePriceLevelMessage
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