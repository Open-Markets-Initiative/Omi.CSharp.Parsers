using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Incremental Refresh Book Long Qty: MDIncrementalRefreshBookLongQty
    /// </summary>

    public partial class MdIncrementalRefreshBookLongQty
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