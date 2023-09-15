using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Order Add
    /// </summary>

    public partial class OrderAdd
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            RequestTime RequestTime;
            SecurityId SecurityId;
            OrderDetailsComp OrderDetailsComp;
        };
    };
}