using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Full Refresh Tcp Long Qty: SnapshotFullRefreshTCPLongQty
    /// </summary>

    public partial class SnapshotFullRefreshTcpLongQty
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            SecurityId SecurityId;
            HighLimitPrice HighLimitPrice;
            LowLimitPrice LowLimitPrice;
            MaxPriceVariation MaxPriceVariation;
        };
    };
}