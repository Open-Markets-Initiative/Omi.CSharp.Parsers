using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Incremental Refresh Volume Long Qty: MDIncrementalRefreshVolumeLongQty
    /// </summary>

    public partial class MdIncrementalRefreshVolumeLongQty
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