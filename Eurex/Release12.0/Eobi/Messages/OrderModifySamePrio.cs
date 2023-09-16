using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Order Modify Same Prio
    /// </summary>

    public partial class OrderModifySamePrio
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            RequestTime RequestTime;
            TransactTime TransactTime;
            PrevDisplayQty PrevDisplayQty;
            SecurityId SecurityId;
            OrderDetailsComp OrderDetailsComp;
        };
    };
}