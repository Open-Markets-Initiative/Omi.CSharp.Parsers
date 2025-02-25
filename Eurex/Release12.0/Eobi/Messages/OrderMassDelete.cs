using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Order Mass Delete
    /// </summary>

    public partial class OrderMassDelete
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SecurityId SecurityId;
            public TransactTime TransactTime;
        };
    };
}