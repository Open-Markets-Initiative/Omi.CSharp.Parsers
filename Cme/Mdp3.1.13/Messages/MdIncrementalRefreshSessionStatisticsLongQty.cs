using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Incremental Refresh Session Statistics Long Qty: MDIncrementalRefreshSessionStatisticsLongQty
    /// </summary>

    public partial class MdIncrementalRefreshSessionStatisticsLongQty
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