using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Order Modify
/// </summary>

public partial class OrderModify
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public RequestTime RequestTime;
        public TrdRegTsPrevTimePriority TrdRegTsPrevTimePriority;
        public PrevPrice PrevPrice;
        public PrevDisplayQty PrevDisplayQty;
        public SecurityId SecurityId;
        public OrderDetailsComp OrderDetailsComp;
        public PrevPriceHhiIndicator PrevPriceHhiIndicator;
        public Pad7 Pad7;
    };
};
