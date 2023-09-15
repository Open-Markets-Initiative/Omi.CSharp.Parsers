using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Order Modify
    /// </summary>

    public partial class OrderModify
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            RequestTime RequestTime;
            TrdRegTsPrevTimePriority TrdRegTsPrevTimePriority;
            PrevPrice PrevPrice;
            PrevDisplayQty PrevDisplayQty;
            SecurityId SecurityId;
            OrderDetailsComp OrderDetailsComp;
            PrevPriceHhiIndicator PrevPriceHhiIndicator;
            Pad7 Pad7;
        };
    };
}