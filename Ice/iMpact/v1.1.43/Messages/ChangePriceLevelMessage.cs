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
            public MarketId MarketId;
            public Side Side;
            public PriceLevelPosition PriceLevelPosition;
            public Price Price;
            public Quantity Quantity;
            public OrderCount OrderCount;
            public ImpliedQuantity ImpliedQuantity;
            public ImpliedOrderCount ImpliedOrderCount;
            public Timestamp Timestamp;
        };
    };
}