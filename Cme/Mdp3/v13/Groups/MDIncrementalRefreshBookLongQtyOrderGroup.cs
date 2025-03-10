using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Book Long Qty Order Group: Number of OrderID entries
/// </summary>

public partial class MDIncrementalRefreshBookLongQtyOrderGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public OrderId OrderId;
        public MdOrderPriorityOptional MdOrderPriorityOptional;
        public MdDisplayQtyOptional MdDisplayQtyOptional;
        public ReferenceId ReferenceId;
        public OrderUpdateAction OrderUpdateAction;
        public Padding2 Padding2;
    };
};
