using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Market Snapshot Price Level Message: This message is for price level in snapshot only.
/// </summary>

public partial class MarketSnapshotPriceLevelMessage
{
    /// <summary>
    ///  Market Id
    /// </summary>
    public int MarketId => Fields.MarketId.Value;

    /// <summary>
    ///  1 = Bid, 2 = Offer
    /// </summary>
    public Side Side => Fields.Side.Value;

    /// <summary>
    ///  Position of the price level
    /// </summary>
    public sbyte PriceLevelPosition => Fields.PriceLevelPosition.Value;

    /// <summary>
    ///  DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>
    public long Price => Fields.Price.Value;

    /// <summary>
    ///  Quantity
    /// </summary>
    public int Quantity => Fields.Quantity.Value;

    /// <summary>
    ///  Number of all orders at the price level
    /// </summary>
    public short OrderCount => Fields.OrderCount.Value;

    /// <summary>
    ///  Quantity that were implied
    /// </summary>
    public int ImpliedQuantity => Fields.ImpliedQuantity.Value;

    /// <summary>
    ///  Number of implied orders at the price level
    /// </summary>
    public short ImpliedOrderCount => Fields.ImpliedOrderCount.Value;

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
    };

    protected Layout Fields;
};
