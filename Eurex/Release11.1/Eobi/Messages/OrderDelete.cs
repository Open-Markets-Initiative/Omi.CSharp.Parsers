using System.Runtime.InteropServices;

namespace Eurex.Eobi
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