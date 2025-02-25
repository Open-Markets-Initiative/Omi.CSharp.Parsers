using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Order Add
    /// </summary>

    public partial class OrderAdd
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public RequestTime RequestTime;
            public SecurityId SecurityId;
            public OrderDetailsComp OrderDetailsComp;
        };
    };
}