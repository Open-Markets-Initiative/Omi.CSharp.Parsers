using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Book Long Qty Order Group: Number of OrderID entries
    /// </summary>

    public partial class MDIncrementalRefreshBookLongQtyOrderGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            OrderId OrderId;
            MdOrderPriorityOptional MdOrderPriorityOptional;
            MdDisplayQtyOptional MdDisplayQtyOptional;
            ReferenceId ReferenceId;
            OrderUpdateAction OrderUpdateAction;
            Padding2 Padding2;
        };
    };
}