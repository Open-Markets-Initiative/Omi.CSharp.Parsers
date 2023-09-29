using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market Snapshot Price Level Message: This message is for price level in snapshot only.
    /// </summary>

    public partial class MarketSnapshotPriceLevelMessage
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
        };
    };
}