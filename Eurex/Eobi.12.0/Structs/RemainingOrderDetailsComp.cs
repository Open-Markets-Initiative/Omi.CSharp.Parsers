using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Remaining Order Details Comp
    /// </summary>

    public partial class RemainingOrderDetailsComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TrdRegTsPrevTimePriority TrdRegTsPrevTimePriority;
            DisplayQty DisplayQty;
            Price Price;
        };
    };
}