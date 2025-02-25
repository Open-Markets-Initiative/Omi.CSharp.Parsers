using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Incremental Refresh Book Long Qty: MDIncrementalRefreshBookLongQty
    /// </summary>

    public partial class MdIncrementalRefreshBookLongQty
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTime TransactTime;
            public MatchEventIndicator MatchEventIndicator;
            public Padding2 Padding2;
        };
    };
}