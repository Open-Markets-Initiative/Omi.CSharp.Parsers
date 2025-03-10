using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Market Snapshot Price Level Message: This message is for price level in snapshot only.
/// </summary>

public partial class MarketSnapshotPriceLevelMessage
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
    };
};
