using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Snapshot Order
/// </summary>

public partial class SnapshotOrder
{
    /// <summary>
    ///  Order Details Comp
    /// </summary>
    public string OrderDetailsComp => Fields.OrderDetailsComp.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public OrderDetailsComp OrderDetailsComp;
    };

    protected Layout Fields;
};
