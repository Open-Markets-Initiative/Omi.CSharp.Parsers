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
            SecurityId SecurityId;
            TransactTime TransactTime;
        };
    };
}