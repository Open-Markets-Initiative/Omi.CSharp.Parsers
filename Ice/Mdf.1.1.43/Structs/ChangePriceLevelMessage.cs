using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Change Price Level Message
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