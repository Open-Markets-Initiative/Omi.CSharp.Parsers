using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Order Delete
    /// </summary>

    public partial class OrderDelete
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            RequestTime RequestTime;
            TransactTime TransactTime;
            SecurityId SecurityId;
            OrderDetailsComp OrderDetailsComp;
        };
    };
}