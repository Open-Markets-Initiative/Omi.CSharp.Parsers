using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Add Price Level Message: Upon receipt of this message, client should add/insert a price level at the specified position in the book for the given market, and push down the price levels that were previously at or below that position.
/// </summary>

public partial class AddPriceLevelMessage
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
