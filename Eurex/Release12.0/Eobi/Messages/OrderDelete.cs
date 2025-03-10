using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Order Delete
/// </summary>

public partial class OrderDelete
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public RequestTime RequestTime;
        public TransactTime TransactTime;
        public SecurityId SecurityId;
        public OrderDetailsComp OrderDetailsComp;
    };
};
