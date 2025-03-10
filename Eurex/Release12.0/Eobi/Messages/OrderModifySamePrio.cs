using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Order Modify Same Prio
/// </summary>

public partial class OrderModifySamePrio
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public RequestTime RequestTime;
        public TransactTime TransactTime;
        public PrevDisplayQty PrevDisplayQty;
        public SecurityId SecurityId;
        public OrderDetailsComp OrderDetailsComp;
    };
};
