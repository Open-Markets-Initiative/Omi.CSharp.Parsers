using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Remaining Order Details Comp
/// </summary>

public partial class RemainingOrderDetailsComp
{
    /// <summary>
    ///  Trd Reg Ts Prev Time Priority
    /// </summary>
    public ulong TrdRegTsPrevTimePriority => Layout.TrdRegTsPrevTimePriority.Value;

    /// <summary>
    ///  Display Qty
    /// </summary>
    public ulong DisplayQty => Layout.DisplayQty.Value;

    /// <summary>
    ///  Price
    /// </summary>
    public ulong Price => Layout.Price.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TrdRegTsPrevTimePriority TrdRegTsPrevTimePriority;
        public DisplayQty DisplayQty;
        public Price Price;
    };
};
