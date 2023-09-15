using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Incremental Refresh Volume Long Qty: MDIncrementalRefreshVolumeLongQty
    /// </summary>

    public partial class MdIncrementalRefreshVolumeLongQty
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            Padding2 Padding2;
        };
    };
}