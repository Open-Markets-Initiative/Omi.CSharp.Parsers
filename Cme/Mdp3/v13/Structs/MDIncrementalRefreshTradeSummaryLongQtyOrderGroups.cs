using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Trade Summary Long Qty Order Groups: Number of OrderID and LastQty entries in Trade Summary message Block
/// </summary>

public partial class MDIncrementalRefreshTradeSummaryLongQtyOrderGroups
{
    /// <summary>
    ///  8 Byte aligned repeating group dimensions
    /// </summary>
    public string GroupSize8Byte => Fields.GroupSize8Byte.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSize8Byte GroupSize8Byte;
    };

    protected Layout Fields;
};
