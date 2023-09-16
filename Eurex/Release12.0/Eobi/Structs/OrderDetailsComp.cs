using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Order Details Comp
    /// </summary>

    public partial class OrderDetailsComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TrdRegTsTimePriority TrdRegTsTimePriority;
            DisplayQty DisplayQty;
            Side Side;
            OrdType OrdType;
            HhiIndicator HhiIndicator;
            Pad5 Pad5;
            Price Price;
        };
    };
}