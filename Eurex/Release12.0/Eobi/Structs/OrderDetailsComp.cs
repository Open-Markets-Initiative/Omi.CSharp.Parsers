using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Order Details Comp
/// </summary>

public partial class OrderDetailsComp
{
    /// <summary>
    ///  Trd Reg Ts Time Priority
    /// </summary>
    public ulong TrdRegTsTimePriority => Layout.TrdRegTsTimePriority.Value;

    /// <summary>
    ///  Display Qty
    /// </summary>
    public ulong DisplayQty => Layout.DisplayQty.Value;

    /// <summary>
    ///  Side
    /// </summary>
    public Side Side => Layout.Side.Value;

    /// <summary>
    ///  Ord Type
    /// </summary>
    public OrdType OrdType => Layout.OrdType.Value;

    /// <summary>
    ///  Hhi Indicator
    /// </summary>
    public HhiIndicator HhiIndicator => Layout.HhiIndicator.Value;

    /// <summary>
    ///  Pad 5
    /// </summary>
    public string Pad5 => Layout.Pad5.Value;

    /// <summary>
    ///  Price
    /// </summary>
    public ulong Price => Layout.Price.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TrdRegTsTimePriority TrdRegTsTimePriority;
        public DisplayQty DisplayQty;
        public Side Side;
        public OrdType OrdType;
        public HhiIndicator HhiIndicator;
        public Pad5 Pad5;
        public Price Price;
    };
};
