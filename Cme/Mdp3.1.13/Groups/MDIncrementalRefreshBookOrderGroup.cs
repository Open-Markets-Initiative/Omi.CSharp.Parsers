using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Book Order Group: Number of OrderID entries
    /// </summary>

    public partial class MDIncrementalRefreshBookOrderGroup
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